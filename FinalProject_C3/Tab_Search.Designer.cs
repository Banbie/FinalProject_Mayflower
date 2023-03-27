namespace FinalProject_C3
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
            this.components = new System.ComponentModel.Container();
            this.dgv_flow = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_flow
            // 
            this.dgv_flow.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_flow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_flow.Location = new System.Drawing.Point(23, 63);
            this.dgv_flow.Name = "dgv_flow";
            this.dgv_flow.RowHeadersWidth = 51;
            this.dgv_flow.RowTemplate.Height = 23;
            this.dgv_flow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_flow.Size = new System.Drawing.Size(843, 316);
            this.dgv_flow.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // dtp_start
            // 
            this.dtp_start.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_start.Location = new System.Drawing.Point(444, 31);
            this.dtp_start.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(197, 26);
            this.dtp_start.TabIndex = 5;
            // 
            // dtp_end
            // 
            this.dtp_end.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_end.Location = new System.Drawing.Point(669, 31);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(197, 26);
            this.dtp_end.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "~";
            // 
            // Tab_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.dgv_flow);
            this.Name = "Tab_Search";
            this.Text = "실적확인";
            this.Load += new System.EventHandler(this.Tab_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_flow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label1;
    }
}