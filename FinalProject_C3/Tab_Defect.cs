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
using MySql.Data.MySqlClient;
using System.IO;


namespace FinalProject_C3
{
    public partial class Tab_Defect : MetroFramework.Forms.MetroForm
    {
        

        public Tab_Defect()
        {
            InitializeComponent();
        }
        private DateTime currentDate = DateTime.Now;

        private void Tab_Defect_Load(object sender, EventArgs e)
        {
            // DB 연결
            DBMySql db = new DBMySql();
            db.Connection();

            // 오늘 날짜 구하기
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MM-dd");

            // 쿼리 실행
            //DataTable dt = db.Select($"SELECT CONCAT('{formattedDate}', '_', `PLC-d103`) as proid \r\nFROM io-plc \r\nWHERE DATE_FORMAT(timestamp, '%Y-%m-%d') = '{currentDate.ToString("yyyy-MM-dd")}'");
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 첫 번째 컬럼만 처리
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                // 클릭된 셀의 데이터 가져오기
                string imageName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
               
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
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(-1);
            string formattedDate = currentDate.ToString("MM-dd");

            DBMySql db = new DBMySql();
            DataTable dt = db.Select($"SELECT DATE_FORMAT(daytime, '%Y-%m-%d') AS date, CONCAT('{formattedDate}', '_', total) as proid FROM mayflower.tfs WHERE DATE_FORMAT(daytime, '%Y-%m-%d') = '{currentDate.ToString("yyyy-MM-dd")}' AND tf = 1");
            // 데이터 그리드 뷰에 데이터 바인딩
            dataGridView1.DataSource = dt;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            // DB 연결
            DBMySql db = new DBMySql();
            db.Connection();

            // 쿼리 실행
            DataTable dt = db.Select("SELECT DATE_FORMAT(daytime, '%Y-%m-%d') AS date, CONCAT(DATE_FORMAT(daytime, '%m-%d'), '_', total) as proid \r\nFROM mayflower.tfs \r\nWHERE tf = 1 \r\nAND DATE_FORMAT(daytime, '%Y-%m-%d') = DATE_FORMAT(NOW(), '%Y-%m-%d')");

            // 데이터 그리드 뷰에 데이터 바인딩
            dataGridView1.DataSource = dt;
        }
    }
}
