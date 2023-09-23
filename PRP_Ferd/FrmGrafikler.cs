using FerdBussiness;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace PRP_Ferd
{
    public partial class FrmGrafikler : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        Bussiness blc = new Bussiness();
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            chartAylar.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Oswald", 10, FontStyle.Bold);
            chartAylar.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Oswald", 10, FontStyle.Bold);
            chartAylar.ChartAreas[0].AxisX.Interval = 1;
            chartAylar.Series["Negatif"].Color = Color.Red;
            chartAylar.Series["Pozitif"].Color = Color.Green;
            chartAylar.Series["Toplam"].Color = Color.Blue;
            DataTable originalData = blc.MiktarlarToplamiGetir();
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            DataTable sortedData = new DataTable();
            sortedData.Columns.Add("Ay", typeof(string));
            sortedData.Columns.Add("NegatifMiktar", typeof(int));
            sortedData.Columns.Add("PozitifMiktar", typeof(int));
            sortedData.Columns.Add("ToplamMiktar", typeof(int));
            foreach (string ay in aylar)
            {
                DataRow[] rows = originalData.Select("Ay = '" + ay + "'");
                if (rows.Length > 0)
                {
                    int negatifMiktar = Convert.ToInt32(rows[0]["NegatifMiktar"]);
                    int pozitifMiktar = Convert.ToInt32(rows[0]["PozitifMiktar"]);
                    int toplamMiktar = negatifMiktar + pozitifMiktar;
                    sortedData.Rows.Add(ay, negatifMiktar, pozitifMiktar, toplamMiktar);
                }
            }
            chartAylar.Series["Negatif"].Points.DataBind(sortedData.AsEnumerable(), "Ay", "NegatifMiktar", "");
            chartAylar.Series["Pozitif"].Points.DataBind(sortedData.AsEnumerable(), "Ay", "PozitifMiktar", "");
            chartAylar.Series["Toplam"].Points.DataBind(sortedData.AsEnumerable(), "Ay", "ToplamMiktar", "");
        }
        private void FrmGrafikler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private bool grafikkontrol = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (grafikkontrol)
            {
                button2.Text = "Gelir-Gider Türleri Pasta Grafikler";
                chartAylar.Visible = true;
                chartTurler.Visible = false;
                chartTurler2.Visible = false;
            }
            else
            {
                button2.Text = "Aylık Sütun Grafik";
                chartAylar.Visible = false;
                chartTurler.Visible = true;
                chartTurler2.Visible = true;
                GiderlerPastaGrafik();
                GelirlerPastaGrafik();
            }

            grafikkontrol = !grafikkontrol;
        }
        private void GelirlerPastaGrafik()
        {
            //Aşağıdaki kısımların tuhaf gözüktüğünün farkındayım, fakat yazış biçimi olarak denediğim diğer her şeyde chart'taki görüntüler açısından sorunla karşılaştım. 
            chartTurler2.Series["Maaş"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Maaş"].YValueMembers = "Gelirler";
            chartTurler2.Series["Borsa"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Borsa"].YValueMembers = "Gelirler";
            chartTurler2.Series["Kira"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Kira"].YValueMembers = "Gelirler";
            chartTurler2.Series["Aidat"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Aidat"].YValueMembers = "Gelirler";
            chartTurler2.Series["Fatura"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Fatura"].YValueMembers = "Gelirler";
            chartTurler2.Series["Alışveriş"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Alışveriş"].YValueMembers = "Gelirler";
            chartTurler2.Series["Market"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Market"].YValueMembers = "Gelirler";
            chartTurler2.Series["Diğer"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Diğer"].YValueMembers = "Gelirler";
            chartTurler2.Series["Eğlence"].XValueMember = "GelirGiderTur";
            chartTurler2.Series["Eğlence"].YValueMembers = "Gelirler";
            chartTurler2.Series["Kira"]["PieLabelStyle"] = "Disabled";
            chartTurler2.Series["Maaş"]["PieLabelStyle"] = "Outside";
            chartTurler2.Series["Maaş"]["PieLineColor"] = "Black";
            chartTurler2.Series["Maaş"].Font = new Font("Oswald", 12, FontStyle.Bold);
            chartTurler2.Series["Maaş"].Label = "#PERCENT{P1}";
            chartTurler2.Series["Maaş"].LegendText = "#AXISLABEL";
            chartTurler2.Legends[0].Font = new Font("Oswald", 12, FontStyle.Bold);

            chartTurler2.DataSource = blc.GelirTureGoreGetir();
            chartTurler2.DataBind();
        }
        private void GiderlerPastaGrafik()
        {
            //Aşağıdaki kısımların tuhaf gözüktüğünün farkındayım, fakat yazış biçimi olarak denediğim diğer her şeyde chart'taki görüntüler açısından sorunla karşılaştım. 
            chartTurler.Series["Kira"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Kira"].YValueMembers = "Giderler";
            chartTurler.Series["Aidat"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Aidat"].YValueMembers = "Giderler";
            chartTurler.Series["Maaş"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Maaş"].YValueMembers = "Giderler";
            chartTurler.Series["Borsa"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Borsa"].YValueMembers = "Giderler";
            chartTurler.Series["Fatura"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Fatura"].YValueMembers = "Giderler";
            chartTurler.Series["Alışveriş"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Alışveriş"].YValueMembers = "Giderler";
            chartTurler.Series["Market"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Market"].YValueMembers = "Giderler";
            chartTurler.Series["Diğer"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Diğer"].YValueMembers = "Giderler";
            chartTurler.Series["Eğlence"].XValueMember = "GelirGiderTur";
            chartTurler.Series["Eğlence"].YValueMembers = "Giderler";
            chartTurler.Series["Kira"]["PieLabelStyle"] = "Disabled";
            chartTurler.Series["Kira"]["PieLabelStyle"] = "Outside";
            chartTurler.Series["Kira"]["PieLineColor"] = "Black";
            chartTurler.Series["Kira"].Font = new Font("Oswald", 12, FontStyle.Bold);
            chartTurler.Series["Kira"].Label = "#PERCENT{P1}";
            chartTurler.Series["Kira"].LegendText = "#AXISLABEL";
            chartTurler.Legends[0].Font = new Font("Oswald", 12, FontStyle.Bold);

            chartTurler.DataSource = blc.GiderTureGoreGetir();
            chartTurler.DataBind();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmParaYonetimi frmParaYonetimi = new FrmParaYonetimi();
            frmParaYonetimi.Show();
        }
    }
}
