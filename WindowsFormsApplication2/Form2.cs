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
        private string time;
        private string count;

        public registrationForm()
        {
            InitializeComponent();
        }

        public registrationForm(string timeFinal, string countFinal)
        {
            InitializeComponent();
            time = timeFinal;
            count = countFinal;
        }

        //Metodas kuris aktyvuojamas is karto atidarius formos langa
        private void regitrationForm_Load(object sender, EventArgs e)
        {
            label3.Text = time;
            label4.Text = count;
        }

        
        //Metodas aktyvuojmas paspaudus mygtuka Issaugoti
        //perima sugaisto laiko ir atliktu bandymu skaiciaus kintamuosius is Form1, nuskaito textboxe ivesta varda ir aktyvuoja metoda DataTransfer. Pavykusio ar nepavykusio prisijungimo prie duombzes statusa parodo label lblConTest.

        private void btnIssaugoti_Click(object sender, EventArgs e)
        {
            // Tikrinam ar įvestas zaidejo vardas prie isaugojant rezultata
            if (txtVardas.Text == "")
            {
                MessageBox.Show("Įveskite žaidėjo vardą");
            }
            else if (listNames.Items.Count != 0)
            {
                btnIssaugoti.Text = "Uzdaryti";
                MessageBox.Show("Jusu rezultatai jau išsaugoti");
                this.Close();
            }

            else
            {
                MasterMind frm1 = new MasterMind();
                String name = txtVardas.Text;
                string connSuccess = DataTransfer(name, time, count);
                lblConTest.Text = connSuccess;
            }
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
            string Query1 = "INSERT INTO testuser.user4(Name, Time, Count) values ('" + name + "', '" + time + "', '" + count + "');";
            string Query2 = "SELECT * FROM testuser.user4 order by Count asc, Time;";

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

                for (int i = 0; i < 10; i++) // Parodo 5 geriausiu rezultatu
                {
                    string nr = Convert.ToString(i + 1);
                    myReader2.Read();
                    listNames.Items.Add("  " + nr + ".  " + myReader2[1]);
                    listScores.Items.Add("     " + myReader2[3] + "         " + myReader2[2]);
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

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }               
}
