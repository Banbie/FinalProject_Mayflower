﻿namespace FinalProject_C3
{
    partial class Tab_Search
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dt_Time = new MetroFramework.Controls.MetroDateTime();
            this.dt_Time1 = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.날짜 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.총생산량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량갯수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_doneplan = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Search = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doneplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_Time
            // 
            this.dt_Time.Location = new System.Drawing.Point(742, 59);
            this.dt_Time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Time.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_Time.Name = "dt_Time";
            this.dt_Time.Size = new System.Drawing.Size(194, 29);
            this.dt_Time.TabIndex = 2;
            // 
            // dt_Time1
            // 
            this.dt_Time1.Location = new System.Drawing.Point(962, 59);
            this.dt_Time1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Time1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_Time1.Name = "dt_Time1";
            this.dt_Time1.Size = new System.Drawing.Size(194, 29);
            this.dt_Time1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(942, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "~";
            // 
            // dgv_Search
            // 
            this.dgv_Search.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.날짜,
            this.총생산량,
            this.불량갯수,
            this.불량률});
            this.dgv_Search.Location = new System.Drawing.Point(23, 92);
            this.dgv_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.RowHeadersWidth = 51;
            this.dgv_Search.RowTemplate.Height = 23;
            this.dgv_Search.Size = new System.Drawing.Size(472, 627);
            this.dgv_Search.TabIndex = 12;
            // 
            // 날짜
            // 
            this.날짜.HeaderText = "날짜";
            this.날짜.MinimumWidth = 6;
            this.날짜.Name = "날짜";
            this.날짜.Width = 120;
            // 
            // 총생산량
            // 
            this.총생산량.HeaderText = "총 생산량";
            this.총생산량.MinimumWidth = 6;
            this.총생산량.Name = "총생산량";
            this.총생산량.Width = 125;
            // 
            // 불량갯수
            // 
            this.불량갯수.HeaderText = "불량 갯수";
            this.불량갯수.MinimumWidth = 6;
            this.불량갯수.Name = "불량갯수";
            this.불량갯수.Width = 125;
            // 
            // 불량률
            // 
            this.불량률.HeaderText = "불량률";
            this.불량률.MinimumWidth = 6;
            this.불량률.Name = "불량률";
            this.불량률.Width = 125;
            // 
            // dgv_doneplan
            // 
            this.dgv_doneplan.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgv_doneplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doneplan.Location = new System.Drawing.Point(501, 92);
            this.dgv_doneplan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_doneplan.Name = "dgv_doneplan";
            this.dgv_doneplan.RowHeadersWidth = 51;
            this.dgv_doneplan.RowTemplate.Height = 23;
            this.dgv_doneplan.Size = new System.Drawing.Size(726, 247);
            this.dgv_doneplan.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(501, 341);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "총생산량";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "불량갯수";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "불량률(%)";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(726, 378);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "날짜별 총 생산량 대비 불량률 그래프";
            this.chart1.Titles.Add(title1);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1162, 65);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(65, 23);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseSelectable = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(498, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "현재 완료된 주문";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "날짜별 현황";
            // 
            // Tab_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 798);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgv_doneplan);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_Time1);
            this.Controls.Add(this.dt_Time);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Movable = false;
            this.Name = "Tab_Search";
            this.Text = "실적확인";
            this.Load += new System.EventHandler(this.Tab_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doneplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime dt_Time;
        private MetroFramework.Controls.MetroDateTime dt_Time1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.DataGridView dgv_doneplan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn 날짜;
        private System.Windows.Forms.DataGridViewTextBoxColumn 총생산량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량갯수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량률;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}