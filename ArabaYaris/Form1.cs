using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace ArabaYaris
{
    public partial class Form1 : Form
    {

        List<Label> Seritler = new List<Label>();
        int k;
        double hizGosterge;
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            for (int i = 0; i < 16; i++)
            {
                Seritler.Add(new Label()
                {
                    AutoSize = false,
                    BackColor = Color.White,
                    Width = 30,
                    Height = 100,
                    Location = new Point((((i / 8) + 1) * (this.Width / 3)) - 25, k),
                });

                k += 127;
                this.Controls.Add(Seritler[i]);
                if (i == 7)
                {
                    k = 0;
                }
                AracOlustur(new Random().Next(0, 3));
                timer1.Start();
                maincar.BackgroundImageLayout = ImageLayout.Stretch;
                maincar.Image = Resource1.maincar;

                // Cursor.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rect2 = arabalar[m].Bounds;
            rect1 = maincar.Bounds;
            foreach (Label item in Seritler)
            {
                item.Location = new Point(item.Location.X, item.Location.Y + 15);

                if (item.Location.Y >= this.Height)
                {
                    item.Location = new Point(item.Location.X, -127);
                }
            }
            hizGosterge += 0.68;

            if (Math.Round(hizGosterge, 0) % 9 == 0)
            {
                timer1.Interval -= 1;
            }
            hizDeger.Text = hizGosterge.ToString("0.00");
            
            k++;

            if (k % 40 == 0)
            {
                k = new Random().Next(0, 3);
                AracOlustur(k);
            }

            arabalar[m].Location = new Point(arabalar[m].Location.X, arabalar[m].Location.Y + 20);

            if (rect1.IntersectsWith(rect2) == true)
            {
                timer1.Stop();
                MessageBox.Show("Maalesef kaybettiniz");
                
            }
            
        }

        int a = 0; // arabanýn harita dýþýna çýkmasýný engellemek için oluþturulan bir deðiþken 

        // sadece sað ve sola gitme þeklindede yapýlabilirdi o zaman çok basic olurdu a = -1 iken þu olsun falan filan
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.A && maincar.Left > 10)
            //{
            //    maincar.Location = new Point(maincar.Location.X - 10, maincar.Location.Y);

            //}
            //else if (e.KeyCode == Keys.D && maincar.Right < this.Width - 10)
            //{
            //    maincar.Location = new Point(maincar.Location.X + 10, maincar.Location.Y);

            //}
            //else if (e.KeyCode == Keys.W && maincar.Top > 5)
            //{
            //    maincar.Location = new Point(maincar.Location.X, maincar.Location.Y - 10);
            //}
            //else if (e.KeyCode == Keys.S && maincar.Bottom < this.Height -85)
            //{
            //    maincar.Location = new Point(maincar.Location.X, maincar.Location.Y + 10);
            //}

            if (e.KeyCode == Keys.A && a != -1)
            {
                maincar.Location = new Point(maincar.Location.X - 300, maincar.Location.Y);
                a--;
            }else if (e.KeyCode == Keys.D && a != 1)
            {
                maincar.Location = new Point(maincar.Location.X + 300, maincar.Location.Y);
                a++;
            }

        }
        List<PictureBox> arabalar = new List<PictureBox>();

        // aracýn geleceði yerler 0 1 ve 2 rakamlarý ile iþaretleniyor
        Rectangle rect1;
        Rectangle rect2;
        public int m;
        public void AracOlustur(int sayi)
        {
            arabalar.Add(new PictureBox()
            {
                Width = 140,
                Height = 200,
                BackgroundImage = Resource1.car3_kopya,
                BackgroundImageLayout = ImageLayout.Stretch,

            });


            if (sayi == 0)
            {
                arabalar[m].Location = new Point(100, -150);
            }else if (sayi == 1)
            {
                arabalar[m].Location = new Point(400, -150);
            }else if (sayi == 2)
            {
                arabalar[m].Location = new Point(700, -150);
            }
            
            this.Controls.Add(arabalar[m]);
            
        }


        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{

        //    maincar.Location = e.Location;
        //}
    }
}
