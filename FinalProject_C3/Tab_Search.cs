using LoginTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using MySqlX.XDevAPI;
using System.Runtime.InteropServices.ComTypes;
using MetroFramework;
using MetroFramework.Forms;

namespace FinalProject_C3
{
    //Tab_Search 클래스는 DBMySql 객체를 생성하고, 검색 버튼(btn_Search) 클릭 이벤트 핸들러를 정의합니다
    //검색 버튼을 클릭하면, DateTimePicker를 통해 선택된 시작일(startDate) 과 종료일(endDate) 을 기반으로 SQL 쿼리를 생성하고,
    //데이터베이스(MySQL) 에 해당 쿼리를 실행하여 결과를 가져옵니다.
    //검색된 데이터는 DataGridView 컨트롤(dgv_Search, dgv_Total) 에 표시되며, DrawChart() 메서드를 통해 차트(Chart) 가 그려집니다.
    //만약 검색 도중 오류가 발생하면, 사용자에게 메시지 박스를 통해 오류를 알리게 됩니다.

    //설정된 날짜범위가 DB에 검색되는 범위이고
    //tb_plan에서는 날짜+state(상태)가 '완료'인 경우를 조회하여 총 생산량을 가져오고
    //tb_prod에서는 날짜+spec(합격상태 1불합격 2합격)가 1인 경우를 조회하여 불량갯수를 가져온다.
    //두 데이터를 가져와 나눠 불량률을 계산하고, 세가지 데이터를 날짜 기준으로 데이터그리드뷰에 표시
    public partial class Tab_Search : MetroForm
    {
        DBMySql db = new DBMySql();
        Timer timer = new Timer();
        public Tab_Search()
        {
            InitializeComponent();
            timer.Interval = 30000; // 30초 간격
            timer.Tick += new EventHandler(timer1_Tick);
        }

        private void Tab_Search_Load(object sender, EventArgs e)
        {
            db.Connection();
            // 최근 30개 완료된 계획 가져오기
            string query = "SELECT comname AS '주문자',planea AS '주문량' ,donedate AS '완료시각' FROM tb_plan WHERE donedate IS NOT NULL ORDER BY donedate DESC LIMIT 30";
            DataTable donePlanTable = db.ExecuteDataTable(query);
            dgv_doneplan.DataSource = donePlanTable;
            dgv_doneplan.Columns["주문자"].Width = 120;
            dgv_doneplan.Columns["주문량"].Width = 120;
            dgv_doneplan.Columns["완료시각"].Width = 140;
            // DataGridView 마지막 행에 빈칸이 나오는 경우 방지
            dgv_Search.AllowUserToAddRows = false;
            dgv_doneplan.AllowUserToAddRows = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // btn_Search_Click_1 이벤트 핸들러 호출
            btn_Search_Click_1(null, null);
            // Tab_Search_Load 이벤트 핸들러 호출
            Tab_Search_Load(null, null);
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            // 조회 시작일과 종료일 설정
            DateTime startDate = dt_Time.Value.Date;
            DateTime endDate = dt_Time1.Value.Date.AddDays(1);

            // tfs 테이블에서 각 일자별 총 생산량, 불량갯수 조회
            string query = $"SELECT DATE(DayTime) AS '날짜', MAX(acceptive) AS '총 생산량', MAX(defective) AS '불량 갯수' FROM tfs WHERE DayTime >= '{startDate:yyyy-MM-dd}' AND DayTime < '{endDate:yyyy-MM-dd}' GROUP BY DATE(DayTime)";
            DataTable defectResult = db.ExecuteDataTable(query);

            // 검색 결과를 출력할 데이터 그리드뷰의 컬럼 설정
            dgv_Search.Columns.Clear();
            dgv_Search.Columns.Add("Date", "날짜");
            dgv_Search.Columns["Date"].Width = 120;
            dgv_Search.Columns.Add("TotalProduction", "총 생산량");
            dgv_Search.Columns.Add("DefectiveCount", "불량 갯수");
            dgv_Search.Columns.Add("DefectiveRate", "불량률(%)");


            // 각 일자별 불량률 계산 및 데이터 그리드뷰에 출력
            foreach (DataRow row in defectResult.Rows)
            {
                DateTime date = Convert.ToDateTime(row["날짜"]);
                int acceptCount = Convert.ToInt32(row["총 생산량"]);
                int defectCount = Convert.ToInt32(row["불량 갯수"]);

                // 해당 날짜에 맞는 총 생산량 조회
                DataRow[] prodRows = defectResult.Select($"날짜 = '{date:yyyy-MM-dd}'");
                int totalProduction = prodRows.Length > 0 ? Convert.ToInt32(prodRows[0]["총 생산량"]) : 0;

                double defectRate = totalProduction != 0 ? Math.Round((double)defectCount / totalProduction * 100, 2) : 0;

                dgv_Search.Rows.Add(date.ToString("yyyy-MM-dd"), totalProduction, defectCount, $"{defectRate}%");
            }
            DrawChart();
        }

        private void DrawChart()
        {
            // 차트 초기화
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("ChartArea");
            chart1.ChartAreas[0].AxisX.Title = "날짜";
            chart1.ChartAreas[0].AxisY.Title = "총생산량,갯수";
            chart1.ChartAreas[0].AxisY2.Title = "불량률 (%)";

            // 차트 데이터 추가
            Series seriesTotalQuantity = chart1.Series.Add("총 생산량");
            Series seriesDefectCount = chart1.Series.Add("불량 갯수");
            Series seriesDefectRate = chart1.Series.Add("불량률");
            seriesTotalQuantity.ChartType = SeriesChartType.Column;
            seriesDefectCount.ChartType = SeriesChartType.Column;
            seriesDefectRate.ChartType = SeriesChartType.Column;
            seriesDefectRate.YAxisType = AxisType.Secondary;

            foreach (DataGridViewRow row in dgv_Search.Rows)
            {
                DateTime date = Convert.ToDateTime(row.Cells["date"].Value);
                int totalProduction = Convert.ToInt32(row.Cells["TotalProduction"].Value);
                int defectiveCount = Convert.ToInt32(row.Cells["DefectiveCount"].Value);
                double defectRate = totalProduction != 0 ? Math.Round((double)defectiveCount / totalProduction * 100, 2) : 100.0;

                seriesTotalQuantity.Points.AddXY(date.ToString("yyyy-MM-dd"), totalProduction);
                seriesDefectCount.Points.AddXY(date.ToString("yyyy-MM-dd"), defectiveCount);
                seriesDefectRate.Points.AddXY(date.ToString("yyyy-MM-dd"), defectRate);
            }

            // 불량률 데이터 포맷 설정
            seriesDefectRate.LabelFormat = "0.00 %";
        }
    }
}
