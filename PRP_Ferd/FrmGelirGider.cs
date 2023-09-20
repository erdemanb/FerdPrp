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
            DateTime simdikiTarih = DateTime.Now;
            cmbAylar.SelectedIndex = simdikiTarih.Month - 1;
            dataGridView1.DataSource = bl.GelirlerVeriListele();
            dataGridView1.Columns["GelirGiderID"].Visible = false;
            DataGridOzellikler(dataGridView1);
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dataGridView1.Columns[1].HeaderText = "Ay";
            dataGridView1.Columns[2].HeaderText = "Miktar";
            dataGridView1.Columns[3].HeaderText = "Açıklama";
            dataGridView1.Columns["Miktar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Ay"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                bl.VeriEkleTblGelirGider(int.Parse(txtMiktar.Text), cmbAylar.Text, txtAciklama.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Miktar Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            int gider;
            try
            {
                gider =(-1) *  int.Parse(txtMiktar.Text);
                bl.VeriEkleTblGelirGider(gider, cmbAylar.Text, txtAciklama.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Miktar Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("ID Değeri Bulunamadı!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private bool ayListelemeModu = false;
        private void btnAyaGoreListele_Click(object sender, EventArgs e)
        {
            if (ayListelemeModu)
            {
                dataGridView1.DataSource = bl.GelirlerVeriListele();
                ayListelemeModu = false;
                btnAyaGoreListele.Text = "Ay'a Göre Listele";
            }
            else
            {
                try
                {
                    dataGridView1.DataSource = bl.AyaGoreListele(cmbAylar.Text);
                    ayListelemeModu = true;
                    btnAyaGoreListele.Text = "Genel Listeye Dön";
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
    }
}
