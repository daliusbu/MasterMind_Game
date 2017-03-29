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
        private int skaitDydis;

        public registrationForm()
        {
            InitializeComponent();
        }

        // susikuriam konstruktoriu kad perduoti duomenis is Form1
        public registrationForm(string timeFinal, string countFinal, int skaitDydis)
        {
            InitializeComponent();
            time = timeFinal;
            count = countFinal;
            this.skaitDydis = skaitDydis;
        }

        //parodom zaidejo pasiekimus
        private void regitrationForm_Load(object sender, EventArgs e)
        {
            label3.Text = time;
            label4.Text = count;
        }

        
        //Metodas aktyvuojmas paspaudus mygtuka Issaugoti
        //paima zaidejo rezultatus, nuskaito textboxe ivesta varda ir aktyvuoja metoda DataTransfer. Pavykusio ar nepavykusio prisijungimo prie duombzes statusa parodo label lblConTest.

        private void btnIssaugoti_Click(object sender, EventArgs e)
        {
            // Tikrinam ar įvestas zaidejo vardas prie isaugojant rezultata
            if (txtVardas.Text == "")
            {
                MessageBox.Show("Įveskite žaidėjo vardą");
            }
            else if (listNames.Items.Count != 0)
            {
                btnIssaugoti.Text = "Uždaryti";
                MessageBox.Show("Jusu rezultatai jau išsaugoti");
                this.Close();
            }

            else
            {
                MasterMind frm1 = new MasterMind();
                String name = txtVardas.Text;
                string connSuccess = DataTransfer(name, time, count, skaitDydis);
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

        private string DataTransfer(string name, string time, string count, int skaitDydis)
        {
            string numberSize;
            switch (skaitDydis)
            {
                case 4:
                    numberSize = "user4";
                    break;
                case 6:
                    numberSize = "user6";
                    break;
                default:
                    numberSize = "user4";
                    break;
            }
            string pranesimas = "Prisjungti nepavyko";
            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=;";
            string Query1 = "INSERT INTO testuser." + numberSize + " (Name, Time, Count) values ('" + name + "', '" + time + "', '" + count + "');";
            string Query2 = "SELECT * FROM testuser." + numberSize +" order by Count asc, Time;";

            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand SendToDB = new MySqlCommand(Query1, con);
            MySqlCommand GetFromDB = new MySqlCommand(Query2, con);
            MySqlDataReader myReader1;
            MySqlDataReader myReader2;

            //con.Open();
            try
            {
                con.Open();
                myReader1 = SendToDB.ExecuteReader();
                con.Close();
                con.Open();
                myReader2 = GetFromDB.ExecuteReader();
           
                // i ekrana isvedame 10 geriausiu rezultatu
                int num = 1;
                while(myReader2.Read() &&  num < 11)
                {
                    string nr = Convert.ToString(num);
                    listNames.Items.Add("  " + nr + ".  " + myReader2[1]);
                    listScores.Items.Add("     " + myReader2[3] + "         " + myReader2[2]);
                    num ++;
                }
                               
                if (con.State == ConnectionState.Open)
                {
                    pranesimas = "Connection success";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Klaida: " + ex.Message + "\nNepavyko prisijungti prie duombazės");
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
