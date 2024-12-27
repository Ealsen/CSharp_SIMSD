using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Login.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Diagnostics; // 引用这个命名空间

namespace Login
{
	public partial class UserMain : Form
	{
		public UserMain()
		{
			InitializeComponent();

			UpdateTitle();
			LoadData();

			this.FormClosing += UserMain_FormClosing; // 绑定 FormClosing 事件
		}




		private void UserMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			// 弹出确认关闭的对话框
			if (MessageBox.Show("是否退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				e.Cancel = false; // 允许关闭窗体
				Application.ExitThread(); // 退出应用程序的线程
			}
			else
			{
				e.Cancel = true; // 取消关闭操作
			}
		}

		private void UpdateTitle()
		{
			//this.Text = "欢迎, 用户 " + UserSession.LoggedInUser + "!"; // 动态设置窗口标题
			this.Text = "用户窗口";
		}
		private void LoadData()
		{
			// 数据库连接字符串
			using (MySqlConnection conn = new MySqlConnection(DbConfig.ConnectionString))
			{
				try
				{
					// 打开连接
					conn.Open();

					// 查询语句：通过 user 表中的 username 查找对应的 student_id，然后查询 score 表
					// 未查only_id字段，因为只需要显示课程编号、课程名称、学号、姓名、班级、分数
					string query = @"
                SELECT s.subject_id AS '课程编号',
                       s.subject_name AS '课程名称',
                       s.student_id AS '学号',
                       s.student_name AS '姓名',
                       s.student_class AS '班级',
                       s.score AS '分数'
                FROM score s
                JOIN user u ON s.student_id = u.student_id
                WHERE u.username = @Username
            ";

					// 创建命令并设置参数
					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@Username", UserSession.LoggedInUser); // 使用用户名作为参数

					// 数据适配器
					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

					// 数据表
					DataTable dataTable = new DataTable();

					// 填充数据
					adapter.Fill(dataTable);

					// 绑定到 DataGridView
					dataGridView1.DataSource = dataTable;

					// 自动调整列宽
					dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

					// 设置列标题
					dataGridView1.Columns["课程编号"].HeaderText = "课程编号";
					dataGridView1.Columns["课程名称"].HeaderText = "课程名称";
					dataGridView1.Columns["学号"].HeaderText = "学生学号";
					dataGridView1.Columns["姓名"].HeaderText = "学生姓名";
					dataGridView1.Columns["班级"].HeaderText = "学生班级";
					dataGridView1.Columns["分数"].HeaderText = "分数";

					////隐藏多余的列（如果有）
					// dataGridView1.Columns["only_id"].Visible = false; // 示例


				}
				catch (Exception ex)
				{
					// 显示具体的错误信息
					MessageBox.Show("加载数据时出错: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}




		private void UserMain_Load(object sender, EventArgs e)
		{
			hello.Text = "你好, 用户 " + UserSession.LoggedInUser;
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

		private void quit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("是否退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.ExitThread();
			}

		}

		private void hello_TextChanged(object sender, EventArgs e)
		{

		}


		private void quit_Click_2(object sender, EventArgs e)
		{
			if (MessageBox.Show("是否退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.ExitThread();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void LoginOut_Click(object sender, EventArgs e)
		{
			Login lg = new Login();
			lg.Show();
			this.Visible = false;
		}
	}
}
