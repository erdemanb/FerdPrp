using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FerdBussiness;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;

namespace PRP_Ferd
{
    public partial class FrmYapilacaklar : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public FrmYapilacaklar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }


        private void FrmYapilacaklar_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            DataGridOzellikler(dataGridView1);
            DataGridOzellikler(dataGridView2);
            DataGridViewaVeriListele();
            txtYapilacakIs.Focus();

        }

        private void DataGridViewaVeriListele()
        {

            Bussiness bl = new Bussiness();
            DataTable VeriTablosu = bl.YapilacaklarVeriListele();
            DataTable VeriTablosu2 = bl.TamamlananlarVeriListele();
            dataGridView1.DataSource = VeriTablosu;
            dataGridView2.DataSource = VeriTablosu2;
            GuncelleSiraNumaralari(dataGridView1);
            GuncelleSiraNumaralari(dataGridView2);
            dataGridView2.Columns["YapilanIsID"].Visible = false;
            dataGridView1.Columns["IsID"].Visible = false;

        }
        private void GuncelleSiraNumaralari(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells["Sira"].Value = (i + 1).ToString();
            }
        }
        //Aşağıdaki metot, her datagridviewda sol başa sıralama ekleyip, kolonların boyutunu otomatik ayarlar.
        private void DataGridOzellikler(DataGridView geneldatagv)
        {
            DataGridViewTextBoxColumn siraSutunu = new DataGridViewTextBoxColumn();
            siraSutunu.Name = "Sira";
            geneldatagv.Columns.Insert(0, siraSutunu);

            // DataGridView'daki satır sayısı kadar sıra değerlerini güncelle
            for (int i = 0; i < geneldatagv.Rows.Count; i++)
            {
                geneldatagv.Rows[i].Cells["Sira"].Value = (i + 1).ToString();
            }

            // Kolon boyutlarını otomatik ayarla
            geneldatagv.RowTemplate.Height = 30;
            geneldatagv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            geneldatagv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            geneldatagv.ReadOnly = true;

        }
        private void FrmYapilacaklar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bussiness bl1 = new Bussiness();
                if (!string.IsNullOrEmpty(txtYapilacakIs.Text))
                {
                    bl1.VeriEkleTblIsler(txtYapilacakIs.Text);
                }
             
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu!" + ex.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtYapilacakIs.Clear();
            txtGorevID.Clear();
            txtTamamlananID.Clear();
            DataGridViewaVeriListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ClearSelection();
            txtTamamlananID.Clear();
            txtYapilacakIs.Clear();
            try
            {
                if (e.RowIndex >= 0)
                {

                    txtYapilacakIs.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGorevID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu! Geçerli bir satıra tıklayınız. \n" + ex.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bussiness bl3 = new Bussiness();

            if (!string.IsNullOrEmpty(txtGorevID.Text))
            {
                try
                {
                    bl3.SatirSilTblIsler(int.Parse(txtGorevID.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir satırı seçtiğinizden emin olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (!string.IsNullOrEmpty(txtTamamlananID.Text))
            {
                try
                {
                    bl3.SatirSilTblTamamlananlar(int.Parse(txtTamamlananID.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir satırı seçtiğinizden emin olunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DataGridViewaVeriListele();
            txtYapilacakIs.Clear();
            txtGorevID.Clear();
            txtTamamlananID.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Görevler tablosundaki tüm veriler silinecektir, devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Bussiness bl4 = new Bussiness();
                bl4.TumVerileriSilTblIsler();
                MessageBox.Show("Görevler tablosu tamamen temizlenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DataGridViewaVeriListele();
            txtTamamlananID.Clear();
            txtGorevID.Clear();
            txtYapilacakIs.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bussiness bl5 = new Bussiness();

            try
            {
                if (!String.IsNullOrEmpty(txtYapilacakIs.Text))
                {
                    bl5.SatirGuncelleTblIsler(int.Parse(txtGorevID.Text), txtYapilacakIs.Text);
                }
                else if(!String.IsNullOrEmpty(txtGorevID.Text))
                {
                    MessageBox.Show("Güncellenen görev boş bırakılamaz, \"Görev Sil\" butonunu kullanmalısınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(txtGorevID.Text))
                {
                    MessageBox.Show("Lütfen görevler listesinden bir satırın seçili olduğundan emin olunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi için, daha önce var olan bir görevi seçmelisiniz.","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            DataGridViewaVeriListele();
            txtTamamlananID.Clear();
            txtGorevID.Clear();
        }


        private void txtYapilacakIs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string girilenMetin = txtYapilacakIs.Text.Trim();

                if (!string.IsNullOrEmpty(girilenMetin))
                {
                    Bussiness bl7 = new Bussiness();
                    bl7.VeriEkleTblIsler(girilenMetin);
                    txtYapilacakIs.Clear();
                    DataGridViewaVeriListele();
                }
            }
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            Bussiness bl8 = new Bussiness();
            if (!String.IsNullOrEmpty(txtGorevID.Text))
            {
                bl8.VeriEkleTblTamamlananlar(txtYapilacakIs.Text);
            }
            try
            {
                bl8.SatirSilTblIsler(int.Parse(txtGorevID.Text));

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen görevler listesinden bir satırın seçili olduğundan emin olunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DataGridViewaVeriListele();
            txtYapilacakIs.Clear();
            txtGorevID.Clear();
            txtTamamlananID.Clear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
            txtGorevID.Clear();
            txtYapilacakIs.Clear();
            try
            {
                if (e.RowIndex >= 0)
                {

                    txtYapilacakIs.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtTamamlananID.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu! Geçerli bir satıra tıklayınız. \n" + ex.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tamamlananlar tablosundaki tüm veriler silinecektir, devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Bussiness bl4 = new Bussiness();
                bl4.TumVerileriSilTblTamamlananlar();
                MessageBox.Show("Tamamlananlar tablosu tamamen temizlenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DataGridViewaVeriListele();
            txtTamamlananID.Clear();
            txtGorevID.Clear();
            txtYapilacakIs.Clear();

        }

        private void btnEkle_Enter(object sender, EventArgs e)
        {
            btnEkle.BackColor = SystemColors.MenuHighlight;
        }

        private void btnEkle_Leave(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.Transparent;
        }

        private void btnSil_Enter(object sender, EventArgs e)
        {
            btnSil.BackColor = SystemColors.MenuHighlight;
        }

        private void btnSil_Leave(object sender, EventArgs e)
        {
            btnSil.BackColor= Color.Transparent;
        }

        private void btnGuncelle_Enter(object sender, EventArgs e)
        {
            btnGuncelle.BackColor = SystemColors.MenuHighlight;
        }

        private void btnTamamlandi_Enter(object sender, EventArgs e)
        {
            btnTamamlandi.BackColor = SystemColors.MenuHighlight;
        }

        private void btnGuncelle_Leave(object sender, EventArgs e)
        {
            btnGuncelle.BackColor= Color.Transparent;
        }

        private void btnTamamlandi_Leave(object sender, EventArgs e)
        {
            btnTamamlandi.BackColor= Color.Transparent;
        }

        private void btnTabloTemizle_Enter(object sender, EventArgs e)
        {
            btnTabloTemizle.BackColor = SystemColors.MenuHighlight; 
        }

        private void btnTabloTemizle_Leave(object sender, EventArgs e)
        {
            btnTabloTemizle.BackColor= Color.Transparent;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.MenuHighlight;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor= Color.Transparent;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PDF_Disa_Aktar(dataGridView2);
        }

        public static void PDF_Disa_Aktar(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                DateTime dateTime = DateTime.Now; // veya başka bir tarih

                string tarih = dateTime.ToString("dd/MM/yyyy");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf|Tüm dosyalar (*.*)|*.*";
                save.FileName = tarih + " Tamamlananlar Listesi";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (File.Exists(save.FileName))
                        {
                            File.Delete(save.FileName);
                        }

                        PdfPTable pTable = new PdfPTable(2); // Tüm sütunları içerecek şekilde başlatın
                        float firstColumnWidth = 3f; // İlk sütunun genişliği 200 birim (örnek değer)
                        pTable.SetWidths(new float[] { firstColumnWidth, '*' }); // İkinci sütunun genişliği 0 (otomatik genişlik)
                        pTable.DefaultCell.Padding = 2;
                        pTable.WidthPercentage = 100;
                        BaseFont baseFont = BaseFont.CreateFont("Helvetica", "CP1254", true);
                        Font font = new Font(baseFont, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            pTable.CompleteRow();

                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                if (i == 0 || i == 2) // Sadece 0 ve 2 indexli sütunları ekler
                                {
                                    if (row.Cells[i].Value != null)
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase(row.Cells[i].Value.ToString(), font));
                                        cell.VerticalAlignment = Element.ALIGN_CENTER;
                                        pTable.AddCell(cell);
                                    }
                                    else
                                    {
                                        pTable.AddCell("");
                                    }
                                }
                            }
                        }

                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A5, 10f, 35f, 35f, 20f);
                            PdfWriter.GetInstance(document, fileStream);
                            document.Open();
                            Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 15);
                            Paragraph title = new Paragraph("FERD Tamamlananlar Listesi " + tarih, titleFont);
                            title.SpacingAfter = 30f;
                            title.Alignment = Element.ALIGN_CENTER;
                            document.Add(title);
                            document.Add(pTable);
                            document.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }
    }
}
