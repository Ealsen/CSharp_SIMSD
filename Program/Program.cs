using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //// 打印出当前系统的日期和时间
            // Console.WriteLine("SIMSDBB！");
            //Console.WriteLine("The current date and time is: " + DateTime.Now);
        }
    }
}
