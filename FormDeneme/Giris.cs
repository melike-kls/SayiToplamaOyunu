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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        byte difficulity;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "" || txtAd.Text == string.Empty)
            {
                MessageBox.Show("Bütün Alanlar Doldurulmalıdır");
            }
            else
            {


                if (rdbKolay.Checked)
                {
                    difficulity = 1;
                }
                else if (rdbOrta.Checked)
                {
                    difficulity = 2;
                }
                else if (rdbZor.Checked)
                {
                    difficulity = 3;
                }
                else
                {
                    difficulity = 1;
                }



                Oyun frm1 = new Oyun(txtAd.Text, txtSoyad.Text, difficulity);

                frm1.Show();
            }
        }
    }
}
