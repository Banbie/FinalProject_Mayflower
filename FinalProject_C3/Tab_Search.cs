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
        public Tab_Search()
        {
            InitializeComponent();
        }

        private void Tab_Search_Load(object sender, EventArgs e)
        {
            db.Connection();
            btn_Search.PerformClick();
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            // 조회 시작일과 종료일 설정
            DateTime startDate = dt_Time.Value.Date;
            DateTime endDate = dt_Time1.Value.Date.AddDays(1);

            // 총 생산량 쿼리 실행
            string query = $"SELECT SUM(nowea) FROM tb_plan WHERE state = '완료' AND DATE(donetime) >= '{startDate:yyyy-MM-dd}' AND DATE(donetime) < '{endDate:yyyy-MM-dd}'";
            try
            {
                object result = db.ExecuteScalar(query);
                int totalQuantity = result is DBNull ? 0 : Convert.ToInt32(result);
                int totalDefectCount = 0;

                // 불량품 수 쿼리 실행System.InvalidCastException: '개체를 DBNull에서 다른 형식으로 캐스팅할 수 없습니다.'
                string defectQuery = $"SELECT DATE(proddate), COUNT(*) FROM tb_prod WHERE DATE(proddate) >= '{startDate:yyyy-MM-dd}' AND DATE(proddate) < '{endDate:yyyy-MM-dd}' AND spec = '1' GROUP BY DATE(proddate)";
                DataTable defectTable = db.ExecuteDataTable(defectQuery);

                // 검색 결과를 출력할 데이터 그리드뷰의 컬럼 설정
                dgv_Search.Columns.Clear();
                dgv_Search.Columns.Add("date", "날짜");
                dgv_Search.Columns.Add("totalQuantity", "총 생산량");
                dgv_Search.Columns.Add("defectCount", "불량 갯수");
                dgv_Search.Columns.Add("defectRate", "불량률(%)");

                // 각 일자별 생산량과 불량품 수, 불량률 계산 및 데이터 그리드뷰에 출력
                foreach (DataRow row in defectTable.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["DATE(proddate)"]);
                    int dailyQuantity = GetDailyQuantity(date, startDate, endDate);
                    int count = Convert.ToInt32(row["COUNT(*)"]);
                    double defectRate = dailyQuantity != 0 ? Math.Round((double)count / dailyQuantity * 100, 2) : 0;
                    totalDefectCount += count;

                    dgv_Search.Rows.Add(date.ToString("yyyy-MM-dd"), dailyQuantity, count, $"{defectRate}%");
                }

                // 총 생산량과 불량률 계산 및 출력
                double totalDefectRate = totalQuantity != 0 ? Math.Round((double)totalDefectCount / totalQuantity * 100, 2) : 0;
                dgv_Total.Rows.Clear();
                dgv_Total.Rows.Add($"{startDate:yyyy-MM-dd} ~ {endDate.AddDays(-1):MM-dd}", totalQuantity, totalDefectCount, $"{totalDefectRate}%");

                // 차트 그리기
                DrawChart();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"검색 도중 오류가 발생하였습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 시작일과 종료일 사이에서 각 일자별 생산된 제품 수를 구합니다.
        private int GetDailyQuantity(DateTime date, DateTime startDate, DateTime endDate)
        {
            string query = $"SELECT SUM(nowea) FROM tb_plan WHERE state = '완료' AND DATE(donetime) = '{date:yyyy-MM-dd}'";
            object result = db.ExecuteScalar(query);
            int dailyQuantity = Convert.ToInt32(result ?? 0);
            return dailyQuantity;
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
                int totalQuantity = Convert.ToInt32(row.Cells["totalQuantity"].Value);
                int defectCount = Convert.ToInt32(row.Cells["defectCount"].Value);
                double defectRate = totalQuantity != 0 ? Math.Round((double)defectCount / totalQuantity * 100, 2) : 100.0;

                seriesTotalQuantity.Points.AddXY(date.ToString("yyyy-MM-dd"), totalQuantity);
                seriesDefectCount.Points.AddXY(date.ToString("yyyy-MM-dd"), defectCount);
                seriesDefectRate.Points.AddXY(date.ToString("yyyy-MM-dd"), defectRate);
            }

            // 불량률 데이터 포맷 설정
            seriesDefectRate.LabelFormat = "0.00 %";
        }
    }
}
