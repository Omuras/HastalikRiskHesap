using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajokuluproje
{
    public partial class girisEkran : Form
    {

        private String ad = null;
        private String soyad = null;
        HASTALIK_SECİMİ nextPage = new HASTALIK_SECİMİ();


        public girisEkran()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void soyadChanged(object sender, EventArgs e)
        {
           // this.soyad = (String)sender;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Kaydet_button(object sender, EventArgs e)
        {
           nextPage.Show();
            this.Hide();


        }

        private void adChanged(object sender, EventArgs e)
        {
            //this.ad = (String) sender;
        }
    }
}
