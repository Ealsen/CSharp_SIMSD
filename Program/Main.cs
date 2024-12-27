using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Login.Login;

namespace Login
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        // 退出按钮
        private void quit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("是否退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }


        // 管理员按钮
        private void manager_button_Click(object sender, EventArgs e)
        {
            grade_management gm = new grade_management();
            gm.ShowDialog();
        }


        // 注销按钮
        private void logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Visible = false;
        }


        // 查询按钮
        private void search_button_Click(object sender, EventArgs e)
        {
            search newsearch = new search();
            newsearch.ShowDialog();
        }

        private void Main_close(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }


        // 分析按钮
        private void fenxi_button_Click(object sender, EventArgs e)
        {
            analysis anls = new analysis();
            anls.ShowDialog();
        }


        // 统计按钮
        private void tongji_button_Click(object sender, EventArgs e)
        {
            statistics stat = new statistics();
            stat.ShowDialog();
        }


        // 窗体加载事件
		private void Main_Load(object sender, EventArgs e)
		{
            // 使用了一个唯一ID来标识用户，这里直接显示当前登录的用户
			hello.Text = "你好, 管理员 " + UserSession.LoggedInUser;

		}



		private void Header_Click(object sender, EventArgs e)
		{

		}

		private void hello_TextChanged(object sender, EventArgs e)
		{

		}


  //      // 成绩更新按钮——窗口跳转
		//private void ScoreUpdata_Click(object sender, EventArgs e)
		//{
  //          ScoreUpdate su = new ScoreUpdate();
  //          su.ShowDialog();
		//}
	}
}
