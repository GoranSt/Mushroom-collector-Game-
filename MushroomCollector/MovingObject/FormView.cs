using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;






namespace MovingObject
{
    public partial class FormView : Form
    {

        public Igrach igr { set; get; }

        enum objPosition
        {
            Left, Right, Up, Down, Stop

        }
        private int brojSpace { set; get; }
        private int tmp { set; get; }
        private int broj { set; get; }
        private int _x;
        private int _y;
        private int lokacijaZolta { set; get; }
        private objPosition _objPosition;
        public bool nivo { set; get; }
        public FormView()
        {
            brojSpace = 3;
            tmp = 0;
            _x = 50;
            _y = 50;
            _objPosition = objPosition.Stop;

            

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Resource1.motion);
            //sp.PlayLooping();
            sp.Play();

           
         
           

            InitializeComponent();
            
        }

    



        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objPosition = objPosition.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                _objPosition = objPosition.Right;
            }

            if (e.KeyCode == Keys.Up)
            {

                _objPosition = objPosition.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                _objPosition = objPosition.Down;
            }

            if ((e.KeyCode == Keys.Space )&& brojSpace>0)
            {
                brojSpace--;
                lblZastaniBroj.Text = brojSpace.ToString();
                _objPosition = objPosition.Stop;
            }



        }

        private void FormView_Load(object sender, EventArgs e)
        {
            //pictureBox1.SendToBack();
            if (nivo)
            {

                label14.Text = "NORMAL";

               
            }
            else
            {
                label14.Text = "IMPOSSIBRU";
                lblVremeBroj.Text = "45";
                tmrMoving.Interval = 10;
            }

            lblCovek.Location = new Point(_x, _y);


          
           
          
    

     

        }

        private void panela2_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(new Bitmap("retro_mushroom_super_2.png"), _x, _y, 32, 32);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {






            Random r = new Random();

          

            broj = r.Next(1, 3);
            if (broj == 1 && label1.Location.Y < 400)
            {                                                     //
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 10);
            }
            else if (label1.Location.Y > 10)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 10);
            }



            broj = r.Next(1, 3);
            if (broj == 1 && label2.Location.Y < 400)
            {
                label2.Location = new Point(label2.Location.X, label2.Location.Y + 10);
            }
            else
            {
                label2.Location = new Point(label2.Location.X, label2.Location.Y - 10);
            }



            broj = r.Next(1, 3);
            if (broj == 1 && label11.Location.Y < 400)
            {
                label11.Location = new Point(label11.Location.X, label11.Location.Y + 10);
            }
            else
            {
                label11.Location = new Point(label11.Location.X, label11.Location.Y - 10);
            }


            broj = r.Next(1, 3);
            if (broj == 1 && label12.Location.Y < 400)
            {
                label12.Location = new Point(label12.Location.X, label12.Location.Y + 10);
            }
            else
            {
                label12.Location = new Point(label12.Location.X, label12.Location.Y - 10);
            }


            broj = r.Next(1, 3);
            if (broj == 1 && label13.Location.Y < 400)
            {
                label13.Location = new Point(label13.Location.X, label13.Location.Y + 10);
            }
            else
            {
                label13.Location = new Point(label13.Location.X, label13.Location.Y - 10);
            }


            broj = r.Next(1, 3);
            if (broj == 1 && label8.Location.Y < 400)
            {
                label8.Location = new Point(label8.Location.X, label8.Location.Y + 10);
            }
            else
            {
                label8.Location = new Point(label8.Location.X, label8.Location.Y - 10);
            }

            broj = r.Next(1, 3);
            if (broj == 1 && label5.Location.Y < 400)
            {
                label5.Location = new Point(label5.Location.X, label5.Location.Y + 10);
            }
            else
            {
                label5.Location = new Point(label5.Location.X, label5.Location.Y - 10);
            }

            broj = r.Next(1, 3);
            if (broj == 1 && label10.Location.Y < 400)
            {
                label10.Location = new Point(label10.Location.X, label10.Location.Y + 10);
            }
            else
            {
                label10.Location = new Point(label10.Location.X, label10.Location.Y - 10);
            }



            broj = r.Next(1, 3);
            if (broj == 1 && label7.Location.Y < 400)
            {
                label7.Location = new Point(label7.Location.X, label7.Location.Y + 10);
            }
            else
            {
                label7.Location = new Point(label7.Location.X, label7.Location.Y - 10);
            }

            broj = r.Next(1, 3);
            if (broj == 1 && label9.Location.Y < 400)
            {
                label9.Location = new Point(label9.Location.X, label9.Location.Y + 10);
            }
            else
            {
                label9.Location = new Point(label9.Location.X, label9.Location.Y - 10);
            }



         

            broj = r.Next(1, 3);
            if (broj == 1 && label4.Location.Y < 400)
            {
                label4.Location = new Point(label4.Location.X, label4.Location.Y + 10);
            }
            else
            {
                label4.Location = new Point(label4.Location.X, label4.Location.Y - 10);
            }





            //label1.Location = new Point(label1.Location.X + 5, label1.Location.Y + 5);


            if (_objPosition == objPosition.Stop)
            {
                _x = _x + 0;
                _y = _y + 0;
            }
            if (_objPosition == objPosition.Right && _x < 660)
            {
                _x += 5;
                lblCovek.Location = new Point(_x, _y);
            }
            if (_objPosition == objPosition.Left && _x > 0)
            {
                _x -= 5;
                lblCovek.Location = new Point(_x, _y);
            }

            if (_objPosition == objPosition.Up && _y > 0)
            {
                _y -= 5;
                lblCovek.Location = new Point(_x, _y);
            }

            if (_objPosition == objPosition.Down && _y < 330)
            {
                _y += 5;
                lblCovek.Location = new Point(_x, _y);
            }

            //odbivanje

            if (_x == 640)
            {
                _objPosition = objPosition.Left;

            }
            if (_x == 0)
            {
                _objPosition = objPosition.Right;
            }



            if (_y == 330)
            {
                _objPosition = objPosition.Up;

            }
            if (_y == 0)
            {
                _objPosition = objPosition.Down;
            }



            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            if ((Math.Abs(lblZolta.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(lblZolta.Location.Y - lblCovek.Location.Y) <= 50))
            {


                
                int dodajVreme= int.Parse(lblVremeBroj.Text);
                dodajVreme += 10;
                lblVremeBroj.Text = dodajVreme.ToString();
             
                if (lokacijaZolta % 2 == 0)
                {
                    lblZolta.Location = new Point(349, 37);
                    lokacijaZolta = 1;
                }
                else
                {
                    lblZolta.Location = new Point(349, 302);
                    lokacijaZolta = 0;
                }
                
            }

           



            //1

            if ((Math.Abs(label1.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label1.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;
                
                //Close();
                Close();
            }


            //2

            if ((Math.Abs(label2.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label2.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }


            //3


      


            //4

            if ((Math.Abs(label4.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label4.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }


            //5


            if ((Math.Abs(label5.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label5.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }


            //6


         


            //7


            if ((Math.Abs(label7.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label7.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }


            //8


            if ((Math.Abs(label8.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label8.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }


            //9


            if ((Math.Abs(label9.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label9.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }


            //10


            if ((Math.Abs(label10.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label10.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }



            //11

            if ((Math.Abs(label11.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label11.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }



            //12

            if ((Math.Abs(label12.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label12.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }


            //13


            if ((Math.Abs(label13.Location.X - lblCovek.Location.X) <= 50) && (Math.Abs(label13.Location.Y - lblCovek.Location.Y) <= 50))
            {
                timer1.Stop();
                tmrMoving.Stop();
                igr = new Igrach();
                MessageBox.Show("Печурката ве отру\n Вие освоивте: " + lblRezultatBroj.Text + " поени", "Жалам");
                igr.poeni = int.Parse(lblRezultatBroj.Text);
                igr.freeze = int.Parse(lblZastaniBroj.Text);
                DialogResult = DialogResult.OK;

                //Close();
                Close();
            }






           

           int t= int.Parse(lblVremeBroj.Text);
           t--;
           if (t == 0)
           {
               timer1.Stop();
               tmrMoving.Stop();

               igr = new Igrach();
               igr.poeni = int.Parse(lblRezultatBroj.Text);
               igr.freeze = int.Parse(lblZastaniBroj.Text);
              
           
          
               
              
               MessageBox.Show(" Времето истече, вашиот резултат е " + lblRezultatBroj.Text);
               DialogResult = DialogResult.OK;
               //Close();
               Close();
           }
           lblVremeBroj.Text = t.ToString();

            if ((_x >=620 &&  _x <= 670) && (_y >= 0 && _y <= 50) && tmp==0)
            {
                int p = 0;

                int.TryParse(lblPoeni.Text, out p);

                p++;
                lblPoeni.Text = p.ToString();
                p -= 1;
                lblRezultatBroj.Text = p.ToString();
                lblPoeni.Location = new Point(30, 320);
                tmp = 1;
            }

          
                if ((_x >= 0 && _x <= 50) && (_y >= 300 && _y <=350) && tmp==1)
                {
                    int p = 0;

                    int.TryParse(lblPoeni.Text, out p);

                    p++;
                    lblPoeni.Text = p.ToString();
                    p -= 1;
                    lblRezultatBroj.Text = p.ToString();
                    lblPoeni.Location = new Point(652, 28);
                    tmp = 0;
                }


                //Invalidate();
        }

        private void lblRezultat_Click(object sender, EventArgs e)
        {

        }

        private void lblCovek_Validating(object sender, CancelEventArgs e)
        {


           




        }

       

      
      








    }
}
