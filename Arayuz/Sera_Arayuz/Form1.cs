using Syncfusion.Windows.Forms.Tools;
using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sera_Arayuz
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort = new SerialPort();

        public Form1()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWH5cdnRRQmNZUUF0WkU=");
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            comboBoxCOMPorts.Items.AddRange(ports);

            serialPort = new SerialPort();

            InitializeCharts();
        }

        private void InitializeCharts()
        {
            chartSicaklik.Series.Clear();
            Series seriesSicaklik = new Series("Sýcaklýk");
            seriesSicaklik.ChartType = SeriesChartType.Line;
            chartSicaklik.Series.Add(seriesSicaklik);

            chartNem.Series.Clear();
            Series seriesNem = new Series("Nem");
            seriesNem.ChartType = SeriesChartType.Line;
            chartNem.Series.Add(seriesNem);

            chartToprakNem.Series.Clear();
            Series seriesToprakNem = new Series("Toprak Nem");
            seriesToprakNem.ChartType = SeriesChartType.Line;
            chartToprakNem.Series.Add(seriesToprakNem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxCOMPorts.SelectedItem != null)
            {
                string selectedPort = comboBoxCOMPorts.SelectedItem.ToString();
                serialPort = new SerialPort(selectedPort, 9600);

                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                MessageBox.Show("Baðlantý Baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir COM port seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Baðlantý Kesildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();
                string[] sensorValues = data.Split(',');
                Debug.WriteLine("Gelen veri: " + data);

                if (sensorValues.Length >= 7)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        double suVeri, gazVeri, fanHiz, ledParlaklik;

                        if (double.TryParse(sensorValues[3], out suVeri))
                            progressBarSu.Value = (int)suVeri;

                        if (double.TryParse(sensorValues[4], out gazVeri))
                            progressBarGaz.Value = (int)gazVeri;

                        if (double.TryParse(sensorValues[5], out fanHiz))
                            trackBarFanHiz.Value = (int)fanHiz;

                        if (double.TryParse(sensorValues[6], out ledParlaklik))
                            trackBarLedParlaklik.Value = (int)ledParlaklik;

                        UpdateCharts(sensorValues[0], sensorValues[1], sensorValues[2]);
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri iþleme hatasý: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int xAxisCounter = 0;

        private void UpdateCharts(string sicaklik, string nem, string toprakNem)
        {
            try
            {
                chartSicaklik.Series[0].Points.AddXY(xAxisCounter++, double.Parse(sicaklik));
                if (chartSicaklik.Series[0].Points.Count > 50)
                    chartSicaklik.Series[0].Points.RemoveAt(0);

                chartSicaklik.ChartAreas[0].AxisX.Maximum = xAxisCounter + 10;
                chartSicaklik.ChartAreas[0].AxisX.Minimum = xAxisCounter - 20;

                chartNem.Series[0].Points.AddXY(xAxisCounter++, double.Parse(nem));
                if (chartNem.Series[0].Points.Count > 50)
                    chartNem.Series[0].Points.RemoveAt(0);

                chartNem.ChartAreas[0].AxisX.Maximum = xAxisCounter + 10;
                chartNem.ChartAreas[0].AxisX.Minimum = xAxisCounter - 20;

                chartToprakNem.Series[0].Points.AddXY(xAxisCounter++, double.Parse(toprakNem));
                if (chartToprakNem.Series[0].Points.Count > 50)
                    chartToprakNem.Series[0].Points.RemoveAt(0);

                chartToprakNem.ChartAreas[0].AxisX.Maximum = xAxisCounter + 10;
                chartToprakNem.ChartAreas[0].AxisX.Minimum = xAxisCounter - 20;

                chartSicaklik.Invalidate();
                chartNem.Invalidate();
                chartToprakNem.Invalidate();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Grafik güncelleme hatasý: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLedAc_Click(object sender, EventArgs e)
        {
            SendCommand("LED_ON");
        }

        private void btnLedKapat_Click(object sender, EventArgs e)
        {
            SendCommand("LED_OFF");
        }

        private void btnFanAc_Click(object sender, EventArgs e)
        {
            SendCommand("FAN_ON");
        }

        private void btnFanKapat_Click(object sender, EventArgs e)
        {
            SendCommand("FAN_OFF");
        }

        private void btnEsikDegerAyarla_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEsikDeger.Text))
            {
                int esikDeger;
                if (int.TryParse(txtEsikDeger.Text, out esikDeger))
                {
                    SendCommand("SET_THRESHOLD:" + esikDeger);
                }
                else
                {
                    MessageBox.Show("Geçerli bir eþik deðeri girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir eþik deðeri girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SendCommand(string command)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine(command);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
