using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnectionApplikation
{
    public partial class Form1 : Form
    {
        //Skapa ett MySQLCOnnector object
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            // Bygg upp information för MySQLCOnnection object
            string server = "localhost";
            string database = "oop22gbapplication";
            string user = "root";
            string pass = "SokrateS13";

            //Establera kopplika till Database
            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};";
            conn = new MySqlConnection(connString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertToDB();
        }

        private void insertToDB()
        {
            //Hämta data från textfält
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string petName = txtPet.Text;

            //Bygg upp SQL querry
            string SQLquerry = $"INSERT INTO people(people_name, people_age,people_pet) VALUES ('{name}', {age}, '{petName}');";

            //Skapar ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLquerry, conn);

            //Try/Catch block
            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekvera SQL querry
                cmd.ExecuteReader();

                //stänger kopplingen till DB
                conn.Close();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            // Bekräftelse till användaren
            MessageBox.Show("Insert finished successfully!");
        }
    }
}
