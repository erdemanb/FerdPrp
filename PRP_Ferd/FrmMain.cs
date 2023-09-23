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

namespace PRP_Ferd
{
    public partial class FrmMain : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Bussiness blmain = new Bussiness();
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnYapilacaklar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmYapilacaklar fry = new FrmYapilacaklar();
            fry.Show();
        }


        private void btnParaYonetimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmParaYonetimi frp = new FrmParaYonetimi();
            frp.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
