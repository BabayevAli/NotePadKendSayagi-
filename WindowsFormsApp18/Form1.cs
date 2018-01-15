using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialRes c = new DialRes();
            if (saveFileDialog1.FileName != "")
            {
                c.FileName = saveFileDialog1.FileName;
            }
            else
                c.FileName = "Unitled";
            c.ShowDialog();
            if (c.Dialog == 0)
            {
                saveFileDialog1.Filter = "Text Document (*txt)|*.txt";
                if (saveFileDialog1.FileName == "")
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    else
                        return;
                }
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            else if (c.Dialog == 1)
            {
                richTextBox1.Clear();
            }
            else if (c.Dialog == 2)
            {

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName != "")
            {
                saveFileDialog1.Filter = "Text Document (*txt)|*.txt";
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                saveFileDialog1.Filter = "Text Document (*txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialRes c = new DialRes();
            if (saveFileDialog1.FileName != "")
            {
                c.FileName = saveFileDialog1.FileName;
            }
            else
                c.FileName = "Unitled";
            c.ShowDialog();
            if (c.Dialog == 0)
            {
                saveFileDialog1.Filter = "Text Document (*txt)|*.txt";
                if (saveFileDialog1.FileName == "")
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    else
                        return;
                }
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            else if (c.Dialog == 1)
            {
                richTextBox1.Clear();
            }
            else if (c.Dialog == 2)
            {

            }
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.ShowDialog();
            var b = richTextBox1.Find(Form3.FindText);
            richTextBox1.Select(b, Form3.FindText.Length);
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = richTextBox1.Find(Form3.FindText, RichTextBoxFinds.None);
            richTextBox1.Select(i, Form3.FindText.Length);
            richTextBox1.SelectionColor = Color.Red;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString());
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void openfolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            DirectoryInfo directory = new DirectoryInfo(folderBrowserDialog1.SelectedPath);

            foreach (var filename in directory.GetFiles())
            {
                richTextBox1.AppendText(Environment.NewLine + filename.Name);
            }
        }
    }
}
