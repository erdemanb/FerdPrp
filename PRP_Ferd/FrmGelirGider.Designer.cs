namespace PRP_Ferd
{
    partial class FrmGelirGider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirGider));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGelirEkle = new System.Windows.Forms.Button();
            this.btnGiderEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGelirSil = new System.Windows.Forms.Button();
            this.lblGelirGiderTur = new System.Windows.Forms.Label();
            this.cmbAylar = new System.Windows.Forms.ComboBox();
            this.btnAyaGoreListele = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnTumVeriyiSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Oswald SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Oswald SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btnGelirEkle
            // 
            this.btnGelirEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnGelirEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGelirEkle.FlatAppearance.BorderSize = 2;
            this.btnGelirEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGelirEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGelirEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelirEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGelirEkle.Location = new System.Drawing.Point(54, 607);
            this.btnGelirEkle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGelirEkle.Name = "btnGelirEkle";
            this.btnGelirEkle.Size = new System.Drawing.Size(88, 39);
            this.btnGelirEkle.TabIndex = 4;
            this.btnGelirEkle.Text = "Gelir Ekle";
            this.btnGelirEkle.UseVisualStyleBackColor = false;
            this.btnGelirEkle.Click += new System.EventHandler(this.btnGelirEkle_Click);
            // 
            // btnGiderEkle
            // 
            this.btnGiderEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnGiderEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiderEkle.FlatAppearance.BorderSize = 2;
            this.btnGiderEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGiderEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGiderEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGiderEkle.Location = new System.Drawing.Point(147, 607);
            this.btnGiderEkle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGiderEkle.Name = "btnGiderEkle";
            this.btnGiderEkle.Size = new System.Drawing.Size(88, 39);
            this.btnGiderEkle.TabIndex = 5;
            this.btnGiderEkle.Text = "Gider Ekle";
            this.btnGiderEkle.UseVisualStyleBackColor = false;
            this.btnGiderEkle.Click += new System.EventHandler(this.btnGiderEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Açıklama:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(82, 461);
            this.txtMiktar.MaxLength = 15;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(345, 27);
            this.txtMiktar.TabIndex = 0;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(82, 530);
            this.txtAciklama.MaxLength = 50;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(345, 27);
            this.txtAciklama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miktar:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 2;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.Location = new System.Drawing.Point(241, 607);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 39);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGelirSil
            // 
            this.btnGelirSil.BackColor = System.Drawing.Color.Transparent;
            this.btnGelirSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGelirSil.FlatAppearance.BorderSize = 2;
            this.btnGelirSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGelirSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGelirSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelirSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGelirSil.Location = new System.Drawing.Point(335, 607);
            this.btnGelirSil.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGelirSil.Name = "btnGelirSil";
            this.btnGelirSil.Size = new System.Drawing.Size(88, 39);
            this.btnGelirSil.TabIndex = 7;
            this.btnGelirSil.Text = "Sil";
            this.btnGelirSil.UseVisualStyleBackColor = false;
            this.btnGelirSil.Click += new System.EventHandler(this.btnGelirSil_Click);
            // 
            // lblGelirGiderTur
            // 
            this.lblGelirGiderTur.AutoSize = true;
            this.lblGelirGiderTur.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirGiderTur.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGelirGiderTur.Location = new System.Drawing.Point(50, 566);
            this.lblGelirGiderTur.Name = "lblGelirGiderTur";
            this.lblGelirGiderTur.Size = new System.Drawing.Size(26, 22);
            this.lblGelirGiderTur.TabIndex = 9;
            this.lblGelirGiderTur.Text = "Ay:";
            // 
            // cmbAylar
            // 
            this.cmbAylar.FormattingEnabled = true;
            this.cmbAylar.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAylar.Location = new System.Drawing.Point(82, 563);
            this.cmbAylar.Name = "cmbAylar";
            this.cmbAylar.Size = new System.Drawing.Size(345, 30);
            this.cmbAylar.TabIndex = 3;
            // 
            // btnAyaGoreListele
            // 
            this.btnAyaGoreListele.BackColor = System.Drawing.Color.Transparent;
            this.btnAyaGoreListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyaGoreListele.FlatAppearance.BorderSize = 2;
            this.btnAyaGoreListele.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAyaGoreListele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAyaGoreListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyaGoreListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAyaGoreListele.Location = new System.Drawing.Point(462, 456);
            this.btnAyaGoreListele.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAyaGoreListele.Name = "btnAyaGoreListele";
            this.btnAyaGoreListele.Size = new System.Drawing.Size(118, 39);
            this.btnAyaGoreListele.TabIndex = 8;
            this.btnAyaGoreListele.Text = "Ay\'a Göre Listele";
            this.btnAyaGoreListele.UseVisualStyleBackColor = false;
            this.btnAyaGoreListele.Click += new System.EventHandler(this.btnAyaGoreListele_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(663, 466);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(106, 22);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "InvisibleLabelForID";
            this.lblID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(939, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToplam.Location = new System.Drawing.Point(29, 436);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(50, 22);
            this.lblToplam.TabIndex = 14;
            this.lblToplam.Text = "Toplam:";
            // 
            // btnTumVeriyiSil
            // 
            this.btnTumVeriyiSil.BackColor = System.Drawing.Color.Transparent;
            this.btnTumVeriyiSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTumVeriyiSil.FlatAppearance.BorderSize = 2;
            this.btnTumVeriyiSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTumVeriyiSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnTumVeriyiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumVeriyiSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTumVeriyiSil.Location = new System.Drawing.Point(462, 565);
            this.btnTumVeriyiSil.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTumVeriyiSil.Name = "btnTumVeriyiSil";
            this.btnTumVeriyiSil.Size = new System.Drawing.Size(118, 39);
            this.btnTumVeriyiSil.TabIndex = 10;
            this.btnTumVeriyiSil.Text = "Tüm Veriyi Sil";
            this.btnTumVeriyiSil.UseVisualStyleBackColor = false;
            this.btnTumVeriyiSil.Click += new System.EventHandler(this.btnTumVeriyiSil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(462, 500);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Seçili Aydaki Tüm Veriyi Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Maaş",
            "Borsa",
            "Kira",
            "Aidat",
            "Fatura",
            "Alışveriş",
            "Market",
            "Eğlence",
            "Diğer"});
            this.cmbTur.Location = new System.Drawing.Point(82, 494);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(345, 30);
            this.cmbTur.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(46, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tür:";
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 660);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTumVeriyiSil);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAyaGoreListele);
            this.Controls.Add(this.cmbAylar);
            this.Controls.Add(this.lblGelirGiderTur);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGelirSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiderEkle);
            this.Controls.Add(this.btnGelirEkle);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Oswald SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGelirGider";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGelirGider_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGelirEkle;
        private System.Windows.Forms.Button btnGiderEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGelirSil;
        private System.Windows.Forms.Label lblGelirGiderTur;
        private System.Windows.Forms.ComboBox cmbAylar;
        private System.Windows.Forms.Button btnAyaGoreListele;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnTumVeriyiSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label label3;
    }
}