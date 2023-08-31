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
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void comboboxTemizle()
        {
            comboBoxKatagori.Items.Clear();
            comboBoxMarka.Items.Clear();
        }

        void gridDoldur()//veritabanından bilgileri çekerek datagrid e aktaracak fonksiyonu yazdık
        {
            comboboxTemizle();
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-U3DHGAV\\SQLEXPRESS; Initial Catalog=KirtasiyeDB;Integrated Security=True");
                con.Open();
                da = new SqlDataAdapter("select UrunID ,Ad,Katagori.KatagoriAd,Aciklamasi,Marka.MarkaAd,fiyat from Urun " +
                "inner join Katagori on Urun.KatagoriID = Katagori.KatagoriID " +
                "inner join Marka on Urun.MarkaID = Marka.MarkaID", con);
                ds = new DataSet();

                da.Fill(ds, "urun");
                dataGridView1.DataSource = ds.Tables["urun"];

                SqlCommand cmd2 = new SqlCommand("select katagoriAd from Katagori order by katagoriAd asc", con);
                cmd2.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBoxKatagori.Items.Add(dr["KatagoriAd"].ToString());
                }

                SqlCommand cmd3 = new SqlCommand("select MarkaAd from Marka order by MarkaAd asc", con);
                cmd3.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dt2);

                foreach (DataRow dr in dt2.Rows)
                {
                    comboBoxMarka.Items.Add(dr["MarkaAd"].ToString());
                }


                con.Close();

                GC.Collect();
                //Çöp Toplayıcısı
                GC.WaitForPendingFinalizers();
                //Çöp Yakıcısı
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA/n" + hata.ToString());
            }
        }

        void temizle() //textbox ve comboboxları temizledik
        {
            textBoxUrunId.Text = "";
            textBoxUrunAdi.Text = "";
            comboBoxKatagori.Text = "";
            richTextBox1.Text = "";
            comboBoxMarka.Text = "";
            textBoxFiyat.Text = "";

        }



        private void FormUrunler_Load(object sender, EventArgs e)
        {
            gridDoldur();//ürünler ekranı yüklendiğinde veritabanından bilgileri çekip gridlere yazacak fonksiyon çalışır


        }
        //MouseHover:mouse ile üzerine gidildiğinde yapılacak işlemler
        //MouseLeave :mouse üstünden ayırılnca gerçekleşecek işlemler
        //Biz mouse butonların üzerine gidip ayrılınca renk değiştirecek şekilde ayarladık
        private void labelGetir_MouseHover(object sender, EventArgs e)
        {

           
            labelGetir.BackColor = Color.DarkCyan;
        }

        private void labelGetir_MouseLeave(object sender, EventArgs e)
        {

            
            labelGetir.BackColor = Color.CadetBlue;
        }

        private void labelEkle_MouseHover(object sender, EventArgs e)
        {
            labelEkle.BackColor = Color.DarkCyan;
        }

        private void labelEkle_MouseLeave(object sender, EventArgs e)
        {
            labelEkle.BackColor = Color.CadetBlue;
        }

        private void labelGuncelle_MouseHover(object sender, EventArgs e)
        {
            labelGuncelle.BackColor = Color.DarkCyan;
        }

        private void labelGuncelle_MouseLeave(object sender, EventArgs e)
        {
            labelGuncelle.BackColor = Color.CadetBlue;
        }

        private void labelTemizle_MouseHover(object sender, EventArgs e)
        {
            labelTemizle.BackColor = Color.Orchid;
        }
        private void labelTemizle_MouseLeave(object sender, EventArgs e)
        {
            labelTemizle.BackColor = Color.RosyBrown;
        }
        private void labelSil_MouseHover(object sender, EventArgs e)
        {
            labelSil.BackColor = Color.Maroon;
        }

        private void labelSil_MouseLeave(object sender, EventArgs e)
        {
            labelSil.BackColor = Color.Firebrick;

        }

        private void labelGetir_Click(object sender, EventArgs e)
        {
            string id = textBoxUrunId.Text;
            int intID = Convert.ToInt32(id);



            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (intID == Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))
                {
                    textBoxUrunAdi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    comboBoxKatagori.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    richTextBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    comboBoxMarka.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    textBoxFiyat.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                }
            }

        }

        private void labelTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void labelEkle_Click(object sender, EventArgs e)//veritabanına yeni kayıt eklemek için yazılan fonksiyon
        {
            try
            {
                string sorgu = "insert into Urun(urunId,ad,KatagoriID,Aciklamasi,MarkaID,Fiyat)values(@id,@ad,@katagoriID,@aciklamasi,@markaID,@fiyat)";
                cmd = new SqlCommand(sorgu, con);

                cmd.Parameters.AddWithValue("@id",textBoxUrunId.Text);
                cmd.Parameters.AddWithValue("@ad", textBoxUrunAdi.Text);

               
                 if (comboBoxKatagori.SelectedItem.ToString().Equals("Kalem"))
                {
                    cmd.Parameters.AddWithValue("@katagoriID", 1);
                }
                else if (comboBoxKatagori.SelectedItem.ToString().Equals("Silgi"))
                {
                    cmd.Parameters.AddWithValue("@katagoriID", 2);

                }
                cmd.Parameters.AddWithValue("@aciklamasi", richTextBox1.Text);

                if (comboBoxMarka.SelectedItem == null)
                {
                    cmd.Parameters.AddWithValue("@markaID", 1);
                }
                else if (comboBoxMarka.SelectedItem.ToString().Equals("Belirsiz"))
                {
                    cmd.Parameters.AddWithValue("@markaID", 1);

                }
                else if (comboBoxMarka.SelectedItem.ToString().Equals("Pritt"))
                {
                    cmd.Parameters.AddWithValue("@markaID", 2);

                }
                else if (comboBoxMarka.SelectedItem.ToString().Equals("Rotring"))
                {
                    cmd.Parameters.AddWithValue("@markaID", 3);

                }

                cmd.Parameters.AddWithValue("@fiyat", textBoxFiyat.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                gridDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Eklenemedi.\nHata: " + ex.Message);
            }
        }

        private void labelGuncelle_Click(object sender, EventArgs e)//veritabanında seçilen kaydı güncellemek için fonksiyon
        {
            string sorgu = "update urun set ad='" + textBoxUrunAdi.Text +"',aciklamasi='"+richTextBox1.Text+"',fiyat='"+textBoxFiyat.Text+"' where urunID="+textBoxUrunId.Text+"";
            string sorguK1 = "update urun set katagoriID='1'where UrunID="+textBoxUrunId.Text+"";
            string sorguK2 = "update urun set katagoriID='2'where UrunID=" + textBoxUrunId.Text + "";
            string sorguM1 = "update urun set markaID='1'where UrunID=" + textBoxUrunId.Text + "";
            string sorguM2 = "update urun set markaID='2'where UrunID=" + textBoxUrunId.Text + "";
            string sorguM3 = "update urun set markaID='3'where UrunID=" + textBoxUrunId.Text + "";
            try
            {
                cmd = new SqlCommand(sorgu, con);


                SqlCommand cmd2 = new SqlCommand();
                SqlCommand cmd3 = new SqlCommand();
                if (comboBoxKatagori.SelectedItem.ToString().Equals("Kalem"))
                {
                    cmd2 = new SqlCommand(sorguK1, con);

                }
                else if (comboBoxKatagori.SelectedItem.ToString().Equals("Silgi"))
                {

                    cmd2 = new SqlCommand(sorguK2, con);

                }


                if (comboBoxMarka.SelectedItem.ToString().Equals("Belirsiz"))
                {
                    cmd3 = new SqlCommand(sorguM1, con);

                }
                else if (comboBoxMarka.SelectedItem.ToString().Equals("Pritt"))
                {
                    cmd3 = new SqlCommand(sorguM2, con);

                }
                else if (comboBoxMarka.SelectedItem.ToString().Equals("Rotring"))
                {
                    cmd3 = new SqlCommand(sorguM3, con);
                }

                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                con.Close();
                gridDoldur();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Hata\n",ex.Message);
            }
        }

        private void labelSil_Click(object sender, EventArgs e)//veritabanındaki seçilen kaydı kalıcı olarak silen fonksiyon
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Seçili Kayıt Silinecek!", "Devam", MessageBoxButtons.YesNo);

            if (secim == DialogResult.Yes)
            {
                string sorgu = "delete from urun where urunID=" + Convert.ToInt32(textBoxUrunId.Text) + "";
                cmd = new SqlCommand(sorgu, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                gridDoldur();
                temizle();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           textBoxUrunId.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
           textBoxUrunAdi.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
           comboBoxKatagori.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxMarka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //dataGridde idnin üstüne tıklandığında kaydın bilgilerinin getirilmesini sağlar
        }


    }
}
