namespace Sera_Arayuz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer4 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBoxCOMPorts = new ComboBox();
            label3 = new Label();
            chartSicaklik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartNem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartToprakNem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            progressBarSu = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            progressBarGaz = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            trackBarLedParlaklik = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            trackBarFanHiz = new ProgressBar();
            label7 = new Label();
            clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            txtEsikDeger = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSicaklik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartNem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartToprakNem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBarSu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBarGaz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLedParlaklik).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBoxCOMPorts);
            panel1.Location = new Point(34, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 306);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(33, 87);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 4;
            label2.Text = "COM Portu Seç";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(70, 39);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 3;
            label1.Text = "Bağlantı";
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(33, 224);
            button2.Name = "button2";
            button2.Size = new Size(174, 36);
            button2.TabIndex = 2;
            button2.Text = "Bağlantıyı Kes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(33, 168);
            button1.Name = "button1";
            button1.Size = new Size(174, 36);
            button1.TabIndex = 1;
            button1.Text = "Bağlantı Başlat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBoxCOMPorts
            // 
            comboBoxCOMPorts.FormattingEnabled = true;
            comboBoxCOMPorts.Location = new Point(33, 111);
            comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            comboBoxCOMPorts.Size = new Size(174, 28);
            comboBoxCOMPorts.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(489, 15);
            label3.Name = "label3";
            label3.Size = new Size(421, 40);
            label3.TabIndex = 5;
            label3.Text = "Sera Otomasyonu Arayüzü";
            // 
            // chartSicaklik
            // 
            chartArea10.Name = "ChartArea1";
            chartSicaklik.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            chartSicaklik.Legends.Add(legend10);
            chartSicaklik.Location = new Point(320, 76);
            chartSicaklik.Name = "chartSicaklik";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "sicaklik";
            series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartSicaklik.Series.Add(series10);
            chartSicaklik.Size = new Size(490, 306);
            chartSicaklik.TabIndex = 6;
            chartSicaklik.Text = "chart1";
            title10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            title10.Name = "Title1";
            title10.Text = "Sıcaklık Grafiği";
            chartSicaklik.Titles.Add(title10);
            // 
            // chartNem
            // 
            chartArea11.Name = "ChartArea1";
            chartNem.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            chartNem.Legends.Add(legend11);
            chartNem.Location = new Point(852, 76);
            chartNem.Name = "chartNem";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "nem";
            series11.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartNem.Series.Add(series11);
            chartNem.Size = new Size(490, 306);
            chartNem.TabIndex = 7;
            chartNem.Text = "chart2";
            title11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            title11.Name = "Title1";
            title11.Text = "Nem Grafiği";
            chartNem.Titles.Add(title11);
            // 
            // chartToprakNem
            // 
            chartArea12.Name = "ChartArea1";
            chartToprakNem.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            chartToprakNem.Legends.Add(legend12);
            chartToprakNem.Location = new Point(320, 419);
            chartToprakNem.Name = "chartToprakNem";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "toprakNem";
            series12.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartToprakNem.Series.Add(series12);
            chartToprakNem.Size = new Size(490, 306);
            chartToprakNem.TabIndex = 8;
            chartToprakNem.Text = "chart3";
            title12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            title12.Name = "Title1";
            title12.Text = "Toprak Nem Grafiği";
            chartToprakNem.Titles.Add(title12);
            // 
            // progressBarSu
            // 
            progressBarSu.BackColor = Color.White;
            progressBarSu.BackMultipleColors = new Color[]
    {
    Color.Empty
    };
            progressBarSu.BackSegments = false;
            progressBarSu.BorderStyle = BorderStyle.FixedSingle;
            progressBarSu.CustomText = null;
            progressBarSu.CustomWaitingRender = false;
            progressBarSu.ForegroundImage = null;
            progressBarSu.Location = new Point(852, 528);
            progressBarSu.Maximum = 800;
            progressBarSu.MultipleColors = new Color[]
    {
    Color.Empty
    };
            progressBarSu.Name = "progressBarSu";
            progressBarSu.SegmentWidth = 12;
            progressBarSu.Size = new Size(490, 29);
            progressBarSu.TabIndex = 9;
            progressBarSu.Text = "progressBarAdv1";
            progressBarSu.Value = 0;
            progressBarSu.WaitingGradientWidth = 400;
            // 
            // progressBarGaz
            // 
            progressBarGaz.BackColor = Color.White;
            progressBarGaz.BackMultipleColors = new Color[]
    {
    Color.Empty
    };
            progressBarGaz.BackSegments = false;
            progressBarGaz.BorderStyle = BorderStyle.FixedSingle;
            progressBarGaz.CustomText = null;
            progressBarGaz.CustomWaitingRender = false;
            progressBarGaz.ForegroundImage = null;
            progressBarGaz.Location = new Point(852, 612);
            progressBarGaz.Maximum = 255;
            progressBarGaz.MultipleColors = new Color[]
    {
    Color.Empty
    };
            progressBarGaz.Name = "progressBarGaz";
            progressBarGaz.SegmentWidth = 12;
            progressBarGaz.Size = new Size(490, 29);
            progressBarGaz.TabIndex = 10;
            progressBarGaz.Value = 0;
            progressBarGaz.WaitingGradientWidth = 400;
            // 
            // trackBarLedParlaklik
            // 
            trackBarLedParlaklik.BackColor = Color.White;
            trackBarLedParlaklik.BackMultipleColors = new Color[]
    {
    Color.Empty
    };
            trackBarLedParlaklik.BackSegments = false;
            trackBarLedParlaklik.BorderStyle = BorderStyle.FixedSingle;
            trackBarLedParlaklik.CustomText = null;
            trackBarLedParlaklik.CustomWaitingRender = false;
            trackBarLedParlaklik.ForegroundImage = null;
            trackBarLedParlaklik.Location = new Point(852, 696);
            trackBarLedParlaklik.MultipleColors = new Color[]
    {
    Color.Empty
    };
            trackBarLedParlaklik.Name = "trackBarLedParlaklik";
            trackBarLedParlaklik.SegmentWidth = 12;
            trackBarLedParlaklik.Size = new Size(490, 29);
            trackBarLedParlaklik.TabIndex = 11;
            trackBarLedParlaklik.Text = "progressBarAdv3";
            trackBarLedParlaklik.Value = 0;
            trackBarLedParlaklik.WaitingGradientWidth = 400;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(852, 504);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 5;
            label4.Text = "Su Seviyesi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(852, 588);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 12;
            label5.Text = "Kirli Hava Oranı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(852, 672);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 13;
            label6.Text = "Led Parlaklığı";
            // 
            // trackBarFanHiz
            // 
            trackBarFanHiz.Location = new Point(942, 419);
            trackBarFanHiz.Maximum = 255;
            trackBarFanHiz.Name = "trackBarFanHiz";
            trackBarFanHiz.Size = new Size(400, 59);
            trackBarFanHiz.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(852, 439);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 15;
            label7.Text = "Fan Hızı:";
            // 
            // clock1
            // 
            clock1.BackgroundColor = SystemColors.Control;
            clock1.ClockFormat = "HH:mm:ss";
            clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Analog;
            clock1.CurrentDateTime = new DateTime(2024, 12, 5, 2, 13, 54, 161);
            clock1.CustomTime = new DateTime(2024, 12, 10, 20, 2, 50, 890);
            clock1.DisplayDates = true;
            clock1.Location = new Point(34, 481);
            clock1.MinimumSize = new Size(75, 75);
            clock1.Name = "clock1";
            clock1.Now = new DateTime(0L);
            clock1.Remainder = new DateTime(2024, 12, 5, 2, 13, 54, 159);
            clock1.Renderer = clockRenderer4;
            clock1.ShowClockFrame = false;
            clock1.ShowCustomTimeClock = false;
            clock1.ShowHourDesignator = false;
            clock1.Size = new Size(244, 244);
            clock1.StopTimer = false;
            clock1.TabIndex = 16;
            clock1.Text = "clock1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(34, 419);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(34, 763);
            button3.Name = "button3";
            button3.Size = new Size(196, 68);
            button3.TabIndex = 5;
            button3.Text = "LED Aç";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnLedAc_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(280, 763);
            button4.Name = "button4";
            button4.Size = new Size(196, 68);
            button4.TabIndex = 18;
            button4.Text = "LED Kapat";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnLedKapat_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(530, 763);
            button5.Name = "button5";
            button5.Size = new Size(196, 68);
            button5.TabIndex = 19;
            button5.Text = "Fan Aç";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnFanAc_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Teal;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(782, 763);
            button6.Name = "button6";
            button6.Size = new Size(196, 68);
            button6.TabIndex = 20;
            button6.Text = "Fan Kapat";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnFanKapat_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(1035, 796);
            button7.Name = "button7";
            button7.Size = new Size(307, 35);
            button7.TabIndex = 21;
            button7.Text = "Sulama Eşik Değeri Ayarla";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnEsikDegerAyarla_Click;
            // 
            // txtEsikDeger
            // 
            txtEsikDeger.BackColor = SystemColors.ActiveCaption;
            txtEsikDeger.BorderStyle = BorderStyle.FixedSingle;
            txtEsikDeger.Location = new Point(1035, 763);
            txtEsikDeger.Name = "txtEsikDeger";
            txtEsikDeger.Size = new Size(307, 27);
            txtEsikDeger.TabIndex = 22;
            txtEsikDeger.Text = "Lütfen bir değer girin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1382, 873);
            Controls.Add(txtEsikDeger);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(clock1);
            Controls.Add(label7);
            Controls.Add(trackBarFanHiz);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(trackBarLedParlaklik);
            Controls.Add(progressBarGaz);
            Controls.Add(progressBarSu);
            Controls.Add(chartToprakNem);
            Controls.Add(chartNem);
            Controls.Add(chartSicaklik);
            Controls.Add(label3);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartSicaklik).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartNem).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartToprakNem).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBarSu).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBarGaz).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLedParlaklik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private ComboBox comboBoxCOMPorts;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSicaklik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartToprakNem;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarSu;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarGaz;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv trackBarLedParlaklik;
        private Label label4;
        private Label label5;
        private Label label6;
        private ProgressBar trackBarFanHiz;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox txtEsikDeger;
    }
}
