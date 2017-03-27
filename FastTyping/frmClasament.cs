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
     public partial class frmClasament : Form
    {
         String[] clas_f = File.ReadAllLines(@"clasament_f.txt");
         

        public frmClasament()
        {
            
            InitializeComponent();

            foreach (string s in clas_f)
                textBox1.Text += s + Environment.NewLine;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meniu.frmC_open = false;
            this.Close();
        }
    }
}
