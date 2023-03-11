
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
            this.PanelBoczny = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.PanelTylny.SuspendLayout();
            this.PanelWykresow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chV)).BeginInit();
            this.PanelBoczny.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(393, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port COM:";
            // 
            // cBoxPortCom
            // 
            this.cBoxPortCom.FormattingEnabled = true;
            this.cBoxPortCom.Location = new System.Drawing.Point(455, 2);
            this.cBoxPortCom.Name = "cBoxPortCom";
            this.cBoxPortCom.Size = new System.Drawing.Size(65, 21);
            this.cBoxPortCom.TabIndex = 7;
            this.cBoxPortCom.Click += new System.EventHandler(this.Form1_Load);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(546, 6);
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
            this.rBtnON.Location = new System.Drawing.Point(529, 6);
            this.rBtnON.Name = "rBtnON";
            this.rBtnON.Size = new System.Drawing.Size(14, 13);
            this.rBtnON.TabIndex = 9;
            this.rBtnON.TabStop = true;
            this.rBtnON.UseVisualStyleBackColor = true;
            // 
            // tBoxTemp
            // 
            this.tBoxTemp.Location = new System.Drawing.Point(3, 266);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
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
            this.PanelTylny.Size = new System.Drawing.Size(584, 591);
            this.PanelTylny.TabIndex = 23;
            // 
            // PanelWykresow
            // 
            this.PanelWykresow.ColumnCount = 1;
            this.PanelWykresow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelWykresow.Controls.Add(this.chV, 0, 0);
            this.PanelWykresow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWykresow.Location = new System.Drawing.Point(3, 3);
            this.PanelWykresow.Name = "PanelWykresow";
            this.PanelWykresow.RowCount = 2;
            this.PanelWykresow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelWykresow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelWykresow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelWykresow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelWykresow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelWykresow.Size = new System.Drawing.Size(368, 585);
            this.PanelWykresow.TabIndex = 24;
            // 
            // chV
            // 
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 80.23259F;
            chartArea1.InnerPlotPosition.Width = 95F;
            chartArea1.InnerPlotPosition.X = 4F;
            chartArea1.InnerPlotPosition.Y = 4.95661F;
            chartArea1.Name = "Napięcie";
            this.chV.ChartAreas.Add(chartArea1);
            this.chV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chV.Location = new System.Drawing.Point(3, 3);
            this.chV.Name = "chV";
            series1.ChartArea = "Napięcie";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.IsVisibleInLegend = false;
            series1.Name = "chV";
            this.chV.Series.Add(series1);
            this.chV.Size = new System.Drawing.Size(362, 286);
            this.chV.TabIndex = 15;
            this.chV.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Napięcie [V]";
            this.chV.Titles.Add(title1);
            this.chV.MouseLeave += new System.EventHandler(this.chV_MouseLeave);
            this.chV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chV_MouseMove);
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
            this.PanelBoczny.Size = new System.Drawing.Size(204, 585);
            this.PanelBoczny.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tBoxTemp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 579);
            this.panel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 234);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ograniczenie prądowe:";
            // 
            // Zasilacz_warsztatowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 637);
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
            this.PanelBoczny.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

