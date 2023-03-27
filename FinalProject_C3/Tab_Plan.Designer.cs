namespace FinalProject_C3
{
    partial class Tab_Plan
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dg_plan = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.donut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dg_now = new System.Windows.Forms.DataGridView();
            this.planManager = new MetroFramework.Drawing.Html.HtmlPanel();
            this.testTile1 = new MetroFramework.Controls.MetroTile();
            this.duedate1 = new MetroFramework.Controls.MetroLabel();
            this.planea1 = new MetroFramework.Controls.MetroLabel();
            this.nowea1 = new MetroFramework.Controls.MetroLabel();
            this.priority1 = new MetroFramework.Controls.MetroLabel();
            this.testButton = new MetroFramework.Controls.MetroButton();
            this.recivedate1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_now)).BeginInit();
            this.planManager.SuspendLayout();
            this.testTile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_plan
            // 
            this.dg_plan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg_plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_plan.Location = new System.Drawing.Point(462, 392);
            this.dg_plan.Name = "dg_plan";
            this.dg_plan.RowTemplate.Height = 23;
            this.dg_plan.Size = new System.Drawing.Size(218, 132);
            this.dg_plan.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // donut
            // 
            chartArea2.Name = "ChartArea1";
            this.donut.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.donut.Legends.Add(legend2);
            this.donut.Location = new System.Drawing.Point(786, 289);
            this.donut.Name = "donut";
            this.donut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.donut.Series.Add(series2);
            this.donut.Size = new System.Drawing.Size(251, 268);
            this.donut.TabIndex = 7;
            this.donut.Text = "chart1";
            // 
            // dg_now
            // 
            this.dg_now.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg_now.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_now.Location = new System.Drawing.Point(34, 396);
            this.dg_now.Name = "dg_now";
            this.dg_now.RowTemplate.Height = 23;
            this.dg_now.Size = new System.Drawing.Size(261, 128);
            this.dg_now.TabIndex = 9;
            // 
            // planManager
            // 
            this.planManager.AutoScroll = true;
            this.planManager.AutoScrollMinSize = new System.Drawing.Size(1013, 18);
            this.planManager.BackColor = System.Drawing.SystemColors.Window;
            this.planManager.Controls.Add(this.testTile1);
            this.planManager.Location = new System.Drawing.Point(23, 63);
            this.planManager.Name = "planManager";
            this.planManager.Size = new System.Drawing.Size(1013, 234);
            this.planManager.TabIndex = 11;
            this.planManager.Text = "Plan Manager";
            // 
            // testTile1
            // 
            this.testTile1.ActiveControl = null;
            this.testTile1.Controls.Add(this.duedate1);
            this.testTile1.Controls.Add(this.planea1);
            this.testTile1.Controls.Add(this.nowea1);
            this.testTile1.Controls.Add(this.priority1);
            this.testTile1.Controls.Add(this.testButton);
            this.testTile1.Controls.Add(this.recivedate1);
            this.testTile1.Location = new System.Drawing.Point(10, 30);
            this.testTile1.Name = "testTile1";
            this.testTile1.Size = new System.Drawing.Size(180, 180);
            this.testTile1.TabIndex = 0;
            this.testTile1.Text = "고객사";
            this.testTile1.UseSelectable = true;
            // 
            // duedate1
            // 
            this.duedate1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.duedate1.Location = new System.Drawing.Point(10, 90);
            this.duedate1.Name = "duedate1";
            this.duedate1.Size = new System.Drawing.Size(80, 20);
            this.duedate1.TabIndex = 5;
            this.duedate1.Text = "납기일자";
            // 
            // planea1
            // 
            this.planea1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.planea1.Location = new System.Drawing.Point(10, 70);
            this.planea1.Name = "planea1";
            this.planea1.Size = new System.Drawing.Size(80, 20);
            this.planea1.TabIndex = 4;
            this.planea1.Text = "수주수량";
            // 
            // nowea1
            // 
            this.nowea1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nowea1.Location = new System.Drawing.Point(10, 50);
            this.nowea1.Name = "nowea1";
            this.nowea1.Size = new System.Drawing.Size(80, 20);
            this.nowea1.TabIndex = 3;
            this.nowea1.Text = "생산완료";
            // 
            // priority1
            // 
            this.priority1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.priority1.Location = new System.Drawing.Point(10, 30);
            this.priority1.Name = "priority1";
            this.priority1.Size = new System.Drawing.Size(80, 20);
            this.priority1.TabIndex = 2;
            this.priority1.Text = "우선순위";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(108, 150);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(62, 20);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "주문 취소";
            this.testButton.UseSelectable = true;
            // 
            // recivedate1
            // 
            this.recivedate1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.recivedate1.Location = new System.Drawing.Point(10, 10);
            this.recivedate1.Name = "recivedate1";
            this.recivedate1.Size = new System.Drawing.Size(80, 20);
            this.recivedate1.TabIndex = 0;
            this.recivedate1.Text = "수주날짜";
            // 
            // Tab_Plan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 580);
            this.Controls.Add(this.planManager);
            this.Controls.Add(this.dg_now);
            this.Controls.Add(this.donut);
            this.Controls.Add(this.dg_plan);
            this.Name = "Tab_Plan";
            this.Text = "생산계획";
            this.Load += new System.EventHandler(this.Tab_Plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_now)).EndInit();
            this.planManager.ResumeLayout(false);
            this.testTile1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_plan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart donut;
        private System.Windows.Forms.DataGridView dg_now;
        private MetroFramework.Drawing.Html.HtmlPanel planManager;
        private MetroFramework.Controls.MetroTile testTile1;
        private MetroFramework.Controls.MetroLabel duedate1;
        private MetroFramework.Controls.MetroLabel planea1;
        private MetroFramework.Controls.MetroLabel nowea1;
        private MetroFramework.Controls.MetroLabel priority1;
        private MetroFramework.Controls.MetroButton testButton;
        private MetroFramework.Controls.MetroLabel recivedate1;
    }
}
