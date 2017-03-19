using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class MasterMind : Form
    {
        public MasterMind()
        {
            InitializeComponent();
        }

        int skaitDydis = 4;
        int skaitMax = 9999;
        int count = 1;     // count = bandymu speti kiekis



        private void radio6_CheckedChanged(object sender, EventArgs e)
        {
            skaitDydis = 6;
            skaitMax = 999999;
            MessageBox.Show("Paspauskite mygtuka 'Pradeti'");

        }
        private void radio4_CheckedChanged(object sender, EventArgs e)
        {
            if (skaitDydis == 6)
            {
                skaitDydis = 4;
                skaitMax = 9999;
                lstItems.Text = "";
            }

        }

        // Metodas Random Skaiciaus Generatorius
        private HashSet<int> skaiciausGeneratorius()
        {
            // Sugeneruojam random skaiciu ir Seta 'masyvas', kuriame issaugosim to skaiciaus skaitmenis(setas tam, kad visi skaiciaus skaitmenys butu skirtingi)
            Random rand = new Random();
            int skaicius;

            HashSet<int> masyvas = new HashSet<int>();
            do
            {
                skaicius = rand.Next(0, skaitMax);
                masyvas.Clear();
                for (int i = 0; i < skaitDydis; i++)
                {
                    int skaitmuo = skaicius % 10;
                    masyvas.Add(skaitmuo);
                    skaicius = skaicius / 10;
                }

            } while (masyvas.Count < skaitDydis);
            return masyvas;
        }

        // Metodas laiko parodymui formos antrasteje
        private int _ticks = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = _ticks.ToString();
        }

        // Taimerio objekto deklaravimas (sukurimas metode zemiau)
        private Stopwatch stopWatch;

        // Metodas mygtukui "Pradeti"
        private void button1_Click(object sender, EventArgs e)
        {
            // Istrinam visu langu turini ir nuresetinam laikmati
            lstItems.Items.Clear();
            txtResult.Text = "";
            txtResult2.Text = "";
            txtGuess.Text = "";
            _ticks = 0;
            count = 1;     // count = bandymu speti kiekis

            HashSet<int> setas1 = skaiciausGeneratorius();
            var outGen = string.Join("", setas1);
            txtGen.Text = outGen;
            stopWatch = new Stopwatch();
            stopWatch.Start();
            timer1.Start();
            txtGuess.Select();
        }

        // Metodas mygtukui "Tikrinti"

        private void compareNum(object sender, EventArgs e)
        {
            AcceptButton = compare;
            txtGuess.Select();
            if (txtGen.Text == "")
            {
                MessageBox.Show("Paspauskite mygtuka 'Pradeti'");
            }
            else if (txtGuess.Text.Length == skaitDydis) // patikrina ar teisingo ilgio ivestas skaicius (gali buti ir kiti simboliai)
            {
                string a = txtGuess.Text;
                string b = txtGen.Text;
                if (a == b)
                {
                    timer1.Stop();
                    stopWatch.Stop();

                    MessageBox.Show("Atspejote is " + count + " bandymu" + "\nJusu laikas: " + stopWatch.Elapsed.Minutes.ToString("00") + " : " + stopWatch.Elapsed.Seconds.ToString("00"));
                    count = 1;
                    _ticks = 0;
                }
                else
                {
                    int n = 0; int m = 0;
                    for (int i = 0; i < skaitDydis; i++)
                    {
                        if (b.Contains(a[i]))
                        {
                            n++;
                        }
                        if (a[i] == b[i])
                        {
                            m++;
                        }
                    }
                    txtResult.Text = "Atspeta: " + n;
                    txtResult2.Text = "Savo vietoje: " + m;
                    lstItems.Items.Add(count + ".   " + a + "       " + n + " : " + m);
                    txtGuess.Text = "";
                    //txtGuess.;
                }
                count++;
            }
            else
            {
                MessageBox.Show("Iveskite " + skaitDydis + " skaitmenu skaiciu");
            }

        }

        // Nematomas sugeneruoto skaiciaus textBox
        private void txtGen_TextChanged(object sender, EventArgs e)
        {

        }

        // Rezultatu saraso langas 1
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Tarpinio rezultato langeliai 1 ir 2
        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtResult2_TextChanged(object sender, EventArgs e)
        {

        }

        // Metodas Menu punktas Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar norite zaidima baigti?", "Zaidimo pabaigimas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MasterMind_Load(object sender, EventArgs e)
        {

        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zaistiDarKartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string help = "Žaidimo tikslas atspėti kompiuterio sugeneruotą skaičių. Tam reikia skirti kuo mažiau bandymų ir laiko.\nGalima pasirinkti 4-ių arba 6-ių skaitmenų skaičių. Visi skaitmenys skaičiuje yra skirtingi, t.y skaičiaus 1123 negali būti.\n\nSĖKMĖS!";

            MessageBox.Show(help);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
