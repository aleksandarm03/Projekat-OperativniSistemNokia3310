using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nokia3310
{
    class FileOpenClose
    {
        #region File
        //open file and load it to the textBox
        public void OpenFile(string filename, TextBox textBox)
        {
            try
            {
                if (File.Exists(filename))
                {
                    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    textBox.Text = sr.ReadToEnd();
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("Can't find file", "No file Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileLoadException err)
            {
                MessageBox.Show(err.Message, "Can't read File");
            }
            catch (Exception)
            {
            }
        }

        //Save note
        public void SaveFile(string fileName, TextBox textBox)
        {
            try
            {
                if (textBox.Text.Length > 0)
                {
                    FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(textBox.Text);
                    sw.Close();
                    MessageBox.Show("File saved", "Save");
                }
                else
                {
                    MessageBox.Show("Nothing to save - note is empty", "Nothing to save",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}
