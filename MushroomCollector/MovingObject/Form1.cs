using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using MovingObject.Properties;
using System.IO;

namespace MovingObject
{
    public partial class Form1 : Form
    {
        public List<Igrach> li { set; get; }
        public Igrach ig { set; get; }
     
        public Form1()
        {
            InitializeComponent();
            li = new List<Igrach>();
       
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Resource1.kopce_zvuk);

            sp.Play();

            panel1.Visible = true;
            button1.Enabled = false;
            txtIme.Text = "";
            txtIme.Focus();

            rbNormal.Checked = true;    
        }

        private void button3_Click(object sender, EventArgs e)
        {

          

            Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;     
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Orange;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LawnGreen;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LawnGreen;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LawnGreen;
        }
        private void btnZapocni_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            FormView pocni = new FormView();
            panel1.Visible = false; 
         ig = new Igrach();
            if (rbNormal.Checked){
                ig.normal = true;
            }
            else{
                ig.normal = false;
            }
            pocni.nivo = ig.normal;

            if(pocni.ShowDialog()==DialogResult.OK)
            {        
                ig.ime = txtIme.Text;
                ig.poeni = pocni.igr.poeni;
                ig.freeze = pocni.igr.freeze;
              
                li.Add(ig);
              
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
           SoundPlayer sp = new SoundPlayer(Resource1.kopce_zvuk);
            sp.Play();
          
            button1.Enabled = true;
            panel1.Visible = false;
 
        }

        private void btnOtkazi_MouseHover(object sender, EventArgs e)
        {
            btnOtkazi.ForeColor = Color.Yellow;
        }

        private void btnZapocni_MouseHover(object sender, EventArgs e)
        {
            btnZapocni.ForeColor = Color.Yellow;
        }

        private void btnOtkazi_MouseLeave(object sender, EventArgs e)
        {
            btnOtkazi.ForeColor = Color.White;
        }

        private void btnZapocni_MouseLeave(object sender, EventArgs e)
        {
            btnZapocni.ForeColor = Color.White;
        }

  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, "Името е задолжително!");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Resource1.kopce_zvuk);

            sp.Play();

            rezultati rz = new rezultati();
            string pratiRez = "";
         
            li = li.OrderByDescending(x => x.poeni).ToList();
            for (int i = 0; i < li.Count; i++)
            {

                pratiRez += i+1 + ". " + li[i].ToString() + "\n";

            }

            rz.pratiRez = pratiRez;
            if (rz.ShowDialog() == DialogResult.OK)
            {
                li.Clear();

            }
        }

       

     


      

      

        
    }
}
