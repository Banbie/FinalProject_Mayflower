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

    public partial class Tab_State : MetroFramework.Forms.MetroForm
    {
        public Tab_State()
        {
            InitializeComponent();
        }
        private int CalculateAngle(int x, int y)
        {
            double xFromCenter = x - pictureBox1.Width / 2;
            double yFromCenter = pictureBox1.Height / 2 - y;

            double radians = Math.Atan2(yFromCenter, xFromCenter);
            int degrees = (int)(radians * (180 / Math.PI)) + 90;

            if (degrees < 0)
            {
                degrees += 360;
            }

            return degrees;
        }

        private int CalculateValue(int degrees)
        {
            int value = 0;

            // 이미지를 3구역으로 나눕니다.
            int sectionSize = 360 / 3;
            int section = degrees / sectionSize;

            // 1~3의 값을 각 구역에 매핑합니다.
            if (section == 0)
            {
                value = 2;
            }
            else if (section == 1)
            {
                value = 1;
            }
            else if (section == 2)
            {
                value = 3;
            }

            return value;
        }



        private void Tab_State_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 10);
            MessageBox.Show(randomNumber.ToString());
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int degrees = CalculateAngle(e.X, e.Y);
            int value = CalculateValue(degrees);

            MessageBox.Show(value.ToString()); // 선택된 값 출력
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int sectionSize = 360 / 3;
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;
            int radius = (int)(Math.Min(centerX, centerY) * 0.9);

            // 구역 경계선을 그립니다.
            for (int i = 0; i < 3; i++)
            {
                int startAngle = i * sectionSize;
                int endAngle = startAngle + sectionSize;

                // startAngle과 endAngle을 degree에서 radian으로 변환합니다.
                double startRadian = startAngle * Math.PI / 180;
                double endRadian = endAngle * Math.PI / 180;

                // startRadian과 endRadian 사이의 부채꼴을 그립니다.
                

                // 구역 경계선 중간 지점 좌표 계산
                int middleAngle = i * sectionSize + sectionSize / 2;
                double middleRadian = middleAngle * Math.PI / 180;
                int middleX = (int)(centerX + radius * Math.Cos(middleRadian));
                int middleY = (int)(centerY - radius * Math.Sin(middleRadian));

                // 숫자 출력
                if (i == 0) // 첫 번째 구역일 때는 3 출력
                {
                    e.Graphics.DrawString("1", this.Font, Brushes.Black, new PointF(middleX, middleY));
                }
                else if (i == 1) // 두 번째 구역일 때는 2 출력
                {
                    e.Graphics.DrawString("3", this.Font, Brushes.Black, new PointF(middleX, middleY));
                }
                else // 세 번째 구역일 때는 1 출력
                {
                    e.Graphics.DrawString("2", this.Font, Brushes.Black, new PointF(middleX, middleY));
                }
            }






        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
