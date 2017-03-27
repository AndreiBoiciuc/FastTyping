using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastTyping
{
    public partial class Meniu : Form
    {

        public static Clasament clasament = new Clasament();
        public static Boolean frmC_open = false;

        public Meniu()
        {
            
            InitializeComponent();
        }
        

        //-----Start
        private void lblstart_MouseEnter(object sender, EventArgs e)
        {
            lblstart.ForeColor = Color.LimeGreen;
        }

        private void lblstart_MouseLeave(object sender, EventArgs e)
        {
            lblstart.ForeColor = Color.White;
        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            Completat frmCompletat = new Completat();
            frmCompletat.Show();
            
        }


        //------clasament

        private void label_cls_MouseEnter(object sender, EventArgs e)
        {
            label_cls.ForeColor = Color.DodgerBlue;
        }

        private void label_cls_MouseLeave(object sender, EventArgs e)
        {
            label_cls.ForeColor = Color.White;
        }

        private void label_cls_Click(object sender, EventArgs e)
        {
            if (frmC_open == false)
            {
                frmClasament c = new frmClasament();
                c.Show();
                frmC_open = true;
            }
                
        }


        //----despre

        private void lbldespre_MouseEnter(object sender, EventArgs e)
        {
            lbldespre.ForeColor = Color.DodgerBlue;
        }

        private void lbldespre_MouseLeave(object sender, EventArgs e)
        {
            lbldespre.ForeColor = Color.White;
        }

        private void lbldespre_Click(object sender, EventArgs e)
        {
            Despre frmDespre = new Despre();
            frmDespre.Show();
        }


        //---exit
        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.White;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
