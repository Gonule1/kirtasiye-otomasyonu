namespace KirtasiyeProjesi
{
    partial class FormUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.labelTemizle = new System.Windows.Forms.Label();
            this.labelEkle = new System.Windows.Forms.Label();
            this.labelGuncelle = new System.Windows.Forms.Label();
            this.labelSil = new System.Windows.Forms.Label();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxKatagori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelGetir = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUrunId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Katagori";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fiyat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUrunAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUrunAdi.Location = new System.Drawing.Point(103, 43);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(181, 26);
            this.textBoxUrunAdi.TabIndex = 5;
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFiyat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFiyat.Location = new System.Drawing.Point(103, 163);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(181, 26);
            this.textBoxFiyat.TabIndex = 8;
            // 
            // labelTemizle
            // 
            this.labelTemizle.BackColor = System.Drawing.Color.RosyBrown;
            this.labelTemizle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTemizle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTemizle.ForeColor = System.Drawing.Color.Black;
            this.labelTemizle.Location = new System.Drawing.Point(425, 220);
            this.labelTemizle.Name = "labelTemizle";
            this.labelTemizle.Size = new System.Drawing.Size(90, 25);
            this.labelTemizle.TabIndex = 9;
            this.labelTemizle.Text = "Temizle";
            this.labelTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTemizle.Click += new System.EventHandler(this.labelTemizle_Click);
            this.labelTemizle.MouseLeave += new System.EventHandler(this.labelTemizle_MouseLeave);
            this.labelTemizle.MouseHover += new System.EventHandler(this.labelTemizle_MouseHover);
            // 
            // labelEkle
            // 
            this.labelEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.labelEkle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEkle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEkle.ForeColor = System.Drawing.Color.Black;
            this.labelEkle.Location = new System.Drawing.Point(541, 260);
            this.labelEkle.Name = "labelEkle";
            this.labelEkle.Size = new System.Drawing.Size(90, 25);
            this.labelEkle.TabIndex = 10;
            this.labelEkle.Text = "Ekle";
            this.labelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEkle.Click += new System.EventHandler(this.labelEkle_Click);
            this.labelEkle.MouseLeave += new System.EventHandler(this.labelEkle_MouseLeave);
            this.labelEkle.MouseHover += new System.EventHandler(this.labelEkle_MouseHover);
            // 
            // labelGuncelle
            // 
            this.labelGuncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.labelGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGuncelle.ForeColor = System.Drawing.Color.Black;
            this.labelGuncelle.Location = new System.Drawing.Point(541, 305);
            this.labelGuncelle.Name = "labelGuncelle";
            this.labelGuncelle.Size = new System.Drawing.Size(90, 25);
            this.labelGuncelle.TabIndex = 11;
            this.labelGuncelle.Text = "Güncelle";
            this.labelGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGuncelle.Click += new System.EventHandler(this.labelGuncelle_Click);
            this.labelGuncelle.MouseLeave += new System.EventHandler(this.labelGuncelle_MouseLeave);
            this.labelGuncelle.MouseHover += new System.EventHandler(this.labelGuncelle_MouseHover);
            // 
            // labelSil
            // 
            this.labelSil.BackColor = System.Drawing.Color.Firebrick;
            this.labelSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSil.ForeColor = System.Drawing.Color.PapayaWhip;
            this.labelSil.Location = new System.Drawing.Point(541, 351);
            this.labelSil.Name = "labelSil";
            this.labelSil.Size = new System.Drawing.Size(90, 25);
            this.labelSil.TabIndex = 12;
            this.labelSil.Text = "Sil";
            this.labelSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSil.Click += new System.EventHandler(this.labelSil_Click);
            this.labelSil.MouseLeave += new System.EventHandler(this.labelSil_MouseLeave);
            this.labelSil.MouseHover += new System.EventHandler(this.labelSil_MouseHover);
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMarka.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(103, 123);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(181, 27);
            this.comboBoxMarka.TabIndex = 13;
            // 
            // comboBoxKatagori
            // 
            this.comboBoxKatagori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxKatagori.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKatagori.FormattingEnabled = true;
            this.comboBoxKatagori.Location = new System.Drawing.Point(103, 83);
            this.comboBoxKatagori.Name = "comboBoxKatagori";
            this.comboBoxKatagori.Size = new System.Drawing.Size(181, 27);
            this.comboBoxKatagori.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(383, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Açıklama";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(318, 285);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 81);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // labelGetir
            // 
            this.labelGetir.BackColor = System.Drawing.Color.CadetBlue;
            this.labelGetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGetir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGetir.ForeColor = System.Drawing.Color.Black;
            this.labelGetir.Location = new System.Drawing.Point(318, 220);
            this.labelGetir.Name = "labelGetir";
            this.labelGetir.Size = new System.Drawing.Size(90, 25);
            this.labelGetir.TabIndex = 17;
            this.labelGetir.Text = "Getir";
            this.labelGetir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGetir.Click += new System.EventHandler(this.labelGetir_Click);
            this.labelGetir.MouseLeave += new System.EventHandler(this.labelGetir_MouseLeave);
            this.labelGetir.MouseHover += new System.EventHandler(this.labelGetir_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxMarka, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxKatagori, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUrunAdi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFiyat, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUrunId, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 216);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 202);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 40);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ürün Id";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUrunId
            // 
            this.textBoxUrunId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUrunId.Font = new System.Drawing.Font("Cambria", 12F);
            this.textBoxUrunId.Location = new System.Drawing.Point(103, 3);
            this.textBoxUrunId.Name = "textBoxUrunId";
            this.textBoxUrunId.Size = new System.Drawing.Size(181, 26);
            this.textBoxUrunId.TabIndex = 16;
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelGetir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSil);
            this.Controls.Add(this.labelGuncelle);
            this.Controls.Add(this.labelEkle);
            this.Controls.Add(this.labelTemizle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUrunler";
            this.Text = "FormUrunler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.Label labelTemizle;
        private System.Windows.Forms.Label labelEkle;
        private System.Windows.Forms.Label labelGuncelle;
        private System.Windows.Forms.Label labelSil;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.ComboBox comboBoxKatagori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelGetir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUrunId;
    }
}