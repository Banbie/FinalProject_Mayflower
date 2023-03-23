using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using MySql.Data.MySqlClient;

namespace FinalProject_C3
{
    public partial class Tab_Plan : Form
    {
        private readonly Timer timer = new Timer(); // 타이머 생성
        private static readonly string connectionString =
        "Server=192.168.0.3;" +
        "Database=mayflower;" +
        "Port=3306;" +
        "Uid=edu;" +
        "Pwd=1234;";
        private readonly MySqlConnection connection = new MySqlConnection(connectionString);

        public Tab_Plan()
        {
            InitializeComponent();
            // 타이머 설정
            timer.Interval = 1000; // 1초 간격으로 실행
            timer.Tick += timer1_Tick; // 타이머 이벤트 핸들러 설정
            timer.Start(); // 타이머 시작

            // 데이터베이스 연결
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoadDataToDataGridView(string query, DataGridView dataGridView)
        {
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
        }

        private void Tab_Plan_Load(object sender, EventArgs e)
        {
            // 전체 데이터 조회
            string query = "SELECT priority AS 우선순위, planea AS 주문량," +
                " state AS 현황, donetime AS 종료시각 FROM tb_plan;";
            LoadDataToDataGridView(query, dg_plan);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // 쿼리 실행
                var query = "SELECT priority AS 우선순위, planea AS 주문량," +
                " state AS 현황, donetime AS 종료시각 FROM tb_plan;";
                var adapter = new MySqlDataAdapter(query, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // prod 데이터 그리드 갱신
                dg_plan.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show(ex.Message);
            }
        }
    }
}
