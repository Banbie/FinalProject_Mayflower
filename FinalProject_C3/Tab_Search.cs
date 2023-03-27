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
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            dgv_flow.DataSource = db.SelectAll("tb_flow").Tables[0];
        }
    }
    
}
