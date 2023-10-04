using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _1ProjectPython
{
    public partial class Form4 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = pythondb.mdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pythondbDataSet.встроенные_функции". При необходимости она может быть перемещена или удалена.
            this.встроенные_функцииTableAdapter.Fill(this.pythondbDataSet.встроенные_функции);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("UPDATE [встроенные функции] SET аргументы ='" + textBox1.Text +"', описание ='" + textBox2.Text +"', пример ='" + textBox3.Text + "'WHERE функция =" + textBox5.Text, myConnection);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("DELETE FROM [встроенные функции] WHERE функция = " + "'" + textBox4.Text + "'", myConnection);
            command.ExecuteNonQuery();
        }
    }
}
