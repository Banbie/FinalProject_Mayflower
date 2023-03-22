namespace FinalProject_C3
{
    partial class Admin
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
            this.pn_Top = new System.Windows.Forms.Panel();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_접속시간 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_현재시간 = new System.Windows.Forms.Label();
            this.lb_NowTime = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.cb_Hide = new System.Windows.Forms.CheckBox();
            this.bt_Staff = new System.Windows.Forms.Button();
            this.bt_Data = new System.Windows.Forms.Button();
            this.bt_Device = new System.Windows.Forms.Button();
            this.bt_Poor = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Plan = new System.Windows.Forms.Button();
            this.timerSliding = new System.Windows.Forms.Timer(this.components);
            this.pn_Center = new System.Windows.Forms.Panel();
            this.pn_Top.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Top
            // 
            this.pn_Top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pn_Top.Controls.Add(this.lb_UserName);
            this.pn_Top.Controls.Add(this.lb_Position);
            this.pn_Top.Controls.Add(this.lb_접속시간);
            this.pn_Top.Controls.Add(this.label2);
            this.pn_Top.Controls.Add(this.lb_현재시간);
            this.pn_Top.Controls.Add(this.lb_NowTime);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(1264, 100);
            this.pn_Top.TabIndex = 0;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_UserName.Location = new System.Drawing.Point(1033, 53);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(63, 13);
            this.lb_UserName.TabIndex = 5;
            this.lb_UserName.Text = "직원이름";
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Position.Location = new System.Drawing.Point(990, 53);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(35, 13);
            this.lb_Position.TabIndex = 4;
            this.lb_Position.Text = "직급";
            // 
            // lb_접속시간
            // 
            this.lb_접속시간.AutoSize = true;
            this.lb_접속시간.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_접속시간.Location = new System.Drawing.Point(962, 9);
            this.lb_접속시간.Name = "lb_접속시간";
            this.lb_접속시간.Size = new System.Drawing.Size(63, 13);
            this.lb_접속시간.TabIndex = 3;
            this.lb_접속시간.Text = "접속시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1031, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "09:00:00";
            // 
            // lb_현재시간
            // 
            this.lb_현재시간.AutoSize = true;
            this.lb_현재시간.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_현재시간.Location = new System.Drawing.Point(962, 31);
            this.lb_현재시간.Name = "lb_현재시간";
            this.lb_현재시간.Size = new System.Drawing.Size(63, 13);
            this.lb_현재시간.TabIndex = 1;
            this.lb_현재시간.Text = "현재시간";
            // 
            // lb_NowTime
            // 
            this.lb_NowTime.AutoSize = true;
            this.lb_NowTime.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_NowTime.Location = new System.Drawing.Point(1031, 31);
            this.lb_NowTime.Name = "lb_NowTime";
            this.lb_NowTime.Size = new System.Drawing.Size(65, 13);
            this.lb_NowTime.TabIndex = 0;
            this.lb_NowTime.Text = "09:00:00";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSideMenu.Controls.Add(this.cb_Hide);
            this.panelSideMenu.Controls.Add(this.bt_Staff);
            this.panelSideMenu.Controls.Add(this.bt_Data);
            this.panelSideMenu.Controls.Add(this.bt_Device);
            this.panelSideMenu.Controls.Add(this.bt_Poor);
            this.panelSideMenu.Controls.Add(this.bt_Search);
            this.panelSideMenu.Controls.Add(this.bt_Plan);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 100);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 581);
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
            this.cb_Hide.Location = new System.Drawing.Point(0, 531);
            this.cb_Hide.Name = "cb_Hide";
            this.cb_Hide.Size = new System.Drawing.Size(200, 50);
            this.cb_Hide.TabIndex = 9;
            this.cb_Hide.Text = "<";
            this.cb_Hide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_Hide.UseVisualStyleBackColor = true;
            this.cb_Hide.CheckedChanged += new System.EventHandler(this.cb_Hide_CheckedChanged);
            // 
            // bt_Staff
            // 
            this.bt_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Staff.FlatAppearance.BorderSize = 0;
            this.bt_Staff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_Staff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Staff.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_Staff.ForeColor = System.Drawing.Color.White;
            this.bt_Staff.Location = new System.Drawing.Point(0, 250);
            this.bt_Staff.Name = "bt_Staff";
            this.bt_Staff.Size = new System.Drawing.Size(200, 50);
            this.bt_Staff.TabIndex = 8;
            this.bt_Staff.Text = "직원 관리";
            this.bt_Staff.UseVisualStyleBackColor = false;
            this.bt_Staff.Click += new System.EventHandler(this.bt_Staff_Click);
            // 
            // bt_Data
            // 
            this.bt_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Data.FlatAppearance.BorderSize = 0;
            this.bt_Data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Data.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_Data.ForeColor = System.Drawing.Color.White;
            this.bt_Data.Location = new System.Drawing.Point(0, 200);
            this.bt_Data.Name = "bt_Data";
            this.bt_Data.Size = new System.Drawing.Size(200, 50);
            this.bt_Data.TabIndex = 7;
            this.bt_Data.Text = "설비 데이터";
            this.bt_Data.UseVisualStyleBackColor = false;
            this.bt_Data.Click += new System.EventHandler(this.bt_Data_Click);
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
            // bt_Poor
            // 
            this.bt_Poor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Poor.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Poor.FlatAppearance.BorderSize = 0;
            this.bt_Poor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bt_Poor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bt_Poor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Poor.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.bt_Poor.ForeColor = System.Drawing.Color.White;
            this.bt_Poor.Location = new System.Drawing.Point(0, 100);
            this.bt_Poor.Name = "bt_Poor";
            this.bt_Poor.Size = new System.Drawing.Size(200, 50);
            this.bt_Poor.TabIndex = 4;
            this.bt_Poor.Text = "불량 추적";
            this.bt_Poor.UseVisualStyleBackColor = false;
            this.bt_Poor.Click += new System.EventHandler(this.bt_Poor_Click);
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
            this.bt_Search.Text = "실적 검색";
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
            // timerSliding
            // 
            this.timerSliding.Interval = 10;
            this.timerSliding.Tick += new System.EventHandler(this.timerSliding_Tick);
            // 
            // pn_Center
            // 
            this.pn_Center.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Center.Location = new System.Drawing.Point(200, 100);
            this.pn_Center.Name = "pn_Center";
            this.pn_Center.Size = new System.Drawing.Size(1064, 581);
            this.pn_Center.TabIndex = 4;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pn_Center);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.pn_Top);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.CheckBox cb_Hide;
        private System.Windows.Forms.Button bt_Staff;
        private System.Windows.Forms.Button bt_Data;
        private System.Windows.Forms.Button bt_Device;
        private System.Windows.Forms.Button bt_Poor;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_Plan;
        private System.Windows.Forms.Timer timerSliding;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.Label lb_접속시간;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_현재시간;
        private System.Windows.Forms.Label lb_NowTime;
        private System.Windows.Forms.Panel pn_Center;
    }
}