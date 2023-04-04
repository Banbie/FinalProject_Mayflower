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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tb_pronow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lb_nowplan = new MetroFramework.Controls.MetroLabel();
            this.lb_nowprod = new MetroFramework.Controls.MetroLabel();
            this.plannum1 = new MetroFramework.Controls.MetroLabel();
            this.mpb_pro = new MetroFramework.Controls.MetroProgressBar();
            this.prod_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbtf = new System.Windows.Forms.TextBox();
            this.pbgreen = new System.Windows.Forms.PictureBox();
            this.pborange = new System.Windows.Forms.PictureBox();
            this.pbred = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpS = new MetroFramework.Controls.MetroDateTime();
            this.dtpE = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.testTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pborange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pronow
            // 
            this.tb_pronow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_pronow.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_pronow.Location = new System.Drawing.Point(840, 41);
            this.tb_pronow.Name = "tb_pronow";
            this.tb_pronow.ReadOnly = true;
            this.tb_pronow.Size = new System.Drawing.Size(382, 26);
            this.tb_pronow.TabIndex = 0;
            this.tb_pronow.TextChanged += new System.EventHandler(this.tb_pronow_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(711, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "공정 진행 정보 :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.testTile1);
            this.panel1.Controls.Add(this.mpb_pro);
            this.panel1.Location = new System.Drawing.Point(13, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 103);
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
            this.testTile1.Location = new System.Drawing.Point(10, 10);
            this.testTile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testTile1.Name = "testTile1";
            this.testTile1.Size = new System.Drawing.Size(373, 82);
            this.testTile1.TabIndex = 9;
            this.testTile1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(170, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(22, 25);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "::";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(347, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(22, 25);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "::";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_nowplan
            // 
            this.lb_nowplan.Enabled = false;
            this.lb_nowplan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_nowplan.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lb_nowplan.Location = new System.Drawing.Point(101, 28);
            this.lb_nowplan.Name = "lb_nowplan";
            this.lb_nowplan.Size = new System.Drawing.Size(63, 25);
            this.lb_nowplan.TabIndex = 12;
            this.lb_nowplan.Text = "1";
            // 
            // lb_nowprod
            // 
            this.lb_nowprod.AutoSize = true;
            this.lb_nowprod.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_nowprod.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lb_nowprod.Location = new System.Drawing.Point(221, 28);
            this.lb_nowprod.Name = "lb_nowprod";
            this.lb_nowprod.Size = new System.Drawing.Size(91, 25);
            this.lb_nowprod.TabIndex = 4;
            this.lb_nowprod.Text = "NowProd";
            this.lb_nowprod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plannum1
            // 
            this.plannum1.Enabled = false;
            this.plannum1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.plannum1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.plannum1.Location = new System.Drawing.Point(7, 28);
            this.plannum1.Name = "plannum1";
            this.plannum1.Size = new System.Drawing.Size(88, 25);
            this.plannum1.TabIndex = 11;
            this.plannum1.Text = "현재주문";
            // 
            // mpb_pro
            // 
            this.mpb_pro.Location = new System.Drawing.Point(389, 20);
            this.mpb_pro.Maximum = 75;
            this.mpb_pro.Name = "mpb_pro";
            this.mpb_pro.Size = new System.Drawing.Size(420, 64);
            this.mpb_pro.TabIndex = 0;
            // 
            // prod_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.prod_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.prod_chart.Legends.Add(legend1);
            this.prod_chart.Location = new System.Drawing.Point(12, 272);
            this.prod_chart.Name = "prod_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.prod_chart.Series.Add(series1);
            this.prod_chart.Size = new System.Drawing.Size(688, 408);
            this.prod_chart.TabIndex = 3;
            this.prod_chart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(17, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "양품률";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(695, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "상태 표시등";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbtf
            // 
            this.tbtf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbtf.Font = new System.Drawing.Font("굴림", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbtf.Location = new System.Drawing.Point(840, 419);
            this.tbtf.Name = "tbtf";
            this.tbtf.ReadOnly = true;
            this.tbtf.Size = new System.Drawing.Size(382, 75);
            this.tbtf.TabIndex = 12;
            this.tbtf.Text = "불합격";
            this.tbtf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbgreen
            // 
            this.pbgreen.Image = global::FinalProject_C3.Properties.Resources.new_moon__3_;
            this.pbgreen.Location = new System.Drawing.Point(1045, 562);
            this.pbgreen.Name = "pbgreen";
            this.pbgreen.Size = new System.Drawing.Size(171, 156);
            this.pbgreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbgreen.TabIndex = 11;
            this.pbgreen.TabStop = false;
            // 
            // pborange
            // 
            this.pborange.Image = global::FinalProject_C3.Properties.Resources.new_moon__4_;
            this.pborange.Location = new System.Drawing.Point(868, 562);
            this.pborange.Name = "pborange";
            this.pborange.Size = new System.Drawing.Size(171, 156);
            this.pborange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pborange.TabIndex = 10;
            this.pborange.TabStop = false;
            // 
            // pbred
            // 
            this.pbred.Image = global::FinalProject_C3.Properties.Resources.new_moon__2_;
            this.pbred.Location = new System.Drawing.Point(691, 562);
            this.pbred.Name = "pbred";
            this.pbred.Size = new System.Drawing.Size(171, 156);
            this.pbred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbred.TabIndex = 9;
            this.pbred.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(840, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 340);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dtpS
            // 
            this.dtpS.Location = new System.Drawing.Point(262, 231);
            this.dtpS.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpS.Name = "dtpS";
            this.dtpS.Size = new System.Drawing.Size(200, 29);
            this.dtpS.TabIndex = 13;
            this.dtpS.TabStop = false;
            this.dtpS.CloseUp += new System.EventHandler(this.dtpS_CloseUp);
            // 
            // dtpE
            // 
            this.dtpE.Location = new System.Drawing.Point(500, 231);
            this.dtpE.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpE.Name = "dtpE";
            this.dtpE.Size = new System.Drawing.Size(200, 29);
            this.dtpE.TabIndex = 14;
            this.dtpE.CloseUp += new System.EventHandler(this.dtpE_CloseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(468, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "~";
            // 
            // Tab_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpE);
            this.Controls.Add(this.dtpS);
            this.Controls.Add(this.pbgreen);
            this.Controls.Add(this.tbtf);
            this.Controls.Add(this.pbred);
            this.Controls.Add(this.pborange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prod_chart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pronow);
            this.Movable = false;
            this.Name = "Tab_Monitor";
            this.Text = "모니터링";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tab_Monitor_FormClosed);
            this.Load += new System.EventHandler(this.Tab_Monitor_Load);
            this.panel1.ResumeLayout(false);
            this.testTile1.ResumeLayout(false);
            this.testTile1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pborange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroProgressBar mpb_pro;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lb_nowprod;
        private MetroFramework.Controls.MetroTile testTile1;
        private MetroFramework.Controls.MetroLabel lb_nowplan;
        private MetroFramework.Controls.MetroLabel plannum1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pbred;
        private System.Windows.Forms.PictureBox pborange;
        private System.Windows.Forms.PictureBox pbgreen;
        private System.Windows.Forms.TextBox tbtf;
        private MetroFramework.Controls.MetroDateTime dtpS;
        private MetroFramework.Controls.MetroDateTime dtpE;
        private System.Windows.Forms.Label label4;
    }
}