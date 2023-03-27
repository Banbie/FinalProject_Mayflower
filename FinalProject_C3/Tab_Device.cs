﻿using System;
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
            lb_name.Text = name;
        }

        private void Tab_Device_Load(object sender, EventArgs e)
        {
            db.Connection();
            dgv_flow.DataSource = db.SelectAll("tb_flow").Tables[0];
            getcb_plan();
            getcb_prod();
            get_usernum();
        }

        private void getcb_plan()
        {
            cb_plan.Items.Clear();
            cb_plan.Items.Add("생산계획");
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

        private void getcb_prod()
        {
            cb_prod.Items.Clear();
            cb_prod.Items.Add("제품번호");
            try
            {
                string strqry = "select prodnum from tb_prod";
                foreach (DataRow dr in db.Select(strqry).Rows)
                {
                    cb_prod.Items.Add(dr["prodnum"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void get_usernum()
        {
            string con = "usernum";
            string tb = "tb_user";
            string where = $"where username = '{lb_name.Text}'";
            lb_usernum.Text = db.SelectDetail(con, tb, where).Tables[0].Rows[0][0].ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            dgv_flow.DataSource = db.SelectAll("tb_flow").Tables[0];
        }

        private void bt_flowupdate_Click(object sender, EventArgs e)
        {
            if (cb_plan.SelectedText != "생산계획" || cb_prod.SelectedText != "제품번호")
            {
                string table = "tb_cur(plannum,prodnum,usernum)";
                string values = $"{cb_plan.SelectedItem},{cb_prod.SelectedItem},{lb_usernum.Text}";
                db.Insert(table,values);
            }
        }
    }
}
