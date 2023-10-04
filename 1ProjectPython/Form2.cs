using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace _1ProjectPython
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            form3 = new Form3();
            form4 = new Form4();
            form5 = new Form5();
        }

        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        Form3 form3;
        Form4 form4;
        Form5 form5;

        private void button3_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wmp.URL = (@"b1.m4a");
            wmp.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form5.Show();
        }
    }
}
