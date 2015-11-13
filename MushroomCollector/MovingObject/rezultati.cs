using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MovingObject
{
    public partial class rezultati : Form
    {
        public bool proveriIzbSkor { set; get; }
        public string pratiRez { set; get; }
        public rezultati()
        {
            InitializeComponent();
          
            proveriIzbSkor = false;
        }

        private void btnNazad_MouseHover(object sender, EventArgs e)
        {
            btnNazad.ForeColor = Color.Yellow;
        }

        private void btnIzbrisiGi_MouseHover(object sender, EventArgs e)
        {
            btnIzbrisiGi.ForeColor = Color.Yellow;
        }

        private void btnNazad_MouseLeave(object sender, EventArgs e)
        {
            btnNazad.ForeColor = Color.White;
        }

        private void btnIzbrisiGi_MouseLeave(object sender, EventArgs e)
        {
            btnIzbrisiGi.ForeColor = Color.White;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Resource1.kopce_zvuk);
            sp.Play();


            if (proveriIzbSkor)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            
        }

        private void rezultati_Load(object sender, EventArgs e)
        {
            lblRezultati.Text = pratiRez;
           

            
           


        }

        private void btnIzbrisiGi_Click(object sender, EventArgs e)
        {

            SoundPlayer sp = new SoundPlayer(Resource1.kopce_zvuk);
            sp.Play();

            lblRezultati.Text = "";
            pratiRez = "";
            proveriIzbSkor = true;
            
        }

       

    

       
    }
}
