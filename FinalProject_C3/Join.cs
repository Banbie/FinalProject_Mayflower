using LoginTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject_C3
{
    public partial class Join : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
             int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        bool On;
        Point Pos;
        TextBox[] txtList;

        const string NUMPlaceholder = "";
        const string IdPlaceholder = "아이디 입력";
        const string PwPlaceholder = "비밀번호(4~32자리)";
        const string Pw2Placeholder = "비밀번호 재입력";
        const string NamePlaceholder = "이름을 입력해주세요";
        const string AuthorPlaceholder = "직급선택";

        public Join()
        {
            InitializeComponent();

            //FormBorderStyle = None 일 때, Form 마우스 클릭으로 이동
            PNL_JOIN.MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            PNL_JOIN.MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            PNL_JOIN.MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 3, 3));
            BT_JOIN.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BT_JOIN.Width, BT_JOIN.Height, 1, 1));

            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { TB_NUM, TB_ID, TB_PW, TB_PW2, TB_NAME, TB_AUTHOR };
            foreach (var txt in txtList)
            {
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
            CB_AUTHOR.Height = 30;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == NUMPlaceholder | txt.Text == IdPlaceholder | txt.Text == PwPlaceholder |
                txt.Text == Pw2Placeholder | txt.Text == NamePlaceholder | txt.Text == AuthorPlaceholder)
            {
                txt.ForeColor = Color.FromArgb(60, 30, 30);
                txt.Text = string.Empty;
                if (txt == TB_PW) TB_PW.PasswordChar = '●';
                if (txt == TB_PW2) TB_PW2.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == TB_NUM) txt.Text = NUMPlaceholder;
                else if (txt == TB_ID) txt.Text = IdPlaceholder;
                else if (txt == TB_PW) { txt.Text = PwPlaceholder; TB_PW.PasswordChar = default; }
                else if (txt == TB_PW2) { txt.Text = Pw2Placeholder; TB_PW.PasswordChar = default; }
                else if (txt == TB_NAME) txt.Text = NamePlaceholder;
                else if (txt == TB_AUTHOR) txt.Text = AuthorPlaceholder;
                
            }
        }

        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }
    

    public void ClearTextBox()
        {
            foreach (TextBox txt in txtList)
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == TB_NUM) txt.Text = NUMPlaceholder;
                else if (txt == TB_ID) txt.Text = IdPlaceholder;
                else if (txt == TB_PW) { txt.Text = PwPlaceholder; TB_PW.PasswordChar = default; }
                else if (txt == TB_PW2) { txt.Text = Pw2Placeholder; TB_PW.PasswordChar = default; }
                else if (txt == TB_NAME) txt.Text = NamePlaceholder;
                else if (txt == TB_AUTHOR) txt.Text = AuthorPlaceholder;
            }
        }


        public static bool isValidID(string Text)
        {
            if (Config.user_ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Config.user_ds.Tables[0].Rows)
                {
                    if (Text == row["userid"].ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool isValidPassword(string Text)
        {
            //영문, 숫자, 특수문자 포함 4-32자리
            Regex regex = new Regex(@"^(?=.*?[A-Za-z])(?=.*?\d)(?=.*?[~`!@#$%\^&*()-+=.]).{4,32}$");
            Match match = regex.Match(Text);
            return match.Success;
        }

        private void BT_JOIN_Click(object sender, EventArgs e)
        {
            if (!isValidID(TB_ID.Text)) { MessageBox.Show("이미 존재하는 아이디입니다."); return; }
            if (TB_PW.Text != TB_PW2.Text) { MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요."); return; }
            if (!isValidPassword(TB_PW.Text)) { MessageBox.Show("비밀번호는 영문, 숫자, 특수문자를 포함해야합니다."); return; }

            string value = $"'{TB_ID.Text}', '{TB_PW.Text}', '{TB_NAME.Text}', '{TB_AUTHOR.Text}'";
            //Login._db.Insert(Config.Tables[(int)eTName._user], value);
            Login._db.Insert(value);
            Login.LoadUserInfo();
            MessageBox.Show("회원가입을 완료했습니다. 등록한 아이디로 로그인 해주세요.");

            ClearTextBox();

            Hide();
        }

        private void CB_AUTHOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_AUTHOR.SelectedIndex == 0) TB_AUTHOR.Text = "관리자";
            else if (CB_AUTHOR.SelectedIndex == 1) TB_AUTHOR.Text = "직원";
        }
    }
}