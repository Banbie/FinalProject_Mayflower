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
        Timer timers = new Timer();
        public Tab_Device(string name)
        {
            InitializeComponent();
            lb_name.Text = name +" 님";
            // 타이머 설정
            timers.Interval = 1000;
            timers.Tick += Timer_Tick;
            timers.Start();
        }

        private void Tab_Device_Load(object sender, EventArgs e)
        {
            db.Connection();
            dgv_flow.DataSource = db.SelectAll("tb_flow").Tables[0];
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // DB에서 데이터 가져오기
            var table = db.SelectAll("tb_flow").Tables[0];

            // 데이터그리드 업데이트
            dgv_flow.DataSource = table;
        }
    }
}
