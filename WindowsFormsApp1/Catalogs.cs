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
    public partial class Catalogs : Form
    {
        public Catalogs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Directory.CreateDirectory("C:\\ChickiBambony");
            DirectoryInfo papka = new DirectoryInfo("C:\\ChickiBambony_2");


            if (!papka.Exists)
            {
                papka.Create();
            }


            string[] catalogs = Directory.GetDirectories("C:\\");
            foreach (string dir in catalogs)
            {
               // MessageBox.Show(dir);
            }

            File.Create("C:\\ChickiBambony\\Dolli.pptx");

            FileInfo info = new FileInfo("C:\\ChickiBambony\\Dolli.txt");
            info.Create();
        }

    }
}
