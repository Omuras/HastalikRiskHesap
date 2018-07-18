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

    
    public partial class SEKER_HASTALIGI : Form
    {

        public HASTALIK_SECİMİ parent;

        public SEKER_HASTALIGI()
        {

            InitializeComponent();
            
        }

        private void hesapla(object sender, EventArgs e)
        {
            
        }
        private void geriDon(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();
        }

 
    }
}

