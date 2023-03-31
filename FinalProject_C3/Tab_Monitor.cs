using LoginTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.AxHost;
using System.IO;

namespace FinalProject_C3
{
    public partial class Tab_Monitor : MetroFramework.Forms.MetroForm
    {
        DBMySql db = new DBMySql();

        public Tab_Monitor()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Tab_Monitor_Load(object sender, EventArgs e)
        {
            get_picture();
            get_qual();
            lightdisplay();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            get_prosess();
            lightdisplay();
            mpb_pro.PerformStep();
        }

        private void get_prosess()
        {
            string cond = "d.proname, f.flowdate, f.flowtime";
            string table = "tb_flow f left join tb_device d on f.pronum = d.pronum";
            string orderby = "order by f.flownum DESC LIMIT 1";

            try
            {
                DataRow dbSel = db.SelectDetail(cond, table, orderby).Tables[0].Rows[0];
                tb_pronow.Text = $"{dbSel[1]:yyyy-MM-dd}" + " " + dbSel[2] + " " + dbSel[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void progress()
        {
            string query = $"SELECT prodnum,plannum,pronum FROM tb_flow ORDER BY flownum DESC LIMIT 1 ;";
            try
            {
                DataRow dr = db.Select(query).Rows[0];
                if (dr[2].ToString() == "0")
                {
                    lb_nowprod.Text = dr[0].ToString();
                    lb_nowplan.Text = dr[1].ToString();
                    mpb_pro.Value = 0;

                }
                else if (dr[2].ToString() == "1")
                {
                    mpb_pro.Value = 36;
                }
                else if (dr[2].ToString() == "2")
                {
                    TF(dr[0].ToString());
                    //noweaupdate(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void get_qual()
        {

            prod_chart.Series.Clear();

            int allprod = CountGood("WHERE ");
            int goods = CountGood("WHERE spec = 2 AND ");
            int defect = CountGood("WHERE spec = 1 AND ");
            int etc = goods + defect;
            etc -= allprod;

            // Series 생성
            Series goodseries = new Series("양품률");
            goodseries.ChartType = SeriesChartType.Doughnut;

            // 데이터 포인트 추가
            DataPoint goodDataPoint = new DataPoint();
            goodDataPoint.SetValueXY("양품", goods);
            goodseries.Points.Add(goodDataPoint);

            DataPoint defectDataPoint = new DataPoint();
            defectDataPoint.SetValueXY("불량품", defect);
            goodseries.Points.Add(defectDataPoint);

            DataPoint etcDataPoint = new DataPoint();
            etcDataPoint.SetValueXY("미분류", etc);
            goodseries.Points.Add(etcDataPoint);

            // 차트에 Series 추가
            if (goodseries != null)
            {
                prod_chart.Series.Add(goodseries);
                prod_chart.Update();
                prod_chart.Show();
            }

        }

        private int CountGood(string where) //알고 싶은 컬럼의 sum값
        {
            DateTime sDate = dtpS.Value.Date;
            DateTime eDate = dtpE.Value.Date.AddDays(1);

            var cond = $"count(*)";
            string table = "tb_prod";
            string date = $"proddate BETWEEN '{sDate:yyyy-MM-dd}' AND '{eDate:yyyy-MM-dd}' ;";

            int allProd = Convert.ToInt32(db.SelectDetail(cond, table, where + date).Tables[0].Rows[0][0]);
            return allProd;
        }

        private void get_picture()
        {
            var cond = "prodnum";
            string table = "tb_flow";
            string limit = "ORDER BY flownum DESC LIMIT 1";

            string imageName = db.SelectDetail(cond, table, limit).Tables[0].Rows[0][0].ToString();

            // 이미지 파일 경로
            string imagePath = @"\\192.168.0.10\pi\" + imageName + ".jpg";
            pictureBox1.SizeMode
                = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 이미지 파일이 존재하는 경우에만 이미지 보여주기
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }

        }

        private void lightdisplay()
        {
            string count = "SELECT green,orange,red FROM light;";
            DataTable dt = db.Select(count);
            DataRow ldr = dt.Rows[dt.Rows.Count - 1];
            if (ldr[0].Equals(false)) 
            { pbgreen.Visible = false; }
            else 
            { pbgreen.Visible = true; }
            if (ldr[1].Equals(false)) 
            { pborange.Visible = false; }
            else 
            { pborange.Visible = true; }
            if (ldr[2].Equals(false)) 
            { pbred.Visible = false; }
            else
            { pbred.Visible = true; }
        }

        private void TF(string where)
        {
            string spec = $"SELECT spec from tb_prod where lotnum = '{where}' ;";
            if (db.Select(spec).Rows[0][0].Equals(2))
            {
                tbtf.Text = "합격";
            }
            else if (db.Select(spec).Rows[0][0].Equals(1))
            {
                tbtf.Text = "불합격";
            }
        }

        private void noweaupdate(DataRow dr)
        {
            string count = $"SELECT count(*) FROM tb_prod where lotnum = " +
                        $"any(SELECT distinct prodnum from tb_flow where plannum = {dr[1]}) and spec = 2 ;";
            string plancount = $"SELECT planea FROM tb_plan p where plannum = {dr[1]} ;";
            int nowea = Convert.ToInt32(db.Select(count).Rows[0][0]);
            int planea = Convert.ToInt32(db.Select(plancount).Rows[0][0]);
            string setvalue = $" nowea = {nowea}";
            db.Update("tb_plan", $" nowea = {nowea}", $"WHERE plannum = {dr[1]} ;");

            if (nowea >= planea)
            {

                string planquery = "ALTER TABLE tb_flow MODIFY COLUNM plannum INT DEFAULT " +
                    "(select plannum from tb_plan where nowea < planea order by priority,duetime limit 1 );";
                db.alter(planquery);
            }
            else { }
        }

        private void tb_pronow_TextChanged(object sender, EventArgs e)
        {
            tbtf.Text = "";
            get_picture();
            progress();
        }

        private void Tab_Monitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void dtpS_ValueChanged(object sender, EventArgs e)
        {
            get_qual();
        }

        private void dtpE_ValueChanged(object sender, EventArgs e)
        {
            get_qual();
        }
    }
}
