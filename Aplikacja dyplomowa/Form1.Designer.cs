
namespace Zasilacz_warsztatowy
{
    partial class Zasilacz_warsztatowy
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label OgrLbl;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zasilacz_warsztatowy));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importujDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPortCom = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rBtnON = new System.Windows.Forms.RadioButton();
            this.tBoxTemp = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanelTylny = new System.Windows.Forms.TableLayoutPanel();
            this.PanelWykresow = new System.Windows.Forms.TableLayoutPanel();
            this.chV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OgrL100 = new System.Windows.Forms.Button();
            this.OgrL10 = new System.Windows.Forms.Button();
            this.OgrL1 = new System.Windows.Forms.Button();
            this.OgrP100 = new System.Windows.Forms.Button();
            this.OgrP10 = new System.Windows.Forms.Button();
            this.OgrScrBar = new System.Windows.Forms.HScrollBar();
            this.OgrCBox = new System.Windows.Forms.CheckBox();
            this.OgrP1 = new System.Windows.Forms.Button();
            this.OgrTBox = new System.Windows.Forms.TextBox();
            this.PanelBoczny = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dodaj = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.połącz = new System.Windows.Forms.Button();
            OgrLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.PanelTylny.SuspendLayout();
            this.PanelWykresow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PanelBoczny.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OgrLbl
            // 
            OgrLbl.AutoSize = true;
            OgrLbl.Location = new System.Drawing.Point(123, 56);
            OgrLbl.Name = "OgrLbl";
            OgrLbl.Size = new System.Drawing.Size(14, 13);
            OgrLbl.TabIndex = 11;
            OgrLbl.Text = "A";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zToolStripMenuItem,
            this.zapiszPlikToolStripMenuItem,
            this.importujDaneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // zapiszPlikToolStripMenuItem
            // 
            this.zapiszPlikToolStripMenuItem.Name = "zapiszPlikToolStripMenuItem";
            this.zapiszPlikToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // importujDaneToolStripMenuItem
            // 
            this.importujDaneToolStripMenuItem.Name = "importujDaneToolStripMenuItem";
            this.importujDaneToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.portToolStripMenuItem.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port COM:";
            // 
            // cBoxPortCom
            // 
            this.cBoxPortCom.FormattingEnabled = true;
            this.cBoxPortCom.Location = new System.Drawing.Point(167, 2);
            this.cBoxPortCom.Name = "cBoxPortCom";
            this.cBoxPortCom.Size = new System.Drawing.Size(65, 21);
            this.cBoxPortCom.TabIndex = 7;
            this.cBoxPortCom.Click += new System.EventHandler(this.Form1_Load);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(258, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(30, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "OFF";
            // 
            // rBtnON
            // 
            this.rBtnON.AutoSize = true;
            this.rBtnON.Checked = true;
            this.rBtnON.Enabled = false;
            this.rBtnON.Location = new System.Drawing.Point(241, 6);
            this.rBtnON.Name = "rBtnON";
            this.rBtnON.Size = new System.Drawing.Size(14, 13);
            this.rBtnON.TabIndex = 9;
            this.rBtnON.TabStop = true;
            this.rBtnON.UseVisualStyleBackColor = true;
            // 
            // tBoxTemp
            // 
            this.tBoxTemp.Location = new System.Drawing.Point(3, 224);
            this.tBoxTemp.Multiline = true;
            this.tBoxTemp.Name = "tBoxTemp";
            this.tBoxTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxTemp.Size = new System.Drawing.Size(181, 170);
            this.tBoxTemp.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatus
            // 
            this.StripStatus.Name = "StripStatus";
            this.StripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // PanelTylny
            // 
            this.PanelTylny.ColumnCount = 2;
            this.PanelTylny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTylny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.PanelTylny.Controls.Add(this.PanelWykresow, 0, 0);
            this.PanelTylny.Controls.Add(this.PanelBoczny, 1, 0);
            this.PanelTylny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTylny.Location = new System.Drawing.Point(0, 24);
            this.PanelTylny.Name = "PanelTylny";
            this.PanelTylny.RowCount = 1;
            this.PanelTylny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTylny.Size = new System.Drawing.Size(584, 516);
            this.PanelTylny.TabIndex = 23;
            // 
            // PanelWykresow
            // 
            this.PanelWykresow.ColumnCount = 1;
            this.PanelWykresow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelWykresow.Controls.Add(this.chV, 0, 0);
            this.PanelWykresow.Controls.Add(this.groupBox1, 0, 1);
            this.PanelWykresow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWykresow.Location = new System.Drawing.Point(3, 3);
            this.PanelWykresow.Name = "PanelWykresow";
            this.PanelWykresow.RowCount = 3;
            this.PanelWykresow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelWykresow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.PanelWykresow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelWykresow.Size = new System.Drawing.Size(368, 510);
            this.PanelWykresow.TabIndex = 24;
            // 
            // chV
            // 
            chartArea1.AxisX.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX2.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.Interval = 0D;
            chartArea1.AxisY2.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY2.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisY2.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.None;
            chartArea1.AxisY2.MajorGrid.Interval = 0D;
            chartArea1.AxisY2.MajorTickMark.Interval = 0D;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 80.23259F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 4F;
            chartArea1.InnerPlotPosition.Y = 4.95661F;
            chartArea1.Name = "Napięcie";
            this.chV.ChartAreas.Add(chartArea1);
            this.chV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chV.Location = new System.Drawing.Point(3, 3);
            this.chV.Name = "chV";
            series1.ChartArea = "Napięcie";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Name = "chV";
            this.chV.Series.Add(series1);
            this.chV.Size = new System.Drawing.Size(362, 364);
            this.chV.TabIndex = 15;
            this.chV.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Napięcie [V]";
            this.chV.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OgrL100);
            this.groupBox1.Controls.Add(this.OgrL10);
            this.groupBox1.Controls.Add(this.OgrL1);
            this.groupBox1.Controls.Add(this.OgrP100);
            this.groupBox1.Controls.Add(this.OgrP10);
            this.groupBox1.Controls.Add(this.OgrScrBar);
            this.groupBox1.Controls.Add(this.OgrCBox);
            this.groupBox1.Controls.Add(this.OgrP1);
            this.groupBox1.Controls.Add(this.OgrTBox);
            this.groupBox1.Controls.Add(OgrLbl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 114);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ograniczenie prądowe";
            // 
            // OgrL100
            // 
            this.OgrL100.Location = new System.Drawing.Point(3, 53);
            this.OgrL100.Name = "OgrL100";
            this.OgrL100.Size = new System.Drawing.Size(33, 20);
            this.OgrL100.TabIndex = 10;
            this.OgrL100.Text = "<<<";
            this.OgrL100.UseVisualStyleBackColor = true;
            this.OgrL100.Click += new System.EventHandler(this.OgrL100_Click);
            // 
            // OgrL10
            // 
            this.OgrL10.Location = new System.Drawing.Point(38, 53);
            this.OgrL10.Name = "OgrL10";
            this.OgrL10.Size = new System.Drawing.Size(27, 20);
            this.OgrL10.TabIndex = 9;
            this.OgrL10.Text = "<<";
            this.OgrL10.UseVisualStyleBackColor = true;
            this.OgrL10.Click += new System.EventHandler(this.OgrL10_Click);
            // 
            // OgrL1
            // 
            this.OgrL1.Location = new System.Drawing.Point(67, 53);
            this.OgrL1.Name = "OgrL1";
            this.OgrL1.Size = new System.Drawing.Size(20, 20);
            this.OgrL1.TabIndex = 8;
            this.OgrL1.Text = "<";
            this.OgrL1.UseVisualStyleBackColor = true;
            this.OgrL1.Click += new System.EventHandler(this.OgrL1_Click);
            // 
            // OgrP100
            // 
            this.OgrP100.Location = new System.Drawing.Point(186, 53);
            this.OgrP100.Name = "OgrP100";
            this.OgrP100.Size = new System.Drawing.Size(33, 20);
            this.OgrP100.TabIndex = 7;
            this.OgrP100.Text = ">>>";
            this.OgrP100.UseVisualStyleBackColor = true;
            this.OgrP100.Click += new System.EventHandler(this.OgrP100_Click);
            // 
            // OgrP10
            // 
            this.OgrP10.Location = new System.Drawing.Point(157, 53);
            this.OgrP10.Name = "OgrP10";
            this.OgrP10.Size = new System.Drawing.Size(27, 20);
            this.OgrP10.TabIndex = 6;
            this.OgrP10.Text = ">>";
            this.OgrP10.UseVisualStyleBackColor = true;
            this.OgrP10.Click += new System.EventHandler(this.OgrP10_Click);
            // 
            // OgrScrBar
            // 
            this.OgrScrBar.LargeChange = 100;
            this.OgrScrBar.Location = new System.Drawing.Point(6, 87);
            this.OgrScrBar.Maximum = 2100;
            this.OgrScrBar.Name = "OgrScrBar";
            this.OgrScrBar.Size = new System.Drawing.Size(210, 17);
            this.OgrScrBar.SmallChange = 10;
            this.OgrScrBar.TabIndex = 3;
            this.OgrScrBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OgrScrBar_Scroll);
            // 
            // OgrCBox
            // 
            this.OgrCBox.AutoSize = true;
            this.OgrCBox.Location = new System.Drawing.Point(6, 19);
            this.OgrCBox.Name = "OgrCBox";
            this.OgrCBox.Size = new System.Drawing.Size(131, 17);
            this.OgrCBox.TabIndex = 0;
            this.OgrCBox.Text = "Ograniczenie aktywne";
            this.OgrCBox.UseVisualStyleBackColor = true;
            this.OgrCBox.Click += new System.EventHandler(this.OgrCBox_Click);
            // 
            // OgrP1
            // 
            this.OgrP1.Location = new System.Drawing.Point(135, 53);
            this.OgrP1.Name = "OgrP1";
            this.OgrP1.Size = new System.Drawing.Size(20, 20);
            this.OgrP1.TabIndex = 5;
            this.OgrP1.Text = ">";
            this.OgrP1.UseVisualStyleBackColor = true;
            this.OgrP1.Click += new System.EventHandler(this.OgrP1_Click);
            // 
            // OgrTBox
            // 
            this.OgrTBox.AcceptsTab = true;
            this.OgrTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OgrTBox.Location = new System.Drawing.Point(89, 53);
            this.OgrTBox.MaxLength = 5;
            this.OgrTBox.Name = "OgrTBox";
            this.OgrTBox.ShortcutsEnabled = false;
            this.OgrTBox.Size = new System.Drawing.Size(35, 20);
            this.OgrTBox.TabIndex = 4;
            this.OgrTBox.Text = "20.00";
            this.OgrTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OgrTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OgrTBox_KeyUp);
            // 
            // PanelBoczny
            // 
            this.PanelBoczny.ColumnCount = 1;
            this.PanelBoczny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelBoczny.Controls.Add(this.panel1, 0, 0);
            this.PanelBoczny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBoczny.Location = new System.Drawing.Point(377, 3);
            this.PanelBoczny.Name = "PanelBoczny";
            this.PanelBoczny.RowCount = 1;
            this.PanelBoczny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelBoczny.Size = new System.Drawing.Size(204, 510);
            this.PanelBoczny.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tBoxTemp);
            this.panel1.Controls.Add(this.dodaj);
            this.panel1.Controls.Add(this.test);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 504);
            this.panel1.TabIndex = 18;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(69, 506);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 40;
            this.dodaj.Text = "dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(35, 425);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(121, 49);
            this.test.TabIndex = 43;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // połącz
            // 
            this.połącz.Location = new System.Drawing.Point(294, 2);
            this.połącz.Name = "połącz";
            this.połącz.Size = new System.Drawing.Size(75, 21);
            this.połącz.TabIndex = 41;
            this.połącz.Text = "Połącz";
            this.połącz.UseVisualStyleBackColor = true;
            this.połącz.Click += new System.EventHandler(this.połącz_Click);
            // 
            // Zasilacz_warsztatowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.połącz);
            this.Controls.Add(this.PanelTylny);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rBtnON);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxPortCom);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Zasilacz_warsztatowy";
            this.Text = "Zasilacz warsztatowy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PanelTylny.ResumeLayout(false);
            this.PanelWykresow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelBoczny.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importujDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPortCom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rBtnON;
        private System.Windows.Forms.TextBox tBoxTemp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatus;
        private System.Windows.Forms.TableLayoutPanel PanelTylny;
        private System.Windows.Forms.TableLayoutPanel PanelWykresow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chV;
        private System.Windows.Forms.TableLayoutPanel PanelBoczny;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button połącz;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button OgrL100;
        private System.Windows.Forms.Button OgrL10;
        private System.Windows.Forms.Button OgrL1;
        private System.Windows.Forms.Button OgrP100;
        private System.Windows.Forms.Button OgrP10;
        private System.Windows.Forms.Button OgrP1;
        private System.Windows.Forms.TextBox OgrTBox;
        private System.Windows.Forms.HScrollBar OgrScrBar;
        private System.Windows.Forms.CheckBox OgrCBox;
    }
}

