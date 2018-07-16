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
        private double endeks;
        private double kiloDeger;
        private double boyDeger;
        private double idealKilo;
        public HASTALIK_SECİMİ parent;
        private Boolean notNull = false;
        private Boolean cinsiyet = false;          //false ise kadin True ise erkek
      
        public OBEZİTE()
        {
            InitializeComponent();
        }


        private void hesapla(object sender, EventArgs e)        //Hesapla butonuna basilinca yapilacak islem
        {
            if (radioButton2.Checked)
            {
                cinsiyet = true;
            }

            if (!string.IsNullOrEmpty(boytext.Text) || !string.IsNullOrEmpty(boytext.Text) || (!radioButton1.Checked && !radioButton2.Checked))     //Alanlaril dolu olup olmadigini sorguluyoruz
            {
                boyDeger = int.Parse(boytext.Text);
                kiloDeger = int.Parse(kilotext.Text);           //Eger alanlar bos değilse girilen degerleri değiskenlere atıyoruz


                notNull = true;
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanlari doldurunuz! ");              //Eger alanlar bos ise hata yazdirip isleme devam etmiyoruz
                notNull = false;

            }

            if (notNull == true) {                  //Eger alanlar doluysa islemleri yapıyoruz  (notNull kendi olusturdugum bir degisken sadece bos dolu sorgusu icin)
                boyDeger = boyDeger / 100;
                endeks = kiloDeger / Math.Pow(boyDeger, 2);     //Cinsiyeti kullanmamamın sebebi ideal kilo hesabı eklemedigimiz için fakat veritabanına atmak için kullanılabilir

                if (cinsiyet)               //ideal kilo hesabı 
                {
                    idealKilo = 50 + 2.3 * ((boyDeger - 152.4) / 2.54);                                 //Erkekse                        //50 + (2,3 ) * ((Boyunuz - 152,4) / 2,54)
                }
                else
                {
                    idealKilo = 45.5 + 2.3 * ((boyDeger - 152.4) / 2.54);           //kadınsa
                }



                ekranaYaz(endeks,idealKilo);                      //İslemler yapıldıktan sonra ekrana yazdirmasi için ayrı fonksiyona gönderiyorum

                boyDeger = 0;
                kiloDeger = 0;
            }

        }

        private void ekranaYaz(double sonuc,double idealKilo)                //Ekrana yazdirma fonksiyonu
        {

            if (sonuc < 18.5)
                MessageBox.Show("Kütle endeksiniz : " + sonuc + "   Düşük kilolusunuz! İdeal kilonuz = " + idealKilo);
            else if (sonuc < 25)
                MessageBox.Show("Kütle endeksiniz : " + sonuc + "   Kilonuz normal! İdeal kilonuz = " + idealKilo);
            else if (sonuc < 30)
                MessageBox.Show("Kütle endeksiniz : " + sonuc + "   Fazla kilolusunuz! İdeal kilonuz = " + idealKilo);
            else
                MessageBox.Show("Kütle endeksiniz : " + sonuc + "   Obezite sınıfına giriyorsunuz! İdeal kilonuz = " + idealKilo);
            kilotext.ResetText();               //textboxların içerigini sıfırlıyor yani boşaltıyor
            boytext.ResetText();
        }

        private void geriDon(object sender, EventArgs e)                    //Geri dön fonksiyonu
        {
            parent.Show();
            this.Hide();
        }


    }
    }
