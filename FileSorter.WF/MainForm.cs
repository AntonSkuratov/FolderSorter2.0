using FileSorter.BL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter.WF
{
    public partial class MainForm : Form
    {
        private static List<string> folders = new List<string>();

        private FileRepository? fileRepository;
        public MainForm()
        {
            InitializeComponent();
        }

        private void lbAllFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data!.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                lblInfo1.Text = "Отпустите мышь";
            }
        }
        private void lbAllFiles_DragLeave(object sender, EventArgs e)
        {
            lblInfo1.Text = "Перетащите папки";
        }
        private void lbAllFiles_DragDrop(object sender, DragEventArgs e)
        {
            lblInfo1.Text = "";
            foreach (string folder in (string[])e.Data!.GetData(DataFormats.FileDrop)!)
                folders.Add(folder);
            fileRepository = new FileRepository(folders);
            foreach (var file in fileRepository.GetAllFiles())
                lbAllFiles.Items.Add(file);
            lblFilesCount.Text = $"Всего файлов: {fileRepository.FilesCount}";
        }
        private void tbFinalPath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                tbFinalPath.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            FileRepositoryManagement fileRepositoryManagement=new FileRepositoryManagement(fileRepository!);
            fileRepositoryManagement.MoveTo(tbFinalPath.Text);
        }
    }
}
