using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;

namespace FinalProject_C3
{
    
    public partial class Tab_Plan : MetroFramework.Forms.MetroForm
    {
        public MetroFramework.Drawing.Html.HtmlPanel manager;
        public static MySqlConnection ConnectDB()
        {
            string connectionString =
             "Server=192.168.0.3;;" +
            //"Server=localhost;" +
            "Database=mayflower;" +
            "Port=3306;" +
            "Uid=edu;" +
            //"Uid=root;" +
            "Pwd=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }
        MySqlConnection connection = ConnectDB();

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

            var query = "SELECT COUNT(*) FROM tb_plan;";
            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                planRowNumber = Convert.ToInt32(reader.ExecuteScalar()) - 1;
            }
            connection.Close();

            InitializeComponent();

            PanelInit();

            UpdateChart();

            DataTable dataTable = GridInit();
            dataTable.Columns.RemoveAt(0);
            dgv_plan.DataSource = dataTable;

            prod_chart.Titles.Add("생산 완료/미완료 비율");
            
            Show();
        }

        public void PanelInit()
        {
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
                planRowNumber = Convert.ToInt32(reader.ExecuteScalar()) - 1;
            }

            manager = planManager;
            MetroFramework.Controls.MetroButton planBtn = new MetroFramework.Controls.MetroButton();
            planManager.Controls.Add(planBtn);
            planBtn.Location = new Point((310 * (planRowNumber + 1)) + 10, 30);
            planBtn.Name = "planBtn";
            planBtn.Size = new Size(40, 300);
            planBtn.TabIndex = 1;
            planBtn.Text = "+";
            planBtn.UseSelectable = true;
            planBtn.Click += new EventHandler(planBtn_Click);

            OrderTile[] orderTile = new OrderTile[planRowNumber + 1];

            var dataTable = new DataTable();

            query = "SELECT * FROM tb_plan ORDER BY priority, duedate;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }

            DataRow row;

            for (int i = 0; i < planRowNumber + 1; i++)
            {
                row = dataTable.Rows[i];
                orderTile[i] = new OrderTile(planManager, row, i,this);
            }

            connection.Close();
        }

        public void PanelInit(string column , int order)  //overloading column 에 기준 컬럼 문자열로 쉼표를 통해 복수 설정 가능,  order==이면 내림차순 나머지 오름차순
        {
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
                planRowNumber = Convert.ToInt32(reader.ExecuteScalar()) - 1;
            }

            manager = planManager;
            MetroFramework.Controls.MetroButton planBtn = new MetroFramework.Controls.MetroButton();
            planManager.Controls.Add(planBtn);
            planBtn.Location = new Point((310 * (planRowNumber + 1)) + 10, 30);
            planBtn.Name = "planBtn";
            planBtn.Size = new Size(40, 300);
            planBtn.TabIndex = 1;
            planBtn.Text = "+";
            planBtn.UseSelectable = true;
            planBtn.Click += new EventHandler(planBtn_Click);

            OrderTile[] orderTile = new OrderTile[planRowNumber + 1];

            var dataTable = new DataTable();
            string sortWay;
            if (order == 1)
            {
                sortWay = "DESC";
            }
            else
            {
                sortWay = "ASC";
            }
            query = $"SELECT * FROM tb_plan ORDER BY {column} {sortWay};";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }

            DataRow row;

            for (int i = 0; i < planRowNumber + 1; i++)
            {
                row = dataTable.Rows[i];
                orderTile[i] = new OrderTile(planManager, row, i, this);
            }

            connection.Close();
        } 

        private void GridInit(string column, int order)
        {
            string sortWay;
            if (order == 1)
            {
                sortWay = "DESC";
            }
            else
            {
                sortWay = "ASC";
            }
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show(ex.Message);
            }
            var dataTable = new DataTable();

            var query = $"SELECT * FROM tb_plan ORDER BY {column} {sortWay};";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }

            dataTable.Columns.RemoveAt(0);
            dataTable.Columns[1].ColumnName = "수주일자";
            dataTable.Columns[2].ColumnName = "납기기한";
            dataTable.Columns[3].ColumnName = "주문자";
            dataTable.Columns[4].ColumnName = "생산량";
            dataTable.Columns[5].ColumnName = "주문량";
            dataTable.Columns[6].ColumnName = "우선순위";
            //dataTable.Columns[7].ColumnName = "배정/출하시간";
            dgv_plan.DataSource = dataTable;

            connection.Close();
        }

        private DataTable GridInit()
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show(ex.Message);
            }

            var query = "SELECT * FROM tb_plan ORDER BY priority, duedate;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }

            connection.Close();
            dataTable.Columns[1].ColumnName = "수주일자";
            dataTable.Columns[2].ColumnName = "납기기한";
            dataTable.Columns[3].ColumnName = "주문자";
            dataTable.Columns[4].ColumnName = "생산량";
            dataTable.Columns[5].ColumnName = "주문량";
            dataTable.Columns[6].ColumnName = "우선순위";
            
            dataTable.Columns[7].ColumnName = "배정/출하시간";


            return dataTable;
        } // sort 된 DataTable 리턴

        private string UpdateRow(DataTable dataTable) //업데이트 해야하는 pk 체워야하는ea planea 공백기준으로 스트링 리턴
        {
            //init
            string targetRow="";
            int rowIndex = dataTable.Rows.Count;
            DataRow row = dataTable.Rows[0]; //주문완료 된 행이 없는 경우 우선순위 첫번째 Primary Key 반환
            int remain = Int32.Parse(row[5].ToString()) - Int32.Parse(row[4].ToString());
            string noRow = row[0].ToString()+" "+ remain.ToString()+" " + row[5].ToString(); 
            if (rowIndex > 0) //안전구문
            {
                for (int i =0; i<rowIndex; i++)
                {
                    row = dataTable.Rows[i];

                    if (row[4].ToString() != row[5].ToString())
                    {
                        remain = Int32.Parse(row[5].ToString()) - Int32.Parse(row[4].ToString());
                        targetRow = row[0].ToString()+" "+ remain.ToString()+" " + row[5].ToString(); 
                        break;
                    }
                    targetRow = noRow;
                }
            }
            return targetRow;
        }

        private int DeltaEa()
        {
            int deltaEa = 0;
            int pastEa = 0;
            connection.Open();
            var query= "SELECT acceptive FROM tfs WHERE state = 'done' ORDER BY daytime DESC LIMIT 1;";
            try
            {
                MySqlCommand reader = new MySqlCommand(query, connection); //과거에 읽어온 done 값 검색
                if(reader.ExecuteScalar()==null)
                {
                    query = "SELECT acceptive FROM tfs WHERE daytime = (SELECT MAX(daytime) FROM tfs);";
                    using (reader = new MySqlCommand(query, connection))
                    {
                        deltaEa = Int32.Parse(reader.ExecuteScalar().ToString());
                    }
                    query = "UPDATE tfs SET state = 'done' WHERE daytime = (SELECT MAX(daytime) FROM (SELECT * FROM tfs) AS t);";
                    using (reader = new MySqlCommand(query, connection))
                    {
                        reader.ExecuteNonQuery();
                    }
                    if (deltaEa < 0)  //안전구문
                    {
                        deltaEa = 0;
                    }
                }
                else
                {
                    pastEa = Int32.Parse(reader.ExecuteScalar().ToString()); //done값이 있을 경우 pastEa 값에 넣었던 총 갯수 저장

                    query = "SELECT acceptive FROM tfs WHERE daytime = (SELECT MAX(daytime) FROM tfs);";
                    using (reader = new MySqlCommand(query, connection))
                    {
                        deltaEa = Int32.Parse(reader.ExecuteScalar().ToString())-pastEa;
                    }
                    query = "UPDATE tfs SET state = 'done' WHERE daytime = (SELECT MAX(daytime) FROM (SELECT * FROM tfs) AS t);";
                    using (reader = new MySqlCommand(query, connection))
                    {
                        reader.ExecuteNonQuery();
                    }
                    if (deltaEa < 0)  //안전구문
                    {
                        deltaEa = 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();




            return deltaEa;
        }

        private int UpdateNowea(string data, int deltaEa) // nowea 최신화하고 남는 갯수 리턴
        {
            
            var query="";
            string[] words = data.Split(' ');
            int pk = Int32.Parse(words[0]);
            int fillEa = Int32.Parse(words[1]);
            int planEa = Int32.Parse(words[2]);
            int handOver = 0;
            DateTime dateTime= DateTime.Now;

            if (deltaEa > fillEa)
            {
                query = $"UPDATE tb_plan SET nowea = {planEa}, donedate ='{dateTime}' WHERE plannum = {pk};";
                handOver = deltaEa - fillEa;
            }
            else if(deltaEa == fillEa)
            {
                query = $"UPDATE tb_plan SET nowea = {planEa}, donedate ='{dateTime}' WHERE plannum = {pk};";
            }
            else
            {
                query = $"UPDATE tb_plan SET nowea = {planEa - fillEa + deltaEa} WHERE plannum = {pk};";
            }
            connection.Open();
            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                reader.ExecuteNonQuery();
            }
            connection.Close();
            return handOver;

        }

        public void RefTile()
        {
            int scl = planManager.HorizontalScroll.Value;
            planManager.Dispose();
            planManager = new MetroFramework.Drawing.Html.HtmlPanel();
            planManager.AutoScroll = true;
            planManager.AutoScrollMinSize = new Size(1032, 18);
            planManager.BackColor = SystemColors.Window;
            planManager.Controls.Add(this.testTile1);
            planManager.Location = new Point(23, 63);
            planManager.Name = "planManager";
            planManager.Size = new Size(1032, 364);
            planManager.TabIndex = 11;
            planManager.Text = "Plan Manager";
            this.Controls.Add(planManager);
            PanelInit();
        }

        public void RefTile(string column, int order)
        {
            planManager.Dispose();
            planManager = new MetroFramework.Drawing.Html.HtmlPanel();
            planManager.AutoScroll = true;
            planManager.AutoScrollMinSize = new Size(1032, 18);
            planManager.BackColor = SystemColors.Window;
            planManager.Controls.Add(this.testTile1);
            planManager.Location = new Point(23, 63);
            planManager.Name = "planManager";
            planManager.Size = new Size(1032, 364);
            planManager.TabIndex = 11;
            planManager.Text = "Plan Manager";
            this.Controls.Add(planManager);
            PanelInit(column, order);
        }

        private int CountGood(string column) //알고 싶은 컬럼의 sum값
        {
            connection.Open();
            var query = $"SELECT SUM({column}) FROM tb_plan;";
            int allProd;
            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                allProd= Convert.ToInt32(reader.ExecuteScalar());
            }
            connection.Close();
            return allProd;
        }        

        private void UpdateChart()
        {
            prod_chart.Series.Clear();
            int defect;
            int goods;
            int orders;

            orders = CountGood("planea");
            goods = CountGood("nowea");

            defect = goods - orders;

            // Series 생성
            Series series = new Series("Series1");
            series.ChartType = SeriesChartType.Doughnut;

            // 데이터 포인트 추가
            DataPoint goodDataPoint = new DataPoint();
            goodDataPoint.SetValueXY("완료", goods);
            series.Points.Add(goodDataPoint);

            DataPoint defectDataPoint = new DataPoint();
            defectDataPoint.SetValueXY("미완료", defect);
            series.Points.Add(defectDataPoint);

            // 차트에 Series 추가
            prod_chart.Series.Add(series);

            prod_chart.Update();
            prod_chart.Show();
        }

        private void planBtn_Click(object sender, EventArgs e)
        {

            RefTile();
            Plan_DML dml = new Plan_DML
            {
                TopLevel = true
            };
            dml.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RefTile();
            DataTable dataTable = GridInit();
            dataTable.Columns.RemoveAt(0);
            dgv_plan.DataSource = dataTable;
            UpdateChart();
        }

        private void metroButton2_Click(object sender, EventArgs e) //순위
        {
            RefTile("priority",0);
            GridInit("priority", 0);
            UpdateChart();
        }

        private void metroButton3_Click(object sender, EventArgs e) //납기
        {
            RefTile("duedate", 0);
            GridInit("duedate", 0);
            UpdateChart();
        }

        private void metroButton4_Click(object sender, EventArgs e) //수량
        {
            RefTile("planea", 1);
            GridInit("planea", 1);
            UpdateChart();
        }

        private void bt_done_Click(object sender, EventArgs e)
        {
            int remain = 0;
            //여기에 deltaEa값 넣고 remain에 넣음 됨
            remain = DeltaEa();
            if(remain == 0)
            {
                MessageBox.Show("생산된 재고가 없습니다.");
            }
            else
            {
                MessageBox.Show("제품 출하 완료");
            }
            while (remain != 0)
            {
                string setStr = UpdateRow(GridInit());
                remain = UpdateNowea(setStr, remain);
            }
            UpdateChart();
        }
    }

    public class OrderTile : MetroFramework.Forms.MetroForm
    {
        DataRow row;
        MetroFramework.Controls.MetroTile planPanel = new MetroFramework.Controls.MetroTile();
        MetroFramework.Drawing.Html.HtmlPanel manager;
        Tab_Plan tab_Plan;
        public OrderTile(MetroFramework.Drawing.Html.HtmlPanel planManager, DataRow row, int i, Control tab_Plan) //넣을 HtmlPanel
        {
            this.tab_Plan = (Tab_Plan)tab_Plan;
            manager = planManager;
            manager.Controls.Add(planPanel);

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

        private void labeling(MetroFramework.Controls.MetroTile planPanel, DataRow row)
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

            int planEa = int.Parse(planLabel[10].Text);
            int nowEa = int.Parse(planLabel[9].Text.ToString());
            if (nowEa != 0 && planEa > nowEa)
            {
                planTb.Text = "진행중";
            }
            else if (planEa == nowEa)
            {
                planTb.Text = "출하 완료";
            }
        }

        void CancelBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = ConnectDB();
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
            this.planPanel.Dispose();

        }

        private MySqlConnection ConnectDB()
        {
            string connectionString =
            "Server=192.168.0.3;;" +
            "Database=mayflower;" +
            "Port=3306;" +
            "Uid=edu;" +
            "Pwd=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }
    }
}
