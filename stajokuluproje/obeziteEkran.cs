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
            else if(radioButton1.Checked)
            {
                cinsiyetDeger = "Kadın";
            }
            if (!string.IsNullOrEmpty(boytext.Text) || !string.IsNullOrEmpty(boytext.Text) || (!radioButton1.Checked && !radioButton2.Checked))     //Alanlaril dolu olup olmadigini sorguluyoruz
            {
                boyDeger = int.Parse(boytext.Text);
                kiloDeger = int.Parse(kilotext.Text);           //Eger alanlar bos değilse girilen degerleri değiskenlere atıyoruz

                if (boyDeger < 140)
                {
                    MessageBox.Show("Lütfen geçerli bir boy bilgisi giriniz");      // Boy degerinin geçerliliği kontrol ediliyor
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
                MessageBox.Show("Lütfen bütün alanlari doldurunuz! ");              //Eger alanlar bos ise hata yazdirip isleme devam etmiyoruz
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

        private void ekranaYaz(double sonuc,double idealKilo)                //Ekrana yazdirma fonksiyonu
        {
            int ik = (int) idealKilo;
            if (sonuc < 18.5) {
                MessageBox.Show("Kütle endeksiniz : " + sonuc.ToString("0.##") + " Belki Ölü olabilirsiniz! İdeal kilonuz = " + ik.ToString("0.##"));
               
            }
            else if (sonuc < 25)
                MessageBox.Show("Kütle endeksiniz : " + sonuc.ToString("0.##") + " Sende fakirsin dimi la! İdeal kilonuz = " + ik.ToString("0.##"));
            else if (sonuc < 30)
                MessageBox.Show("Kütle endeksiniz : " + sonuc.ToString("0.##") + " Şişkoya bak! İdeal kilonuz = " + ik.ToString("0.##"));
            else
                MessageBox.Show("Kütle endeksiniz : " + sonuc.ToString("0.##") + " Yeter artık yeter yeme ! İdeal kilonuz = " + ik.ToString("0.##"));
            kilotext.ResetText();               //textboxların içerigini sıfırlıyor yani boşaltıyor
            boytext.ResetText();
        }
        private void VeritabaninaEkle(double boy, double kilo, String cinsiyet)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Merve\\Desktop\\stajokuluproje\\stajokuluproje\\StajOkuluDatabase.mdb"); //Veritabanı çekiliyor
            conn.Open(); //veriytabanı bağlantısı açıldı
            String Sorgu = "INSERT INTO ObeziteTablosu(KullaniciNo,Boy,Kilo,Cinsiyet,Tarih)VALUES('" + kullaniciNo + "','" + int.Parse(boy.ToString()) + "','" + int.Parse(kilo.ToString()) + "','" + cinsiyet + "','" + DateTime.Now.ToLongDateString() +"')"; //Veritabanına ekleme yapılıyor
            try
            {
                //Hata yok ise sorgu çalıştırılacak komutu
                OleDbCommand cmd = new OleDbCommand(Sorgu, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bilgileeiniz kaydedildi!");
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
