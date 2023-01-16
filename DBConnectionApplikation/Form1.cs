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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using TextBox = System.Windows.Forms.TextBox;
using MySqlX.XDevAPI.Relational;

namespace DBConnectionApplikation
{
    public partial class Form1 : Form
    {
        //Skapa ett MySQLCOnnector object
        MySqlConnection conn;

        TextBox[] txtBoxes;

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

            //Skapa en array av textbox, för validering
            txtBoxes = new TextBox[] { txtName, txtAge, txtPet };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertToDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectFromDB();
        }

        private void insertToDB()
        {
            //ValideringsCheck
            bool valid = true;

            //Validering; kontrollera att varje textbox har ett värde
            foreach (TextBox textbox in txtBoxes)
            {
                //Cleanup
                textbox.Text = textbox.Text.Trim();

                //validering
                if (textbox.Text == "")
                {
                    //Validering has failed
                    textbox.BackColor = Color.Red;

                    valid = false;
                } else
                {
                    textbox.BackColor = TextBox.DefaultBackColor;
                }
            }

            //Kontrollerar validerings resultat
            if (!valid) {
                MessageBox.Show("Felaktig inmatning. Kontrollera röda fält.");
                return;
            }

            //Hämta data från textfält
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string petName = txtPet.Text;

            //Bygg upp SQL querry
            //string SQLquerry = $"INSERT INTO people(people_name, people_age,people_pet) VALUES ('{name}', {age}, '{petName}');";
            string SQLquerry = $"CALL insertPeople('{name}', {age}, '{petName}');";

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

        private void selectFromDB()
        {
            //Bygg upp SQL querry
            //string SQLquerry = "SELECT * FROM people";
            string SQLquerry = "CALL selectPeople();";

            //Skapar ett MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(SQLquerry, conn);

            //Try/Catch block
            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekvera SQL querry
                MySqlDataReader reader = cmd.ExecuteReader();

                //Skriva till Grid
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                gridOutput.DataSource = dataTable;

                //Tömma output label
                lblSelectOutput.Text = "";

                //Tömma Persons listan
                People.persons.Clear();

                //Exekvera SQL querry
                reader = cmd.ExecuteReader();

                //While Loop för att skriva ut hämtad data
                while (reader.Read())
                {
                    //Hämta specifik data från Reader objekt
                    int id = Convert.ToInt32(reader["people_id"]);
                    string name = reader["people_name"].ToString();
                    int age = Convert.ToInt32(reader["people_age"]);
                    string petName = reader["people_pet"].ToString();

                    //Skriva ut värden till label
                    lblSelectOutput.Text += $"{name} är {age} år gammal. Husdjuret heter {petName}{Environment.NewLine}";

                    //Skapa ett nytt objekt av People och sparar det i statisk lista
                    People.persons.Add(new People(id, name, age, petName));
                }

                //stänger kopplingen till DB
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void gridOutput_Click(object sender, EventArgs e)
        {
            // Validering för att kontrollera att en rad har blivit hämtad
            if (gridOutput.SelectedRows.Count != 1) return;

            //Validering för att kontolerea att vi har lokal data från DB
            if (People.persons.Count == 0) return;

            //Int vairabel för markerat id
            int id = 0;

            //Hämtar ID från den markerade raden
            DataGridViewSelectedRowCollection rows = gridOutput.SelectedRows;
            id = Convert.ToInt32(rows[0].Cells[0].Value);

            /*foreach (DataGridViewRow row in rows)
            {
                id = Convert.ToInt32(row.Cells[0].Value);
            }*/

            foreach (People person in People.persons)
            {
                //Söker efter rätt post i listan
                if (person.Id == id)
                {
                    //Hittat rätt person

                    //Hämta properties från person och skriv in dem i textfält

                    txtBoxes[0].Text = person.Name;
                    txtBoxes[1].Text = person.Age.ToString();
                    txtBoxes[2].Text = person.Pet;

                    //Avsluta med break
                    break;
                }
            }

        }
    }
}
