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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.donut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.planManager = new MetroFramework.Drawing.Html.HtmlPanel();
            this.testTile = new MetroFramework.Controls.MetroTile();
            this.testLabel = new MetroFramework.Controls.MetroLabel();
            this.testButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut)).BeginInit();
            this.planManager.SuspendLayout();
            this.testTile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // donut
            // 
            chartArea3.Name = "ChartArea1";
            this.donut.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.donut.Legends.Add(legend3);
            this.donut.Location = new System.Drawing.Point(1056, 451);
            this.donut.Name = "donut";
            this.donut.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.donut.Series.Add(series3);
            this.donut.Size = new System.Drawing.Size(661, 526);
            this.donut.TabIndex = 7;
            this.donut.Text = "chart1";
            // 
            // planManager
            // 
            this.planManager.AutoScroll = true;
            this.planManager.AutoScrollMinSize = new System.Drawing.Size(1694, 18);
            this.planManager.BackColor = System.Drawing.SystemColors.Window;
            this.planManager.Controls.Add(this.testTile1);
            this.planManager.Location = new System.Drawing.Point(23, 63);
            this.planManager.Name = "planManager";
            this.planManager.Size = new System.Drawing.Size(1694, 364);
            this.planManager.TabIndex = 11;
            this.planManager.Text = "Plan Manager";
            // 
            // testTile1
            // 
            this.testTile1.ActiveControl = null;
            this.testTile1.Controls.Add(this.testTB);
            this.testTile1.Controls.Add(this.metroLabel1);
            this.testTile1.Controls.Add(this.plannumValue1);
            this.testTile1.Controls.Add(this.plannum1);
            this.testTile1.Controls.Add(this.duedateValue1);
            this.testTile1.Controls.Add(this.planeaValue1);
            this.testTile1.Controls.Add(this.noweaValue1);
            this.testTile1.Controls.Add(this.priorityVelue1);
            this.testTile1.Controls.Add(this.recivedateValue1);
            this.testTile1.Controls.Add(this.duedate1);
            this.testTile1.Controls.Add(this.planea1);
            this.testTile1.Controls.Add(this.nowea1);
            this.testTile1.Controls.Add(this.priority1);
            this.testTile1.Controls.Add(this.recivedate1);
            this.testTile1.Location = new System.Drawing.Point(10, 30);
            this.testTile1.Name = "testTile1";
            this.testTile1.Size = new System.Drawing.Size(300, 300);
            this.testTile1.TabIndex = 0;
            this.testTile1.Text = "고객사";
            this.testTile1.UseSelectable = true;
            this.testTile1.Visible = false;
            // 
            // testLabel
            // 
            this.testLabel.Location = new System.Drawing.Point(10, 10);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(80, 20);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "수주날짜";
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
            this.testTB.CustomButton.Image = null;
            this.testTB.CustomButton.Location = new System.Drawing.Point(42, 2);
            this.testTB.CustomButton.Name = "";
            this.testTB.CustomButton.Size = new System.Drawing.Size(155, 155);
            this.testTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.testTB.CustomButton.TabIndex = 1;
            this.testTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.testTB.CustomButton.UseSelectable = true;
            this.testTB.CustomButton.Visible = false;
            this.testTB.Lines = new string[] {
        "Memo"};
            this.testTB.Location = new System.Drawing.Point(90, 130);
            this.testTB.MaxLength = 32767;
            this.testTB.Name = "testTB";
            this.testTB.PasswordChar = '\0';
            this.testTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.testTB.SelectedText = "";
            this.testTB.SelectionLength = 0;
            this.testTB.SelectionStart = 0;
            this.testTB.ShortcutsEnabled = true;
            this.testTB.Size = new System.Drawing.Size(200, 160);
            this.testTB.TabIndex = 14;
            this.testTB.Text = "Memo";
            this.testTB.UseSelectable = true;
            this.testTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.testTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(10, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 20);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "비고";
            // 
            // plannumValue1
            // 
            this.plannumValue1.Enabled = false;
            this.plannumValue1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.plannumValue1.Location = new System.Drawing.Point(90, 110);
            this.plannumValue1.Name = "plannumValue1";
            this.plannumValue1.Size = new System.Drawing.Size(80, 20);
            this.plannumValue1.TabIndex = 12;
            this.plannumValue1.Text = "1";
            // 
            // plannum1
            // 
            this.plannum1.Enabled = false;
            this.plannum1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.plannum1.Location = new System.Drawing.Point(10, 110);
            this.plannum1.Name = "plannum1";
            this.plannum1.Size = new System.Drawing.Size(80, 20);
            this.plannum1.TabIndex = 11;
            this.plannum1.Text = "주문번호";
            // 
            // duedateValue1
            // 
            this.duedateValue1.Enabled = false;
            this.duedateValue1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.duedateValue1.Location = new System.Drawing.Point(90, 90);
            this.duedateValue1.Name = "duedateValue1";
            this.duedateValue1.Size = new System.Drawing.Size(87, 20);
            this.duedateValue1.TabIndex = 10;
            this.duedateValue1.Text = "2023-04-07";
            // 
            // planeaValue1
            // 
            this.planeaValue1.Enabled = false;
            this.planeaValue1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.planeaValue1.Location = new System.Drawing.Point(90, 70);
            this.planeaValue1.Name = "planeaValue1";
            this.planeaValue1.Size = new System.Drawing.Size(80, 20);
            this.planeaValue1.TabIndex = 9;
            this.planeaValue1.Text = "20";
            // 
            // noweaValue1
            // 
            this.noweaValue1.Enabled = false;
            this.noweaValue1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.noweaValue1.Location = new System.Drawing.Point(90, 50);
            this.noweaValue1.Name = "noweaValue1";
            this.noweaValue1.Size = new System.Drawing.Size(80, 20);
            this.noweaValue1.TabIndex = 8;
            this.noweaValue1.Text = "10";
            // 
            // priorityVelue1
            // 
            this.priorityVelue1.Enabled = false;
            this.priorityVelue1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.priorityVelue1.Location = new System.Drawing.Point(90, 30);
            this.priorityVelue1.Name = "priorityVelue1";
            this.priorityVelue1.Size = new System.Drawing.Size(80, 20);
            this.priorityVelue1.TabIndex = 7;
            this.priorityVelue1.Text = "0";
            // 
            // recivedateValue1
            // 
            this.recivedateValue1.Enabled = false;
            this.recivedateValue1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.recivedateValue1.Location = new System.Drawing.Point(90, 10);
            this.recivedateValue1.Name = "recivedateValue1";
            this.recivedateValue1.Size = new System.Drawing.Size(90, 20);
            this.recivedateValue1.TabIndex = 6;
            this.recivedateValue1.Text = "2023-03-27";
            // 
            // duedate1
            // 
            this.duedate1.Enabled = false;
            this.duedate1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.duedate1.Location = new System.Drawing.Point(10, 90);
            this.duedate1.Name = "duedate1";
            this.duedate1.Size = new System.Drawing.Size(80, 20);
            this.duedate1.TabIndex = 5;
            this.duedate1.Text = "납기일자";
            // 
            // planea1
            // 
            this.planea1.Enabled = false;
            this.planea1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.planea1.Location = new System.Drawing.Point(10, 70);
            this.planea1.Name = "planea1";
            this.planea1.Size = new System.Drawing.Size(80, 20);
            this.planea1.TabIndex = 4;
            this.planea1.Text = "수주수량";
            // 
            // nowea1
            // 
            this.nowea1.Enabled = false;
            this.nowea1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nowea1.Location = new System.Drawing.Point(10, 50);
            this.nowea1.Name = "nowea1";
            this.nowea1.Size = new System.Drawing.Size(80, 20);
            this.nowea1.TabIndex = 3;
            this.nowea1.Text = "생산완료";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(10, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "생산완료";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(10, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "수주수량";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(10, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "납기일자";
            // 
            // Tab_Plan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1740, 1000);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.planManager);
            this.Controls.Add(this.donut);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Tab_Plan";
            this.Text = "PRODUCT_PLAN";
            ((System.ComponentModel.ISupportInitialize)(this.donut)).EndInit();
            this.planManager.ResumeLayout(false);
            this.testTile1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart donut;
        private MetroFramework.Drawing.Html.HtmlPanel planManager;
        private MetroFramework.Controls.MetroTile testTile1;
        private MetroFramework.Controls.MetroLabel duedate1;
        private MetroFramework.Controls.MetroLabel planea1;
        private MetroFramework.Controls.MetroLabel nowea1;
        private MetroFramework.Controls.MetroLabel priority1;
        private MetroFramework.Controls.MetroLabel recivedate1;
        private MetroFramework.Controls.MetroLabel plannumValue1;
        private MetroFramework.Controls.MetroLabel plannum1;
        private MetroFramework.Controls.MetroLabel duedateValue1;
        private MetroFramework.Controls.MetroLabel planeaValue1;
        private MetroFramework.Controls.MetroLabel noweaValue1;
        private MetroFramework.Controls.MetroLabel priorityVelue1;
        private MetroFramework.Controls.MetroLabel recivedateValue1;
        private MetroFramework.Controls.MetroTextBox testTB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
