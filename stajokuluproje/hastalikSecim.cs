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
        KALP_HASTALIĞI kalpGec = new KALP_HASTALIĞI();
        OBEZİTE obeziteGec = new OBEZİTE();
        SEKER_HASTALIGI sekerGec = new SEKER_HASTALIGI();
        

        public HASTALIK_SECİMİ()
        {
            InitializeComponent();
        }

        private void kalpGiris(object sender, EventArgs e)
        {

            kalpGec.Show();
            this.Hide();

        }

        private void sekerGiris(object sender, EventArgs e)
        {
            sekerGec.parent = this;
            sekerGec.Show();
            this.Hide();

        }

        private void obeziteGiris(object sender, EventArgs e)
        {
            obeziteGec.Show();
            this.Hide();
        }
       
       
    
    }
}
