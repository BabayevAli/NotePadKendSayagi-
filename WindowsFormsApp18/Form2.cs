using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class DialRes : Form
    {
        public int Dialog { get; set; } = 3;
        public string FileName { get; set; }
        public DialRes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text += " " + FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog = 0;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dialog = 1;
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dialog = 3;
            Hide();

        }
    }
}
