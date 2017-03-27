namespace FastTyping
{
    partial class Meniu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblstart = new System.Windows.Forms.Label();
            this.lbldespre = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.label_cls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.BackColor = System.Drawing.Color.Transparent;
            this.lblstart.Font = new System.Drawing.Font("Agency FB", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart.ForeColor = System.Drawing.Color.White;
            this.lblstart.Location = new System.Drawing.Point(164, 41);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(160, 57);
            this.lblstart.TabIndex = 0;
            this.lblstart.Text = "S T A R T";
            this.lblstart.Click += new System.EventHandler(this.lblstart_Click);
            this.lblstart.MouseEnter += new System.EventHandler(this.lblstart_MouseEnter);
            this.lblstart.MouseLeave += new System.EventHandler(this.lblstart_MouseLeave);
            // 
            // lbldespre
            // 
            this.lbldespre.AutoSize = true;
            this.lbldespre.BackColor = System.Drawing.Color.Transparent;
            this.lbldespre.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldespre.ForeColor = System.Drawing.Color.White;
            this.lbldespre.Location = new System.Drawing.Point(167, 150);
            this.lbldespre.Name = "lbldespre";
            this.lbldespre.Size = new System.Drawing.Size(145, 41);
            this.lbldespre.TabIndex = 1;
            this.lbldespre.Text = "D E S P R E";
            this.lbldespre.Click += new System.EventHandler(this.lbldespre_Click);
            this.lbldespre.MouseEnter += new System.EventHandler(this.lbldespre_MouseEnter);
            this.lbldespre.MouseLeave += new System.EventHandler(this.lbldespre_MouseLeave);
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.White;
            this.lblexit.Location = new System.Drawing.Point(201, 194);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(83, 41);
            this.lblexit.TabIndex = 2;
            this.lblexit.Text = "E X I T";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            this.lblexit.MouseEnter += new System.EventHandler(this.lblexit_MouseEnter);
            this.lblexit.MouseLeave += new System.EventHandler(this.lblexit_MouseLeave);
            // 
            // label_cls
            // 
            this.label_cls.AutoSize = true;
            this.label_cls.BackColor = System.Drawing.Color.Transparent;
            this.label_cls.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cls.ForeColor = System.Drawing.Color.White;
            this.label_cls.Location = new System.Drawing.Point(140, 102);
            this.label_cls.Name = "label_cls";
            this.label_cls.Size = new System.Drawing.Size(206, 41);
            this.label_cls.TabIndex = 3;
            this.label_cls.Text = "C L A S A M E N T";
            this.label_cls.Click += new System.EventHandler(this.label_cls_Click);
            this.label_cls.MouseEnter += new System.EventHandler(this.label_cls_MouseEnter);
            this.label_cls.MouseLeave += new System.EventHandler(this.label_cls_MouseLeave);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FastTyping.Properties.Resources.meniu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.label_cls);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lbldespre);
            this.Controls.Add(this.lblstart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lbldespre;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label label_cls;
    }
}

