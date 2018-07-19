using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace stajokuluproje 
{

    
    public partial class SEKER_HASTALIGI : Form
    {

        public HASTALIK_SECİMİ parent;
        private int kullaniciNo = 0;
        private double aclikKanSekeri = 0;
        private double toklukKanSekeri = 0;
        private String AiledeSekerDurumu;
        public SEKER_HASTALIGI(int kullaniciNo)
        {
            this.kullaniciNo = kullaniciNo;
            InitializeComponent();
            
        }

        private void hesapla(object sender, EventArgs e)
        {
            aclikKanSekeri = double.Parse(aclık_skr.Text);
            toklukKanSekeri = double.Parse(tok_skr.Text);
            if (radioButton3.Checked)
                AiledeSekerDurumu = "EVET";
            else if (radioButton4.Checked)
                AiledeSekerDurumu = "HAYIR";
            VeritabaninaEkle();
        }
        private void VeritabaninaEkle()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Merve\\Desktop\\stajokuluproje\\stajokuluproje\\StajOkuluDatabase.mdb"); //Veritabanı çekiliyor
            conn.Open(); //veriytabanı bağlantısı açıldı
            String Sorgu = "INSERT INTO " +
                "SekerHastaligi(KullaniciNo,AclikKanSekeri,ToklukKanSekeri,AiledeVarmi,Tarih)" +
                "VALUES('" + kullaniciNo + "','" + aclikKanSekeri + "','" + toklukKanSekeri + "','" + AiledeSekerDurumu + "','" 
                + DateTime.Now.ToLongDateString() + "')";//Veritabanına ekleme yapılıyor
            try
            {
                //Hata yok ise sorgu çalıştırılacak komutu
                OleDbCommand cmd = new OleDbCommand(Sorgu, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bilgileriniz kaydedildi!");
            }
            catch (Exception ex)
            {
                //kayıt eklenemediğinde verilen hata
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        private void geriDon(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();
        }

 
    }
}

