namespace FinalProject_C3
{
    partial class Plan_DML
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dt_dueDate = new MetroFramework.Controls.MetroDateTime();
            this.tb_planEA = new MetroFramework.Controls.MetroTextBox();
            this.tb_comName = new MetroFramework.Controls.MetroTextBox();
            this.dt_reciveDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tb_priority = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.bt_update = new MetroFramework.Controls.MetroButton();
            this.bt_insert = new MetroFramework.Controls.MetroButton();
            this.cb_planNum = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(132, 192);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "납기일자";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(132, 242);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "수주수량";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(150, 289);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "고객사";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dt_dueDate
            // 
            this.dt_dueDate.Location = new System.Drawing.Point(238, 192);
            this.dt_dueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_dueDate.Name = "dt_dueDate";
            this.dt_dueDate.Size = new System.Drawing.Size(200, 29);
            this.dt_dueDate.TabIndex = 4;
            // 
            // tb_planEA
            // 
            // 
            // 
            // 
            this.tb_planEA.CustomButton.Image = null;
            this.tb_planEA.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.tb_planEA.CustomButton.Name = "";
            this.tb_planEA.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_planEA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_planEA.CustomButton.TabIndex = 1;
            this.tb_planEA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_planEA.CustomButton.UseSelectable = true;
            this.tb_planEA.CustomButton.Visible = false;
            this.tb_planEA.Lines = new string[0];
            this.tb_planEA.Location = new System.Drawing.Point(238, 242);
            this.tb_planEA.MaxLength = 32767;
            this.tb_planEA.Name = "tb_planEA";
            this.tb_planEA.PasswordChar = '\0';
            this.tb_planEA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_planEA.SelectedText = "";
            this.tb_planEA.SelectionLength = 0;
            this.tb_planEA.SelectionStart = 0;
            this.tb_planEA.ShortcutsEnabled = true;
            this.tb_planEA.Size = new System.Drawing.Size(200, 25);
            this.tb_planEA.TabIndex = 5;
            this.tb_planEA.UseSelectable = true;
            this.tb_planEA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_planEA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_comName
            // 
            // 
            // 
            // 
            this.tb_comName.CustomButton.Image = null;
            this.tb_comName.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.tb_comName.CustomButton.Name = "";
            this.tb_comName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_comName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_comName.CustomButton.TabIndex = 1;
            this.tb_comName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_comName.CustomButton.UseSelectable = true;
            this.tb_comName.CustomButton.Visible = false;
            this.tb_comName.Lines = new string[0];
            this.tb_comName.Location = new System.Drawing.Point(238, 289);
            this.tb_comName.MaxLength = 32767;
            this.tb_comName.Name = "tb_comName";
            this.tb_comName.PasswordChar = '\0';
            this.tb_comName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_comName.SelectedText = "";
            this.tb_comName.SelectionLength = 0;
            this.tb_comName.SelectionStart = 0;
            this.tb_comName.ShortcutsEnabled = true;
            this.tb_comName.Size = new System.Drawing.Size(200, 25);
            this.tb_comName.TabIndex = 6;
            this.tb_comName.UseSelectable = true;
            this.tb_comName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_comName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dt_reciveDate
            // 
            this.dt_reciveDate.Location = new System.Drawing.Point(238, 142);
            this.dt_reciveDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_reciveDate.Name = "dt_reciveDate";
            this.dt_reciveDate.Size = new System.Drawing.Size(200, 29);
            this.dt_reciveDate.TabIndex = 8;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(132, 143);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "수주일자";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_priority
            // 
            // 
            // 
            // 
            this.tb_priority.CustomButton.Image = null;
            this.tb_priority.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.tb_priority.CustomButton.Name = "";
            this.tb_priority.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_priority.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_priority.CustomButton.TabIndex = 1;
            this.tb_priority.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_priority.CustomButton.UseSelectable = true;
            this.tb_priority.CustomButton.Visible = false;
            this.tb_priority.Lines = new string[0];
            this.tb_priority.Location = new System.Drawing.Point(238, 338);
            this.tb_priority.MaxLength = 32767;
            this.tb_priority.Name = "tb_priority";
            this.tb_priority.PasswordChar = '\0';
            this.tb_priority.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_priority.SelectedText = "";
            this.tb_priority.SelectionLength = 0;
            this.tb_priority.SelectionStart = 0;
            this.tb_priority.ShortcutsEnabled = true;
            this.tb_priority.Size = new System.Drawing.Size(200, 25);
            this.tb_priority.TabIndex = 10;
            this.tb_priority.UseSelectable = true;
            this.tb_priority.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_priority.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(132, 338);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 25);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "우선순위";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(311, 388);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(60, 30);
            this.bt_update.TabIndex = 11;
            this.bt_update.Text = "수정";
            this.bt_update.UseSelectable = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(377, 388);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(60, 30);
            this.bt_insert.TabIndex = 12;
            this.bt_insert.Text = "등록";
            this.bt_insert.UseSelectable = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // cb_planNum
            // 
            this.cb_planNum.FormattingEnabled = true;
            this.cb_planNum.ItemHeight = 23;
            this.cb_planNum.Location = new System.Drawing.Point(238, 95);
            this.cb_planNum.Name = "cb_planNum";
            this.cb_planNum.Size = new System.Drawing.Size(200, 29);
            this.cb_planNum.TabIndex = 13;
            this.cb_planNum.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(132, 97);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 25);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "주문번호";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(0, 86);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(92, 365);
            this.metroTile1.TabIndex = 15;
            this.metroTile1.Text = "Mayflower";
            this.metroTile1.UseSelectable = true;
            // 
            // Plan_DML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cb_planNum);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.tb_priority);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dt_reciveDate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tb_comName);
            this.Controls.Add(this.tb_planEA);
            this.Controls.Add(this.dt_dueDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Plan_DML";
            this.Text = "등록/수정";
            this.Load += new System.EventHandler(this.Plan_DML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dt_dueDate;
        private MetroFramework.Controls.MetroTextBox tb_planEA;
        private MetroFramework.Controls.MetroTextBox tb_comName;
        private MetroFramework.Controls.MetroDateTime dt_reciveDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tb_priority;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton bt_update;
        private MetroFramework.Controls.MetroButton bt_insert;
        private MetroFramework.Controls.MetroComboBox cb_planNum;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}