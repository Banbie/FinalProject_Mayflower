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
        //private readonly Timer timer = new Timer(); // 타이머 생성
        private static readonly string connectionString =
        //"Server=192.168.0.3;" +
        "Server=localhost;" +
        "Database=mayflower;" +
        "Port=3306;" +
        "Uid=root;" +
        "Pwd=1234;";
        private readonly MySqlConnection connection = new MySqlConnection(connectionString);
        private int nowea = 0; // 초기값 0으로 설정

        public int planRowNumber;

        int[] specButton;
        MetroFramework.Controls.MetroButton[] planButton;

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

            var query = "SELECT COUNT(*) FROM tb_plan;";
            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                planRowNumber = Convert.ToInt32(reader.ExecuteScalar())-1;
            }
            specButton = new int[planRowNumber + 1];
            planButton = new MetroFramework.Controls.MetroButton[planRowNumber + 1];

            InitializeComponent();

            PanelLoad();

            MetroFramework.Controls.MetroButton planBtn = new MetroFramework.Controls.MetroButton();
            planManager.Controls.Add(planBtn);
            planBtn.Location = new Point((310 * (planRowNumber+1)) + 10, 30);
            planBtn.Name = "planBtn";
            planBtn.Size = new Size(40, 300);
            planBtn.TabIndex = 1;
            planBtn.Text = "+";
            planBtn.UseSelectable = true;
            planBtn.Click += new EventHandler(planBtn_Click);
            
            // 타이머 설정
            //timer.Interval = 1000; // 1초 간격으로 실행
            //timer.Tick += timer1_Tick; // 타이머 이벤트 핸들러 설정
            //timer.Start(); // 타이머 시작


        }

        //private void Tab_Plan_Load(object sender, EventArgs e)
        //{
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
        //}

        //private void get_now() // 현재 실행하고있는 생산계획 불러오기
        //{
        //    try
        //    {
        //        var limit1 = "select * from tb_cur inner join on tb_cur.plannum = tb_plan.plannum order by curnum DESC LIMIT 1";
        //        var adapter = new MySqlDataAdapter(limit1, connection);
        //        var dataTable = new DataTable();
        //        adapter.Fill(dataTable);
        //        dg_now.DataSource = dataTable;
        //    }
        //    catch (Exception ex)
        //    {
        //        // 예외 처리
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        ////함수로 만들어놨으니까 삭제 얼마든지 하셔도 됩니다...

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
                //dg_plan.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show(ex.Message);
            }
            
        }

        private void planBtn_Click(object sender, EventArgs e)
        {
            MetroFramework.Forms.MetroForm Plan_DML = new MetroFramework.Forms.MetroForm();
            Plan_DML.TopLevel= true;
            Plan_DML.Text = "PLAN 등록/수정";
            Plan_DML.Size = new Size(500, 500);
            Plan_DML.Show();
        }

        private void PanelLoad()
        {
            var query = "SELECT COUNT(*) FROM tb_plan;";
            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                planRowNumber = Convert.ToInt32(reader.ExecuteScalar()) - 1;
            }
            query = "SELECT * FROM tb_plan ORDER BY priority, duedate;";
            
            MetroFramework.Controls.MetroTile[] planPanel = new MetroFramework.Controls.MetroTile[planRowNumber + 1];
            
            var dataTable = new DataTable();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }
            DataRow row;
            if (planRowNumber > -1)
            {
                for (int i = 0; i < planRowNumber + 1; i++)
                {
                    row = dataTable.Rows[i];
                    MetroFramework.Controls.MetroLabel[] planLabel = new MetroFramework.Controls.MetroLabel[13];
                    
                    MetroFramework.Controls.MetroTextBox planTb = new MetroFramework.Controls.MetroTextBox();

                    planPanel[i] = new MetroFramework.Controls.MetroTile();
                    planManager.Controls.Add(planPanel[i]);
                    planPanel[i].ActiveControl = null;
                    planPanel[i].Location = new Point((310 * i) + 10, 30);
                    planPanel[i].Name = $"planPanel{i}";
                    planPanel[i].Size = new Size(300, 300);
                    planPanel[i].TabIndex = 0;
                    planPanel[i].Text = row[3].ToString();
                    planPanel[i].UseSelectable = true;

                    planTb.CustomButton.Image = null;
                    planTb.CustomButton.Location = new Point(6, 2);
                    planTb.CustomButton.Name = "";
                    planTb.CustomButton.Size = new Size(111, 111);
                    planTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
                    planTb.CustomButton.TabIndex = 1;
                    planTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
                    planTb.CustomButton.UseSelectable = true;
                    planTb.CustomButton.Visible = false;
                    planTb.Lines = new string[] { "Memo" };
                    planTb.Location = new Point(90, 130);
                    planTb.MaxLength = 32767;
                    planTb.Name = $"planTB{i}";
                    planTb.PasswordChar = '\0';
                    planTb.ScrollBars = ScrollBars.None;
                    planTb.SelectedText = "";
                    planTb.SelectionLength = 0;
                    planTb.SelectionStart = 0;
                    planTb.ShortcutsEnabled = true;
                    planTb.Size = new Size(200, 160);
                    planTb.TabIndex = 14;
                    planTb.Text = "Memo";
                    planTb.UseSelectable = true;
                    planTb.WaterMarkColor = Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
                    planTb.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);

                    planPanel[i].Controls.Add(planTb);

                    for (int j = 0; j < 13; j++)
                    {
                        planLabel[j] = new MetroFramework.Controls.MetroLabel();
                        planLabel[j].AutoSize = false;
                        planLabel[j].TabIndex = 0;

                        if (j > 6)
                        {
                            planLabel[j].Location = new Point(90, (20 * (j - 7)) + 10);
                            planLabel[j].Size = new Size(90, 20);
                        }
                        else
                        {
                            planLabel[j].Location = new Point(10, (20 * j) + 10);
                            planLabel[j].Size = new Size(80, 20);
                        }
                        planPanel[i].Controls.Add(planLabel[j]);
                    }

                    //key
                    planLabel[0].Name = $"planPanel{i}_recivedate";
                    planLabel[0].Text = "수주날짜";
                    planLabel[1].Name = $"planPanel{i}_priority";
                    planLabel[1].Text = "우선순위";
                    planLabel[2].Name = $"planPanel{i}_nowea";
                    planLabel[2].Text = "생산완료";
                    planLabel[3].Name = $"planPanel{i}_planea";
                    planLabel[3].Text = "수주수량";
                    planLabel[4].Name = $"planPanel{i}_duedate";
                    planLabel[4].Text = "납기일자";
                    planLabel[5].Name = $"planPanel{i}_plannum";
                    planLabel[5].Text = "주문번호";
                    planLabel[6].Name = $"planPanel{i}_plannum";
                    planLabel[6].Text = "비고";

                    //value
                    planLabel[7].Name = $"planPanel{i}_recivedateValue";
                    planLabel[8].Name = $"planPanel{i}_priorityValue";
                    planLabel[9].Name = $"planPanel{i}_noweaValue";
                    planLabel[10].Name = $"planPanel{i}_planeaValue";
                    planLabel[11].Name = $"planPanel{i}_duedateValue";
                    planLabel[12].Name = $"planPanel{i}_plannumValue";

                    //db에서 불러오기
                    planLabel[7].Text = row[1].ToString();
                    planLabel[8].Text = row[6].ToString();
                    planLabel[9].Text = row[4].ToString();
                    planLabel[10].Text = row[5].ToString();
                    planLabel[11].Text = row[2].ToString();
                    planLabel[12].Text = row[0].ToString();

                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //planManager.

        }
    }
}
