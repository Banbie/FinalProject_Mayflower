namespace FinalProject_C3
{
    partial class Tab_Device
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
            this.dgv_device = new System.Windows.Forms.DataGridView();
            this.bt_devicein = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_cur = new System.Windows.Forms.DataGridView();
            this.bt_deviceup = new System.Windows.Forms.Button();
            this.bt_devicedel = new System.Windows.Forms.Button();
            this.dt_start = new MetroFramework.Controls.MetroDateTime();
            this.dt_end = new MetroFramework.Controls.MetroDateTime();
            this.dgv_deflow = new System.Windows.Forms.DataGridView();
            this.bt_search = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pro = new MetroFramework.Controls.MetroComboBox();
            this.devicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deflow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_device
            // 
            this.dgv_device.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_device.Location = new System.Drawing.Point(23, 122);
            this.dgv_device.Name = "dgv_device";
            this.dgv_device.RowHeadersWidth = 51;
            this.dgv_device.RowTemplate.Height = 23;
            this.dgv_device.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_device.Size = new System.Drawing.Size(443, 268);
            this.dgv_device.TabIndex = 3;
            this.dgv_device.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_device_CellClick);
            // 
            // bt_devicein
            // 
            this.bt_devicein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_devicein.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_devicein.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_devicein.ForeColor = System.Drawing.Color.White;
            this.bt_devicein.Location = new System.Drawing.Point(258, 38);
            this.bt_devicein.Name = "bt_devicein";
            this.bt_devicein.Size = new System.Drawing.Size(64, 28);
            this.bt_devicein.TabIndex = 0;
            this.bt_devicein.Text = "추가";
            this.bt_devicein.UseVisualStyleBackColor = false;
            this.bt_devicein.Click += new System.EventHandler(this.bt_devicein_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_cur
            // 
            this.dgv_cur.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_cur.Location = new System.Drawing.Point(23, 72);
            this.dgv_cur.Name = "dgv_cur";
            this.dgv_cur.RowTemplate.Height = 23;
            this.dgv_cur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_cur.Size = new System.Drawing.Size(443, 44);
            this.dgv_cur.TabIndex = 18;
            // 
            // bt_deviceup
            // 
            this.bt_deviceup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_deviceup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_deviceup.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_deviceup.ForeColor = System.Drawing.Color.White;
            this.bt_deviceup.Location = new System.Drawing.Point(328, 38);
            this.bt_deviceup.Name = "bt_deviceup";
            this.bt_deviceup.Size = new System.Drawing.Size(64, 28);
            this.bt_deviceup.TabIndex = 20;
            this.bt_deviceup.Text = "수정";
            this.bt_deviceup.UseVisualStyleBackColor = false;
            this.bt_deviceup.Click += new System.EventHandler(this.bt_deviceup_Click);
            // 
            // bt_devicedel
            // 
            this.bt_devicedel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_devicedel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_devicedel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_devicedel.ForeColor = System.Drawing.Color.White;
            this.bt_devicedel.Location = new System.Drawing.Point(402, 38);
            this.bt_devicedel.Name = "bt_devicedel";
            this.bt_devicedel.Size = new System.Drawing.Size(64, 28);
            this.bt_devicedel.TabIndex = 21;
            this.bt_devicedel.Text = "삭제";
            this.bt_devicedel.UseVisualStyleBackColor = false;
            this.bt_devicedel.Click += new System.EventHandler(this.bt_devicedel_Click);
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(472, 325);
            this.dt_start.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(184, 29);
            this.dt_start.TabIndex = 22;
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(675, 325);
            this.dt_end.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(184, 29);
            this.dt_end.TabIndex = 23;
            // 
            // dgv_deflow
            // 
            this.dgv_deflow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deflow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devicename,
            this.proname,
            this.flowdate,
            this.Column6});
            this.dgv_deflow.Location = new System.Drawing.Point(472, 72);
            this.dgv_deflow.Name = "dgv_deflow";
            this.dgv_deflow.RowHeadersVisible = false;
            this.dgv_deflow.RowHeadersWidth = 51;
            this.dgv_deflow.RowTemplate.Height = 23;
            this.dgv_deflow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_deflow.Size = new System.Drawing.Size(387, 247);
            this.dgv_deflow.TabIndex = 24;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_search.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_search.ForeColor = System.Drawing.Color.White;
            this.bt_search.Location = new System.Drawing.Point(751, 360);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(108, 28);
            this.bt_search.TabIndex = 25;
            this.bt_search.Text = "조회";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "디바이스번호";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "디바이스이름";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "공정순서번호";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "공정이름";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(657, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // cb_pro
            // 
            this.cb_pro.FormattingEnabled = true;
            this.cb_pro.ItemHeight = 23;
            this.cb_pro.Location = new System.Drawing.Point(472, 359);
            this.cb_pro.Name = "cb_pro";
            this.cb_pro.Size = new System.Drawing.Size(273, 29);
            this.cb_pro.TabIndex = 27;
            this.cb_pro.UseSelectable = true;
            // 
            // devicename
            // 
            this.devicename.HeaderText = "디바이스이름";
            this.devicename.Name = "devicename";
            // 
            // proname
            // 
            this.proname.HeaderText = "공정이름";
            this.proname.Name = "proname";
            this.proname.Width = 90;
            // 
            // flowdate
            // 
            this.flowdate.HeaderText = "날짜";
            this.flowdate.Name = "flowdate";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "총 가동 횟수";
            this.Column6.Name = "Column6";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_name.Location = new System.Drawing.Point(698, 32);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(103, 29);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "홍길동";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(816, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "님";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tab_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_pro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.dgv_deflow);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.bt_devicedel);
            this.Controls.Add(this.bt_deviceup);
            this.Controls.Add(this.dgv_cur);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.dgv_device);
            this.Controls.Add(this.bt_devicein);
            this.Name = "Tab_Device";
            this.Text = "디바이스관리";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tab_Device_FormClosed);
            this.Load += new System.EventHandler(this.Tab_Device_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deflow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_device;
        private System.Windows.Forms.Button bt_devicein;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_cur;
        private System.Windows.Forms.Button bt_deviceup;
        private System.Windows.Forms.Button bt_devicedel;
        private MetroFramework.Controls.MetroDateTime dt_start;
        private MetroFramework.Controls.MetroDateTime dt_end;
        private System.Windows.Forms.DataGridView dgv_deflow;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cb_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn proname;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label2;
    }
}