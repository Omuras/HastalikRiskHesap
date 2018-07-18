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

       
      

        private void Kaydet_button(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(adtext.Text) || !string.IsNullOrEmpty(adtext.Text) || !string.IsNullOrEmpty(numberText.Text))
            {
                                                        //Database eklenilecek
                goNext();
            }

            
        }

        /*private void funct(object sender , EventArgs e)
        {
            MessageBox.Show("EMINE");


        }*/
        private void goNext()
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
