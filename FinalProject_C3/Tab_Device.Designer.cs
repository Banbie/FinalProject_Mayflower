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
            this.dgv_flow = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_plan = new MetroFramework.Controls.MetroComboBox();
            this.cb_prod = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bt_flowupdate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_flow
            // 
            this.dgv_flow.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_flow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_flow.Location = new System.Drawing.Point(11, 57);
            this.dgv_flow.Name = "dgv_flow";
            this.dgv_flow.RowHeadersWidth = 51;
            this.dgv_flow.RowTemplate.Height = 23;
            this.dgv_flow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_flow.Size = new System.Drawing.Size(843, 268);
            this.dgv_flow.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(654, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_name.Location = new System.Drawing.Point(764, 335);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(81, 16);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "ㅇㅇㅇ 님";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(757, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Revert";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cb_plan
            // 
            this.cb_plan.FormattingEnabled = true;
            this.cb_plan.ItemHeight = 23;
            this.cb_plan.Location = new System.Drawing.Point(99, 331);
            this.cb_plan.Name = "cb_plan";
            this.cb_plan.Size = new System.Drawing.Size(138, 29);
            this.cb_plan.TabIndex = 12;
            this.cb_plan.UseSelectable = true;
            // 
            // cb_prod
            // 
            this.cb_prod.FormattingEnabled = true;
            this.cb_prod.ItemHeight = 23;
            this.cb_prod.Location = new System.Drawing.Point(344, 331);
            this.cb_prod.Name = "cb_prod";
            this.cb_prod.Size = new System.Drawing.Size(138, 29);
            this.cb_prod.TabIndex = 13;
            this.cb_prod.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(9, 334);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "생산계획";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(254, 334);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "제품번호";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_flowupdate
            // 
            this.bt_flowupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_flowupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_flowupdate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_flowupdate.ForeColor = System.Drawing.Color.White;
            this.bt_flowupdate.Location = new System.Drawing.Point(488, 331);
            this.bt_flowupdate.Name = "bt_flowupdate";
            this.bt_flowupdate.Size = new System.Drawing.Size(81, 28);
            this.bt_flowupdate.TabIndex = 0;
            this.bt_flowupdate.Text = "적용";
            this.bt_flowupdate.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tab_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 369);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cb_prod);
            this.Controls.Add(this.cb_plan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_flow);
            this.Controls.Add(this.bt_flowupdate);
            this.Name = "Tab_Device";
            this.Text = "디바이스관리";
            this.Load += new System.EventHandler(this.Tab_Device_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_flow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroComboBox cb_plan;
        private MetroFramework.Controls.MetroComboBox cb_prod;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button bt_flowupdate;
        private System.Windows.Forms.Timer timer1;
    }
}