using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void regitrationForm_Load(object sender, EventArgs e)
        {
        }

        //public string time;


        //Metodas aktyvuojmas paspaudus mygtuka Issaugoti
        //perima sugaisto laiko ir atliktu bandymu skaiciaus kintamuosius is Form1, nuskaito textboxe ivesta varda ir aktyvuoja metoda DataTransfer. Pavykusio ar nepavykusio prisijungimo prie duombzes statusa parodo label lblConTest.

        private void btnIssaugoti_Click(object sender, EventArgs e)
        {
            MasterMind frm1 = new MasterMind();
            String name = txtVardas.Text;
            string time = frm1.LaikasBle();
            string count = frm1.countFinal;
            string connSuccess = DataTransfer(name, time, count);
            frm1.bandymas1();
            lblLaikas.Text = time;
            lblConTest.Text = connSuccess;
        }

        //Mygtukas Iseiti-> uzdaro Form2 langa
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        // Metodas DataTransfer -> duomenu perdavimas i / is duombazes
        // Query1 ir myReader1 siuncia paskutinio zaidimo duomenis i duombaze
        // Query2 ir meReader2 gauna visu zaidimo rezultatus is duombazes

        private string DataTransfer(string name, string time, string count)
        {
            string pranesimas = "Connection Failed";
            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=;";
            string Query1 = "INSERT INTO testuser.user(Name, Time, Count) values ('" + name + "', '" + time + "', '" + count + "');";
            string Query2 = "SELECT * FROM testuser.user order by Count desc;";

            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand SendToDB = new MySqlCommand(Query1, con);
            MySqlCommand GetFromDB = new MySqlCommand(Query2, con);
            MySqlDataReader myReader1;
            MySqlDataReader myReader2;
            {
                con.Open();
                myReader1 = SendToDB.ExecuteReader();
                con.Close();
                con.Open();
                myReader2 = GetFromDB.ExecuteReader();
                for (int i = 0; i < 10; i++) // Parodo 10 geriausiu rezultatu
                {
                    myReader2.Read();
                    listScores.Items.Add(myReader2[1] + " :    " + myReader2[3] + "   laikas:  " + myReader2[2]);
                }
                               
                if (con.State == ConnectionState.Open)
                {
                    pranesimas = "Connection success";
                }
            }
            return pranesimas;
        }




        private void txtVardas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblVardas_Click(object sender, EventArgs e)
        {

        }

        private void lblLaikas_Click(object sender, EventArgs e)
        {

        }
    }               
}
