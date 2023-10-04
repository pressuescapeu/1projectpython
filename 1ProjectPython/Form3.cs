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

namespace _1ProjectPython
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = (@"t1.txt");
            using (StreamReader sr = new StreamReader(path))
            {
                string res = sr.ReadToEnd();
                //label2.Text = res;
                if (richTextBox1.Text == res)
                {
                    pictureBox2.Visible = true;
                    Image image = Image.FromFile(@"right.png");
                    pictureBox2.BackgroundImage = image;
                }
                else
                {
                    pictureBox2.Visible = true;
                    Image image = Image.FromFile(@"false.jpg");
                    pictureBox2.BackgroundImage = image;
                }
            }
        }
    }
}
