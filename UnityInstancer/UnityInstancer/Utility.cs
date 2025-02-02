using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityInstancer
{
    public class Utility
    {
        public static DialogResult ShowMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(message, title, buttons, icon);
        }

        public static string? OpenFileDialog(string path, string fileTypes)
        {
            try //try to run this code, on error break and show the error.
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    //sets info about our file dialog.
                    openFileDialog.InitialDirectory = @path;
                    openFileDialog.Filter = fileTypes; //format: "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                    openFileDialog.FilterIndex = 1; //ensure that filter is always this one.
                    openFileDialog.RestoreDirectory = false;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        string filePath = openFileDialog.FileName;
                        return filePath;
                    }
                    else //needed so that it can return something.
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
