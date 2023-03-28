using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginTest;
using MySql.Data.MySqlClient;

namespace FinalProject_C3
{
    public partial class Tab_Device : MetroFramework.Forms.MetroForm
    {
        DBMySql db = new DBMySql();

        public Tab_Device(string name)
        {
            InitializeComponent();
            lb_name.Text = name;
        }

        private void Tab_Device_Load(object sender, EventArgs e)
        {
            db.Connection();
            dgv_device.DataSource = db.SelectAll("tb_device").Tables[0];
            getcb_pro();
            timer1.Start();
        }

        //private void getcb_prod()
        //{
        //    cb_prod.Items.Clear();
        //    cb_prod.Items.Add("제품번호");
        //    try
        //    {
        //        string strqry = "select prodnum from tb_prod";
        //        foreach (DataRow dr in db.Select(strqry).Rows)
        //        {
        //            cb_prod.Items.Add(dr["prodnum"]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void get_usernum()
        //{
        //    string con = "usernum";
        //    string tb = "tb_user";
        //    string where = $"where username = '{lb_name.Text}'";
        //    lb_usernum.Text = db.SelectDetail(con, tb, where).Tables[0].Rows[0][0].ToString();
        //}

        //private void get_cur()
        //{
        //    string tableOrder= $"tb_cur order by curnum DESC LIMIT 1";
        //    dgv_cur.DataSource = db.SelectAll(tableOrder).Tables[0];
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    dgv_device.DataSource = db.SelectAll("tb_flow").Tables[0];
        //} 

        private void bt_flowupdate_Click(object sender, EventArgs e)
        {
            //    if (cb_plan.SelectedText != "생산계획" || cb_prod.SelectedText != "제품번호")
            //        {
            //            string table = "tb_cur(plannum,prodnum,usernum)";
            //            string values = $"{cb_plan.SelectedItem},{cb_prod.SelectedItem},{lb_usernum.Text}";
            //            db.Insert(table, values);
            //            get_cur();
            //        }
        }//삭제됨

        private void Tab_Device_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgv_device.DataSource = db.SelectAll("tb_device").Tables[0]; // 주기적 DB 업데이트
        }

        private void dgv_device_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                dgv_cur.Rows[0].Cells[i].Value = dgv_device.Rows[e.RowIndex].Cells[i].Value;
                
            }//선택된 dgv_device값을 dgv_cur에 불러오기
        }

        private void bt_devicein_Click(object sender, EventArgs e)
        {
            try
            {
                string values = $"'{dgv_cur.Rows[0].Cells[1].Value}',{dgv_cur.Rows[0].Cells[2].Value},'{dgv_cur.Rows[0].Cells[3].Value}'";
                db.Insert("tb_device(devicename,pronum,proname)", values);
                MessageBox.Show("디바이스를 추가하였습니다.","추가완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bt_deviceup_Click(object sender, EventArgs e)
        {
            try
            {
                string setvalue = $"devicename = '{dgv_cur.Rows[0].Cells[1].Value}'," +
                    $"pronum = {dgv_cur.Rows[0].Cells[2].Value}," +
                    $"proname = '{dgv_cur.Rows[0].Cells[3].Value}'";
                string wherevalue = $"where devicenum = {dgv_cur.Rows[0].Cells[0].Value}";
                db.Update("tb_device", setvalue, wherevalue);
                MessageBox.Show("디바이스를 수정하였습니다.", "수정완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_devicedel_Click(object sender, EventArgs e)
        {
            try
            {
                string values = $"tb_device where devicenum = {dgv_cur.Rows[0].Cells[0].Value}";
                db.DeleteAll(values);
                MessageBox.Show("디바이스를 삭제하였습니다.", "삭제완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getcb_pro()
        {
            cb_pro.Items.Clear();
            cb_pro.Items.Add("전체");
            try
            {
                string strqry = "select distinct proname from tb_device";
                foreach (DataRow dr in db.Select(strqry).Rows)
                {
                    cb_pro.Items.Add(dr["proname"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            // 조회 시작일과 종료일 설정
            DateTime sDate = dt_start.Value.Date;
            DateTime eDate = dt_end.Value.Date.AddDays(1);

            // 총 생산량 쿼리 실행
            string query = $"SELECT count(prodnum) FROM tb_flow WHERE pr = '완료' AND DATE(donetime) >= '{startDate:yyyy-MM-dd}' AND DATE(donetime) < '{endDate:yyyy-MM-dd}'";
            //try
            //{
            //    object result = db.ExecuteScalar(query);
            //    int totalQuantity = Convert.ToInt32(result ?? 0);
            //    int totalDefectCount = 0;

            //    // 불량품 수 쿼리 실행
            //    string defectQuery = $"SELECT DATE(proddate), COUNT(*) FROM tb_prod WHERE DATE(proddate) >= '{startDate:yyyy-MM-dd}' AND DATE(proddate) < '{endDate:yyyy-MM-dd}' AND spec = '1' GROUP BY DATE(proddate)";
            //    DataTable defectTable = db.ExecuteDataTable(defectQuery);

            //    // 검색 결과를 출력할 데이터 그리드뷰의 컬럼 설정
            //    dgv_Search.Columns.Clear();
            //    dgv_Search.Columns.Add("date", "날짜");
            //    dgv_Search.Columns.Add("totalQuantity", "총 생산량");
            //    dgv_Search.Columns.Add("defectCount", "불량 갯수");
            //    dgv_Search.Columns.Add("defectRate", "불량률(%)");

            //    // 각 일자별 생산량과 불량품 수, 불량률 계산 및 데이터 그리드뷰에 출력
            //    foreach (DataRow row in defectTable.Rows)
            //    {
            //        DateTime date = Convert.ToDateTime(row["DATE(proddate)"]);
            //        int dailyQuantity = GetDailyQuantity(date, startDate, endDate);
            //        int count = Convert.ToInt32(row["COUNT(*)"]);
            //        double defectRate = dailyQuantity != 0 ? Math.Round((double)count / dailyQuantity * 100, 2) : 0;
            //        totalDefectCount += count;

            //        dgv_Search.Rows.Add(date.ToString("yyyy-MM-dd"), dailyQuantity, count, $"{defectRate}%");
            //    }

            //    // 총 생산량과 불량률 계산 및 출력
            //    double totalDefectRate = totalQuantity != 0 ? Math.Round((double)totalDefectCount / totalQuantity * 100, 2) : 0;
            //    dgv_Total.Rows.Clear();
            //    dgv_Total.Rows.Add($"{startDate:yyyy-MM-dd} ~ {endDate.AddDays(-1):MM-dd}", totalQuantity, totalDefectCount, $"{totalDefectRate}%");

            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
