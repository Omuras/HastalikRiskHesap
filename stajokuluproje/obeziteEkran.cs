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
    public partial class OBEZİTE : Form
    {
        private int kiloDeger;
        private int boyDeger;
        private Boolean bayan ;
        public HASTALIK_SECİMİ parent;
        // parent.Show();
        // this.Hide();
        public OBEZİTE()
        {
            InitializeComponent();
        }

        private void cinsiyetSecimi(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                bayan = true;

            }
            else if (radioButton2.Checked)
            {
                bayan = false;
            }

        }

        private void textGirdi1(object sender, EventArgs e)
        {
            boyDeger = int.Parse(boytext.Text);
        }
        private void textGirdi2(object sender, EventArgs e)
        {
            kiloDeger = int.Parse(kilotext.Text);

        }

        private void hesapla(object sender, EventArgs e)
        {

            MessageBox.Show(kiloDeger + " kilosunda ve bu boyda " + boyDeger);



        }
    }
        }
