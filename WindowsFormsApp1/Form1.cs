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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            StreamReader textfile = new StreamReader("C:\\Users\\НикитенкоВ\\Desktop\\1.txt");
            string str="";
            while (!textfile.EndOfStream)
            {
                str += textfile.ReadLine();
            }
            label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter textfile;
            FileInfo file = new FileInfo("C:\\Users\\НикитенкоВ\\Desktop\\1.txt");

            textfile = file.AppendText();
            textfile.WriteLine(textBox1);
            textfile.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("C:\\Users\\НикитенкоВ\\Desktop\\1.txt");

            if (!file.Exists)
            {
                MessageBox.Show("Файла не сущетвует!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Catalogs form = new Catalogs();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tasks form = new Tasks();
            form.ShowDialog();
        }
    }
}
