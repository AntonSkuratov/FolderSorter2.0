namespace FileSorter.WF
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbAllFiles = new ListBox();
            tbFinalPath = new TextBox();
            lblInfo1 = new Label();
            lblFilesCount = new Label();
            btnSort = new Button();
            lblInfo2 = new Label();
            SuspendLayout();
            // 
            // lbAllFiles
            // 
            lbAllFiles.AllowDrop = true;
            lbAllFiles.FormattingEnabled = true;
            lbAllFiles.ItemHeight = 15;
            lbAllFiles.Location = new Point(12, 12);
            lbAllFiles.Name = "lbAllFiles";
            lbAllFiles.Size = new Size(519, 589);
            lbAllFiles.TabIndex = 0;
            lbAllFiles.DragDrop += lbAllFiles_DragDrop;
            lbAllFiles.DragEnter += lbAllFiles_DragEnter;
            lbAllFiles.DragLeave += lbAllFiles_DragLeave;
            // 
            // tbFinalPath
            // 
            tbFinalPath.Location = new Point(673, 12);
            tbFinalPath.Name = "tbFinalPath";
            tbFinalPath.Size = new Size(509, 23);
            tbFinalPath.TabIndex = 1;
            tbFinalPath.MouseDoubleClick += tbFinalPath_MouseDoubleClick;
            // 
            // lblInfo1
            // 
            lblInfo1.AutoSize = true;
            lblInfo1.Enabled = false;
            lblInfo1.Font = new Font("Segoe UI", 12F);
            lblInfo1.Location = new Point(189, 240);
            lblInfo1.Name = "lblInfo1";
            lblInfo1.Size = new Size(145, 21);
            lblInfo1.TabIndex = 2;
            lblInfo1.Text = "Перетащите папки";
            // 
            // lblFilesCount
            // 
            lblFilesCount.AutoSize = true;
            lblFilesCount.Font = new Font("Segoe UI", 12F);
            lblFilesCount.Location = new Point(537, 58);
            lblFilesCount.Name = "lblFilesCount";
            lblFilesCount.Size = new Size(122, 21);
            lblFilesCount.TabIndex = 3;
            lblFilesCount.Text = "Всего файлов: 0";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(815, 562);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(121, 39);
            btnSort.TabIndex = 4;
            btnSort.Text = "Сортировать";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Enabled = false;
            lblInfo2.Font = new Font("Segoe UI", 12F);
            lblInfo2.Location = new Point(537, 14);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(130, 21);
            lblInfo2.TabIndex = 5;
            lblInfo2.Text = "Оконечный путь";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1194, 617);
            Controls.Add(lblInfo2);
            Controls.Add(btnSort);
            Controls.Add(lblFilesCount);
            Controls.Add(lblInfo1);
            Controls.Add(tbFinalPath);
            Controls.Add(lbAllFiles);
            MaximumSize = new Size(1210, 656);
            MinimumSize = new Size(1210, 656);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сортировщик файлов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAllFiles;
        private TextBox tbFinalPath;
        private Label lblInfo1;
        private Label lblFilesCount;
        private Button btnSort;
        private Label lblInfo2;
    }
}