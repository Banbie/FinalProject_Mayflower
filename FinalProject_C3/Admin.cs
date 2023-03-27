using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C3
{
    public partial class Admin : Form
    {
        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 200;
        const int MIN_SLIDING_WIDTH = 50;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 10;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 200;
        //private Dictionary<string, string> userData;

        //public Admin(Dictionary<string, string> userData)

        private readonly Dictionary<string, string> userData;

        public Admin(Dictionary<string, string> userData)
        {
            InitializeComponent();
            //로그인 할때 로그인 user테이블의 id를 검색해 그 행의 이름,직급을 가져와 라벨에 씌우는 코드인데
            //작동은 정상적으로 하는데 프로그램 종료 시 key값이 없다는 오류가 떠서 어차피 끄는거니 오류뜨면 종료하게 만듬
            try
            {
                this.userData = userData;

                // userData 변수를 이용하여 원하는 작업을 수행합니다.
                // 예를 들어, 아래와 같이 라벨에 값을 설정할 수 있습니다.
                lb_UserName.Text = userData["username"];
                lb_Position.Text = userData["author"];
            }
            catch (KeyNotFoundException ex)
            {
                //MessageBox.Show("사용자 정보를 찾을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            bt_Monitor.PerformClick(); // 기본적으로 생산계획 폼 열어놓기
            timerDate.Interval = 100; //타이머 간격 100ms
            timerDate.Start();  //타이머 시작            
            lb_LogTime.Text = DateTime.Now.ToString("T"); // label1에 현재날짜시간 표시, F:자세한 전체 날짜/시간
        }
        private void cb_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Hide.Checked == true)
            {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
                bt_Plan.Text = "1";
                bt_Search.Text = "2";
                bt_Defect.Text = "3";
                bt_Device.Text = "4";
                bt_State.Text = "5";
                bt_Monitor.Text = "6";
                cb_Hide.Text = ">";
            }
            else
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                bt_Plan.Text = "생산 계획";
                bt_Search.Text = "실적 검색";
                bt_Defect.Text = "불량 추적";
                bt_Device.Text = "디바이스 관리";
                bt_State.Text = "설비 데이터";
                bt_Monitor.Text = "직원 관리";
                cb_Hide.Text = "<";
            }
            //타이머 시작
            timerSliding.Start();
        } //슬라이딩 메뉴 수정

        private void timerSliding_Tick(object sender, EventArgs e)
        {
            if (cb_Hide.Checked == true) //슬라이딩 메뉴를 숨기는 동작
            {
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    timerSliding.Stop();
            }
            else //슬라이딩 메뉴를 보이는 동작
            {
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding.Stop();
            }
            panelSideMenu.Width = _posSliding;
        } // 네비게이션 탭 슬라이딩메뉴 모션
        private void bt_Plan_Click(object sender, EventArgs e)
        {
            Tab_Plan plan = new Tab_Plan();
            plan.TopLevel = false;
            //plan.Dock = System.Windows.Forms.DockStyle.Fill;
            pn_Center.Controls.Add(plan);
            plan.Show();
        } // 생산계획 폼 열기
        private void bt_Search_Click(object sender, EventArgs e)
        {
            Tab_Search search = new Tab_Search();
            search.TopLevel = false;
            pn_Center.Controls.Add(search);
            search.Show();
        } // 실적검색 폼 열기
        private void bt_Poor_Click(object sender, EventArgs e)
        {
            Tab_Defect defect = new Tab_Defect();
            defect.TopLevel = false;
            pn_Center.Controls.Add(defect);
            defect.Show();
        } // 불량추적 폼 열기
        private void bt_Device_Click(object sender, EventArgs e)
        {
            Tab_Device device = new Tab_Device(lb_UserName.Text);
            device.TopLevel = false;
            pn_Center.Controls.Add(device);
            device.Show();
        } // 디바이스관리 폼 열기
        private void bt_Data_Click(object sender, EventArgs e)
        {
            Tab_State state = new Tab_State();
            state.TopLevel = false;
            pn_Center.Controls.Add(state);
            state.Show();
        } // 설비데이터 폼 열기
        private void bt_Staff_Click(object sender, EventArgs e)
        {
            Tab_Monitor monitor = new Tab_Monitor();
            monitor.TopLevel = false;
            pn_Center.Controls.Add(monitor);
            monitor.Show();
        } // 직원관리 폼 열기

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lb_NowTime.Text = DateTime.Now.ToString("F");
            // label1에 현재날짜시간 표시, F:자세한 전체 날짜/시간
            // T:시간만 표시
        }
    }
}
