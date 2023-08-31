using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // vt baglantisi için

namespace KirtasiyeProjesi
{
    public partial class FormGiris : Form
    {
        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
        public FormGiris()
        {
            InitializeComponent();
        }
        int saat, dakika, saniye;
        public static String zaman;
        public static bool girisYapildi = false;

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;

        private void textBoxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {

            string sorgu = "SELECT * FROM GirisBilgileri where kullaniciAdi=@user AND sifre=@pass";
            // veritabanından kullanıcı adı ve şifreyi çeken sorguyu yazdık
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-U3DHGAV\\SQLEXPRESS; Initial Catalog=KirtasiyeDB;Integrated Security=True");
                con.Open();//veritabanı bağlantısı yaptık
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@user", textBoxKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@pass", textBoxSifre.Text);
                //veritabanından çekilen bilgilerle labeldakileri karşılaştırdık.
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
                    girisYapildi = true;
                    saat = 01;
                    dakika = 59;
                    saniye = 59;
                    timer1.Enabled = true;
                    timer1.Interval = 1000;//timerı saniyede 1 kontrol edecek şekilde ayarladık
                    timer1.Start();//timerı başlattık



                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                con.Close();
            }
            //şifre kullanıcı adı kontorolü yapan kodu yazdık başarılı ise giriş yapacak değilse tekrar soracak
            catch (Exception hata)
            {
                MessageBox.Show("HATA/n" + hata.ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dakika == 0 & saniye == 0) //dakika ve saniye 0 a eşit ise 
            {
                if (saat > 0)                // ve saat sıfırdan büyükse
                {
                    saat--;                 //saati bir azaltır
                    dakika = 59;            // saat azaldığı için saniye ve dakika 59 olur.
                    saniye = 59;
                }  
            }
            if (saniye == 0)
            {
                if (dakika > 0)
                {
                    dakika--;
                    saniye = 59;
                }
            }

            Form1 f = new Form1();
            foreach (Form _f in Application.OpenForms)   //Form1 elamanlarına ulaşılmasını sağlar
            {
                if (_f.Name == "Form1")
                    f = (Form1)_f;     
            }
            f.labelZaman.Text = String.Format("{0:00}:{1:00}:{2:00}", saat, dakika, saniye);

            if (saat == 0 & dakika == 0 & saniye == 0) // geri sayım sıfırlandığında aşağıdaki işlemleri yapar
            {
                timer1.Stop();
                MessageBox.Show("Giriş Süreniz Doldu! \nTekrar Giriş Yapın.");
                f.labelGirisYap_Click( sender, e); //giriş yap sayfasına yönlendirir
                
                girisYapildi = false;


            }
            saniye--;//her timer ticklemesinde saniyeyi bir azaltır
            
           
        }
    }
}

