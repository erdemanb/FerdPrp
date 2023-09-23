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
            chartAylar.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Oswald", 10, FontStyle.Bold);
            chartAylar.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Oswald", 10, FontStyle.Bold);
            chartAylar.ChartAreas[0].AxisX.Interval = 1;
            chartAylar.Series["Negatif"].Color = Color.Red;
            chartAylar.Series["Pozitif"].Color = Color.Green;
            chartAylar.Series["Toplam"].Color = Color.Blue;
            DataTable originalData = blc.NegatifMiktarlarToplamiGetir();
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
    }
}
