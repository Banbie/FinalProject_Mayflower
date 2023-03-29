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
using static System.Windows.Forms.AxHost;

namespace FinalProject_C3
{
    public partial class Tab_Monitor : MetroFramework.Forms.MetroForm
    {
        DBMySql db = new DBMySql();
        public Tab_Monitor()
        {
            InitializeComponent();
        }

        private void Tab_Monitor_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void get_prosess()
        {
            string cond = "d.proname, f.flowdate, f.flowtime";
            string table = "tb_flow f left join tb_device d on f.pronum = d.pronum";
            string orderby = "order by flownum DESC LIMIT 1";

            //try
            //{
            //    tb_pronow.Text = db.SelectDetail(cond, table, where).Tables[0];
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
