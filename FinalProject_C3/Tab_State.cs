using LoginTest;
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


namespace FinalProject_C3
{

    public partial class Tab_State : MetroFramework.Forms.MetroForm
    {
        ActUtlTypeLib.ActUtlType ActUtilType;
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
        int DataRead1 = 0;


        int Da1 = 0;
        int Da2 = 0;


        private void Tab_State_Load(object sender, EventArgs e)
        {//
            DBMySql db = new DBMySql();

            db.Connection();
            //DataTable dt = db.Select($"SELECT DATE_FORMAT(time, '%Y-%m-%d') AS time, value FROM io_plc WHERE IO_ID ='plc_d103' AND DATE_FORMAT(time, '%Y-%m-%d') = '{currentDate.ToString("yyyy-MM-dd")}';");
            DataTable dt = db.Select($"SELECT DATE_FORMAT(time, '%Y-%m-%d %h:%i:%s') AS time, value \r\nFROM io_plc \r\nwhere IO_ID ='plc_d103' and dATE_FORMAT(time, '%Y-%m-%d') = '2023-03-28';");



            // 차트 생성 및 옵션 설정
            chart1.Parent = this;
            chart1.Dock = DockStyle.None;
            chart1.Location = new Point(10, 10);
            chart1.Width = this.Width - 20;
            chart1.Height = this.Height - 50;
            chart1.ChartAreas.Add(new ChartArea("Default"));
            chart1.Series.Add(new Series("Data"));
            chart1.Series["Data"].ChartType = SeriesChartType.Line;
            chart1.Series["Data"].XValueType = ChartValueType.Time; // x축 값의 타입을 시간으로 설정합니다.

            // y축 범위 설정
            chart1.ChartAreas[0].AxisY.Minimum = 160;
            chart1.ChartAreas[0].AxisY.Maximum = 250;

            // 데이터 추가
            foreach (DataRow row in dt.Rows)
            {
                DateTime time = DateTime.Parse(row["time"].ToString());
                double value = double.Parse(row["value"].ToString());
                chart1.Series["Data"].Points.AddXY(time, value);
            }

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
            timer1.Enabled = true;
        }
    }
}
