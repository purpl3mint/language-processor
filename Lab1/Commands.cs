using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public class Commands
    {

        public void CommandCreate()
        {
            if (StaticData.unsaved)
            {
                StaticData.currentData = StaticData.mainForm.InputTextBox.Text;
                var saveBeforeCloseWindow = new SaveBeforeCloseForm();
                saveBeforeCloseWindow.ShowDialog();
            }

            StaticData.dialogService.FilePath = "";
            StaticData.currentData = "";
            StaticData.mainForm.InputTextBox.Text = StaticData.currentData;
            StaticData.mainForm.Heading = "Language Processor - unnamed";
        }

        public void CommandOpen()
        {
            if (StaticData.unsaved)
            {
                StaticData.currentData = StaticData.mainForm.InputTextBox.Text;
                var saveBeforeCloseWindow = new SaveBeforeCloseForm();
                saveBeforeCloseWindow.ShowDialog();
            }

            StaticData.dialogService.OpenFileDialog();
            StaticData.currentData = StaticData.fileService.ReadFile(StaticData.dialogService.FilePath);

            StaticData.mainForm.InputTextBox.Text = StaticData.currentData;

            StaticData.mainForm.Heading = "Language Processor";
            if (StaticData.dialogService.FilePath != null || StaticData.dialogService.FilePath != "")
                StaticData.mainForm.Heading += " - " + StaticData.dialogService.FilePath;
            else
                StaticData.mainForm.Heading += " - unnamed";

            StaticData.unsaved = false;
        }

        public void CommandSave()
        {
            StaticData.currentData = StaticData.mainForm.InputTextBox.Text;

            if (StaticData.dialogService.FilePath == null)
            {
                StaticData.dialogService.SaveFileDialog();
                StaticData.fileService.SaveFile(StaticData.dialogService.FilePath, StaticData.currentData);
            }
            else
            {
                StaticData.fileService.SaveFile(StaticData.dialogService.FilePath, StaticData.currentData);
            }

            StaticData.unsaved = false;
            StaticData.mainForm.Heading = "Language Processor - " + StaticData.dialogService.FilePath;
        }

        public void CommandSaveAs()
        {
            StaticData.currentData = StaticData.mainForm.InputTextBox.Text;
            StaticData.dialogService.SaveFileDialog();
            StaticData.fileService.SaveFile(StaticData.dialogService.FilePath, StaticData.currentData);
            StaticData.mainForm.Heading = "Language Processor - " + StaticData.dialogService.FilePath;
            StaticData.unsaved = false;
        }

        public void CommandUndo()
        {
            if (StaticData.undoStack.Count > 0)
            {
                StaticData.redoStack.Push(StaticData.mainForm.InputTextBox.Text);
                string newValue = StaticData.undoStack.Pop();
                StaticData.mainForm.InputTextBox.Text = newValue;
            }
        }

        public void CommandRedo()
        {
            if (StaticData.redoStack.Count > 0)
            {
                StaticData.undoStack.Push(StaticData.mainForm.InputTextBox.Text);
                string newValue = StaticData.redoStack.Pop();
                StaticData.mainForm.InputTextBox.Text = newValue;
            }
        }

        public void CommandCopy()
        {
            if (StaticData.mainForm.InputTextBox.SelectionLength > 0)
                StaticData.mainForm.InputTextBox.Copy();
        }
        public void CommandPaste()
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (StaticData.mainForm.InputTextBox.SelectionLength > 0)
                {
                    StaticData.mainForm.InputTextBox.SelectionStart = StaticData.mainForm.InputTextBox.SelectionStart + StaticData.mainForm.InputTextBox.SelectionLength;
                }
                StaticData.mainForm.InputTextBox.Paste();
            }
        }

        public void CommandCut()
        {
            if (StaticData.mainForm.InputTextBox.SelectedText != "")
                StaticData.mainForm.InputTextBox.Cut();
        }

        public void CommandDelete()
        {
            int StartPosDel = StaticData.mainForm.InputTextBox.SelectionStart;
            int LenSelection = StaticData.mainForm.InputTextBox.SelectionLength;
            StaticData.mainForm.InputTextBox.Text = StaticData.mainForm.InputTextBox.Text.Remove(StartPosDel, LenSelection);
        }

        public void CommandSelectAll()
        {
            StaticData.mainForm.InputTextBox.SelectAll();
        }

        public void CommandHelp()
        {
            Help.ShowHelp(null, "../../heeelp/help1.html");
        }
    }
}
