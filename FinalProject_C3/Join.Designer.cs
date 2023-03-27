namespace FinalProject_C3
{
    partial class Join
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
            this.BT_JOIN = new System.Windows.Forms.Button();
            this.TB_PW = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_PW2 = new System.Windows.Forms.TextBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.TB_NUM = new System.Windows.Forms.TextBox();
            this.CB_AUTHOR = new System.Windows.Forms.ComboBox();
            this.TB_AUTHOR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PNL_JOIN = new System.Windows.Forms.Panel();
            this.PNL_JOIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_JOIN
            // 
            this.BT_JOIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BT_JOIN.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_JOIN.ForeColor = System.Drawing.Color.White;
            this.BT_JOIN.Location = new System.Drawing.Point(37, 354);
            this.BT_JOIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_JOIN.Name = "BT_JOIN";
            this.BT_JOIN.Size = new System.Drawing.Size(140, 43);
            this.BT_JOIN.TabIndex = 0;
            this.BT_JOIN.Text = "확인";
            this.BT_JOIN.UseVisualStyleBackColor = false;
            this.BT_JOIN.Click += new System.EventHandler(this.BT_JOIN_Click);
            // 
            // TB_PW
            // 
            this.TB_PW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PW.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_PW.Location = new System.Drawing.Point(19, 148);
            this.TB_PW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PW.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_PW.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_PW.Name = "TB_PW";
            this.TB_PW.Size = new System.Drawing.Size(175, 26);
            this.TB_PW.TabIndex = 3;
            this.TB_PW.Text = "패스워드";
            // 
            // TB_ID
            // 
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ID.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_ID.Location = new System.Drawing.Point(19, 100);
            this.TB_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_ID.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_ID.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(175, 26);
            this.TB_ID.TabIndex = 2;
            this.TB_ID.Text = "아이디";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_PW2
            // 
            this.TB_PW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PW2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_PW2.Location = new System.Drawing.Point(19, 182);
            this.TB_PW2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PW2.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_PW2.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_PW2.Name = "TB_PW2";
            this.TB_PW2.Size = new System.Drawing.Size(175, 26);
            this.TB_PW2.TabIndex = 8;
            this.TB_PW2.Text = "재확인";
            // 
            // TB_NAME
            // 
            this.TB_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NAME.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_NAME.Location = new System.Drawing.Point(19, 231);
            this.TB_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_NAME.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_NAME.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(175, 26);
            this.TB_NAME.TabIndex = 9;
            this.TB_NAME.Text = "이름";
            // 
            // TB_NUM
            // 
            this.TB_NUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NUM.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_NUM.Location = new System.Drawing.Point(19, 320);
            this.TB_NUM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_NUM.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_NUM.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_NUM.Name = "TB_NUM";
            this.TB_NUM.Size = new System.Drawing.Size(175, 26);
            this.TB_NUM.TabIndex = 10;
            this.TB_NUM.Visible = false;
            // 
            // CB_AUTHOR
            // 
            this.CB_AUTHOR.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_AUTHOR.FormattingEnabled = true;
            this.CB_AUTHOR.IntegralHeight = false;
            this.CB_AUTHOR.Items.AddRange(new object[] {
            "관리자",
            "직원"});
            this.CB_AUTHOR.Location = new System.Drawing.Point(19, 288);
            this.CB_AUTHOR.Name = "CB_AUTHOR";
            this.CB_AUTHOR.Size = new System.Drawing.Size(175, 27);
            this.CB_AUTHOR.TabIndex = 12;
            this.CB_AUTHOR.SelectedIndexChanged += new System.EventHandler(this.CB_AUTHOR_SelectedIndexChanged);
            // 
            // TB_AUTHOR
            // 
            this.TB_AUTHOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_AUTHOR.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_AUTHOR.Location = new System.Drawing.Point(19, 320);
            this.TB_AUTHOR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_AUTHOR.MaximumSize = new System.Drawing.Size(175, 30);
            this.TB_AUTHOR.MinimumSize = new System.Drawing.Size(175, 30);
            this.TB_AUTHOR.Name = "TB_AUTHOR";
            this.TB_AUTHOR.Size = new System.Drawing.Size(175, 26);
            this.TB_AUTHOR.TabIndex = 13;
            this.TB_AUTHOR.Text = "직급(숨김)";
            this.TB_AUTHOR.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "직급선택";
            // 
            // PNL_JOIN
            // 
            this.PNL_JOIN.BackColor = System.Drawing.Color.White;
            this.PNL_JOIN.Controls.Add(this.label1);
            this.PNL_JOIN.Controls.Add(this.label2);
            this.PNL_JOIN.Controls.Add(this.TB_PW2);
            this.PNL_JOIN.Controls.Add(this.TB_AUTHOR);
            this.PNL_JOIN.Controls.Add(this.TB_ID);
            this.PNL_JOIN.Controls.Add(this.TB_NAME);
            this.PNL_JOIN.Controls.Add(this.CB_AUTHOR);
            this.PNL_JOIN.Controls.Add(this.TB_PW);
            this.PNL_JOIN.Controls.Add(this.BT_JOIN);
            this.PNL_JOIN.Controls.Add(this.TB_NUM);
            this.PNL_JOIN.Location = new System.Drawing.Point(12, 12);
            this.PNL_JOIN.Name = "PNL_JOIN";
            this.PNL_JOIN.Size = new System.Drawing.Size(215, 406);
            this.PNL_JOIN.TabIndex = 15;
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(239, 430);
            this.Controls.Add(this.PNL_JOIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Join";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.PNL_JOIN.ResumeLayout(false);
            this.PNL_JOIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_JOIN;
        private System.Windows.Forms.TextBox TB_PW;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_PW2;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.TextBox TB_NUM;
        private System.Windows.Forms.ComboBox CB_AUTHOR;
        private System.Windows.Forms.TextBox TB_AUTHOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PNL_JOIN;
    }
}