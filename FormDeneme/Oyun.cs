using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDeneme
{
    public partial class Oyun : Form
    {
        int speed;
        static int toplam = 0;
        static int sure = 3;
        Random rnd = new Random();
        public Oyun(string ad, string soyad, byte difficulty)
        {
            InitializeComponent();
            switch (difficulty)
            {
                case 1://Easy
                    sure = 15;
                    speed = 1000;
                    break;

                case 2://Normal
                    sure = 10;
                    speed = 750;
                    break;

                case 3://Hard
                    sure = 10;
                    speed = 500;
                    break;
            }
            lblad.Text = ad;
            lblsoyad.Text = soyad;
        } 
        
        
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width -panel1.Width -btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(100).ToString();
            btn.Click += Btn_Click;

            this.Controls.Add(btn);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblskor.Text = $"{toplam}";
            btn.Dispose();

        }
        private void TimerRastgeleSayi_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

            timer2.Interval = speed;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (sure==0)
            {
                timer1.Stop();
                timer2.Stop();
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        item.Enabled = false;
                    }
                }
                DialogResult cvp= MessageBox.Show($"Oyun Bitti. Skorunuz:{toplam} \nYeniden Başlamak İstiyorr Musunuz?"
                , "Yeniden Başlatma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cvp==DialogResult.Yes)
                {
                    Application.Restart();
                }  else
            {
                Application.Exit();
            }
            }
          
        }
      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void lblad_Click(object sender, EventArgs e)
        {

        }

        private void lblsure_Click(object sender, EventArgs e)
        {

        }
    }
}
