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
    public partial class Completat : Form
    {

        FrmJoc frmJoc;

        public Completat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF size = graphics.MeasureString(textBox1.Text.Trim(), new Font("Agency FB", 12, FontStyle.Regular, GraphicsUnit.Point));
               
                if (size.Width > 40)
                    MessageBox.Show("Alegeti un nume mai scurt!");
                else
                {

                    if (textBox1.Text.Trim() == "" || (rbtnmica.Checked == rbtnmedie.Checked == rbtnmare.Checked == false))
                        MessageBox.Show("Completati cu numele si selectati o dificultate!");
                    else
                    {
                        if (rbtnmica.Checked == true)
                        {

                            frmJoc = new FrmJoc(1, textBox1.Text.Trim());
                            frmJoc.Show();

                        }
                        else if (rbtnmedie.Checked == true)
                        {

                            frmJoc = new FrmJoc(2, textBox1.Text.Trim());
                            frmJoc.Show();
                        }
                        else if (rbtnmare.Checked == true)
                        {

                            frmJoc = new FrmJoc(3, textBox1.Text.Trim());
                            frmJoc.Show();
                        }


                        this.Close();
                    }

                }
            }

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.CornflowerBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

    }
}
