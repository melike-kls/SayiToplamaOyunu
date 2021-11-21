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
   
    public partial class FormToplama : Form
    { 
        Random rnd = new Random();
        public FormToplama()
        {
            InitializeComponent();
            button1.Text = rnd.Next(100).ToString();
            button2.Text = rnd.Next(100).ToString();
            button3.Text = rnd.Next(100).ToString();
            button1.Click += NumberClick;
            button2.Click += NumberClick;
            button3.Click += NumberClick;
        }


        static int toplam = 0;
         void NumberClick(object sender, EventArgs e)
         {
            Button btn = (Button)sender;
            btn.Enabled = false;
            toplam += int.Parse(btn.Text);
         }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"toplamları:{toplam}");
        }
    }
}
