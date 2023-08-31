namespace KirtasiyeProjesi
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGirisYap = new System.Windows.Forms.Label();
            this.labelZaman = new System.Windows.Forms.Label();
            this.labelUrunler = new System.Windows.Forms.Label();
            this.labelKayıt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.42206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.57793F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelGirisYap, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelZaman, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelUrunler, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelKayıt, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(184, 455);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kırtasiye\r\nOtomasyonu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGirisYap
            // 
            this.labelGirisYap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGirisYap.AutoSize = true;
            this.labelGirisYap.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGirisYap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelGirisYap.Location = new System.Drawing.Point(4, 136);
            this.labelGirisYap.Name = "labelGirisYap";
            this.labelGirisYap.Size = new System.Drawing.Size(176, 67);
            this.labelGirisYap.TabIndex = 1;
            this.labelGirisYap.Text = "Giriş Yap";
            this.labelGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGirisYap.Click += new System.EventHandler(this.labelGirisYap_Click);
            this.labelGirisYap.MouseLeave += new System.EventHandler(this.labelGirisYap_MouseLeave);
            this.labelGirisYap.MouseHover += new System.EventHandler(this.labelGirisYap_MouseHover);
            // 
            // labelZaman
            // 
            this.labelZaman.ForeColor = System.Drawing.Color.Black;
            this.labelZaman.Location = new System.Drawing.Point(4, 340);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(176, 23);
            this.labelZaman.TabIndex = 3;
            this.labelZaman.Text = "00:00:00";
            this.labelZaman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUrunler
            // 
            this.labelUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUrunler.AutoSize = true;
            this.labelUrunler.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunler.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelUrunler.Location = new System.Drawing.Point(4, 204);
            this.labelUrunler.Name = "labelUrunler";
            this.labelUrunler.Size = new System.Drawing.Size(176, 67);
            this.labelUrunler.TabIndex = 2;
            this.labelUrunler.Text = "Ürünler";
            this.labelUrunler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUrunler.Click += new System.EventHandler(this.labelUrunler_Click);
            this.labelUrunler.MouseLeave += new System.EventHandler(this.labelUrunler_MouseLeave);
            this.labelUrunler.MouseHover += new System.EventHandler(this.labelUrunler_MouseHover);
            // 
            // labelKayıt
            // 
            this.labelKayıt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKayıt.AutoSize = true;
            this.labelKayıt.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelKayıt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelKayıt.Location = new System.Drawing.Point(4, 272);
            this.labelKayıt.Name = "labelKayıt";
            this.labelKayıt.Size = new System.Drawing.Size(176, 67);
            this.labelKayıt.TabIndex = 4;
            this.labelKayıt.Text = "Kayıt Ol";
            this.labelKayıt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKayıt.Click += new System.EventHandler(this.labelKayıt_Click);
            this.labelKayıt.MouseLeave += new System.EventHandler(this.labelKayıt_MouseLeave);
            this.labelKayıt.MouseHover += new System.EventHandler(this.labelKayıt_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(193, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 455);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGirisYap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUrunler;
        public System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.Label labelKayıt;
    }
}

