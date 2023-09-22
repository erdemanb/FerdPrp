using System.Drawing;

namespace PRP_Ferd
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYapilacaklar = new System.Windows.Forms.Button();
            this.btnFilmler = new System.Windows.Forms.Button();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnParaYonetimi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(972, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnYapilacaklar
            // 
            this.btnYapilacaklar.BackColor = System.Drawing.Color.Transparent;
            this.btnYapilacaklar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYapilacaklar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYapilacaklar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnYapilacaklar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYapilacaklar.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYapilacaklar.ForeColor = System.Drawing.Color.White;
            this.btnYapilacaklar.Location = new System.Drawing.Point(533, 241);
            this.btnYapilacaklar.Name = "btnYapilacaklar";
            this.btnYapilacaklar.Size = new System.Drawing.Size(202, 53);
            this.btnYapilacaklar.TabIndex = 12;
            this.btnYapilacaklar.Text = "Yapılacaklar Listesi";
            this.btnYapilacaklar.UseVisualStyleBackColor = false;
            this.btnYapilacaklar.Click += new System.EventHandler(this.btnYapilacaklar_Click);
            // 
            // btnFilmler
            // 
            this.btnFilmler.BackColor = System.Drawing.Color.Transparent;
            this.btnFilmler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilmler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilmler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFilmler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmler.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmler.ForeColor = System.Drawing.Color.White;
            this.btnFilmler.Location = new System.Drawing.Point(696, 418);
            this.btnFilmler.Name = "btnFilmler";
            this.btnFilmler.Size = new System.Drawing.Size(202, 53);
            this.btnFilmler.TabIndex = 13;
            this.btnFilmler.Text = "Filmler";
            this.btnFilmler.UseVisualStyleBackColor = false;
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.BackColor = System.Drawing.Color.Transparent;
            this.btnKitaplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitaplar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnKitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitaplar.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitaplar.ForeColor = System.Drawing.Color.White;
            this.btnKitaplar.Location = new System.Drawing.Point(641, 359);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(202, 53);
            this.btnKitaplar.TabIndex = 14;
            this.btnKitaplar.Text = "Kitaplar";
            this.btnKitaplar.UseVisualStyleBackColor = false;
            // 
            // btnParaYonetimi
            // 
            this.btnParaYonetimi.BackColor = System.Drawing.Color.Transparent;
            this.btnParaYonetimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnParaYonetimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParaYonetimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnParaYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParaYonetimi.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnParaYonetimi.Location = new System.Drawing.Point(584, 300);
            this.btnParaYonetimi.Name = "btnParaYonetimi";
            this.btnParaYonetimi.Size = new System.Drawing.Size(202, 53);
            this.btnParaYonetimi.TabIndex = 15;
            this.btnParaYonetimi.Text = "Para Yönetimi";
            this.btnParaYonetimi.UseVisualStyleBackColor = false;
            this.btnParaYonetimi.Click += new System.EventHandler(this.btnParaYonetimi_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 588);
            this.Controls.Add(this.btnParaYonetimi);
            this.Controls.Add(this.btnKitaplar);
            this.Controls.Add(this.btnFilmler);
            this.Controls.Add(this.btnYapilacaklar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYapilacaklar;
        private System.Windows.Forms.Button btnFilmler;
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnParaYonetimi;
    }
}