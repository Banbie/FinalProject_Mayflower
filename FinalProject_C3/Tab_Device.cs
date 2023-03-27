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
            lb_name.Text = name +" 님";
        }

        private void Tab_Device_Load(object sender, EventArgs e)
        {
            db.Connection();
            dgv_flow.DataSource = db.SelectAll("tb_flow").Tables[0];
        }
    }
}
