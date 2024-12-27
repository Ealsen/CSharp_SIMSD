using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
		}



		private void RegBtn_Click(object sender, EventArgs e)
		{
			// 检查用户是否存在
			string userName = Username.Text.Trim();

			/**
             * 连接数据库
             */
			MySqlConnection mycon = new MySqlConnection();
			mycon.ConnectionString = DbConfig.ConnectionString;
			mycon.Open();  // 打开数据库

			// 查询用户是否存在
			MySqlCommand checkCommand = mycon.CreateCommand();
			string s2 = "SELECT username FROM user WHERE username = @Username";
			checkCommand.CommandText = s2;
			checkCommand.Parameters.AddWithValue("@Username", userName);  

			MySqlDataAdapter check = new MySqlDataAdapter();
			check.SelectCommand = checkCommand;
			check.SelectCommand.Connection = mycon;  // 初始化
			DataSet checkData = new DataSet();
			int n = check.Fill(checkData, "user");



			if (n != 0)
			{
				MessageBox.Show("此用户名已存在");
				Username.Text = "";  // 清空输入文本框
				Password.Text = "";
				RePassword.Text = "";
				studentId.Text = "";
				nName.Text = "";
			}
			else if (Username.Text == "" || Password.Text == "" || RePassword.Text == "" || studentId.Text == "" || nName.Text == "")
			{
				MessageBox.Show("请将信息填写完整");
				Username.Focus();
			}
			else if (RePassword.Text != Password.Text)
			{
				MessageBox.Show("密码不一致");
				Password.Text = ""; // 清空输入框
				RePassword.Text = "";
			}
			else
			{
				// 注册成功，上传数据
				string s3 = "INSERT INTO user (username, student_id, password, n_username) " +
							"VALUES (@Username, @StudentId, @Password, @NName)";

				MySqlCommand mycom = new MySqlCommand(s3, mycon);
				mycom.Parameters.AddWithValue("@Username", Username.Text);
				mycom.Parameters.AddWithValue("@StudentId", studentId.Text);
				mycom.Parameters.AddWithValue("@Password", Password.Text);
				mycom.Parameters.AddWithValue("@NName", nName.Text);  // 这里 nName 是存储姓名的控件

				mycom.ExecuteNonQuery();   // 执行语句
				mycon.Close();   // 关闭连接
				mycom = null;
				mycon.Dispose();  // 释放对象

				MessageBox.Show("注册成功");
				this.Close();
			}
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}

		private void Register_Load(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
