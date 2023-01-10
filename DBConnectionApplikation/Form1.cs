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
        }
    }
}
