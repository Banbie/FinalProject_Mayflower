namespace FinalProject_C3
{
    partial class Admin
    {
        //private static MetroFramework.Forms.MetroForm mtForm = new MetroFramework.Forms.MetroForm();
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
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_NowTime = new System.Windows.Forms.Label();
            this.timerSliding = new System.Windows.Forms.Timer(this.components);
            this.pn_Center = new System.Windows.Forms.Panel();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.cb_Hide = new System.Windows.Forms.CheckBox();
            this.bt_Monitor = new System.Windows.Forms.Button();
            this.bt_State = new System.Windows.Forms.Button();
            this.bt_Device = new System.Windows.Forms.Button();
            this.bt_Defect = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Plan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Right = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_UserName.Location = new System.Drawing.Point(223, 41);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(63, 13);
            this.lb_UserName.TabIndex = 5;
            this.lb_UserName.Text = "직원이름";
            // 
            // lb_Position
            // 
            this.lb_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Position.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Position.Location = new System.Drawing.Point(1379, 23);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(157, 13);
            this.lb_Position.TabIndex = 4;
            this.lb_Position.Text = "관리자";
            this.lb_Position.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_NowTime
            // 
            this.lb_NowTime.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_NowTime.Location = new System.Drawing.Point(1186, 38);
            this.lb_NowTime.Name = "lb_NowTime";
            this.lb_NowTime.Size = new System.Drawing.Size(350, 16);
            this.lb_NowTime.TabIndex = 0;
            this.lb_NowTime.Text = "0900:0000";
            this.lb_NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerSliding
            // 
            this.timerSliding.Interval = 10;
            this.timerSliding.Tick += new System.EventHandler(this.timerSliding_Tick);
            // 
            // pn_Center
            // 
            this.pn_Center.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Center.Location = new System.Drawing.Point(20, 60);
            this.pn_Center.Name = "pn_Center";
            this.pn_Center.Size = new System.Drawing.Size(0, 804);
            this.pn_Center.TabIndex = 4;
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSideMenu.Controls.Add(this.cb_Hide);
            this.panelSideMenu.Controls.Add(this.bt_Monitor);
            this.panelSideMenu.Controls.Add(this.bt_State);
            this.panelSideMenu.Controls.Add(this.bt_Device);
            this.panelSideMenu.Controls.Add(this.bt_Defect);
            this.panelSideMenu.Controls.Add(this.bt_Search);
            this.panelSideMenu.Controls.Add(this.bt_Plan);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 804);
            this.panelSideMenu.TabIndex = 3;
            // 
            // cb_Hide
            // 
            this.cb_Hide.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_Hide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_Hide.FlatAppearance.BorderSize = 0;
            this.cb_Hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cb_Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cb_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Hide.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Hide.ForeColor = System.Drawing.Color.White;
            this.cb_Hide.Location = new System.Drawing.Point(0, 754);
            this.cb_Hide.Name = "cb_Hide";
            this.cb_Hide.Size = new System.Drawing.Size(200, 50);
            this.cb_Hide.TabIndex = 9;
            this.cb_Hide.Text = "<";
            this.cb_Hide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Hide.UseVisualStyleBackColor = true;
            this.cb_Hide.CheckedChanged += new System.EventHandler(this.cb_Hide_CheckedChanged);
            // 
            // bt_Monitor
            // 
            this.bt_Monitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Monitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Monitor.FlatAppearance.BorderSize = 0;
            this.bt_Monitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_Monitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_Monitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Monitor.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_Monitor.ForeColor = System.Drawing.Color.White;
            this.bt_Monitor.Location = new System.Drawing.Point(0, 250);
            this.bt_Monitor.Name = "bt_Monitor";
            this.bt_Monitor.Size = new System.Drawing.Size(200, 50);
            this.bt_Monitor.TabIndex = 8;
            this.bt_Monitor.Text = "모니터링";
            this.bt_Monitor.UseVisualStyleBackColor = false;
            this.bt_Monitor.Click += new System.EventHandler(this.bt_Monitor_Click);
            // 
            // bt_State
            // 
            this.bt_State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_State.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_State.FlatAppearance.BorderSize = 0;
            this.bt_State.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_State.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_State.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_State.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_State.ForeColor = System.Drawing.Color.White;
            this.bt_State.Location = new System.Drawing.Point(0, 200);
            this.bt_State.Name = "bt_State";
            this.bt_State.Size = new System.Drawing.Size(200, 50);
            this.bt_State.TabIndex = 7;
            this.bt_State.Text = "설비 데이터";
            this.bt_State.UseVisualStyleBackColor = false;
            this.bt_State.Click += new System.EventHandler(this.bt_Data_Click);
            // 
            // bt_Device
            // 
            this.bt_Device.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Device.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Device.FlatAppearance.BorderSize = 0;
            this.bt_Device.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_Device.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_Device.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Device.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_Device.ForeColor = System.Drawing.Color.White;
            this.bt_Device.Location = new System.Drawing.Point(0, 150);
            this.bt_Device.Name = "bt_Device";
            this.bt_Device.Size = new System.Drawing.Size(200, 50);
            this.bt_Device.TabIndex = 5;
            this.bt_Device.Text = "디바이스 관리";
            this.bt_Device.UseVisualStyleBackColor = false;
            this.bt_Device.Click += new System.EventHandler(this.bt_Device_Click);
            // 
            // bt_Defect
            // 
            this.bt_Defect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Defect.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Defect.FlatAppearance.BorderSize = 0;
            this.bt_Defect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_Defect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_Defect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Defect.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_Defect.ForeColor = System.Drawing.Color.White;
            this.bt_Defect.Location = new System.Drawing.Point(0, 100);
            this.bt_Defect.Name = "bt_Defect";
            this.bt_Defect.Size = new System.Drawing.Size(200, 50);
            this.bt_Defect.TabIndex = 4;
            this.bt_Defect.Text = "불량 추적";
            this.bt_Defect.UseVisualStyleBackColor = false;
            this.bt_Defect.Click += new System.EventHandler(this.bt_Poor_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Search.FlatAppearance.BorderSize = 0;
            this.bt_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_Search.ForeColor = System.Drawing.Color.White;
            this.bt_Search.Location = new System.Drawing.Point(0, 50);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(200, 50);
            this.bt_Search.TabIndex = 3;
            this.bt_Search.Text = "실적 확인";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Plan
            // 
            this.bt_Plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Plan.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Plan.FlatAppearance.BorderSize = 0;
            this.bt_Plan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_Plan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Plan.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_Plan.ForeColor = System.Drawing.Color.White;
            this.bt_Plan.Location = new System.Drawing.Point(0, 0);
            this.bt_Plan.Name = "bt_Plan";
            this.bt_Plan.Size = new System.Drawing.Size(200, 50);
            this.bt_Plan.TabIndex = 2;
            this.bt_Plan.Text = "생산 계획";
            this.bt_Plan.UseVisualStyleBackColor = false;
            this.bt_Plan.Click += new System.EventHandler(this.bt_Plan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pn_Right);
            this.panel1.Controls.Add(this.panelSideMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 804);
            this.panel1.TabIndex = 6;
            // 
            // pn_Right
            // 
            this.pn_Right.Location = new System.Drawing.Point(206, 3);
            this.pn_Right.Margin = new System.Windows.Forms.Padding(0);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(1307, 798);
            this.pn_Right.TabIndex = 4;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.pn_Center);
            this.Controls.Add(this.lb_Position);
            this.Controls.Add(this.lb_NowTime);
            this.Name = "Admin";
            this.Text = "MayFlower";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Timer timerSliding;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.Label lb_NowTime;
        private System.Windows.Forms.Panel pn_Center;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.CheckBox cb_Hide;
        private System.Windows.Forms.Button bt_Monitor;
        private System.Windows.Forms.Button bt_State;
        private System.Windows.Forms.Button bt_Device;
        private System.Windows.Forms.Button bt_Defect;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_Plan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_Right;
    }
}