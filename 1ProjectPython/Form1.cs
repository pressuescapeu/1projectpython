using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ProjectPython
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        Form2 form2;

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVars.count += 1;
            if (GlobalVars.count == 2)
            {
                button2.Visible = true;
                textBox1.Visible = true;
                label1.Text = "Попробуйте вывести Hello World!, используя одинарные кавычки";
            }
            if (GlobalVars.count == 3)
            {
                label1.Text = "Второе что мы пройдем - команда input() и присваивание в Python";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                Image image = Image.FromFile(@"a3.png");
                pictureBox1.Image = image;
                button2.Visible = false;
                textBox1.Text = "";
                textBox1.Visible = false;
            }
            if (GlobalVars.count == 4)
            {
                Image image = Image.FromFile(@"a2.png");
                pictureBox1.Image = image;
                pictureBox4.Visible = true;
                Image im = Image.FromFile(@"a4.png");
                pictureBox4.Image = im;
            }
            if (GlobalVars.count == 5)
            {
                textBox1.Visible = true;
                button2.Visible = true;
                label1.Text = "Попробуйте вывести то, что вам ввели. Если код состоит из 2 строк, используйте 3 пробела как Enter." + "\n" + "Как переменную используйте word";
            }
            if (GlobalVars.count == 6)
            {
                Image image = Image.FromFile(@"a5.png");
                pictureBox1.Image = image;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                button2.Visible = false;
                textBox1.Text = "";
                textBox1.Visible = false;
                label1.Text = "Еще один полезный материал по теме.";
                pictureBox4.Visible = false;
            }
            if (GlobalVars.count == 7)
            {
                Image image = Image.FromFile(@"a6.png");
                pictureBox1.Image = image;
                label1.Text = "Типы данных в Python - не совсем типы данных, но сначала лучше воспринимать их так" + "\n" + "Вот самые основные из них, для новичка";
            }
            if (GlobalVars.count == 8)
            {
                label1.Text = "Напишите программу, которая сначала считывает три фразы по очереди, а потом" + "\n" + "воспроизводит их в обратной последовательности, каждую на отдельной строчке." + "\n" + "переменные - word1, word2, word3, Enter - 3 пробела.";
                textBox1.Visible = true;
                button2.Visible = true;
            }
            if (GlobalVars.count == 8)
            {
                button1.Text = "Перейти на урок Условный оператор";
            }
            if (GlobalVars.count == 8)
            {
                form2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVars.check_count += 1;
            if (GlobalVars.check_count == 2)
            {
                if (textBox1.Text == "print(" + "\'" + "Hello World!" + "\'" + ")")
                {
                    pictureBox3.Visible = true;
                    Image image = Image.FromFile(@"right.png");
                    pictureBox3.BackgroundImage = image;
                }
                else
                {
                    pictureBox3.Visible = true;
                    Image image = Image.FromFile(@"false.jpg");
                    pictureBox3.BackgroundImage = image;
                }
            }
            if (GlobalVars.check_count == 3)
            {
                if (textBox1.Text == "print(input())" || textBox1.Text == "word = input()   print(word)")
                {
                    pictureBox3.Visible = true;
                    Image image = Image.FromFile(@"right.png");
                    pictureBox3.BackgroundImage = image;
                }
                else
                {
                    pictureBox3.Visible = true;
                    Image image = Image.FromFile(@"false.jpg");
                    pictureBox3.BackgroundImage = image;
                }
            }
            if (GlobalVars.check_count == 4)
            {
                if (textBox1.Text == "word1 = input()   word2 = input()   word3 = input()   print(word1, word2, word3)")
                {
                    pictureBox3.Visible = true;
                    Image image = Image.FromFile(@"right.png");
                    pictureBox3.BackgroundImage = image;
                }
                else if (textBox1.Text == "word1 = input()   word2 = input()   word3 = input()   print(word1)   print(word2)   print(word3)")
                {
                    pictureBox3.Visible = true;
                    Image image = Image.FromFile(@"right.png");
                    pictureBox3.BackgroundImage = image;
                }
                else
                {
                    pictureBox3.Visible = true;
                    Image image = Image.FromFile(@"false.jpg");
                    pictureBox3.BackgroundImage = image;
                }
            }
        }
    }
    public partial class GlobalVars
    {
        public static int count = 1;
        public static int check_count = 1;
    }
}
