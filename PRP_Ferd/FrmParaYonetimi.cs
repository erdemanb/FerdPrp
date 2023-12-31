﻿using FerdBussiness;
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
    public partial class FrmParaYonetimi : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public FrmParaYonetimi()
        {
            InitializeComponent();

        }

        private void FrmParaYonetimi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frm = new FrmMain();
            frm.Show();
        }

        private void FrmParaYonetimi_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGelirGider frg = new FrmGelirGider();
            frg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGrafikler frg = new FrmGrafikler();  
            frg.Show();
        }
    }
}