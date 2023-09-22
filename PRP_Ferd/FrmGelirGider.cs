using FerdBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRP_Ferd
{
    public partial class FrmGelirGider : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public FrmGelirGider()
        {

            InitializeComponent();
        }
        Bussiness bl = new Bussiness();
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            cmbAylar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTur.SelectedIndex = 7;
            DateTime simdikiTarih = DateTime.Now;
            cmbAylar.SelectedIndex = simdikiTarih.Month - 1;
            dataGridView1.DataSource = bl.GelirlerVeriListele();
            ToplamaIslemi();
            dataGridView1.Columns["GelirGiderID"].Visible = false;
            DataGridOzellikler(dataGridView1);
            dataGridView1.ClearSelection();
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[1].HeaderText = "Ay";
            dataGridView1.Columns[2].HeaderText = "Miktar";
            dataGridView1.Columns[3].HeaderText = "Tür";
            dataGridView1.Columns[4].HeaderText = "Açıklama";
            dataGridView1.Columns["Miktar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Ay"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["GelirGiderTur"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            txtAciklama.Clear();
            txtMiktar.Clear();
            txtMiktar.Focus();

        }

        private void DataGridOzellikler(DataGridView geneldatagv)
        {

            geneldatagv.RowTemplate.Height = 30;
            geneldatagv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            geneldatagv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            geneldatagv.ReadOnly = true;


        }

        private void FrmGelirGider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            try
            {
                bl.VeriEkleTblGelirGider(int.Parse(txtMiktar.Text), cmbAylar.Text, txtAciklama.Text,cmbTur.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Miktar Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.DataSource = bl.AyaGoreListele(cmbAylar.Text);
            ayListelemeModu = true;
            btnAyaGoreListele.Text = "Genel Listeye Dön";
            ToplamaIslemi();
            dataGridView1.ClearSelection();
            txtAciklama.Clear();
            txtMiktar.Clear();
            txtMiktar.Focus();
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            int gider;
            try
            {
                gider = (-1) * int.Parse(txtMiktar.Text);
                bl.VeriEkleTblGelirGider(gider, cmbAylar.Text, txtAciklama.Text, cmbTur.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Miktar Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.DataSource = bl.AyaGoreListele(cmbAylar.Text);
            ayListelemeModu = true;
            btnAyaGoreListele.Text = "Genel Listeye Dön";
            ToplamaIslemi();
            dataGridView1.ClearSelection();
            txtAciklama.Clear();
            txtMiktar.Clear();
            txtMiktar.Focus();


        }

        private bool negatifguncelleme = false;//Gider ekle butonuyla tabloya eklediğimiz veri negatife döndüğünden ve bu veriyi cellclick olayıyla textboxa çekerken tekrar pozitife dönmesini sağladığımızdan, negatif verilerde güncelleme olayını negatif yapmasını sağlamak için bir boolean tutuyoruz. 
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtAciklama.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cmbTur.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); 
                    int a = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    if(a<0) { negatifguncelleme=true; }
                    else if(a>=0) { negatifguncelleme = false; }
                    txtMiktar.Text = Math.Abs(a).ToString();
                    cmbAylar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Seçtiğiniz satırda veri yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private bool ayListelemeModu = false;

        private void btnAyaGoreListele_Click(object sender, EventArgs e)
        {
            PLAyaGoreListele();
            dataGridView1.ClearSelection();
            txtAciklama.Clear();
            txtMiktar.Clear();
            txtMiktar.Focus();
        }

        private void ToplamaIslemi()
        {
            int columnIndexToSum = 2; 

            int toplam = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[columnIndexToSum].Value != null)
                {
                    int cellValue;
                    if (int.TryParse(row.Cells[columnIndexToSum].Value.ToString(), out cellValue))
                    {
                        toplam += cellValue;
                    }
                }
            }
            if (toplam > 0) {lblToplam.ForeColor = Color.LightGreen;}else if (toplam < 0) {  lblToplam.ForeColor = Color.LightSalmon;} else { lblToplam.ForeColor= Color.White;}
            lblToplam.Text = "TOPLAM:  " + toplam.ToString();
            
        }

        private void PLAyaGoreListele()
        {
            if (ayListelemeModu)
            {
                dataGridView1.DataSource = bl.GelirlerVeriListele();
                ayListelemeModu = false;
                btnAyaGoreListele.Text = "Ay'a Göre Listele";
                ToplamaIslemi();
            }
            else
            {
                try
                {
                    dataGridView1.DataSource = bl.AyaGoreListele(cmbAylar.Text);
                    ayListelemeModu = true;
                    btnAyaGoreListele.Text = "Genel Listeye Dön";
                    ToplamaIslemi();
                }
                catch (Exception)
                {
                    MessageBox.Show("Seçili bir ay olduğuna emin olunuz!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.OwningColumn.Name == "Miktar" && cell.Value != null)
                {
                    int hucreDegeri;
                    if (int.TryParse(cell.Value.ToString(), out hucreDegeri))
                    {
                        if (hucreDegeri > 0)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                        else if (hucreDegeri < 0)
                        {
                            cell.Style.BackColor = Color.LightSalmon;
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmParaYonetimi frmy = new FrmParaYonetimi();
            frmy.Show();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Etkisiz hale getirme
            }

        }

        private void btnGelirSil_Click(object sender, EventArgs e)
        {
            bl.SatirSilTblGelirGider(int.Parse(lblID.Text));
            if (btnAyaGoreListele.Text == "Genel Listeye Dön")
            {
                ayListelemeModu = false;
                PLAyaGoreListele();
            }
            else
            {
                dataGridView1.DataSource = bl.GelirlerVeriListele();
            }
            dataGridView1.ClearSelection();
            txtAciklama.Clear();
            txtMiktar.Clear();
            txtMiktar.Focus();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string aciklama = txtAciklama.Text;
                int gunceldeger = int.Parse(txtMiktar.Text);
                if(negatifguncelleme == true) 
                {
                    gunceldeger = gunceldeger * (-1); 
                }
                bl.VeriGuncelleTblGelirGider(cmbAylar.Text, aciklama, gunceldeger, int.Parse(lblID.Text),cmbTur.Text);
                if (btnAyaGoreListele.Text == "Genel Listeye Dön")
                {
                    PLAyaGoreListele();
                }
                else
                {
                    dataGridView1.DataSource = bl.GelirlerVeriListele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi yapılamadı,bir satırın seçili olduğundan gerekli boşlukları doldurduğunuzdan emin olunuz.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.ClearSelection();
            txtAciklama.Clear();
            txtMiktar.Clear();
            txtMiktar.Focus();

        }

        private void btnTumVeriyiSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Gelir-Gider tablosundaki tüm veriler geri yüklenemez şekilde silinecektir, devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Bussiness bl = new Bussiness();
                bl.TumVerileriSilTblGelirGider();
                MessageBox.Show("Gelir-Gider tablosu tamamen temizlenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = bl.GelirlerVeriListele();
                ToplamaIslemi();

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(cmbAylar.Text + " ayına ait tüm veriler geri yüklenemez şekilde silinecektir, devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Bussiness bl = new Bussiness();
                bl.AyaGoreVeriSilTblGelirGider(cmbAylar.Text);
                MessageBox.Show(cmbAylar.Text + " ayına ait tüm veriler tamamen temizlenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = bl.GelirlerVeriListele();
                ToplamaIslemi();
                dataGridView1.ClearSelection();

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
