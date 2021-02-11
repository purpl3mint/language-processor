using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{

    public partial class Form1 : Form
    {
        private DefaultDialogService dialogService;
        private DefaultFileService fileService;
        private string currentData = "";
        public Form1()
        {
            InitializeComponent();
            dialogService = new DefaultDialogService();
            fileService = new DefaultFileService();
        }

        private void StripMenuAbout_Click(object sender, EventArgs e)
        {
            var aboutWindow = new Form2();
            aboutWindow.Show();
        }

        private void StripMenuHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(null, "Help.chm");
        }

        private void StripMenuOpen_Click(object sender, EventArgs e)
        {
            dialogService.OpenFileDialog();
            currentData = fileService.ReadFile(dialogService.FilePath);

            textBox1.Text = currentData;
        }

        private void StripMenuSave_Click(object sender, EventArgs e)
        {
            currentData = textBox1.Text;
            fileService.SaveFile(dialogService.FilePath, currentData);
        }

        private void StripMenuSaveAs_Click(object sender, EventArgs e)
        {
            currentData = textBox1.Text;
            dialogService.SaveFileDialog();
        }

        private void StripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }


}
