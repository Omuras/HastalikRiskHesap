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
    public partial class HASTALIK_SECİMİ : Form
    {
        KALP_HASTALIĞI kalpGec;
        OBEZİTE obeziteGec;
        SEKER_HASTALIGI sekerGec;
        private int kullaniciNo = 0;
        public HASTALIK_SECİMİ(int kullaniciNo) 
        {
            this.kullaniciNo = kullaniciNo;
            InitializeComponent();
        }

        private void kalpGiris(object sender, EventArgs e)
        {
            kalpGec = new KALP_HASTALIĞI(kullaniciNo);
            kalpGec.parent = this;
            kalpGec.Show();
            this.Hide();

        }

        private void sekerGiris(object sender, EventArgs e)
        {
            sekerGec = new SEKER_HASTALIGI(kullaniciNo);
            sekerGec.parent = this;
            sekerGec.Show();
            this.Hide();

        }

        private void obeziteGiris(object sender, EventArgs e)
        {
            obeziteGec = new OBEZİTE(kullaniciNo);
            obeziteGec.parent = this;
            obeziteGec.Show();
            this.Hide();
        }

        private void HASTALIK_SECİMİ_Load(object sender, EventArgs e)
        {
           
        }
    }
}
