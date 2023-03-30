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
using Org.BouncyCastle.Asn1.X509;

namespace FinalProject_C3
{
    public partial class Tab_Device : MetroFramework.Forms.MetroForm
    {
        DBMySql db = new DBMySql();

        public Tab_Device()
        {
            InitializeComponent();
            
        }

        private void Tab_Device_Load(object sender, EventArgs e)
        {
            db.Connection();
            dgv_device.DataSource = db.SelectAll("tb_device").Tables[0];
            getcb_pro();
        }
 

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

        private void dgv_device_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    dgv_cur.Rows[0].Cells[i].Value = dgv_device.Rows[e.RowIndex].Cells[i].Value;

                }//선택된 dgv_device값을 dgv_cur에 불러오기
            }
        }

        private void bt_devicein_Click(object sender, EventArgs e)
        {
            try
            {
                string values = $"'{dgv_cur.Rows[0].Cells[1].Value}',{dgv_cur.Rows[0].Cells[2].Value},'{dgv_cur.Rows[0].Cells[3].Value}'";
                db.Insert("tb_device(devicename,pronum,proname)", values);
                MessageBox.Show("디바이스를 추가하였습니다.","추가완료");
                dgv_device.DataSource = db.SelectAll("tb_device").Tables[0];
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
                dgv_device.DataSource = db.SelectAll("tb_device").Tables[0];
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
                dgv_device.DataSource = db.SelectAll("tb_device").Tables[0];
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
            DateTime sDate = dt_start.Value;
            DateTime eDate = dt_end.Value.AddDays(1);

            string cond = "d.devicename as  디바이스이름, d.proname as 공정이름, f.flowdate as 날짜, count(*) as 총가동횟수";
            string table = "tb_flow f left join tb_device d on f.pronum = d.pronum ";
            string where;

            if (cb_pro.SelectedItem.ToString() != "전체")
            {   where = $"WHERE proname = '{cb_pro.SelectedItem}' AND DATE(flowdate) >= '{sDate:yyyy-MM-dd}' AND DATE(flowdate) < '{eDate:yyyy-MM-dd}'";  }
            else
            {   where = $"WHERE DATE(flowdate) >= '{sDate:yyyy-MM-dd}' AND DATE(flowdate) < '{eDate:yyyy-MM-dd}'";  }

            string groupBy = " group by d.devicename, d.proname, f.flowdate ;";

            try
            {
                dgv_deflow.DataSource = db.SelectDetail(cond, table, where + groupBy).Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tab_Device_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
