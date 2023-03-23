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
        private int nowea = 0; // 초기값 0으로 설정

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
            // tb_prod 테이블 모니터링
            var prodQuery = "SELECT COUNT(*) FROM tb_prod WHERE spec = 2;";
            var prodCmd = new MySqlCommand(prodQuery, connection);
            var prodCount = Convert.ToInt32(prodCmd.ExecuteScalar());

            if (prodCount > 0) // spec 컬럼에 2라는 데이터가 들어올 때마다 nowea 1 증가
            {
                nowea++;
            }

            // dg_plan 데이터그리드 갱신
            var planQuery = "SELECT priority AS 우선순위, " +
            "CONCAT(IF(MAX(state) = 0, '대기', IF(MAX(state) < MAX(planea), '진행', '완료')), " +
            "' (', '" + nowea.ToString() + " / ', MAX(planea), ')') AS 현황, " +
            "MAX(donetime) AS 종료시각 FROM tb_plan " +
            "GROUP BY priority ORDER BY priority ASC;";
            LoadDataToDataGridView(planQuery, dg_plan);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // 쿼리 실행
                var query = "SELECT priority AS 우선순위, " +
            "CONCAT(IF(MAX(state) = 0, '대기', IF(MAX(state) < MAX(planea), '진행', '완료')), " +
            "' (', '" + nowea.ToString() + " / ', MAX(planea), ')') AS 현황, " +
            "MAX(donetime) AS 종료시각 FROM tb_plan " +
            "GROUP BY priority ORDER BY priority ASC;";
                var adapter = new MySqlDataAdapter(query, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // dg_plan 데이터그리드 갱신
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
