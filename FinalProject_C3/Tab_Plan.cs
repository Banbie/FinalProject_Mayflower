using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

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

            //PanelLoad();

            MetroFramework.Controls.MetroButton planBtn = new MetroFramework.Controls.MetroButton();
            planManager.Controls.Add(planBtn);
            planBtn.Location = new Point((310 * (planRowNumber+1)) + 10, 30);
            planBtn.Name = "planBtn";
            planBtn.Size = new Size(40, 300);
            planBtn.TabIndex = 1;
            planBtn.Text = "+";
            planBtn.UseSelectable = true;
            planBtn.Click += new EventHandler(planBtn_Click);

            OrderTile [] orderTile = new OrderTile[planRowNumber+1];

            var dataTable = new DataTable();

            query = "SELECT * FROM tb_plan ORDER BY priority, duedate;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }

            DataRow row;

            for (int i = 0; i<planRowNumber+1; i++)
            {
                row = dataTable.Rows[i];
                orderTile[i] = new OrderTile(planManager, row, i);
            }

            // 타이머 설정
            //timer.Interval = 1000; // 1초 간격으로 실행
            //timer.Tick += timer1_Tick; // 타이머 이벤트 핸들러 설정
            //timer.Start(); // 타이머 시작

        }
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //planManager.

        }

        private void testBtn_Click(object sender, EventArgs e)
        {

        }
    }

    public class OrderTile : MetroFramework.Forms.MetroForm
    {
        DataRow row;

        public OrderTile(MetroFramework.Drawing.Html.HtmlPanel planManager, DataRow row, int i) //넣을 HtmlPanel
        {
            MetroFramework.Controls.MetroTile planPanel = new MetroFramework.Controls.MetroTile();
            planManager.Controls.Add(planPanel);

            planPanel.ActiveControl = null;
            planPanel.Location = new Point((310 * i) + 10, 30);
            planPanel.Name = $"planPanel{i}";
            planPanel.Size = new Size(300, 300);
            planPanel.TabIndex = 0;
            planPanel.Text = row[3].ToString();
            planPanel.UseSelectable = true;

            MetroFramework.Controls.MetroButton cancelBtn = new MetroFramework.Controls.MetroButton();

            cancelBtn.Location = new Point(240, 265);
            cancelBtn.Name = "testBtn";
            cancelBtn.Size = new Size(50, 25);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseSelectable = true;
            cancelBtn.Click += new EventHandler(this.CancelBtn_Click);
            planPanel.Controls.Add(cancelBtn);

            labeling(planPanel, row);

            this.row = row;

        }

        public void labeling(MetroFramework.Controls.MetroTile planPanel, DataRow row)
        {
            MetroFramework.Controls.MetroLabel[] planLabel = new MetroFramework.Controls.MetroLabel[13];

            MetroFramework.Controls.MetroTextBox planTb = new MetroFramework.Controls.MetroTextBox();

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
            planTb.Name = $"planTB";
            planTb.PasswordChar = '\0';
            planTb.ScrollBars = ScrollBars.None;
            planTb.SelectedText = "";
            planTb.SelectionLength = 0;
            planTb.SelectionStart = 0;
            planTb.ShortcutsEnabled = true;
            planTb.Size = new Size(200, 120);
            planTb.TabIndex = 14;
            planTb.Text = "Memo";
            planTb.UseSelectable = true;
            planTb.WaterMarkColor = Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            planTb.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);

            planPanel.Controls.Add(planTb);

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
                planPanel.Controls.Add(planLabel[j]);
            }

            //key
            planLabel[0].Name = $"planPanel_recivedate";
            planLabel[0].Text = "수주날짜";
            planLabel[1].Name = $"planPane_priority";
            planLabel[1].Text = "우선순위";
            planLabel[2].Name = $"planPanel_nowea";
            planLabel[2].Text = "생산완료";
            planLabel[3].Name = $"planPanel_planea";
            planLabel[3].Text = "수주수량";
            planLabel[4].Name = $"planPanel_duedate";
            planLabel[4].Text = "납기일자";
            planLabel[5].Name = $"planPanel_plannum";
            planLabel[5].Text = "주문번호";
            planLabel[6].Name = $"planPanel_plannum";
            planLabel[6].Text = "비고";

            //value
            planLabel[7].Name = $"planPanel_recivedateValue";
            planLabel[8].Name = $"planPanel_priorityValue";
            planLabel[9].Name = $"planPanel_noweaValue";
            planLabel[10].Name = $"planPanel_planeaValue";
            planLabel[11].Name = $"planPanel_duedateValue";
            planLabel[12].Name = $"planPanel_plannumValue";

            //db에서 불러오기
            planLabel[7].Text = row[1].ToString();
            planLabel[8].Text = row[6].ToString();
            planLabel[9].Text = row[4].ToString();
            planLabel[10].Text = row[5].ToString();
            planLabel[11].Text = row[2].ToString();
            planLabel[12].Text = row[0].ToString();
        }

        void CancelBtn_Click(object sender, EventArgs e)
        {
            string connectionString =
            "Server=localhost;" +
            "Database=mayflower;" +
            "Port=3306;" +
            "Uid=root;" +
            "Pwd=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            var query = $"DELETE FROM tb_plan WHERE plannum = {row[0]};";
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show(ex.Message);
            }
            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                reader.ExecuteNonQuery();
                MessageBox.Show($"주문번호 : {row[0]} 삭제 ");
            }
            connection.Close();
            this.Dispose();
        }
    }
}
