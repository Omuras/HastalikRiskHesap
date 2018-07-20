using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        private String cinsiyet;
        private int kiloSorunu;
        private int AiledeKalpHastaligi;
        private int TansiyonSorunu;
        private int SekerSorunu;
        private int StresliOrtam;
        private int duzenliSpor;
        private int sigaraKullanimi;

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
            if((btnKadin.Checked || btnErkek.Checked) && (btnKalpE.Checked || btnKalpH.Checked) &&
                (btnKiloE.Checked || btnKiloH.Checked) && (btnSekerE.Checked || btnSekerH.Checked) &&
                (btnSigaraH.Checked || btnSigaraE.Checked) && (btnSporE.Checked || btnSporH.Checked) &&
                (btnStresH.Checked || btnStresE.Checked) && (btnTansiyonE.Checked || btnTansiyonH.Checked) &&
                (btnYas0.Checked || btnYas1.Checked || btnYas2.Checked))
            {
                hesap();                //if sorgusu
                degerleriAl();
                VeritabaninaEkle();
            }
            else{
                MessageBox.Show(text: "Lütfen bütün soruları yanitlayin !", caption: "Uyarı !", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }


            
        }

        private void geriDon(object sender, EventArgs e)    //Geri dön fonksiyonu
        {
            parent.Show();
            this.Hide();
        }

        private void hesap() {
            if (btnKalpE.Checked || btnSekerE.Checked || btnTansiyonE.Checked)
                badModifier++;

            if (badModifier == 1)
            {
                // MessageBox.Show("Kalp hastaligi riskiniz vardir!",icon : MessageBoxIcon.Warning);
                MessageBox.Show(text: "Kalp hastaligi riskiniz vardir!", caption: "Dikkat !", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show(text: "Hastalik riskinzi yoktur!", caption: "Dikkat !", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            badModifier = 0;

        }

        private void degerleriAl()
        {
            if (btnKadin.Checked) //cinsiyet
                cinsiyet = "Kadin".ToString();
            else if (btnErkek.Checked)
                cinsiyet = "Erkek".ToString();

            if (btnKiloE.Checked)//kilo sorunu
                kiloSorunu = 1;
            else if (btnKiloH.Checked)
                kiloSorunu = 0;

            if (btnKalpE.Checked) //Ailenizde Kalp Hastalýðý var mý
                AiledeKalpHastaligi = 1;
            else if (btnKalpH.Checked)
                AiledeKalpHastaligi = 0;

            if (btnTansiyonE.Checked)//Tabsiyon hastalýðýnýz var mý
                TansiyonSorunu = 1;
            else if (btnTansiyonH.Checked)
                TansiyonSorunu = 0;

            if (btnSekerE.Checked) //Seker Hastalýðý var mý
                SekerSorunu = 1;
            else if (btnSekerH.Checked)
                SekerSorunu = 0;

            if (btnStresE.Checked) //stresli ortamda bulunuyor musunuz
                StresliOrtam = 1;
            else if (btnStresH.Checked)
                StresliOrtam = 0;

            if (btnSporE.Checked) //duzenli spor yaýyor musunuz
                duzenliSpor = 1;
            else if (btnSporH.Checked)
                duzenliSpor = 0;

            if (btnSigaraE.Checked)//sigara kullanýmý
                sigaraKullanimi = 1;
            else if (btnSigaraH.Checked)
                sigaraKullanimi = 0;

        }
        private void linkOpen(object sender,EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.hastanerandevu.gov.tr/Randevu/login.xhtml;jsessionid=v6yke6zIFGwNkJ00UzZWZaV5");

        }


        private void VeritabaninaEkle()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Omura\\source\\repos\\stajokuluproje\\stajokuluproje\\StajOkuluDatabase.mdb"); //Veritabaný çekiliyor
            conn.Open(); //veriytabaný baðlantýsý açýldý
            String Sorgu = "INSERT INTO " +
                "KalpHastaligi(KullaniciNo,Cinsiyet,Kilo,AiledeKalpHastaligi,Tansiyon,Seker,StresliOrtam,SporDurumu,SigaraKullanimi,Tarih)" +
                "VALUES('" + kullaniciNo + "','" + cinsiyet + "','" + kiloSorunu + "','" + AiledeKalpHastaligi + "','" + TansiyonSorunu + "','" + SekerSorunu + "','" + StresliOrtam + "','" + duzenliSpor + "','" + sigaraKullanimi + "','"
                + DateTime.Now.ToLongDateString() + "')";//Veritabanýna ekleme yapýlýyor
            try
            {
                //Hata yok ise sorgu çalýþtýrýlacak komutu
                OleDbCommand cmd = new OleDbCommand(Sorgu, conn);
                cmd.ExecuteNonQuery();
              //  MessageBox.Show("Bilgileriniz kaydedildi!");
            }
            catch (Exception ex)
            {
                //kayýt eklenemediðinde verilen hata
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

    }
}
