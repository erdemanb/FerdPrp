namespace PRP_Ferd
{
    partial class FrmYapilacaklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYapilacaklar));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGorevID = new System.Windows.Forms.TextBox();
            this.txtYapilacakIs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTabloTemizle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTamamlandi = new System.Windows.Forms.Button();
            this.txtTamamlananID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(50, 490);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 71);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Görev Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(186, 490);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 71);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Görev Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(322, 490);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(128, 72);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Görev Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(50, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 348);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Görevler Listesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(984, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtGorevID
            // 
            this.txtGorevID.Location = new System.Drawing.Point(870, 430);
            this.txtGorevID.MaxLength = 30000;
            this.txtGorevID.Name = "txtGorevID";
            this.txtGorevID.Size = new System.Drawing.Size(36, 31);
            this.txtGorevID.TabIndex = 13;
            this.txtGorevID.TabStop = false;
            // 
            // txtYapilacakIs
            // 
            this.txtYapilacakIs.Location = new System.Drawing.Point(267, 430);
            this.txtYapilacakIs.MaxLength = 90;
            this.txtYapilacakIs.Name = "txtYapilacakIs";
            this.txtYapilacakIs.Size = new System.Drawing.Size(494, 31);
            this.txtYapilacakIs.TabIndex = 0;
            this.txtYapilacakIs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYapilacakIs_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(140, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Görev Açıklaması:";
            // 
            // btnTabloTemizle
            // 
            this.btnTabloTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTabloTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTabloTemizle.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTabloTemizle.Location = new System.Drawing.Point(594, 491);
            this.btnTabloTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTabloTemizle.Name = "btnTabloTemizle";
            this.btnTabloTemizle.Size = new System.Drawing.Size(128, 71);
            this.btnTabloTemizle.TabIndex = 4;
            this.btnTabloTemizle.Text = "Görevler Listesini Temizle";
            this.btnTabloTemizle.UseVisualStyleBackColor = false;
            this.btnTabloTemizle.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.Location = new System.Drawing.Point(531, 58);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(456, 348);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(669, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tamamlananlar";
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.BackColor = System.Drawing.Color.Transparent;
            this.btnTamamlandi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTamamlandi.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamlandi.Location = new System.Drawing.Point(458, 491);
            this.btnTamamlandi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(128, 71);
            this.btnTamamlandi.TabIndex = 19;
            this.btnTamamlandi.Text = "Tamamlandı Olarak İşaretle";
            this.btnTamamlandi.UseVisualStyleBackColor = false;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // txtTamamlananID
            // 
            this.txtTamamlananID.Location = new System.Drawing.Point(912, 430);
            this.txtTamamlananID.MaxLength = 30000;
            this.txtTamamlananID.Name = "txtTamamlananID";
            this.txtTamamlananID.Size = new System.Drawing.Size(36, 31);
            this.txtTamamlananID.TabIndex = 20;
            this.txtTamamlananID.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(730, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 71);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tamamlananlar Listesini Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmYapilacaklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTamamlananID);
            this.Controls.Add(this.btnTamamlandi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnTabloTemizle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYapilacakIs);
            this.Controls.Add(this.txtGorevID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmYapilacaklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYapilacaklar";
            this.Load += new System.EventHandler(this.FrmYapilacaklar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmYapilacaklar_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGorevID;
        private System.Windows.Forms.TextBox txtYapilacakIs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTabloTemizle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTamamlandi;
        private System.Windows.Forms.TextBox txtTamamlananID;
        private System.Windows.Forms.Button button1;
    }
}