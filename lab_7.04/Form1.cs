using System;
using System.IO;
using System.Windows.Forms;

namespace lab_7._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = File.ReadAllText("result.txt");
            label1.Text = temp;
            label1.Visible = true;
            label2.Text = "Символы = " + temp.Length;
            label2.Visible = true;
            progressBar1.Value = temp.Length / 10;
        }
    }
}
