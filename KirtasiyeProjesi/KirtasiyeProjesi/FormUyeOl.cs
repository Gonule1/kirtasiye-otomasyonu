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
    public partial class FormUyeOl : Form
    {
        public FormUyeOl()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void buttonKayıtOl_Click(object sender, EventArgs e)
        {
          

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-U3DHGAV\\SQLEXPRESS; Initial Catalog=KirtasiyeDB;Integrated Security=True");
                con.Open();//veritabanı bağlantısı yaptık
                string sorgu = "insert into GirisBilgileri(KullaniciAdi,Sifre)values(@kullaniciAdi,@sifre)";
                cmd = new SqlCommand(sorgu, con);

                
                cmd.Parameters.AddWithValue("@kullaniciAdi", textBoxKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", textBoxSifre.Text);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show("HATA/n" + hata.ToString());

            }
            MessageBox.Show("Kayıt Başarılı.\nGiriş yapabilirsiniz.");
            textBoxKullaniciAdi.Text = "";
            textBoxSifre.Text = "";

        }

        private void FormUyeOl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
