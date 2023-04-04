using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject_C3
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Login());
            //Dictionary<string, string> hash = new Dictionary<string, string>
            //{
            //    { "username", "TESTER" },
            //    { "author", "TESTAUTHOR" },
            //    { "usernum", "4885" }
            //};

            //Admin form = new Admin(hash);

            //Application.Run(form);
            //form.Show();

            //Application.Run();
        }
    }
}
