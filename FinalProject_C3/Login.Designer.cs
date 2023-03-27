namespace FinalProject_C3
{
    partial class Login
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PNL_LOGIN = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_MIN = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_PW = new System.Windows.Forms.TextBox();
            this.BT_LOGIN = new System.Windows.Forms.Button();
            this.BT_JOIN = new System.Windows.Forms.Button();
            this.PNL_LOGIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_LOGIN
            // 
            this.PNL_LOGIN.BackgroundImage = global::FinalProject_C3.Properties.Resources.로그인화면3;
            this.PNL_LOGIN.Controls.Add(this.pictureBox1);
            this.PNL_LOGIN.Controls.Add(this.label2);
            this.PNL_LOGIN.Controls.Add(this.label1);
            this.PNL_LOGIN.Controls.Add(this.BT_MIN);
            this.PNL_LOGIN.Controls.Add(this.BT_CLOSE);
            this.PNL_LOGIN.Controls.Add(this.TB_ID);
            this.PNL_LOGIN.Controls.Add(this.TB_PW);
            this.PNL_LOGIN.Controls.Add(this.BT_LOGIN);
            this.PNL_LOGIN.Controls.Add(this.BT_JOIN);
            this.PNL_LOGIN.Location = new System.Drawing.Point(0, -1);
            this.PNL_LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNL_LOGIN.Name = "PNL_LOGIN";
            this.PNL_LOGIN.Size = new System.Drawing.Size(425, 492);
            this.PNL_LOGIN.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::FinalProject_C3.Properties.Resources.yacht;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(148, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 134);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(126, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 49);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(103, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project  MayFlower";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_MIN
            // 
            this.BT_MIN.AutoEllipsis = true;
            this.BT_MIN.BackColor = System.Drawing.Color.White;
            this.BT_MIN.FlatAppearance.BorderSize = 0;
            this.BT_MIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MIN.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_MIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BT_MIN.Location = new System.Drawing.Point(356, 21);
            this.BT_MIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_MIN.Name = "BT_MIN";
            this.BT_MIN.Size = new System.Drawing.Size(24, 26);
            this.BT_MIN.TabIndex = 6;
            this.BT_MIN.Text = "_";
            this.BT_MIN.UseVisualStyleBackColor = false;
            this.BT_MIN.Click += new System.EventHandler(this.BT_MIN_Click);
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.BackColor = System.Drawing.Color.White;
            this.BT_CLOSE.FlatAppearance.BorderSize = 0;
            this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLOSE.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_CLOSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BT_CLOSE.Location = new System.Drawing.Point(386, 21);
            this.BT_CLOSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(24, 26);
            this.BT_CLOSE.TabIndex = 4;
            this.BT_CLOSE.Text = "X";
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // TB_ID
            // 
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_ID.Location = new System.Drawing.Point(123, 247);
            this.TB_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_ID.MaximumSize = new System.Drawing.Size(175, 40);
            this.TB_ID.MinimumSize = new System.Drawing.Size(175, 40);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(175, 26);
            this.TB_ID.TabIndex = 2;
            this.TB_ID.Text = "아이디";
            // 
            // TB_PW
            // 
            this.TB_PW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PW.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB_PW.Location = new System.Drawing.Point(123, 283);
            this.TB_PW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PW.MaximumSize = new System.Drawing.Size(175, 40);
            this.TB_PW.MinimumSize = new System.Drawing.Size(175, 40);
            this.TB_PW.Name = "TB_PW";
            this.TB_PW.Size = new System.Drawing.Size(175, 26);
            this.TB_PW.TabIndex = 3;
            this.TB_PW.Text = "비밀번호";
            // 
            // BT_LOGIN
            // 
            this.BT_LOGIN.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BT_LOGIN.Location = new System.Drawing.Point(136, 339);
            this.BT_LOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_LOGIN.Name = "BT_LOGIN";
            this.BT_LOGIN.Size = new System.Drawing.Size(140, 43);
            this.BT_LOGIN.TabIndex = 0;
            this.BT_LOGIN.Text = "로그인";
            this.BT_LOGIN.UseVisualStyleBackColor = true;
            this.BT_LOGIN.Click += new System.EventHandler(this.BT_LOGIN_Click);
            // 
            // BT_JOIN
            // 
            this.BT_JOIN.BackColor = System.Drawing.Color.White;
            this.BT_JOIN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_JOIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_JOIN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BT_JOIN.Location = new System.Drawing.Point(164, 387);
            this.BT_JOIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_JOIN.Name = "BT_JOIN";
            this.BT_JOIN.Size = new System.Drawing.Size(83, 25);
            this.BT_JOIN.TabIndex = 1;
            this.BT_JOIN.Text = "회원가입";
            this.BT_JOIN.UseVisualStyleBackColor = false;
            this.BT_JOIN.Click += new System.EventHandler(this.BT_JOIN_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(422, 491);
            this.Controls.Add(this.PNL_LOGIN);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PNL_LOGIN.ResumeLayout(false);
            this.PNL_LOGIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_LOGIN;
        private System.Windows.Forms.Button BT_JOIN;
        private System.Windows.Forms.TextBox TB_PW;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Panel PNL_LOGIN;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.Button BT_MIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

