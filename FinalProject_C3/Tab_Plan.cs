using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using MySql.Data.MySqlClient;

namespace FinalProject_C3
{
    public partial class Tab_Plan : Form
    {
        private readonly string connectionString =
            "Server=192.168.0.3;" +
            "Database=mayflower;" +
            "Port=3306;" +
            "Uid=edu;" +
            "Pwd=1234;";
        public Tab_Plan()
        {
            InitializeComponent();
        }

        private void LoadDataToDataGridView(string query, DataGridView dataGridView)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        private void Tab_Plan_Load(object sender, EventArgs e)
        {
            // 전체 데이터 조회
            string query = "SELECT * FROM tb_plan;";
            LoadDataToDataGridView(query, dataGridView1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // 선택한 날짜까지의 데이터 조회
            string date = dateTimePicker1.Value.ToString("yyyy%-MM%-dd");
            string query = "SELECT ItemName AS '품목', SUM(Volume) AS '총생산량', closingDate AS '납기일' FROM plan WHERE closingDate = '" + date + "' GROUP BY ItemName;";
            LoadDataToDataGridView(query, dataGridView2);
        }
    }
}
