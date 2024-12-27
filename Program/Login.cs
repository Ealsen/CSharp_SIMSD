using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Login
{
	public partial class Login : Form
	{
		// 密码错误次数
		private int errorTime = 3;

		public Login()
		{
			InitializeComponent();
			
		}

		public static class UserSession
		{
			// 全局变量 记录当前登录用户（管理员和学生）
			public static string LoggedInUser { get; set; }
			public static string LoadStdID { get; set; }

		}


		// 计算MD5哈希值
		static string ComputeMD5Hash(string input)
		{
			// 使用MD5创建哈希对象
			using (MD5 md5 = MD5.Create())
			{
				// 将字符串转换为字节数组
				byte[] inputBytes = Encoding.UTF8.GetBytes(input);

				// 计算哈希值
				byte[] hashBytes = md5.ComputeHash(inputBytes);

				// 将哈希值转换为十六进制字符串
				StringBuilder strb = new StringBuilder();
				foreach (byte b in hashBytes)
				{
					strb.Append(b.ToString("x2")); // 转换为两位小写十六进制
				}
				return strb.ToString();
			}
		}




		// 登录按钮事件
		private void loginBtn_Click(object sender, EventArgs e)
		{
			// 密码错误次数
			errorTime = errorTime - 1;

			string username = txtName.Text.Trim();  //获取用户名
			string password = txtPwd.Text.Trim();  //获取密码

			password = ComputeMD5Hash(password);  //计算MD5哈希值

			//MessageBox.Show(password);

			//string constr = "Database=simsdbb;Data Source=127.0.0.1;Port=3306;User Id=root;Password=123456;pooling=false;CharSet=utf8;";  //设置连接字符串

            //实例化连接对象
			MySqlConnection mycon = new MySqlConnection(); 
            //设置连接字符串
			mycon.ConnectionString = DbConfig.ConnectionString;
			mycon.Open();

			MySqlCommand mycom = new MySqlCommand();  //创建SQL命令执行对象
			string s1 = "select username , password from tb1 where username = '" + username + "' and password = '" + password + "'";
			mycom.CommandText = s1;  //执行SQL命令
			MySqlDataAdapter myDA = new MySqlDataAdapter();  //实例化数据适配器

			myDA.SelectCommand = mycom;  //让适配器执行SELECT命令
			myDA.SelectCommand.Connection = mycon; //初始化
			DataSet myDS = new DataSet();  //实例化结果数据集
			int n = myDA.Fill(myDS, "tb1");  //将结果放入数据适配器 ， 返回元素个数
			if (n != 0)
			{
				//MessageBox.Show("欢迎使用!");  //登录成功

				UserSession.LoggedInUser = username;  //设置当前登录用户
				Main main = new Main();
				main.Show();
				this.Visible = false;
			}
			else
			{
				if (errorTime > 0)
				{
					MessageBox.Show("用户名或密码错误, 请重新输入");
					txtName.Text = ""; //清空输入框
					txtPwd.Text = "";
					txtName.Focus();  //输入光标的位置
				}
				else
				{
					MessageBox.Show("输入错误已达三次，系统将自动退出");
					this.Close();
				}
			}
			mycon.Close();
		}

		// 取消按钮事件
		private void cancelBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// 注册按钮事件
		private void registerBtn_Click(object sender, EventArgs e)
		{

			Register register = new Register();
			register.Show();
			//this.Visible = false;
		}


		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		// 学生登录按钮事件
		private void UserLogin_Click(object sender, EventArgs e)
		{
			errorTime = errorTime - 1;

			string username = txtName.Text.Trim();  //获取用户名
			string password = txtPwd.Text.Trim();  //获取密码
			//password = ComputeMD5Hash(password);  //计算MD5哈希值

			//string constr = "Database=simsdbb;Data Source=127.0.0.1;Port=3306;User Id=root;Password=123456;pooling=false;CharSet=utf8;";  //设置连接字符串
			MySqlConnection mycon = new MySqlConnection();  //实例化连接对象
			mycon.ConnectionString = DbConfig.ConnectionString;
			mycon.Open();

			MySqlCommand mycom = new MySqlCommand();  //创建SQL命令执行对象
			string s1 = "select username , password from user where username = '" + username + "' and password = '" + password + "'";
			mycom.CommandText = s1;  //执行SQL命令AA
			MySqlDataAdapter myDA = new MySqlDataAdapter();  //实例化数据适配器

			myDA.SelectCommand = mycom;  //让适配器执行SELECT命令
			myDA.SelectCommand.Connection = mycon; //初始化 
			DataSet myDS = new DataSet();  //实例化结果数据集
			int n = myDA.Fill(myDS, "use");  //将结果放入数据适配器 ， 返回元素个数
			if (n != 0)
			{
				//MessageBox.Show("欢迎使用!");  //登录成功

				UserSession.LoggedInUser = username;  //设置当前登录用户

				UserMain main = new UserMain();
				main.Show();
				this.Visible = false;
				//            Main main = new Main();
				//main.Show();
				//this.Visible = false;
			}
			else
			{
				if (errorTime > 0)
				{
					MessageBox.Show("用户名或密码错误, 请重新输入");
					txtName.Text = ""; //清空输入框
					txtPwd.Text = "";
					txtName.Focus();  //输入光标的位置
				}
				else
				{
					MessageBox.Show("输入错误已达三次，系统将自动退出");
					this.Close();
				}
			}
			mycon.Close();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
