using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;


struct Dane
{
    public int pomiar;
    public float natężenie;
}

namespace Zasilacz_warsztatowy
{
    public partial class Zasilacz_warsztatowy : Form
    {

        private Dane d;
        double OgrPrądowe = 0;

        public static int wielkość = 20; // int.Parse(cBoxPróbek.Text);
        double[] Pomiary = new double[wielkość];
        bool full = false;
        int akt_pomiar = 0;
        double maks = 0;
        bool połączono = false;

        public static Random r = new Random();
        float rand = 0;

        public static Zasilacz_warsztatowy Form1;
        public TextBox tb;
        public static string port_com;

        string linia;

        public void ustawOgrPr()
        {
            if (OgrPrądowe < 0) OgrPrądowe = 0;
            if (OgrPrądowe > 20) OgrPrądowe = 20;
            OgrTBox.Text = String.Format("{0:0.00}", OgrPrądowe);
            //OgrTBox.Text = (OgrPrądowe/100).ToString()+"."+ (OgrPrądowe%100).ToString();
            OgrScrBar.Value = (int)(OgrPrądowe * 100);
        }


        private void test_Click(object sender, EventArgs e)
        {

        }
        public void Wypełnij_wykres()
        {

            chV.Series["chV"].Points.Clear();

            if (full)
            {
                maks = 0;
                for (int i = 0; i < wielkość; i++)
                {
                    chV.Series["chV"].Points.AddXY(i, (Pomiary[(akt_pomiar + i + 1) % wielkość]) / 100);
                    if (maks < Pomiary[(akt_pomiar + i + 1) % wielkość]) { maks = Pomiary[(akt_pomiar + i + 1) % wielkość]; };

                }
                chV.ChartAreas[0].AxisY2.Maximum = maks / 100;

            }
            else
            {

                for (int i = 0; i <= akt_pomiar; i++)
                {
                    chV.Visible = true;
                    chV.Series["chV"].Points.AddXY(i, Pomiary[i] / 100);
                    chV.ChartAreas[0].AxisX.Crossing = i;
                    chV.ChartAreas[0].AxisX.Maximum = i;
                    //if (min > Pomiary[i]) { min = Pomiary[i]; };
                    if (maks < Pomiary[i]) { maks = Pomiary[i]; };


                }

            }

        }

        //void Ile_rekordów()
        //{
        //    StripStatus.Text = "Rekordów: " + lista.Count.ToString() + " (" + TimeSpan.FromSeconds(lista.Count).ToString() + ")";
        //}


        public Zasilacz_warsztatowy()
        {
            InitializeComponent();
            Form1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrScrBar.Value = (int)(100 * OgrPrądowe);
            OgrTBox.Text = String.Format("{0:0.00}", OgrPrądowe);
            AktualizujKomy();
            KonrtolkiPołącz();

            Form1.SetDesktopLocation((Screen.PrimaryScreen.Bounds.Width - Form1.Size.Width), 0);
            Form1.Height = Screen.PrimaryScreen.Bounds.Height-40;

            OgrL1.Enabled = false;
            OgrL10.Enabled = false;
            OgrL100.Enabled = false;
            OgrP1.Enabled = false;
            OgrP10.Enabled = false;
            OgrP100.Enabled = false;
            OgrScrBar.Enabled = false;
            OgrTBox.Enabled = false;

            chV.Visible = false;
        }

        public void AktualizujKomy()
        {
            cBoxPortCom.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cBoxPortCom.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                cBoxPortCom.Text = ports[0];
                połącz.Enabled = true;

            }
            else
            {
                cBoxPortCom.Text = "";
                połącz.Enabled = false;
            }
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            rand = r.Next(0, 200);
            Pomiary[akt_pomiar] = rand;
            tBoxTemp.Text += rand / 100 + ", ";
            Wypełnij_wykres();
            akt_pomiar = (++akt_pomiar) % wielkość;
            if (akt_pomiar == 0) full = true;
        }


        private void połącz_Click(object sender, EventArgs e)
        {
            if (!połączono)
            {
                Otworz_port();
            }
            else
            {
                Zamknij_port();
            }

        }

        void Otworz_port()
        {
            try
            {
                serialPort1.DtrEnable = false;
                serialPort1.RtsEnable = false;
                serialPort1.PortName = cBoxPortCom.Text;
                serialPort1.BaudRate = 38400;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = (StopBits)1;
                serialPort1.Parity = Parity.None;
                serialPort1.Open();
                KonrtolkiRozłącz();
            }
            catch (Exception err)
            {
                KonrtolkiPołącz();
                MessageBox.Show(err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void KonrtolkiRozłącz()
        {
            połącz.Text = "Rozłącz";
            połączono = true;
            rBtnON.Enabled = true;
            lblStatus.Text = "ON";
        }
        public void KonrtolkiPołącz()
        {
            połącz.Text = "Połącz";
            połączono = false;
            rBtnON.Enabled = false;
            lblStatus.Text = "OFF";
        }
        public void Zamknij_port()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                KonrtolkiPołącz();
            }
        }

        public void Konwertuj_dane()
        {
            byte temp;
            byte temp2;
            int xk;
            int x = 0;


            linia = tBoxTemp.Lines[x++];
            xk = Convert.ToInt32(linia) * 256;
            linia = tBoxTemp.Lines[x++];
            xk += Convert.ToInt32(linia);

            d.pomiar = 0;
            while (x < xk + 2)
            {

                linia = tBoxTemp.Lines[x++];

                temp = Convert.ToByte(linia);

                //Prędkość
                temp2 = (byte)(temp & 0b00000011);
                temp2 = (byte)(temp2 * 256);

                linia = tBoxTemp.Lines[x++];

                temp = Convert.ToByte(linia);
                temp2 += temp;
                d.natężenie = (float)temp2 / 10;

                d.pomiar++;
            }

        }

        public void Zgraj_dane()
        {
            byte dana;
            byte czyok;
            int adres = 0;

            if (serialPort1.IsOpen == false)
            {
                Otworz_port();
            }
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(new byte[] { 0b11001100 }, 0, 1);
                while (true)
                {
                    if (serialPort1.BytesToRead > 0)
                    {
                        if ((byte)serialPort1.ReadByte() == 51)
                        {
                            serialPort1.Write(new byte[] { 0b01010101 }, 0, 1);
                            break;
                        }
                    }
                }

                tb.Text = "";
                for (int i = 1; i > -1; i--)
                {
                    while (true)
                    {
                        if (serialPort1.BytesToRead > 0)
                        {
                            dana = (byte)serialPort1.ReadByte();
                            tb.Text += dana.ToString() + "\r\n";
                            serialPort1.Write(new byte[] { dana }, 0, 1);
                            break;
                        }
                    }
                    while (true)
                    {
                        if (serialPort1.BytesToRead > 0)
                        {
                            czyok = (byte)serialPort1.ReadByte();
                            if (czyok != 1)
                            {
                                i++;
                            }
                            else
                            {
                                adres += dana * (int)Math.Pow(256, i);
                            }
                            break;
                        }
                    }
                }


            }

        }

        private void OgrScrBar_Scroll(object sender, ScrollEventArgs e)
        {
            OgrPrądowe = (double)(OgrScrBar.Value) / 100;
            ustawOgrPr();
        }

        private void OgrP1_Click(object sender, EventArgs e)
        {
            OgrPrądowe += 0.01;
            ustawOgrPr();
        }

        private void OgrP10_Click(object sender, EventArgs e)
        {
            OgrPrądowe += 0.1;
            ustawOgrPr();
        }

        private void OgrP100_Click(object sender, EventArgs e)
        {
            OgrPrądowe += 1;
            ustawOgrPr();
        }

        private void OgrL1_Click(object sender, EventArgs e)
        {
            OgrPrądowe -= 0.01;
            ustawOgrPr();
        }

        private void OgrL10_Click(object sender, EventArgs e)
        {
            OgrPrądowe -= 0.1;
            ustawOgrPr();
        }

        private void OgrL100_Click(object sender, EventArgs e)
        {
            OgrPrądowe -= 1;
            ustawOgrPr();
        }

        private void OgrCBox_Click(object sender, EventArgs e)
        {
            if (OgrCBox.Checked)
            {
                OgrL1.Enabled = true;
                OgrL10.Enabled = true;
                OgrL100.Enabled = true;
                OgrP1.Enabled = true;
                OgrP10.Enabled = true;
                OgrP100.Enabled = true;
                OgrScrBar.Enabled = true;
                OgrTBox.Enabled = true;
            }
            else
            {
                OgrL1.Enabled = false;
                OgrL10.Enabled = false;
                OgrL100.Enabled = false;
                OgrP1.Enabled = false;
                OgrP10.Enabled = false;
                OgrP100.Enabled = false;
                OgrScrBar.Enabled = false;
                OgrTBox.Enabled = false;
            }
        }


        private void OgrTBox_KeyUp(object sender, KeyEventArgs e)
        {
            OgrTBox.Text = OgrTBox.Text.Replace(".", ",");
            if (double.TryParse(OgrTBox.Text, out double temp))
            {
                OgrPrądowe = temp;

                if (OgrPrądowe > 99)
                {
                    OgrPrądowe = temp / 10;
                    OgrTBox.Text = String.Format("{0:0.0}", OgrPrądowe);
                }
                if (OgrPrądowe > 20 && OgrTBox.Text.Length < 5)
                {
                    OgrPrądowe /= 10;
                    OgrTBox.Text = OgrPrądowe.ToString();
                }
                else if (OgrPrądowe > 20 && OgrTBox.Text.Length > 4)
                {
                    OgrPrądowe = 20;
                    OgrTBox.Text = String.Format("{0:0.00}", OgrPrądowe);
                }
            }
            else
            {
                OgrTBox.Text = String.Format("{0:0.00}", OgrPrądowe);
            }
            if (OgrPrądowe < 10 && OgrTBox.Text.Length > 4)
            {
                OgrPrądowe = Math.Round(OgrPrądowe - 0.005, 2);
                OgrTBox.Text = String.Format("{0:0.00}", OgrPrądowe);
            }
            OgrTBox.Select(OgrTBox.Text.Length, 0);
            tBoxTemp.Text += OgrPrądowe + " ";
            OgrScrBar.Value = (int)OgrPrądowe * 100;
        }

        private void cBoxPortCom_MouseDown(object sender, MouseEventArgs e)
        {
            AktualizujKomy();
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            wielkość = int.Parse(cBoxPróbek.Text);
        }
    }
}
