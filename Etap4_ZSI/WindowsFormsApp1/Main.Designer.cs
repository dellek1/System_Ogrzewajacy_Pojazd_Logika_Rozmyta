namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Ust_temp = new System.Windows.Forms.Label();
            this.Wyb_scenariusza = new System.Windows.Forms.Label();
            this.Obraz = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Wykres1 = new System.Windows.Forms.Button();
            this.Wykres2 = new System.Windows.Forms.Button();
            this.Temp_zew = new System.Windows.Forms.Label();
            this.Wiosna = new System.Windows.Forms.CheckBox();
            this.Lato = new System.Windows.Forms.CheckBox();
            this.Jesien = new System.Windows.Forms.CheckBox();
            this.Zima = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Temperatura_zadana = new System.Windows.Forms.Label();
            this.Zmiana_tempLB = new System.Windows.Forms.Label();
            this.TempWEWCHART = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TempZEWchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempWEWCHART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempZEWchart)).BeginInit();
            this.SuspendLayout();
            // 
            // Ust_temp
            // 
            this.Ust_temp.AutoSize = true;
            this.Ust_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ust_temp.Location = new System.Drawing.Point(437, 2);
            this.Ust_temp.Name = "Ust_temp";
            this.Ust_temp.Size = new System.Drawing.Size(258, 24);
            this.Ust_temp.TabIndex = 0;
            this.Ust_temp.Text = "Ustaw temperaturę docelową:";
            this.Ust_temp.Click += new System.EventHandler(this.Ust_temp_Click);
            // 
            // Wyb_scenariusza
            // 
            this.Wyb_scenariusza.AutoSize = true;
            this.Wyb_scenariusza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyb_scenariusza.Location = new System.Drawing.Point(437, 126);
            this.Wyb_scenariusza.Name = "Wyb_scenariusza";
            this.Wyb_scenariusza.Size = new System.Drawing.Size(169, 24);
            this.Wyb_scenariusza.TabIndex = 1;
            this.Wyb_scenariusza.Text = "Wybierz porę roku:";
            this.Wyb_scenariusza.Click += new System.EventHandler(this.Wyb_scenariusza_Click);
            // 
            // Obraz
            // 
            this.Obraz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Obraz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Obraz.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Obraz.Image = ((System.Drawing.Image)(resources.GetObject("Obraz.Image")));
            this.Obraz.Location = new System.Drawing.Point(12, 2);
            this.Obraz.Name = "Obraz";
            this.Obraz.Size = new System.Drawing.Size(402, 229);
            this.Obraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obraz.TabIndex = 4;
            this.Obraz.TabStop = false;
            this.Obraz.UseWaitCursor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBar1.Location = new System.Drawing.Point(441, 35);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(635, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Wykres1
            // 
            this.Wykres1.BackColor = System.Drawing.SystemColors.Info;
            this.Wykres1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wykres1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wykres1.Location = new System.Drawing.Point(888, 237);
            this.Wykres1.Name = "Wykres1";
            this.Wykres1.Size = new System.Drawing.Size(188, 73);
            this.Wykres1.TabIndex = 5;
            this.Wykres1.Text = "Temperatura wewnątrz samochodu";
            this.Wykres1.UseVisualStyleBackColor = false;
            this.Wykres1.Click += new System.EventHandler(this.Wykres1_Click);
            // 
            // Wykres2
            // 
            this.Wykres2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Wykres2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wykres2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wykres2.Location = new System.Drawing.Point(888, 474);
            this.Wykres2.Name = "Wykres2";
            this.Wykres2.Size = new System.Drawing.Size(188, 73);
            this.Wykres2.TabIndex = 6;
            this.Wykres2.Text = "Temperatura na zewnątrz samochodu";
            this.Wykres2.UseVisualStyleBackColor = false;
            this.Wykres2.Click += new System.EventHandler(this.Wykres2_Click);
            // 
            // Temp_zew
            // 
            this.Temp_zew.AutoSize = true;
            this.Temp_zew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Temp_zew.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Temp_zew.Location = new System.Drawing.Point(325, 11);
            this.Temp_zew.Name = "Temp_zew";
            this.Temp_zew.Size = new System.Drawing.Size(37, 40);
            this.Temp_zew.TabIndex = 14;
            this.Temp_zew.Text = "0";
            this.Temp_zew.Click += new System.EventHandler(this.Temp_zew_Click);
            // 
            // Wiosna
            // 
            this.Wiosna.AutoSize = true;
            this.Wiosna.BackColor = System.Drawing.Color.Transparent;
            this.Wiosna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wiosna.ForeColor = System.Drawing.Color.Black;
            this.Wiosna.Location = new System.Drawing.Point(612, 131);
            this.Wiosna.Name = "Wiosna";
            this.Wiosna.Size = new System.Drawing.Size(73, 20);
            this.Wiosna.TabIndex = 15;
            this.Wiosna.Text = "Wiosna";
            this.Wiosna.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Wiosna.UseVisualStyleBackColor = false;
            this.Wiosna.CheckedChanged += new System.EventHandler(this.Wiosna_CheckedChanged);
            // 
            // Lato
            // 
            this.Lato.AutoSize = true;
            this.Lato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lato.Location = new System.Drawing.Point(697, 131);
            this.Lato.Name = "Lato";
            this.Lato.Size = new System.Drawing.Size(53, 20);
            this.Lato.TabIndex = 16;
            this.Lato.Text = "Lato";
            this.Lato.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Lato.UseVisualStyleBackColor = true;
            this.Lato.CheckedChanged += new System.EventHandler(this.Lato_CheckedChanged);
            // 
            // Jesien
            // 
            this.Jesien.AutoSize = true;
            this.Jesien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jesien.Location = new System.Drawing.Point(768, 131);
            this.Jesien.Name = "Jesien";
            this.Jesien.Size = new System.Drawing.Size(67, 20);
            this.Jesien.TabIndex = 18;
            this.Jesien.Text = "Jesien";
            this.Jesien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Jesien.UseVisualStyleBackColor = true;
            this.Jesien.CheckedChanged += new System.EventHandler(this.Jesien_CheckedChanged);
            // 
            // Zima
            // 
            this.Zima.AutoSize = true;
            this.Zima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zima.Location = new System.Drawing.Point(853, 131);
            this.Zima.Name = "Zima";
            this.Zima.Size = new System.Drawing.Size(57, 20);
            this.Zima.TabIndex = 19;
            this.Zima.Text = "Zima";
            this.Zima.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Zima.UseVisualStyleBackColor = true;
            this.Zima.CheckedChanged += new System.EventHandler(this.Zima_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.richTextBox1.Location = new System.Drawing.Point(12, 237);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(402, 437);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Temperatura_zadana
            // 
            this.Temperatura_zadana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Temperatura_zadana.Location = new System.Drawing.Point(693, 2);
            this.Temperatura_zadana.Name = "Temperatura_zadana";
            this.Temperatura_zadana.Size = new System.Drawing.Size(35, 24);
            this.Temperatura_zadana.TabIndex = 21;
            this.Temperatura_zadana.Text = "0";
            this.Temperatura_zadana.Click += new System.EventHandler(this.Temperatura_zadana_Click);
            // 
            // Zmiana_tempLB
            // 
            this.Zmiana_tempLB.AutoSize = true;
            this.Zmiana_tempLB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Zmiana_tempLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zmiana_tempLB.Location = new System.Drawing.Point(181, 109);
            this.Zmiana_tempLB.Name = "Zmiana_tempLB";
            this.Zmiana_tempLB.Size = new System.Drawing.Size(20, 24);
            this.Zmiana_tempLB.TabIndex = 24;
            this.Zmiana_tempLB.Text = "0";
            // 
            // TempWEWCHART
            // 
            this.TempWEWCHART.BackColor = System.Drawing.SystemColors.ControlDark;
            chartArea5.Name = "ChartArea1";
            this.TempWEWCHART.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.TempWEWCHART.Legends.Add(legend5);
            this.TempWEWCHART.Location = new System.Drawing.Point(420, 237);
            this.TempWEWCHART.Name = "TempWEWCHART";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.LegendText = "Temp";
            series5.Name = "Temp";
            this.TempWEWCHART.Series.Add(series5);
            this.TempWEWCHART.Size = new System.Drawing.Size(453, 199);
            this.TempWEWCHART.TabIndex = 0;
            this.TempWEWCHART.Text = "TempWEWCHART";
            // 
            // TempZEWchart
            // 
            this.TempZEWchart.BackColor = System.Drawing.SystemColors.ControlDark;
            chartArea6.Name = "ChartArea1";
            this.TempZEWchart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.TempZEWchart.Legends.Add(legend6);
            this.TempZEWchart.Location = new System.Drawing.Point(429, 474);
            this.TempZEWchart.Name = "TempZEWchart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Temp";
            series6.YValuesPerPoint = 4;
            this.TempZEWchart.Series.Add(series6);
            this.TempZEWchart.Size = new System.Drawing.Size(453, 200);
            this.TempZEWchart.TabIndex = 0;
            this.TempZEWchart.Text = "chart1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1240, 751);
            this.Controls.Add(this.TempZEWchart);
            this.Controls.Add(this.Zmiana_tempLB);
            this.Controls.Add(this.TempWEWCHART);
            this.Controls.Add(this.Temperatura_zadana);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Zima);
            this.Controls.Add(this.Jesien);
            this.Controls.Add(this.Lato);
            this.Controls.Add(this.Wiosna);
            this.Controls.Add(this.Temp_zew);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Wykres2);
            this.Controls.Add(this.Wykres1);
            this.Controls.Add(this.Obraz);
            this.Controls.Add(this.Wyb_scenariusza);
            this.Controls.Add(this.Ust_temp);
            this.Name = "Main";
            this.Text = "Automatyczny System Ogrzewania Pojazdu (Logika Rozmyta)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempWEWCHART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempZEWchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ust_temp;
        private System.Windows.Forms.Label Wyb_scenariusza;
        private System.Windows.Forms.PictureBox Obraz;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Wykres1;
        private System.Windows.Forms.Button Wykres2;
        public System.Windows.Forms.Label Temp_zew;
        private System.Windows.Forms.CheckBox Wiosna;
        private System.Windows.Forms.CheckBox Lato;
        private System.Windows.Forms.CheckBox Jesien;
        private System.Windows.Forms.CheckBox Zima;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label Temperatura_zadana;
        public System.Windows.Forms.Label Zmiana_tempLB;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempWEWCHART;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempZEWchart;
    }
}

