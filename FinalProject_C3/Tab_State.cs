using LoginTest;
using MetroFramework.Controls;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework.Controls;
using ActUtlTypeLib;


namespace FinalProject_C3
{
 

    public partial class Tab_State : MetroFramework.Forms.MetroForm
    {
        ActUtlTypeLib.ActUtlType ActUtilType;
        private MetroProgressBar metroProgressBar1;
        public Tab_State()
        {
            InitializeComponent();           
        }


        private int CalculateValue(int degrees)
        {
            int value = 0;

            // 이미지를 3구역으로 나눕니다.
            int sectionSize = 360 / 3;
            int section = degrees / sectionSize;

            // 1~3의 값을 각 구역에 매핑합니다.
            if (section == 0)
            {
                value = 2;
            }
            else if (section == 1)
            {
                value = 1;
            }
            else if (section == 2)
            {
                value = 3;
            }

            return value;
        }

        private DateTime currentDate = DateTime.Now;

        private int ce = 1;
        private int i = 0;
        int DataRead1 = 0;
        int DataRead2 = 0;
        int DataRead3 = 0;
        int DataRead4 = 0;       
        int DataRead5 = 0;
        int DataRead6 = 0;
        int DataRead7 = 1;
        int DataRead8= 0;
        int DataRead9 = 0;
        int DataRead10 = 0;
        int temp1 = 0;
        int e1 = 0;
        int e2 = 0;
        int e3 = 0;
        int e4 = 0;

        int Da1 = 0;
        int Da2 = 0;
        int Da3 = 0;
        int Da4 = 0;


        private void Tab_State_Load(object sender, EventArgs e)
        {//
            //DBMySql db = new DBMySql();

            //db.Connection();
            ////DataTable dt = db.Select($"SELECT DATE_FORMAT(time, '%Y-%m-%d') AS time, value FROM io_plc WHERE IO_ID ='plc_d103' AND DATE_FORMAT(time, '%Y-%m-%d') = '{currentDate.ToString("yyyy-MM-dd")}';");
            //DataTable dt = db.Select($"SELECT DATE_FORMAT(time, '%Y-%m-%d %h:%i:%s') AS time, value \r\nFROM io_plc \r\nwhere IO_ID ='plc_d103' and dATE_FORMAT(time, '%Y-%m-%d') = '2023-03-28';");



            //// 차트 생성 및 옵션 설정
            //chart1.Parent = this;
            //chart1.Dock = DockStyle.None;
            //chart1.Location = new Point(10, 10);
            //chart1.Width = this.Width - 20;
            //chart1.Height = this.Height - 50;
            //chart1.ChartAreas.Add(new ChartArea("Default"));
            //chart1.Series.Add(new Series("Data"));
            //chart1.Series["Data"].ChartType = SeriesChartType.Line;
            //chart1.Series["Data"].XValueType = ChartValueType.Time; // x축 값의 타입을 시간으로 설정합니다.

            //// y축 범위 설정
            //chart1.ChartAreas[0].AxisY.Minimum = 160;
            //chart1.ChartAreas[0].AxisY.Maximum = 250;

            //// 데이터 추가
            //foreach (DataRow row in dt.Rows)
            //{
            //    DateTime time = DateTime.Parse(row["time"].ToString());
            //    double value = double.Parse(row["value"].ToString());
            //    chart1.Series["Data"].Points.AddXY(time, value);
            //}

            ActUtilType = new ActUtlTypeLib.ActUtlType();
            // ActUtilType.ActLogicalStationNumber값은 MX Component에서 설정한 Station 번호입니다
            ActUtilType.ActLogicalStationNumber = 0;
            // 리턴값이 "0"이면 PLC 연결 성공
            int nRtn = ActUtilType.Open();
            if (nRtn == 0)
            {
                metroTextBox1.Text = "PLC 접속 성공";
               // ActUtilType.SetDevice("M7", 1);


            }
            else
            {
                metroTextBox1.Text = "PLC 접속 실패";

            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            
                ActUtilType.SetDevice("M12", 1);//주황색 on, 빨간색 off 
               
                metroTextBox1.Text = "긴급 정지";
         
        }

        private void Tab_State_FormClosed(object sender, FormClosedEventArgs e)
        {
            int nRtn = ActUtilType.Close();
            MessageBox.Show("연결이 종료되었습니다.");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ActUtilType.SetDevice("M1", 1);
           metroTextBox1.Text = "미풍으로 돌아가는중";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActUtilType.GetDevice("D103", out DataRead1);
            DataRead1 = DataRead1 / 28;
            if (DataRead1 >= 17 && DataRead1 <= 19)
            {
                ActUtilType.SetDevice("M0", 1);
                ActUtilType.SetDevice("M1", 1);
                metroTextBox1.Text = "미풍으로 돌아가는중";

            }
            else if (DataRead1 > 19 && DataRead1 <= 21)
            {
                ActUtilType.SetDevice("M0", 1);
                ActUtilType.SetDevice("M2", 1);
                metroTextBox1.Text = "약풍으로 돌아가는중";
            }
            else if (DataRead1 > 21)
            {
                ActUtilType.SetDevice("M0", 1);
                ActUtilType.SetDevice("M3", 1);
                metroTextBox1.Text = "강풍으로 돌아가는중";
               
            }
                     
                 

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ActUtilType.SetDevice("M2", 1);
            metroTextBox1.Text = "약풍으로 돌아가는중";
           
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ActUtilType.SetDevice("M3", 1);
            metroTextBox1.Text = "강풍으로 돌아가는중";
            
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
           
            if (i == 0)
            {
                i = 1;
                timer1.Enabled = true;
            }
            else
            {
                i = 0;
                timer1.Enabled= false;
                ActUtilType.SetDevice("M2", 1);
                metroTextBox1.Text = "자동 운전꺼짐";
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            ActUtilType.GetDevice("d100", out DataRead2);
            ActUtilType.GetDevice("d101", out DataRead3);
            ActUtilType.GetDevice("d102", out DataRead4);
            ActUtilType.GetDevice("d103", out temp1);
            ActUtilType.GetDevice("d366", out DataRead5);
            ActUtilType.GetDevice("C0", out DataRead6);
            ActUtilType.GetDevice("C1", out DataRead7);
            ActUtilType.GetDevice("C2", out DataRead8);
            ActUtilType.GetDevice("d10", out DataRead9);
            ActUtilType.GetDevice("m12", out e1);
            ActUtilType.GetDevice("m13", out e2);
            ActUtilType.GetDevice("m14", out e3);
            ActUtilType.GetDevice("m15", out e4);
            ActUtilType.GetDevice("x2", out Da1);
            ActUtilType.GetDevice("x3", out Da2);
            ActUtilType.GetDevice("x4", out Da3);
            ActUtilType.GetDevice("x5", out Da4);

            if (DataRead2 <= 1600 && DataRead2 >= 1480)
            {
                Ai1_t.Text = DataRead2.ToString();
            }
            else
            {
                Ai1_t.Text = DataRead2.ToString();
                MessageBox.Show("AI1_S사건 발생 확인 필요.");
                timer1.Enabled = false;
               
            }
            AI2_t.Text= DataRead3.ToString();
            AI3_t.Text= DataRead4.ToString();
            Inverter_state_t.Text= DataRead5.ToString();
            metroProgressBar2.Value = DataRead5;
            temp_t.Text= (temp1/28).ToString();
            Today_t_t.Text = DataRead6.ToString();
            Today_a_t.Text= DataRead7.ToString();
            Today_d_t.Text = DataRead8.ToString();
            Ttot_t.Text= DataRead9.ToString();
            external_control1_t.Text= e1.ToString();
            external_control2_t.Text = e2.ToString();
            external_control3_t.Text = e3.ToString();
            external_control_off.Text = e4.ToString();
            metroTextBox2.Text = Da1.ToString();
            metroTextBox3.Text = Da2.ToString();
            metroTextBox4.Text = Da3.ToString();
            metroTextBox5.Text = Da4.ToString();

        }

        private void SP1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"\\192.168.0.10\pi\sta\ra.jpg");
        }

        private void SP2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"\\192.168.0.10\pi\sta\plc.jpg");
        }
    }
}
