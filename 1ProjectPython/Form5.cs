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
    public partial class Form5 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = pythondb.mdb";
        private OleDbConnection myConnection;
        public Form5()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string useless = textBox1.Text;
            string query = "SELECT * FROM [типы данных] WHERE тип_данных = " + "'" + useless + "'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // очищаем listBox1
            listBox1.Items.Clear();

            // в цикле построчно читаем ответ от БД
            while (reader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
            }

            // закрываем OleDbDataReader
            reader.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
