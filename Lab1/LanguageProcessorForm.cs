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

    public partial class LanguageProcessorForm : Form
    {
        
        public LanguageProcessorForm()
        {
            InitializeComponent();
            this.Text += " - unnamed";
        }

        private void StripMenuAbout_Click(object sender, EventArgs e)
        {
            var aboutWindow = new AboutForm();
            aboutWindow.Show();
        }

        private void StripMenuHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(null, "Help.chm");
        }

        private void StripMenuCreate_Click(object sender, EventArgs e)
        {
            if (StaticData.unsaved)
            {
                StaticData.currentData = textBox1.Text;
                var saveBeforeCloseWindow = new SaveBeforeCloseForm();
                saveBeforeCloseWindow.ShowDialog();
            }

            StaticData.dialogService.FilePath = "";
            StaticData.currentData = "";
            textBox1.Text = StaticData.currentData;
            this.Text = "Language Processor - unnamed";
        }

        private void StripMenuOpen_Click(object sender, EventArgs e)
        {
            if (StaticData.unsaved)
            {
                StaticData.currentData = textBox1.Text;
                var saveBeforeCloseWindow = new SaveBeforeCloseForm();
                saveBeforeCloseWindow.ShowDialog();
            }

            StaticData.dialogService.OpenFileDialog();
            StaticData.currentData = StaticData.fileService.ReadFile(StaticData.dialogService.FilePath);

            textBox1.Text = StaticData.currentData;

            this.Text = "Language Processor";
            if (StaticData.dialogService.FilePath != null || StaticData.dialogService.FilePath != "")
                this.Text += " - " + StaticData.dialogService.FilePath;
            else
                this.Text += " - unnamed";

            StaticData.unsaved = false;
        }

        private void StripMenuSave_Click(object sender, EventArgs e)
        {
            StaticData.currentData = textBox1.Text;
            StaticData.fileService.SaveFile(StaticData.dialogService.FilePath, StaticData.currentData);
            StaticData.unsaved = false;
        }

        private void StripMenuSaveAs_Click(object sender, EventArgs e)
        {
            StaticData.currentData = textBox1.Text;
            StaticData.dialogService.SaveFileDialog();
            StaticData.fileService.SaveFile(StaticData.dialogService.FilePath, StaticData.currentData);
            this.Text = "Language Processor - " + StaticData.dialogService.FilePath;
            StaticData.unsaved = false;
        }

        private void StripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!StaticData.unsaved)
            {
                StaticData.unsaved = true;
                this.Text += " *";
            }

        }

        private void toolStripCreate_Click(object sender, EventArgs e)
        {
            if (StaticData.unsaved)
            {
                StaticData.currentData = textBox1.Text;
                var saveBeforeCloseWindow = new SaveBeforeCloseForm();
                saveBeforeCloseWindow.ShowDialog();
            }

            StaticData.dialogService.FilePath = "";
            StaticData.currentData = "";
            textBox1.Text = StaticData.currentData;
            this.Text = "Language Processor - unnamed";
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            if (StaticData.unsaved)
            {
                StaticData.currentData = textBox1.Text;
                var saveBeforeCloseWindow = new SaveBeforeCloseForm();
                saveBeforeCloseWindow.ShowDialog();
            }

            StaticData.dialogService.OpenFileDialog();
            StaticData.currentData = StaticData.fileService.ReadFile(StaticData.dialogService.FilePath);

            textBox1.Text = StaticData.currentData;

            this.Text = "Language Processor";
            if (StaticData.dialogService.FilePath != null || StaticData.dialogService.FilePath != "")
                this.Text += " - " + StaticData.dialogService.FilePath;
            else
                this.Text += " - unnamed";

            StaticData.unsaved = false;
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (StaticData.dialogService.FilePath == null)
            {
                StaticData.dialogService.SaveFileDialog();
                StaticData.fileService.SaveFile(StaticData.dialogService.FilePath, StaticData.currentData);
            }
            else
            {
                StaticData.fileService.SaveFile(StaticData.dialogService.FilePath, StaticData.currentData);
            }

            StaticData.dialogService.FilePath = "";
            StaticData.currentData = "";
            StaticData.unsaved = false;
        }

        private void toolStripUndo_Click(object sender, EventArgs e)
        {
            if (StaticData.undoStack.Count > 0)
            {
                StaticData.redoStack.Push(textBox1.Text);
                string newValue = StaticData.undoStack.Pop();
                textBox1.Text = newValue;
            }
        }

        private void toolStripRedo_Click(object sender, EventArgs e)
        {
            if (StaticData.redoStack.Count > 0)
            {
                StaticData.undoStack.Push(textBox1.Text);
                string newValue = StaticData.redoStack.Pop();
                textBox1.Text = newValue;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            StaticData.undoStack.Push(textBox.Text);
        }

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            if(textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void toolStripPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (textBox1.SelectionLength > 0)
                {
                    textBox1.SelectionStart = textBox1.SelectionStart + textBox1.SelectionLength;
                }
                textBox1.Paste();
            }
        }

        private void toolStripCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
                textBox1.Cut();
        }

        private void StripMenuUndo_Click(object sender, EventArgs e)
        {
            if (StaticData.undoStack.Count > 0)
            {
                StaticData.redoStack.Push(textBox1.Text);
                string newValue = StaticData.undoStack.Pop();
                textBox1.Text = newValue;
            }
        }

        private void StripMenuRedo_Click(object sender, EventArgs e)
        {
            if (StaticData.redoStack.Count > 0)
            {
                StaticData.undoStack.Push(textBox1.Text);
                string newValue = StaticData.redoStack.Pop();
                textBox1.Text = newValue;
            }
        }

        private void StripMenuCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
                textBox1.Cut();
        }

        private void StripMenuCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void StripMenuPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (textBox1.SelectionLength > 0)
                {
                    textBox1.SelectionStart = textBox1.SelectionStart + textBox1.SelectionLength;
                }
                textBox1.Paste();
            }
        }

        private void StripMenuDelete_Click(object sender, EventArgs e)
        {
            int StartPosDel = textBox1.SelectionStart;
            int LenSelection = textBox1.SelectionLength;
            textBox1.Text = textBox1.Text.Remove(StartPosDel, LenSelection);
        }

        private void StripMenuSelectAll_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void toolStripHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(null, "Help.chm");
        }
    }


}
