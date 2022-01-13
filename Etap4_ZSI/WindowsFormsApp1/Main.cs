using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    using System.Windows.Forms.VisualStyles;

    public partial class Main : Form
    {
        int tab_size = 100;
        float wyjscie; 
        float Wynik;
        bool start = true;

        public Main()
        {
            InitializeComponent();
            createFrame();
        }

        public async Task GenerujTemperature_Wiosna()
        {
            int TheInt;
            bool ok;
            int[] tab_temperatury = File.ReadLines(@"Wiosna.txt")
                .Select(n =>
                {
                    ok = int.TryParse(n, out TheInt);
                    return new { TheInt, ok };
                })
                .Where(x => x.ok)
                .Select(x => x.TheInt).ToArray();
            for (int i = 1; i < tab_size; i++)
            {
                await Task.Delay(500);

                Temp_zew.Text = tab_temperatury[i].ToString();


                Rozmycie();
            }
        }

        public async Task GenerujTemperature_Lato()
        {
            int TheInt;
            bool ok;
            int[] tab_temperatury = File.ReadLines(@"Lato.txt")
                .Select(n =>
                {
                    ok = int.TryParse(n, out TheInt);
                    return new { TheInt, ok };
                })
                .Where(x => x.ok)
                .Select(x => x.TheInt).ToArray();
            for (int i = 1; i < tab_size; i++)
            {
                await Task.Delay(500);

                Temp_zew.Text = tab_temperatury[i].ToString();

                Rozmycie();
            }
        }

        public async Task GenerujTemperature_Jesien()
        {
            int TheInt;
            bool ok;
            int[] tab_temperatury = File.ReadLines(@"Jesien.txt")
                .Select(n =>
                {
                    ok = int.TryParse(n, out TheInt);
                    return new { TheInt, ok };
                })
                .Where(x => x.ok)
                .Select(x => x.TheInt).ToArray();
            for (int i = 1; i < tab_size; i++)
            {
                await Task.Delay(500);

                Temp_zew.Text = tab_temperatury[i].ToString();

                Rozmycie();
            }
        }

        public async Task GenerujTemperature_Zima()
        {
            int TheInt;
            bool ok;
            int[] tab_temperatury = File.ReadLines(@"Zima.txt")
                .Select(n =>
                {
                    ok = int.TryParse(n, out TheInt);
                    return new { TheInt, ok };
                })
                .Where(x => x.ok)
                .Select(x => x.TheInt).ToArray();
            for (int i = 1; i < tab_size; i++)
            {
                await Task.Delay(500); 

                Temp_zew.Text = tab_temperatury[i].ToString();
                Rozmycie();
            }
        }

        void createFrame()
        {
        }
        private void Lista_scenariusza_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TempWEWCHART.Visible = false;
            TempZEWchart.Visible = false;
        }

        private void Temperatura_wew_TextChanged(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Ust_temp_Click(object sender, EventArgs e)
        {
        }

        private void Wyb_scenariusza_Click(object sender, EventArgs e)
        {
        }

        private void tempPokoju_Click(object sender, EventArgs e)
        {
        }

        private void Temp_zew_Click(object sender, EventArgs e)
        {
        }

        private void Wiosna_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                wyjscie = 8;
                start = false;
            }

            if (Wiosna.Checked == true)
            {
                GenerujTemperature_Wiosna();
            }
        }

        private void Lato_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                wyjscie = 15;
                start = false;
            }

            if (Lato.Checked == true)
            {
                GenerujTemperature_Lato();
            }
        }

        private void Jesien_CheckedChanged(object sender, EventArgs e)
        {
            if (start)
            {
                wyjscie = 10;
                start = false;
            }

            if (Jesien.Checked == true)
            {
                GenerujTemperature_Jesien();
            }
        }

        private void Zima_CheckedChanged(object sender, EventArgs e)
        {
            int tzad = trackBar1.Value;
            if (start && tzad < 20)
            {
                wyjscie = 0;
                start = false;
            }
            else if (start && tzad >= 20)
            {
                wyjscie = 8;
                start = false;
            }

            if (Zima.Checked == true)
            {
                GenerujTemperature_Zima();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Temperatura_zadana.Text = trackBar1.Value.ToString();
        }

        private void Scenariusz_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Temperatura_zadana_Click(object sender, EventArgs e)
        {
        }


        private void Zmiana_tempTBX_TextChanged(object sender, EventArgs e)
        {
        }

        public void Rozmycie()
        {
            int tzew = Convert.ToInt32(Temp_zew.Text);
            int tzad = trackBar1.Value;
            float temp = tzad - wyjscie;
            float uBardzoZimno = 0.00f;
            float uZimno = 0.00f;
            float uChlodno = 0.00f;
            float uSrednio = 0.00f;
            float uLetnio = 0.00f;
            float uCieplo = 0.00f;
            float uGoraco = 0.00f;

            //POCZĄTEK SYSTEMU ROZMYTEGO

            // Bardzo zimno
            if (temp >= 40.00f)
            {
                uBardzoZimno = 1.00f;
            }        //x       x2        x       b    

            else if (temp >= 35.00f && temp <= 37.00f)
            {                   // b       x        b       x2
                uBardzoZimno = (37.00f - temp) / (37.00f - 35.00f);
            }
            else
            {
                uBardzoZimno = 0.00f;
            }

            // Zimno 
            if (temp >= 34.00f && temp <= 36.00f)
            {
                uZimno = (temp - 36.00f) / (34.00f - 36.00f);
            }
            else if (temp >= 31.00f && temp <= 34.00f)
            {
                uZimno = 1.00f;
            }
            else if (temp >= 29.00f && temp < 31.00f)
            {
                uZimno = (29.00f - temp) / (29.00f - 31.00f);
            }
            else
            {
                uZimno = 0.00f;
            }

            // Chlodno 
            if (temp >= 28.00f && temp <= 30.00f)
            {
                uChlodno = (temp - 30.00f) / (28.00f - 30.00f);
            }
            else if (temp >= 25.00f && temp <= 28.00f)
            {
                uChlodno = 1.00f;
            }
            else if (temp >= 23.00f && temp < 25.00f)
            {
                uChlodno = (23.00f - temp) / (23.00f - 25.00f);
            }
            else
            {
                uChlodno = 0.00f;
            }

            // Srednio 
            if (temp >= 22.00f && temp <= 24.00f)
            {
                uSrednio = (temp - 24.00f) / (22.00f - 24.00f);
            }
            else if (temp >= 19.00f && temp <= 22.00f)
            {
                uSrednio = 1.00f;
            }
            else if (temp >= 17.00f && temp < 19.00f)
            {
                uSrednio = (17.00f - temp) / (17.00f - 19.00f);
            }
            else
            {
                uSrednio = 0.00f;
            }

            // Letnio 
            if (temp >= 16.00f && temp <= 18.00f)
            {
                uLetnio = (temp - 18.00f) / (16.00f - 18.00f);
            }
            else if (temp >= 13.00f && temp <= 16.00f)
            {
                uLetnio = 1.00f;
            }
            else if (temp >= 11.00f && temp < 13.00f)
            {
                uLetnio = (11.00f - temp) / (11.00f - 13.00f);
            }
            else
            {
                uLetnio = 0.00f;
            }

            // Cieplo 
            if (temp >= 10.00f && temp <= 12.00f)
            {
                uCieplo = (temp - 12.00f) / (10.00f - 12.00f);
            }
            else if (temp >= 7.00f && temp <= 10.00f)
            {
                uCieplo = 1.00f;
            }
            else if (temp >= 5.00f && temp < 7.00f)
            {
                uCieplo = (5.00f - temp) / (5.00f - 7.00f);
            }
            else
            {
                uCieplo = 0.00f;
            }

            //Goraco
            if (temp >= 4.00f && temp <= 6.00f)
            {
                uGoraco = (temp - 6.00f) / (4.00f - 6.00f);
            }
            else if (temp >= 0.00f && temp <= 4.00f)
            {
                uGoraco = 1.00f;
            }
            else
            {
                uGoraco = 0.00f;
            }

            float L = 0.00f;
            float M = 0.00f;

            for (float i = -20; i < 20; i++)
            {
                // Wnioskowanie
                //MIN-przycięcie (CZĘŚĆ WSPÓLNA ZBIORÓW)
                //MAX-suma (SUMA LOGICZNA ZBIORÓW)
                float R1 = Math.Min(uBardzoZimno, ogrzewanieBardzoWysokie(i)); //IF temp = BARDZO ZIMNO THEN OGRZEWANIE = BARDZO WYSOKIE
                float R2 = Math.Min(uZimno, ogrzewanieWysokie(i));             //IF temp = ZIMNO THEN OGRZEWANIE = WYSOKIE
                float R3 = Math.Min(uChlodno, ogrzewanieNiecoWysokie(i));      //IF temp = CHLODNO THEN OGRZEWANIE = NIECO WYSOKIE
                float R4 = Math.Min(uSrednio, ogrzewanieSrednie(i));           //IF temp = SREDNIO THEN OGRZEWANIE = SREDNIE
                float R5 = Math.Min(uLetnio, ogrzewanieNiecoSrednie(i));       //IF temp = LETNIO THEN OGRZEWANIE = NIECO SREDNIE
                float R6 = Math.Min(uCieplo, ogrzewanieNiskie(i));             //IF temp = CIEPLO THEN OGRZEWANIE = NISKIE
                float R7 = Math.Min(uGoraco, ogrzewanieBardzoNiskie(i));       //IF temp = GORACO THEN OGRZEWANIE = BARDZO NISKIE

                Wynik = Math.Max(Math.Max(Math.Max(R1, R2), Math.Max(R3, R4)), Math.Max(Math.Max(R5, R6), Math.Max(R7, 0)));

                // Wyostrzanie
                L += Wynik * i + 0.01f; 
                M += Wynik;
            }
                float wyostrzony = 0.00f;
                wyostrzony = (L / M); 

                Ogrzewanie(wyostrzony, tzad, tzew);
                Przenikanie(wyjscie, tzew);    
                WykresTwew();
        }

        public float ogrzewanieBardzoWysokie(float r) //roznica - o ile system ogrzewania ma się podkręcić/zmniejszyć
        {
            if (r == -20)
            {
                return 1.0f;
            }
            else
            {
                return 0;
            }
        }

        public float ogrzewanieWysokie(float r) 
        {
            if (r == -15)
            {
                return 1.0f;
            }
            else
            {
                return 0;
            }
        }

        public float ogrzewanieNiecoWysokie(float r) 
        {
            if (r == -10)
            {
                return 1.0f;
            }
            else
            {
                return 0;
            }
        }

        public float ogrzewanieSrednie(float r) 
        {
            if (r == 0)
            {
                return 1.0f;
            }
            else
            {
                return 0;
            }
        }

        public float ogrzewanieNiecoSrednie(float r) 
        {
            if (r == 10)
            {
                return 1.0f;
            }
            else
            {
                return 0;
            }
        }

        public float ogrzewanieNiskie(float r) 
        {
            if (r == 15)
            {
                return 1.0f;
            }
            else
            {
                return 0;
            }
        }

        public float ogrzewanieBardzoNiskie(float r) 
        {
            if (r == 20)
            {
                return 1.0f;
            }
            else
            {
                return 0;
            }
        }

        public void Przenikanie(float wyjscie, int tzew)
        {
            if (wyjscie > tzew)
            {
                wyjscie = wyjscie - 0.5f; 
            }
            else
            {
                wyjscie = wyjscie + 0.5f; 
            }
            wyjscie += 5f;

            richTextBox1.AppendText("Temperatura w stopniach Celsjusza w aucie: " + wyjscie.ToString() + "\n");
            Zmiana_tempLB.Text = wyjscie.ToString();
        }

        public void Ogrzewanie(float wyostrzony, int tzad, int tzew)
        {
            wyostrzony *= 10f;
            float value = 0.00f;
            if (wyjscie < tzad)
            {
                value = (tzad / wyostrzony);
                wyjscie = wyjscie + value * Correcting(tzad);
            }
            else if (wyjscie > tzew)
            {
                wyostrzony = (wyjscie - tzad) - wyostrzony;
                wyjscie = wyjscie - wyostrzony * Correcting(tzad);
            }

        }

        public void WykresTwew()
        {
            float x = float.Parse(Zmiana_tempLB.Text);
            float x1 = float.Parse(Temp_zew.Text);
            int y = 0;

                TempWEWCHART.Series["Temp"].Points.AddXY(y, x);
                TempZEWchart.Series["Temp"].Points.AddXY(y, x1);
        }



        private void Wykres1_Click(object sender, EventArgs e)
        {
            TempWEWCHART.Visible = true;
        }

        private void Wykres2_Click(object sender, EventArgs e)
        {
            TempZEWchart.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public float Correcting(int tzad)
        {
            float correctValue = 0;

            if (tzad < 5)
            {
                correctValue = 0.01f * 100.00f;
            }
            else if (tzad < 10)
            {
                correctValue = 0.04f * 100.00f;
            }
            else if (tzad < 20)
            {
                correctValue = 0.06f * 100.00f;
            }
            else if (tzad < 30)
            {
                correctValue = 0.1f * 100.00f;
            }

            return correctValue / 2;
        }
    }
}