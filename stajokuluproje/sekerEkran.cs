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
        private Boolean AiledeSekerDurumu;
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
                AiledeSekerDurumu = true;
            else if (radioButton4.Checked)
                AiledeSekerDurumu = false;


            if(aclikKanSekeri <= 90)
            {
                MessageBox.Show(text: "Sekeriniz yoktur!", caption: " Uyarı !",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }else if (aclikKanSekeri <= 126)
            {
                MessageBox.Show(text: "Gizli Sekeriniz vardir!", caption: " Uyarı !",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }else if (aclikKanSekeri > 126)
            {
                MessageBox.Show(text: "Seker hastaliginiz vardir!", caption: " Uyarı !",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(text: "Gecerli bir aclik kan degeri giriniz!", caption: " Uyarı !",
                                     buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

            if (toklukKanSekeri <= 100)
            {
                MessageBox.Show(text: "Diyabet hastaliginiz yoktur!", caption: " Uyarı !",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            else if (toklukKanSekeri > 100)
            {
                MessageBox.Show(text: "Diyabet hastaliginiz vardir!", caption: " Uyarı !",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(text: "Gecerli bir tokluk kan degeri giriniz!", caption: " Uyarı !",
                                     buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

            VeritabaninaEkle();
        }

        private void linkOpen(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.hastanerandevu.gov.tr/Randevu/login.xhtml;jsessionid=v6yke6zIFGwNkJ00UzZWZaV5");

        }
        private void VeritabaninaEkle()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Omura\\source\\repos\\stajokuluproje\\stajokuluproje\\StajOkuluDatabase.mdb"); //Veritabanı çekiliyor
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
              //  MessageBox.Show("Bilgileriniz kaydedildi!");
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

