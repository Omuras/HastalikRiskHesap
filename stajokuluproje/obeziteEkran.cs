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
    public partial class OBEZİTE : Form
    {
        private double endeks;
        private double kiloDeger;
        private double boyDeger;
        private double idealKilo;
        public HASTALIK_SECİMİ parent;
        private Boolean notNull = false;
        private Boolean cinsiyet = false;          //false ise kadin True ise erkek
        private int kullaniciNo;
        private String cinsiyetDeger;
      
        public OBEZİTE(int kullaniciNo)
        {
            this.kullaniciNo = kullaniciNo;
            InitializeComponent();
        }


        private void hesapla(object sender, EventArgs e)        //Hesapla butonuna basilinca yapilacak islem
        {
            if (radioButton2.Checked)
            {
                cinsiyet = true;
                cinsiyetDeger = "Erkek";
            }
            else if(radiolinkButton.Checked)
            {
                cinsiyetDeger = "Kadın";
            }
            if (!string.IsNullOrEmpty(boytext.Text) || !string.IsNullOrEmpty(boytext.Text) || (!radiolinkButton.Checked && !radioButton2.Checked))     //Alanlaril dolu olup olmadigini sorguluyoruz
            {
                boyDeger = int.Parse(boytext.Text);
                kiloDeger = int.Parse(kilotext.Text);           //Eger alanlar bos değilse girilen degerleri değiskenlere atıyoruz

                if (boyDeger < 140)
                {
                    MessageBox.Show(text: "Lütfen geçerli bir boy değeri giriniz!", caption: "Uyarı !", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);      // Boy degerinin geçerliliği kontrol ediliyor
                    notNull = false;
                    boytext.ResetText();
                }
                else
                {

                    notNull = true;
                }

            }
            else
            {
                MessageBox.Show(text: "Lütfen bütün alanlari doldurunuz!", caption: "Uyarı !", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);             //Eger alanlar bos ise hata yazdirip isleme devam etmiyoruz
                notNull = false;

            }
            VeritabaninaEkle(boyDeger, kiloDeger, cinsiyetDeger); //Verileri veritabanına eklemesi için VeritabanınaEkle fonksiyonuna gönderiliyor

            if (notNull == true) {                  //Eger alanlar doluysa islemleri yapıyoruz  (notNull kendi olusturdugum bir degisken sadece bos dolu sorgusu icin)
                boyDeger = boyDeger / 100;
                endeks = kiloDeger / Math.Pow(boyDeger, 2);     //Cinsiyeti kullanmamamın sebebi ideal kilo hesabı eklemedigimiz için fakat veritabanına atmak için kullanılabilir

                if (cinsiyet)               //ideal kilo hesabı 
                {
                    idealKilo = 50 + 2.3 * ((boyDeger*100 - 152.4) / 2.54);                                 //Erkekse                        //50 + (2,3 ) * ((Boyunuz - 152,4) / 2,54)
                }
                else
                {
                    idealKilo = 45.5 + 2.3 * ((boyDeger*100 - 152.4) / 2.54);           //kadınsa
                }



                ekranaYaz(endeks,idealKilo);                      //İslemler yapıldıktan sonra ekrana yazdirmasi için ayrı fonksiyona gönderiyorum

                boyDeger = 0;
                kiloDeger = 0;
            }

        }
        private void linkOpen(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.hastanerandevu.gov.tr/Randevu/login.xhtml;jsessionid=v6yke6zIFGwNkJ00UzZWZaV5");

        }
        private void ekranaYaz(double sonuc,double idealKilo)                //Ekrana yazdirma fonksiyonu
        {
            int ik = (int) idealKilo;
            if (sonuc < 18.5) {
                MessageBox.Show(text: "Kütle endeksiniz : " + sonuc.ToString("0.##") + " Kütle endeksiniz normalden düşük! İdeal kilonuz = " + ik.ToString("0.##"), caption: "Uyarı !", 
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
            else if (sonuc < 25)
            MessageBox.Show(text: "Kütle endeksiniz : " + sonuc.ToString("0.##") + " Kütle endeksiniz normal! İdeal kilonuz = " + ik.ToString("0.##"), caption: "Uyarı !",
                                   buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

            else if (sonuc < 30)
                MessageBox.Show(text: "Kütle endeksiniz : " + sonuc.ToString("0.##") + " Kütle endeksiniz normalden yüksek! İdeal kilonuz = " + ik.ToString("0.##"), caption: "Uyarı !",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            else
                MessageBox.Show(text: "Kütle endeksiniz : " + sonuc.ToString("0.##") + " Kütle endeksiniz normalden çok yüksek.Obezite sınıfına giriyorsunuz! İdeal kilonuz = " + ik.ToString("0.##"), caption: "Uyarı !",
                                   buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            kilotext.ResetText();               //textboxların içerigini sıfırlıyor yani boşaltıyor
            boytext.ResetText();
        }
        private void VeritabaninaEkle(double boy, double kilo, String cinsiyet)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Omura\\source\\repos\\stajokuluproje\\stajokuluproje\\StajOkuluDatabase.mdb"); //Veritabanı çekiliyor
            conn.Open(); //veriytabanı bağlantısı açıldı
            String Sorgu = "INSERT INTO ObeziteTablosu(KullaniciNo,Boy,Kilo,Cinsiyet,Tarih)VALUES('" + kullaniciNo + "','" + int.Parse(boy.ToString()) + "','" + int.Parse(kilo.ToString()) + "','" + cinsiyet + "','" + DateTime.Now.ToLongDateString() +"')"; //Veritabanına ekleme yapılıyor
            try
            {
                //Hata yok ise sorgu çalıştırılacak komutu
                OleDbCommand cmd = new OleDbCommand(Sorgu, conn);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Bilgileeiniz kaydedildi!");
            }
            catch (Exception ex)
            {
                //kayıt eklenemediğinde verilen hata
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }
        private void geriDon(object sender, EventArgs e)                    //Geri dön fonksiyonu
        {
            parent.Show();
            this.Hide();
        }


    }
    }
