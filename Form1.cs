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
namespace telefonrehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dosyaOku();

        }
        public void dosyaOku()
        {
            string path = @"c:\MyTest.txt";

            //Open the stream and read it back.  
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    listBox1.Items.Add(temp.GetString(b));
                }
            }
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        public void dosyaYaz()
        {
            string path = @"c:\MyTest.txt";

            //Open the stream and read it back.  
            using (FileStream fs = File.OpenWrite (path))
            {

                foreach (string myItem in listBox1.Items)
                {
                    AddText(fs, myItem.ToString());
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ad:" + " "+ textBox1.Text + 
                "Soyad:" + textBox2.Text + "Telefon:" + textBox3.Text);
            dosyaYaz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
