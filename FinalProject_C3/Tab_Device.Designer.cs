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
            this.bt_flowupdate = new System.Windows.Forms.Button();
            this.cb_ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_flow = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flow)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_flowupdate
            // 
            this.bt_flowupdate.Location = new System.Drawing.Point(418, 312);
            this.bt_flowupdate.Name = "bt_flowupdate";
            this.bt_flowupdate.Size = new System.Drawing.Size(61, 28);
            this.bt_flowupdate.TabIndex = 0;
            this.bt_flowupdate.Text = "적용";
            this.bt_flowupdate.UseVisualStyleBackColor = true;
            // 
            // cb_
            // 
            this.cb_.FormattingEnabled = true;
            this.cb_.Location = new System.Drawing.Point(291, 316);
            this.cb_.Name = "cb_";
            this.cb_.Size = new System.Drawing.Size(121, 20);
            this.cb_.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "공정현황";
            // 
            // dgv_flow
            // 
            this.dgv_flow.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_flow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_flow.Location = new System.Drawing.Point(11, 48);
            this.dgv_flow.Name = "dgv_flow";
            this.dgv_flow.RowTemplate.Height = 23;
            this.dgv_flow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_flow.Size = new System.Drawing.Size(843, 254);
            this.dgv_flow.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "생산계획";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_name.Location = new System.Drawing.Point(754, 316);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(81, 16);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "ㅇㅇㅇ 님";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Revert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(214, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "제품번호";
            // 
            // Tab_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgv_flow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_);
            this.Controls.Add(this.bt_flowupdate);
            this.Name = "Tab_Device";
            this.Text = "디바이스관리";
            this.Load += new System.EventHandler(this.Tab_Device_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_flowupdate;
        private System.Windows.Forms.ComboBox cb_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_flow;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}