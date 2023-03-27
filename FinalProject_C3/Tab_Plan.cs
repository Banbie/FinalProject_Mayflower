using System;
using System.Collections;
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
    public partial class Tab_Plan : MetroFramework.Forms.MetroForm
    {
        private readonly Timer timer = new Timer(); // 타이머 생성
        private static readonly string connectionString =
        "Server=192.168.0.3;" +
        //"Server=localhost;" +
        "Database=mayflower;" +
        "Port=3306;" +
        "Uid=edu;" +
        "Pwd=1234;";
        private readonly MySqlConnection connection = new MySqlConnection(connectionString);
        private int nowea = 0; // 초기값 0으로 설정

        public int planRowNumber;

        public Tab_Plan()
        {
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

            var query = "SELECT COUNT(*) FROM tb_plan";
            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                planRowNumber = (Convert.ToInt32(reader.ExecuteScalar()))-1;
                MessageBox.Show(planRowNumber.ToString());
            }

            InitializeComponent();

            MetroFramework.Controls.MetroButton planBtn = new MetroFramework.Controls.MetroButton();
            planManager.Controls.Add(planBtn);
            planBtn.Location = new Point((190 * (planRowNumber+1)) + 10, 30);
            planBtn.Name = "planBtn";
            planBtn.Size = new Size(40, 180);
            planBtn.TabIndex = 1;
            planBtn.Text = "+";
            planBtn.UseSelectable = true;
            planBtn.Click += new EventHandler(planBtn_Click);

            if (planRowNumber > -1)
            {
                MetroFramework.Controls.MetroTile[] planPanel = new MetroFramework.Controls.MetroTile[planRowNumber+1];
                MetroFramework.Controls.MetroLabel[] planLabel = new MetroFramework.Controls.MetroLabel[planRowNumber+1];

                for (int i = 0; i<planRowNumber+1; i++)
                {
                    planPanel[i] = new MetroFramework.Controls.MetroTile();
                    planManager.Controls.Add(planPanel[i]);
                    planPanel[i].ActiveControl = null;
                    planPanel[i].Controls.Add(planLabel[i]);
                    planPanel[i].Location = new Point((190*planRowNumber*i)+10, 30);
                    planPanel[i].Name = $"planPanel{i}";
                    planPanel[i].Size = new Size(180, 180);
                    planPanel[i].TabIndex = 0;
                    planPanel[i].Text = $"planNumRow{i}";
                    planPanel[i].UseSelectable = true;

                    planLabel[i] = new MetroFramework.Controls.MetroLabel();
                    planLabel[i].AutoSize = true;
                    planLabel[i].Location = new Point(30, 27);
                    planLabel[i].Name = $"planLabel{i}";
                    planLabel[i].Size = new Size(80, 20);
                    planLabel[i].TabIndex = 0;
                    planLabel[i].Text = $"nullText{i}";

                    planPanel[i].Controls.Add(planLabel[i]);

                }

            }

            // 타이머 설정
            //timer.Interval = 1000; // 1초 간격으로 실행
            //timer.Tick += timer1_Tick; // 타이머 이벤트 핸들러 설정
            //timer.Start(); // 타이머 시작
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
            //// tb_prod 테이블 모니터링
            //var prodQuery = "SELECT COUNT(*) FROM tb_prod WHERE spec = 2;";
            //var prodCmd = new MySqlCommand(prodQuery, connection);
            //int prodCount = Convert.ToInt32(prodCmd.ExecuteScalar());

            //if (prodCount > 0) // spec 컬럼에 2라는 데이터가 들어올 때마다 nowea 1 증가
            //{
            //    nowea++;
            //}

            //// dg_plan 데이터그리드 갱신
            //var planQuery = "SELECT priority AS 우선순위, " +
            //"CONCAT(IF(MAX(state) = 0, '대기', IF(MAX(state) < MAX(planea), '진행', '완료')), " +
            //"' (', '" + nowea.ToString() + " / ', MAX(planea), ')') AS 현황, " +
            //"MAX(donetime) AS 종료시각 FROM tb_plan " +
            //"GROUP BY priority ORDER BY priority ASC;";
            //LoadDataToDataGridView(planQuery, dg_plan);
        }

        private void get_now() // 현재 실행하고있는 생산계획 불러오기
        {
            try
            {
                var limit1 = "select * from tb_cur inner join on tb_cur.plannum = tb_plan.plannum order by curnum DESC LIMIT 1";
                var adapter = new MySqlDataAdapter(limit1, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dg_now.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show(ex.Message);
            }
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
            get_now();
        }

        private void planBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
