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
            dgv_flow.DataSource = db.SelectAll("tb_flow").Tables[0];
            getcb_plan();
            timer1.Start();
        }
        private void getcb_plan()
        {
            cb_plan.Items.Clear();
            cb_plan.Items.Add("전체");
            try
            {
                string strqry = "select plannum from tb_plan";
                foreach (DataRow dr in db.Select(strqry).Rows)
                {
                    cb_plan.Items.Add(dr["plannum"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timeplan_search()
        {
            string timeS = dtp_start.Value.ToString("yyyy-MM-dd");
            string timeE = dtp_end.Value.ToString("yyyy-MM-dd");
            string query;
            if (cb_plan.SelectedItem == null) { query = "tb_flow";  }
            else if (cb_plan.SelectedItem == "전체")
            { query = $"tb_flow where flowdate between '{timeS}' and '{timeE}'"; }
            else
            { query = $"tb_flow where plannum = {cb_plan.SelectedItem} and flowdate between '{timeS}' and '{timeE}'"; }
            dgv_flow.DataSource = db.SelectAll(query).Tables[0];
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeplan_search();
        }
    }
    
}
