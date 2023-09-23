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
            this.btnYapilacaklar = new System.Windows.Forms.Button();
            this.btnParaYonetimi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYapilacaklar
            // 
            this.btnYapilacaklar.BackColor = System.Drawing.Color.Transparent;
            this.btnYapilacaklar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYapilacaklar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYapilacaklar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnYapilacaklar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYapilacaklar.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYapilacaklar.ForeColor = System.Drawing.Color.White;
            this.btnYapilacaklar.Location = new System.Drawing.Point(61, 360);
            this.btnYapilacaklar.Name = "btnYapilacaklar";
            this.btnYapilacaklar.Size = new System.Drawing.Size(186, 53);
            this.btnYapilacaklar.TabIndex = 12;
            this.btnYapilacaklar.Text = "Yapılacaklar Listesi";
            this.btnYapilacaklar.UseVisualStyleBackColor = false;
            this.btnYapilacaklar.Click += new System.EventHandler(this.btnYapilacaklar_Click);
            // 
            // btnParaYonetimi
            // 
            this.btnParaYonetimi.BackColor = System.Drawing.Color.Transparent;
            this.btnParaYonetimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnParaYonetimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParaYonetimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnParaYonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParaYonetimi.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYonetimi.ForeColor = System.Drawing.Color.White;
            this.btnParaYonetimi.Location = new System.Drawing.Point(253, 360);
            this.btnParaYonetimi.Name = "btnParaYonetimi";
            this.btnParaYonetimi.Size = new System.Drawing.Size(186, 53);
            this.btnParaYonetimi.TabIndex = 15;
            this.btnParaYonetimi.Text = "Para Yönetimi";
            this.btnParaYonetimi.UseVisualStyleBackColor = false;
            this.btnParaYonetimi.Click += new System.EventHandler(this.btnParaYonetimi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Programı Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnParaYonetimi);
            this.Controls.Add(this.btnYapilacaklar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYapilacaklar;
        private System.Windows.Forms.Button btnParaYonetimi;
        private System.Windows.Forms.Button button1;
    }
}