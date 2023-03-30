namespace FinalProject_C3
{
    partial class Tab_Monitor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tb_pronow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testTile1 = new MetroFramework.Controls.MetroTile();
            this.lb_nowplan = new MetroFramework.Controls.MetroLabel();
            this.plannum1 = new MetroFramework.Controls.MetroLabel();
            this.mpb_pro = new MetroFramework.Controls.MetroProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prod_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpS = new System.Windows.Forms.DateTimePicker();
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HUMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_nowprod = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.testTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pronow
            // 
            this.tb_pronow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_pronow.Location = new System.Drawing.Point(722, 46);
            this.tb_pronow.Name = "tb_pronow";
            this.tb_pronow.ReadOnly = true;
            this.tb_pronow.Size = new System.Drawing.Size(310, 21);
            this.tb_pronow.TabIndex = 0;
            this.tb_pronow.TextChanged += new System.EventHandler(this.tb_pronow_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(593, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "공정 진행 정보 :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.testTile1);
            this.panel1.Controls.Add(this.mpb_pro);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 121);
            this.panel1.TabIndex = 2;
            // 
            // testTile1
            // 
            this.testTile1.ActiveControl = null;
            this.testTile1.Controls.Add(this.metroLabel2);
            this.testTile1.Controls.Add(this.metroLabel1);
            this.testTile1.Controls.Add(this.lb_nowplan);
            this.testTile1.Controls.Add(this.lb_nowprod);
            this.testTile1.Controls.Add(this.plannum1);
            this.testTile1.Location = new System.Drawing.Point(10, 28);
            this.testTile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testTile1.Name = "testTile1";
            this.testTile1.Size = new System.Drawing.Size(390, 64);
            this.testTile1.TabIndex = 9;
            this.testTile1.UseSelectable = true;
            // 
            // lb_nowplan
            // 
            this.lb_nowplan.Enabled = false;
            this.lb_nowplan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_nowplan.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lb_nowplan.Location = new System.Drawing.Point(92, 20);
            this.lb_nowplan.Name = "lb_nowplan";
            this.lb_nowplan.Size = new System.Drawing.Size(70, 25);
            this.lb_nowplan.TabIndex = 12;
            this.lb_nowplan.Text = "1";
            // 
            // plannum1
            // 
            this.plannum1.Enabled = false;
            this.plannum1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.plannum1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.plannum1.Location = new System.Drawing.Point(7, 20);
            this.plannum1.Name = "plannum1";
            this.plannum1.Size = new System.Drawing.Size(88, 25);
            this.plannum1.TabIndex = 11;
            this.plannum1.Text = "현재주문";
            // 
            // mpb_pro
            // 
            this.mpb_pro.Location = new System.Drawing.Point(406, 35);
            this.mpb_pro.Maximum = 75;
            this.mpb_pro.Name = "mpb_pro";
            this.mpb_pro.Size = new System.Drawing.Size(378, 48);
            this.mpb_pro.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(808, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 224);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // prod_chart
            // 
            chartArea8.Name = "ChartArea1";
            this.prod_chart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.prod_chart.Legends.Add(legend8);
            this.prod_chart.Location = new System.Drawing.Point(12, 298);
            this.prod_chart.Name = "prod_chart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.prod_chart.Series.Add(series8);
            this.prod_chart.Size = new System.Drawing.Size(350, 231);
            this.prod_chart.TabIndex = 3;
            this.prod_chart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(9, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "양품률";
            // 
            // dtpS
            // 
            this.dtpS.Location = new System.Drawing.Point(12, 271);
            this.dtpS.Name = "dtpS";
            this.dtpS.Size = new System.Drawing.Size(172, 21);
            this.dtpS.TabIndex = 5;
            this.dtpS.ValueChanged += new System.EventHandler(this.dtpS_ValueChanged);
            // 
            // dtpE
            // 
            this.dtpE.Location = new System.Drawing.Point(190, 271);
            this.dtpE.Name = "dtpE";
            this.dtpE.Size = new System.Drawing.Size(172, 21);
            this.dtpE.TabIndex = 6;
            this.dtpE.ValueChanged += new System.EventHandler(this.dtpE_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FAN,
            this.TEMP,
            this.HUMI,
            this.LUX});
            this.dataGridView1.Location = new System.Drawing.Point(369, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(433, 46);
            this.dataGridView1.TabIndex = 7;
            // 
            // FAN
            // 
            this.FAN.HeaderText = "FAN";
            this.FAN.MinimumWidth = 6;
            this.FAN.Name = "FAN";
            this.FAN.Width = 90;
            // 
            // TEMP
            // 
            this.TEMP.HeaderText = "TEMP";
            this.TEMP.MinimumWidth = 6;
            this.TEMP.Name = "TEMP";
            this.TEMP.Width = 125;
            // 
            // HUMI
            // 
            this.HUMI.HeaderText = "HUMI";
            this.HUMI.MinimumWidth = 6;
            this.HUMI.Name = "HUMI";
            this.HUMI.Width = 125;
            // 
            // LUX
            // 
            this.LUX.HeaderText = "LUX";
            this.LUX.MinimumWidth = 6;
            this.LUX.Name = "LUX";
            this.LUX.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(366, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "공장 상태";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_nowprod
            // 
            this.lb_nowprod.AutoSize = true;
            this.lb_nowprod.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_nowprod.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lb_nowprod.Location = new System.Drawing.Point(221, 20);
            this.lb_nowprod.Name = "lb_nowprod";
            this.lb_nowprod.Size = new System.Drawing.Size(91, 25);
            this.lb_nowprod.TabIndex = 4;
            this.lb_nowprod.Text = "NowProd";
            this.lb_nowprod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(365, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(22, 25);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "::";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(153, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(22, 25);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "::";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpE);
            this.Controls.Add(this.dtpS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prod_chart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pronow);
            this.Name = "Tab_Monitor";
            this.Text = "모니터링";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tab_Monitor_FormClosed);
            this.Load += new System.EventHandler(this.Tab_Monitor_Load);
            this.panel1.ResumeLayout(false);
            this.testTile1.ResumeLayout(false);
            this.testTile1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pronow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart prod_chart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpS;
        private System.Windows.Forms.DateTimePicker dtpE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HUMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUX;
        private MetroFramework.Controls.MetroProgressBar mpb_pro;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lb_nowprod;
        private MetroFramework.Controls.MetroTile testTile1;
        private MetroFramework.Controls.MetroLabel lb_nowplan;
        private MetroFramework.Controls.MetroLabel plannum1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}