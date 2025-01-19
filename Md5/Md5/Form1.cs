using System.Data;
using System.Globalization;
using System.IO.Hashing;
using Microsoft.Office.Interop.Excel;

namespace Md5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderLbl.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;

                DirectoryInfo directoryInfo = new DirectoryInfo(folderDlg.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles();

                int i = 1;
                dataGridView.Rows.Clear();
                foreach (FileInfo file in files)
                {
                    Object[] params1 = new Object[] {
                        i,
                        true,
                        file.Name,
                        file.LastWriteTimeUtc.ToString("dd MMMM yyyyг., hh:mm:ss", CultureInfo.GetCultureInfo("ru-RU")),
                        file.Length,
                        ChecksumUtil.GetCheckSumCrc32Async(file)
                    };
                    dataGridView.Rows.Add(params1);
                    i++;

                    file.OpenRead();
                }
            }
        }


        public static class ChecksumUtil
        {
            public static string GetChecksum(HashingAlgoTypes hashingAlgoType, FileInfo file)
            {
                using (var hasher = System.Security.Cryptography.HashAlgorithm.Create(hashingAlgoType.ToString()))
                {
                    using (var stream = file.OpenRead())
                    {
                        var hash = hasher.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "");
                    }
                }
            }

            public static string GetCheckSumCrc32Async(FileInfo fileInfo)
            {
                Crc32 crc32 = new Crc32();
                using (var fs = fileInfo.OpenRead())
                {
                    crc32.Append(fs);
                }

                var checkSum = crc32.GetCurrentHash();
                return BitConverter.ToString(checkSum).Replace("-", "").ToUpper();
            }

        }


        public enum HashingAlgoTypes
        {
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count < 1)
            {
                return;
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Worksheet)workbook.Worksheets.Add();
            worksheet.Columns.AutoFit();
            worksheet.Name = "ANVAR";

            worksheet.Cells[1, 1].Value = "Наименование файла";            
            worksheet.Cells[1, 2].Value = "Дата и время последнего изменения";
            worksheet.Cells[1, 3].Value = "Размер Байт";
            worksheet.Cells[1, 4].Value = "Контрольная сумма";
            int rowIndex = 2;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int cellIndex = 1;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex < 2 || cell.ColumnIndex > 5)
                    {
                        continue;
                    }
                    worksheet.Cells[rowIndex, cellIndex].Value = cell.Value.ToString();
                    cellIndex++;
                }
                rowIndex++;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.Title = "Сохранить Excel";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName == null|| saveFileDialog1.FileName=="")
            {
                return;
            }
            workbook.SaveAs2(saveFileDialog1.FileName);
            workbook.Close();
        }
    }
}
