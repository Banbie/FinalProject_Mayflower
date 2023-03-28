using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalProject_C3
{
    public partial class Plan_DML : MetroFramework.Forms.MetroForm
    {
        
        public Plan_DML()
        {
            InitializeComponent();

            MySqlConnection connection = MysqlConnected();

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show(ex.Message);
            }

            var query = "SELECT plannum FROM tb_plan;";
            using (MySqlDataAdapter reader = new MySqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                reader.Fill(dataTable);
                int count = dataTable.Rows.Count;

                for(int i = 0; i < count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    cb_planNum.Items.Add(Convert.ToInt32(row[0]));
                }

                DateTime dateTime= DateTime.Now;
                dt_reciveDate.Value = dateTime;
            }

            connection.Close();
        }

        private MySqlConnection MysqlConnected()
        {
            string connectionString =
            "Server=localhost;" +
            "Database=mayflower;" +
            "Port=3306;" +
            "Uid=root;" +
            "Pwd=1234;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }
        private void Plan_DML_Load(object sender, EventArgs e)
        {

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = MysqlConnected();

            DateTime reciveDate = dt_reciveDate.Value; 
            DateTime dueDate = dt_dueDate.Value; 
            

            var query = "UPDATE tb_plan SET " +
                $"recivedate ='{reciveDate:yyyy-MM-dd}', " +
                $"duedate ='{dueDate:yyyy-MM-dd}', " +
                $"planea ={tb_planEA.Text}, " +
                $"comname ='{tb_comName.Text}', " +
                $"priority ={tb_priority.Text} " +
                $"WHERE plannum = {cb_planNum.Text};";
            connection.Open();

            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                reader.ExecuteNonQuery();
            }
            connection.Close();
            Plan_DML plan_DML = this;
            plan_DML.Dispose();

            connection.Close();
        }


        private void bt_insert_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = MysqlConnected();

            DateTime reciveDate = dt_reciveDate.Value;
            DateTime dueDate = dt_dueDate.Value;


            var query = "INSERT INTO tb_plan (recivedate, duedate, planea, comname, priority) VALUES " +
               $"('{reciveDate:yyyy-MM-dd}', '{dueDate:yyyy-MM-dd}', {tb_planEA.Text}, '{tb_comName.Text}', {tb_priority.Text})";

            connection.Open();

            using (MySqlCommand reader = new MySqlCommand(query, connection))
            {
                reader.ExecuteNonQuery();
            }
            connection.Close();
            Plan_DML plan_DML = this;
            plan_DML.Dispose();

            connection.Close();
        }

    }
}
