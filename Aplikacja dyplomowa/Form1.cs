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
        private List<Dane> lista = new List<Dane>();

        public static int wielkość = 5;
        double[] Pomiary = new double[wielkość];
        bool full = false;
        int akt_pomiar = 0;
        double min = 2500;
        double maks = 0;
        bool połączono = false;

        public static Random r = new Random();
        float rand = 0;

        public static Zasilacz_warsztatowy Form1;
        public TextBox tb;
        public static string port_com = "";

        string linia;
        bool wgrane = false;

        int temp;

        private void button1_Click(object sender, EventArgs e)
        {
            chV.ChartAreas[0].Position=new System.Windows.Forms.DataVisualization.Charting.ElementPosition(5, 10, 80, 100);
        }
        public void Wypełnij_wykres()
        {

            chV.Series["chV"].Points.Clear();

            if (full)
            {
                min = 2500;
                maks = 0;
                for (int i = 0; i < wielkość; i++)
                {
                    chV.Series["chV"].Points.AddXY(i, (Pomiary[(akt_pomiar + i + 1) % wielkość]) / 100);
                    if (min > Pomiary[(akt_pomiar + i + 1) % wielkość]) { min = Pomiary[(akt_pomiar + i + 1) % wielkość]; };
                    if (maks < Pomiary[(akt_pomiar + i + 1) % wielkość]) { maks = Pomiary[(akt_pomiar + i + 1) % wielkość]; };

                }
                chV.ChartAreas[0].AxisY.Minimum = min / 100;
                chV.ChartAreas[0].AxisY.Maximum = maks / 100;

                chV.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                chV.ChartAreas[0].AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
                chV.ChartAreas[0].AxisY2.Minimum = min / 100;
                chV.ChartAreas[0].AxisY2.Maximum = maks / 100;
                chV.ChartAreas[0].AxisY2.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45;
                //chV.ChartAreas[0].AxisY2.LabelStyle=
                //chV.ChartAreas[0].AxisY2.
            }
            else
            {

                for (int i = 0; i <= akt_pomiar; i++)
                {
                    chV.Series["chV"].Points.AddXY(i, Pomiary[i] / 100);
                    chV.ChartAreas[0].AxisX.Crossing = i + 2;
                    if (min > Pomiary[i]) { min = Pomiary[i]; };
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
            cBoxPortCom.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cBoxPortCom.Items.AddRange(ports);
            Form1.SetDesktopLocation((Screen.PrimaryScreen.Bounds.Width - Form1.Size.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - Form1.Size.Height) / 2);

        }
        private void dodaj_Click(object sender, EventArgs e)
        {
            rand = r.Next(0, 200);
            Pomiary[akt_pomiar] = rand;
            tBoxTemp.Text += rand / 100 + "\r\n";
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
                połącz.Text = "Rozłącz";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rBtnON.Enabled = false;
                lblStatus.Text = "OFF";
            }
        }

        public void Zamknij_port()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                połącz.Text = "Połącz";
            }
        }

        public void Konwertuj_dane()
        {
            byte temp;
            byte temp2;
            int xk;
            int x = 0;

            if (lista.Count != 0) lista.Clear();

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


                lista.Add(d);
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


    }
}