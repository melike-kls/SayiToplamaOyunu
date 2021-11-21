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
    public partial class Form1 : Form
    {  
        
        Button btn = new Button();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
          
            btn.Size = new Size(100, 50);
            btn.Location = new Point(200, 30);
            btn.Text = "gazi";
            btn.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teest");
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
           
        }

        private void Deneme_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            MessageBox.Show($"{btn.Text}Clicklendi");
        }


    }
}
