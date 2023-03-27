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

namespace FinalProject_C3
{
    public partial class Tab_Search : MetroFramework.Forms.MetroForm
    {
        DBMySql db = new DBMySql();
        public Tab_Search()
        {
            InitializeComponent();
        }

        private void Tab_Search_Load(object sender, EventArgs e)
        {
            db.Connection();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DateTime startDate = dt_Time.Value.Date;
            DateTime endDate = dt_Time1.Value.Date.AddDays(1);

            string query = $"SELECT SUM(nowea) FROM tb_plan WHERE state = '완료' AND DATE(donetime) >= '{startDate:yyyy-MM-dd}' AND DATE(donetime) < '{endDate:yyyy-MM-dd}'";

            try
            {
                object result = db.ExecuteScalar(query);
                int totalQuantity = Convert.ToInt32(result ?? 0);
                int totalDefectCount = 0;

                string defectQuery = $"SELECT DATE(proddate), COUNT(*) FROM tb_prod WHERE DATE(proddate) >= '{startDate:yyyy-MM-dd}' AND DATE(proddate) < '{endDate:yyyy-MM-dd}' AND spec = '1' GROUP BY DATE(proddate)";
                DataTable defectTable = db.ExecuteDataTable(defectQuery);

                dgv_Search.Columns.Clear();
                dgv_Search.Columns.Add("date", "날짜");
                dgv_Search.Columns.Add("totalQuantity", "총 생산량");
                dgv_Search.Columns.Add("defectCount", "불량 갯수");
                dgv_Search.Columns.Add("defectRate", "불량률");

                foreach (DataRow row in defectTable.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["DATE(proddate)"]);
                    int dailyQuantity = GetDailyQuantity(date, startDate, endDate);
                    int count = Convert.ToInt32(row["COUNT(*)"]);
                    double defectRate = dailyQuantity != 0 ? Math.Round((double)count / dailyQuantity * 100, 2) : 0;
                    totalDefectCount += count;

                    dgv_Search.Rows.Add(date.ToString("yyyy-MM-dd"), dailyQuantity, count, $"{defectRate}%");
                }

                double totalDefectRate = totalQuantity != 0 ? Math.Round((double)totalDefectCount / totalQuantity * 100, 2) : 0;
                dgv_Total.Rows.Clear();
                dgv_Total.Rows.Add($"{startDate:yyyy-MM-dd} ~ {endDate.AddDays(-1):MM-dd}", totalQuantity, totalDefectCount, $"{totalDefectRate}%");
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
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("ChartArea");
            chart1.ChartAreas[0].AxisX.Title = "날짜";
            chart1.ChartAreas[0].AxisY.Title = "불량률";

            Series series = chart1.Series.Add("불량률");
            series.ChartType = SeriesChartType.Point;

            foreach (DataGridViewRow row in dgv_Search.Rows)
            {
                DateTime date = Convert.ToDateTime(row.Cells["date"].Value);
                double defectRate = 0.0;

                if (row.Cells["defectRate"].Value != null)
                {
                    defectRate = Convert.ToDouble(row.Cells["defectRate"].Value.ToString().Replace("%", ""));
                }

                series.Points.AddXY(date.ToString("yyyy-MM-dd"), defectRate);
            }
        }
    }
}
