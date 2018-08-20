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
    public partial class girisEkran : Form
    {

        private String ad = null;
        private String soyad = null;
        private int kullaniciNo = 0;


        public girisEkran()
        {
            InitializeComponent();
        }

       
      

        private void Kaydet_button(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(adtext.Text) || !string.IsNullOrEmpty(adtext.Text) || !string.IsNullOrEmpty(numberText.Text))
            {
                ad = adtext.Text;
                soyad = soyadtext.Text;
                kullaniciNo = int.Parse(numberText.Text); //Değişkene textboxtaki veriler kaydedildi
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Omura\\source\\repos\\stajokuluproje\\stajokuluproje\\StajOkuluDatabase.mdb"); //Veritabanı çekiliyor
                conn.Open(); //veriytabanı bağlantısı açıldı
                String Sorgu = "INSERT INTO Kullanici(KullaniciNo,Ad,Soyad)VALUES('" + kullaniciNo + "','" + ad + "','" + soyad + "')"; //Veritabanına ekleme yapılıyor
                try
                {
                    //Hata yok ise sorgu çalıştırılacak komutu
                    OleDbCommand cmd = new OleDbCommand(Sorgu, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(text: "Giriş başarılı!", caption: "Durum!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Asterisk);

                    HASTALIK_SECİMİ nextPage = new HASTALIK_SECİMİ(kullaniciNo);
                    nextPage.Show();
                    this.Hide();//Giriş başarılı ise diğer sayfaya girebilsin
                }
                catch (Exception ex)
                {
                    //kayıt eklenemediğinde verilen hata
                    MessageBox.Show(text: "Giriş Başarısız!", caption: "Durum!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);

                }
                conn.Close();
            }
        }

        /*private void funct(object sender , EventArgs e)
        {
            MessageBox.Show("EMINE");


        }*/
        /*private void goNext()
        {
            nextPage.Show();
            this.Hide();
        }*/
        private void adChanged(object sender, EventArgs e)
        {
            //this.ad = (String) sender;
        }
    }
}
