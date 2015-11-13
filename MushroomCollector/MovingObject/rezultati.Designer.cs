namespace MovingObject
{
    partial class rezultati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezultati));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRezultati = new System.Windows.Forms.Label();
            this.btnIzbrisiGi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 368);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNazad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNazad.Location = new System.Drawing.Point(418, 188);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 54);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Назад";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            this.btnNazad.MouseLeave += new System.EventHandler(this.btnNazad_MouseLeave);
            this.btnNazad.MouseHover += new System.EventHandler(this.btnNazad_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox2.Controls.Add(this.lblRezultati);
            this.groupBox2.Location = new System.Drawing.Point(418, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 116);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Најдобри резултати";
            // 
            // lblRezultati
            // 
            this.lblRezultati.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRezultati.Location = new System.Drawing.Point(6, 16);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(188, 97);
            this.lblRezultati.TabIndex = 0;
            // 
            // btnIzbrisiGi
            // 
            this.btnIzbrisiGi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzbrisiGi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzbrisiGi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzbrisiGi.Location = new System.Drawing.Point(543, 188);
            this.btnIzbrisiGi.Name = "btnIzbrisiGi";
            this.btnIzbrisiGi.Size = new System.Drawing.Size(75, 54);
            this.btnIzbrisiGi.TabIndex = 7;
            this.btnIzbrisiGi.Text = "Избриши ги";
            this.btnIzbrisiGi.UseVisualStyleBackColor = false;
            this.btnIzbrisiGi.Click += new System.EventHandler(this.btnIzbrisiGi_Click);
            this.btnIzbrisiGi.MouseLeave += new System.EventHandler(this.btnIzbrisiGi_MouseLeave);
            this.btnIzbrisiGi.MouseHover += new System.EventHandler(this.btnIzbrisiGi_MouseHover);
            // 
            // rezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 370);
            this.Controls.Add(this.btnIzbrisiGi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "rezultati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Резултати";
            this.Load += new System.EventHandler(this.rezultati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIzbrisiGi;
        private System.Windows.Forms.Label lblRezultati;

    }
}