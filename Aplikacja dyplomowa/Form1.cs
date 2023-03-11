using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;


struct Dane
{
    public int sekunda;
    public float natężenie;
}

namespace Zasilacz_warsztatowy
{
    public partial class Zasilacz_warsztatowy : Form
    {
        private Dane d;
        private List<Dane> lista = new List<Dane>();

        public static Zasilacz_warsztatowy Form1;
        public TextBox tb;
        public static string port_com = "";

        string linia;
        bool wgrane = false;

        int temp;

        public void Wypełnij_wykresy()
        {
            
            chV.Series["chV"].Points.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                chV.Series["chV"].Points.AddXY(lista[i].sekunda, lista[i].natężenie);

            }

            //czas
            Ile_rekordów();

            chV.Visible = true;
            PanelTylny.Visible = true;

        }
        void Ile_rekordów()
        {
            StripStatus.Text = "Rekordów: " + lista.Count.ToString() + " (" + TimeSpan.FromSeconds(lista.Count).ToString() + ")";
        }


        public Zasilacz_warsztatowy()
        {
            InitializeComponent();
            Form1 = this;
            tb = tBoxTemp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxPortCom.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cBoxPortCom.Items.AddRange(ports);
            Form1.SetDesktopLocation((Screen.PrimaryScreen.Bounds.Width - Form1.Size.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - Form1.Size.Height) / 2);

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

            d.sekunda = 0;
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
                d.sekunda++;
            }

        }

        void Wartosc_chwilowa(int x, int y)
        {
            if (wgrane)
            {
                Point Punkt_myszy = new Point(x, y);




                chV.ChartAreas[0].CursorX.Interval = 1;
                chV.ChartAreas[0].CursorY.Interval = 0;

                chV.ChartAreas[0].CursorX.SetCursorPixelPosition(Punkt_myszy, true);
                //chV.ChartAreas[0].CursorY.SetCursorPixelPosition(Punkt_myszy, true);


                //chV.ChartAreas[0].CursorY.SetCursorPixelPosition(Punkt_myszy, true);

                //textx.Text = "x: " + String.Format("{0:N0}", chV.ChartAreas[0].AxisX.PixelPositionToValue(e.X));
                //texty.Text = "y: " + String.Format("{0:N1}", chV.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));

                temp = (int)(chV.ChartAreas[0].AxisX.PixelPositionToValue(x));

                //    temp3 = (int)(chV.ChartAreas[0].AxisX.PixelPositionToValue(0));
                //    MessageBox.Show("Exception: " + ex.Message);
                //}
                if (temp < 0) temp = 0;
                if (temp >= lista.Count) temp = lista.Count - 1;

                StripStatus.Text = TimeSpan.FromSeconds(temp).ToString() + "  Prędkość: " + String.Format("{0:N1}", lista[temp].natężenie);



                //HitTestResult wynik = chV.HitTest(x, y);

                //if (wynik.PointIndex > -1 && wynik.ChartArea != null)
                //{
                //    punktx.Text = String.Format("{0:N1}", wynik.Series.Points[wynik.PointIndex].XValue);
                //    punkty.Text = String.Format("{0:N1}", wynik.Series.Points[wynik.PointIndex].YValues[0]);
            }
        }
        private void chV_MouseMove(object sender, MouseEventArgs e)
        {
            Wartosc_chwilowa(e.X, e.Y);
        }


        private void chV_MouseLeave(object sender, EventArgs e)
        {
            Ile_rekordów();
            wgrane = true;
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