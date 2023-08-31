using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirtasiyeProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //Form içinde form açılabilir yapıyoruz
        }
        bool girisAcikMi =false;
        bool urunlerAcikMi = false;
        bool kayitOlAcikMi = false;
        

        public void labelGirisYap_Click(object sender, EventArgs e)
        {

            urunlerAcikMi = false;
            this.Controls.Clear();
            this.InitializeComponent();
            

            if (girisAcikMi == false)
            {
                FormGiris frgiris = new FormGiris();
                frgiris.TopLevel = false;
                panel1.Controls.Add(frgiris);

                frgiris.Location = new Point((panel1.Width / 2 - frgiris.Width / 2), (panel1.Height / 2 - frgiris.Height / 2));

                
                frgiris.Show();
                frgiris.BringToFront();
                girisAcikMi=true;
                

            }
           





        }

      

        private void labelUrunler_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //this.InitializeComponent();
            if (FormGiris.girisYapildi == true)
            {
                girisAcikMi = false; 
                FormUrunler frmUrunler = new FormUrunler();
                frmUrunler.TopLevel = false;
                panel1.Controls.Add(frmUrunler);
                frmUrunler.Dock = DockStyle.Fill;
                
                frmUrunler.Show();
                frmUrunler.BringToFront();

                urunlerAcikMi = true;
            }
        }

        private void labelUrunler_MouseHover(object sender, EventArgs e)
        {

            labelUrunler.ForeColor = Color.Black;
            labelUrunler.BackColor = Color.LightGray;
        }

        private void labelUrunler_MouseLeave(object sender, EventArgs e)
        {
            labelUrunler.ForeColor = Color.DarkSlateGray;
            labelUrunler.BackColor = Color.LightSteelBlue;
        }

        private void labelKayıt_Click(object sender, EventArgs e)
        {
            girisAcikMi = false;
            this.Controls.Clear();
            this.InitializeComponent();


            if (kayitOlAcikMi == false)
            {
                FormUyeOl frUyeOl = new FormUyeOl();
                frUyeOl.TopLevel = false;
                panel1.Controls.Add(frUyeOl);

                frUyeOl.Location = new Point((panel1.Width / 2 - frUyeOl.Width / 2), (panel1.Height / 2 - frUyeOl.Height / 2));//formu ortalar


                frUyeOl.Show();
                frUyeOl.BringToFront();
                kayitOlAcikMi = true;


            }
        }

        private void labelKayıt_MouseHover(object sender, EventArgs e)
        {
            labelKayıt.ForeColor = Color.Black;
            labelKayıt.BackColor = Color.LightGray;
        }

        private void labelKayıt_MouseLeave(object sender, EventArgs e)
        {
            labelKayıt.ForeColor = Color.DarkSlateGray;
            labelKayıt.BackColor = Color.LightSteelBlue;
        }

        private void labelGirisYap_MouseHover(object sender, EventArgs e)
        {
            labelGirisYap.ForeColor = Color.Black;
            labelGirisYap.BackColor = Color.LightGray;
        }

        private void labelGirisYap_MouseLeave(object sender, EventArgs e)
        {
            labelGirisYap.ForeColor = Color.DarkSlateGray;
            labelGirisYap.BackColor = Color.LightSteelBlue;
        }
    }
}
