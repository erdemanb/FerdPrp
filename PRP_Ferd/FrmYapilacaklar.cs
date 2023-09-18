using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerdBussiness;
using Ferd_DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.Close();
        }


        private void FrmYapilacaklar_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn siraSutunu = new DataGridViewTextBoxColumn();
            siraSutunu.Name = "Sira";
            dataGridView1.Columns.Insert(0, siraSutunu);
            DataGridViewaVeriListele();
            txtYapilacakIs.Focus();

        }

        private void DataGridViewaVeriListele()
        {
            dataGridView1.RowTemplate.Height = 30; // Satır yüksekliğini ayarlayın (örnek değer)
            Bussiness bl = new Bussiness();
            DataTable VeriTablosu = bl.VeriListele();
            dataGridView1.DataSource = VeriTablosu;
            dataGridView1.Columns["IsID"].Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Sira"].Value = (i + 1).ToString();
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.ReadOnly = true;
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
                bl1.VeriEkleTblIsler(txtYapilacakIs.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu!" + ex.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataGridViewaVeriListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

            try
            {
                bl3.SatirSilTblIsler(int.Parse(txtGorevID.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen geçerli bir satırı seçtiğinizden emin olunuz!");
            }
            DataGridViewaVeriListele();
            txtYapilacakIs.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tablodaki tüm veriler silinecektir, devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Bussiness bl4 = new Bussiness();
                bl4.TumVerileriSilTblIsler();
                MessageBox.Show("Tablo tamamen temizlenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DataGridViewaVeriListele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bussiness bl5 = new Bussiness();
            bl5.SatirGuncelleTblIsler(int.Parse(txtGorevID.Text), txtYapilacakIs.Text);
            DataGridViewaVeriListele();

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
    }
}
