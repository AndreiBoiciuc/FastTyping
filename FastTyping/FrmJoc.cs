using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FastTyping
{
    public partial class FrmJoc : Form
    {

        int dificultate;
        string nume;
        int scor = 0;
        Boolean zero = false;

        String[] randFirst = File.ReadAllLines(@"cuvinte.txt");
        Random fname = new Random();


        Clasament clasament = new Clasament();

        public FrmJoc(int dif, string _nume)
        {
            
            dificultate = dif;
            nume = _nume;

            InitializeComponent(dif);//dif);

            foreach (Label c in this.Controls.OfType<Label>())
                if (Convert.ToString(c.Tag) == "cuv")
                    c.Text = randFirst[fname.Next(randFirst.Length)];
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Label x=label15;

            foreach (Label c in this.Controls.OfType<Label>())
            {

                if (Convert.ToString(c.Tag) == "cuv" && textBox1.Text == c.Text)
                {
                    x.ForeColor = Color.LawnGreen;

                    textBox1.Clear();
                    
                    scor += dificultate;

                    if(dificultate==1)
                        x.Text = "10";
                    else if (dificultate == 2)
                        x.Text = "15";
                    else if (dificultate == 3)
                        x.Text = "20";

                    c.Text = randFirst[fname.Next(randFirst.Length)];    
                }
                else
                {
                    x = c;
                }
            }
        }


        private void timerDecrement_Tick(object sender, EventArgs e)
        {

            foreach (Label c in this.Controls.OfType<Label>())
            {
                if (Convert.ToString(c.Tag) == "timp" )
                {
                    c.Text = Convert.ToString(Convert.ToInt32(c.Text) - 1);

                    if (Convert.ToInt32(c.Text) == 11)
                        c.ForeColor = Color.Yellow;
                    if (Convert.ToInt32(c.Text) == 7)
                        c.ForeColor = Color.Orange;
                    if (Convert.ToInt32(c.Text) == 4)
                        c.ForeColor = Color.OrangeRed;


                    if (c.Text == "0")
                    {
                        c.ForeColor = Color.Red;
                        zero = true;
                        textBox1.Enabled = false;
                        timerDecrement.Enabled = false;
                        Jucator x = new Jucator(nume, Convert.ToString(scor), Convert.ToString(dificultate));

                        
                        Meniu.clasament.AdaugaJ(x);

                        scor = 0;
                    }
                }
            }


        }

        private void label17_Click(object sender, EventArgs e)
        {
            timerDecrement.Enabled = false;

            if (zero == false)
            {
                foreach (Label c in this.Controls.OfType<Label>())
                    if (Convert.ToString(c.Tag) == "cuv")
                    {
                        c.Visible = false;
                    }

                if (MessageBox.Show("Jocul nu s-a terminat!\nEsti sigur ca vrei sa iesi?", "Iesire", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    timerDecrement.Enabled = true;
                    foreach (Label c in this.Controls.OfType<Label>())
                        if (Convert.ToString(c.Tag) == "cuv")
                            c.Visible = true;
                }
            }
            else
                this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (zero == false)
            {
                timerDecrement.Enabled = false;
                foreach (Label c in this.Controls.OfType<Label>())
                    if (Convert.ToString(c.Tag) == "cuv")
                        c.Visible = false;

                if (MessageBox.Show("Jocul nu s-a terminat, vei pierde scorul obtinut pana acum!\nEsti sigur ca vrei sa incepi din nou?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    FrmJoc frm = new FrmJoc(dificultate, nume);
                    frm.Show();
                }
                else
                {
                    timerDecrement.Enabled = true;
                    foreach (Label c in this.Controls.OfType<Label>())
                        if (Convert.ToString(c.Tag) == "cuv")
                        {
                            c.Visible = true;
                        }
                }

            }
            else
            {
                this.Close();
                FrmJoc frm = new FrmJoc(dificultate, nume);
                frm.Show();
            }

        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (Meniu.frmC_open == false)
            {
                frmClasament c = new frmClasament();
                c.Show();
                Meniu.frmC_open = true;
            } 
        }
    }
}
