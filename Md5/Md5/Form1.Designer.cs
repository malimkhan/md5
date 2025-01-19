namespace Md5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            folderLbl = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            dataGridView = new DataGridView();
            button3 = new Button();
            No = new DataGridViewTextBoxColumn();
            Selected = new DataGridViewCheckBoxColumn();
            FileName = new DataGridViewTextBoxColumn();
            LastModifiedAt = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            MD5 = new DataGridViewTextBoxColumn();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1147, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(52, 20);
            toolStripStatusLabel1.Text = "V 1.0.0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1147, 421);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(folderLbl, 1, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Controls.Add(button2, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1141, 34);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(144, 31);
            button1.TabIndex = 0;
            button1.Text = "Выбрать Пакет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // folderLbl
            // 
            folderLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            folderLbl.AutoSize = true;
            folderLbl.Location = new Point(153, 0);
            folderLbl.Name = "folderLbl";
            folderLbl.Size = new Size(985, 37);
            folderLbl.TabIndex = 1;
            folderLbl.Text = "Select folder";
            folderLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(144, 14);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(153, 40);
            button2.Name = "button2";
            button2.Size = new Size(94, 14);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { No, Selected, FileName, LastModifiedAt, Size, MD5 });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 43);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1141, 335);
            dataGridView.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(3, 384);
            button3.Name = "button3";
            button3.Size = new Size(190, 29);
            button3.TabIndex = 4;
            button3.Text = "Сохранить в Excel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 50;
            // 
            // Selected
            // 
            Selected.HeaderText = "Выбор";
            Selected.MinimumWidth = 6;
            Selected.Name = "Selected";
            Selected.Width = 70;
            // 
            // FileName
            // 
            FileName.HeaderText = "Наименование файла";
            FileName.MinimumWidth = 6;
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            FileName.Width = 300;
            // 
            // LastModifiedAt
            // 
            LastModifiedAt.HeaderText = "Дата и время последнего изменения";
            LastModifiedAt.MinimumWidth = 6;
            LastModifiedAt.Name = "LastModifiedAt";
            LastModifiedAt.ReadOnly = true;
            LastModifiedAt.Width = 300;
            // 
            // Size
            // 
            Size.HeaderText = "Размер Байт";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.ReadOnly = true;
            Size.Width = 125;
            // 
            // MD5
            // 
            MD5.HeaderText = "Контрольная сумма";
            MD5.MinimumWidth = 6;
            MD5.Name = "MD5";
            MD5.ReadOnly = true;
            MD5.Width = 250;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Name = "MainForm";
            Text = "Генератор Информационно-Удостоверяющего Листа";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Label folderLbl;
        private DataGridView dataGridView1;
        private DataGridView dataGridView;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn No;
        private DataGridViewCheckBoxColumn Selected;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn LastModifiedAt;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn MD5;
    }
}
