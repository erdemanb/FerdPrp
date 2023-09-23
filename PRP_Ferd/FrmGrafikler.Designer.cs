namespace PRP_Ferd
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartAylar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartAylar)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAylar
            // 
            this.chartAylar.BackColor = System.Drawing.Color.Transparent;
            this.chartAylar.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartAylar.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Miktar";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartAylar.Legends.Add(legend1);
            this.chartAylar.Location = new System.Drawing.Point(12, 124);
            this.chartAylar.Name = "chartAylar";
            this.chartAylar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Miktar";
            series1.Name = "Toplam";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.IndianRed;
            series2.Legend = "Miktar";
            series2.Name = "Negatif";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series3.IsValueShownAsLabel = true;
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.LabelForeColor = System.Drawing.Color.ForestGreen;
            series3.Legend = "Miktar";
            series3.Name = "Pozitif";
            this.chartAylar.Series.Add(series1);
            this.chartAylar.Series.Add(series2);
            this.chartAylar.Series.Add(series3);
            this.chartAylar.Size = new System.Drawing.Size(1202, 377);
            this.chartAylar.TabIndex = 2;
            this.chartAylar.TabStop = false;
            this.chartAylar.Text = "chartAylar";
            title1.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "Aylar\'a Göre Gelir Gider Grafiği";
            title1.Text = "Aylar\'a Göre Gelir-Gider Grafiği";
            this.chartAylar.Titles.Add(title1);
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 793);
            this.Controls.Add(this.chartAylar);
            this.Name = "FrmGrafikler";
            this.Text = "FrmGrafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGrafikler_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.chartAylar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAylar;
    }
}