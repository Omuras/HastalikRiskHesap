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
    public partial class KALP_HASTALIĞI : Form
    {
        public HASTALIK_SECİMİ parent;
        private int badModifier=0 ;
        private int kullaniciNo = 0;

        public KALP_HASTALIĞI(int kullaniciNo)
        {
            this.kullaniciNo = kullaniciNo;
            InitializeComponent();
        }

        private void KALP_HASTALIĞI_Load(object sender, EventArgs e)
        {

        }
        private void hesaplaFunc(object sender, EventArgs e)                //Gerekli ayarlar yapıldı sorgu yazılması lazım
        {
            hesap();
            if (badModifier > 3)
            {
                MessageBox.Show("Kalp hastaligi riskiniz vardir!");
            }
            else
            {

                MessageBox.Show("Kalp hastaligi riskiniz bulunmamaktadir!");
            }
        }

        private void geriDon(object sender, EventArgs e)    //Geri dön fonksiyonu
        {
            parent.Show();
            this.Hide();
        }

        private void hesap() {
            if (btnKiloE.Checked)               //Kilo sorunu
                badModifier++;
            else
                badModifier--;

            if (btnKalpE.Checked)               //Kalp hastaligi
                badModifier++;
            else
                badModifier--;

            if (btnSekerE.Checked)              //Seker hastaligi
                badModifier++;
            else
                badModifier--;

            if (btnSigaraE.Checked)             //sigara sorunu
                badModifier++;
            else
                badModifier--;

            if (btnSporH.Checked)           //Spor hayır
                badModifier++;
            else
                badModifier--;

            if (btnTansiyonE.Checked)
                badModifier++;
            else
                badModifier--;

            if (btnStresE.Checked)
                badModifier++;
            else
                badModifier--;




        }

        private void btnKadin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grKalpHst_Enter(object sender, EventArgs e)
        {

        }
    }
}
