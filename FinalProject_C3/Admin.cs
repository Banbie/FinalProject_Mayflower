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

        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            bt_Plan.PerformClick(); // 기본적으로 생산계획 폼 열어놓기
        }
        private void cb_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Hide.Checked == true)
            {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
                bt_Plan.Text = "1";
                bt_Search.Text = "2";
                bt_Poor.Text = "3";
                bt_Device.Text = "4";
                bt_Data.Text = "5";
                bt_Staff.Text = "6";
                cb_Hide.Text = ">";
            }
            else
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                bt_Plan.Text = "생산 계획";
                bt_Search.Text = "실적 검색";
                bt_Poor.Text = "불량 추적";
                bt_Device.Text = "디바이스 관리";
                bt_Data.Text = "설비 데이터";
                bt_Staff.Text = "직원 관리";
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
            Tab_Poor poor = new Tab_Poor();
            poor.TopLevel = false;
            pn_Center.Controls.Add(poor);
            poor.Show();
        } // 불량추적 폼 열기
        private void bt_Device_Click(object sender, EventArgs e)
        {
            Tab_Device device = new Tab_Device();
            device.TopLevel = false;
            pn_Center.Controls.Add(device);
            device.Show();
        } // 디바이스관리 폼 열기
        private void bt_Data_Click(object sender, EventArgs e)
        {
            Tab_Data data = new Tab_Data();
            data.TopLevel = false;
            pn_Center.Controls.Add(data);
            data.Show();
        } // 설비데이터 폼 열기
        private void bt_Staff_Click(object sender, EventArgs e)
        {
            Tab_Staff staff = new Tab_Staff();
            staff.TopLevel = false;
            pn_Center.Controls.Add(staff);
            staff.Show();
        } // 직원관리 폼 열기

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
