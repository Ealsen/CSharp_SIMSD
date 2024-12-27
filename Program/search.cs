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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Login
{

    public partial class search : Form
    {
		// 初始化
        public search()
        {
            InitializeComponent();
        }

		//// 类级别的字段
		//private string _columnName = string.Empty;
		//private string _newValue = string.Empty;
		//private string _only_id = string.Empty;

		//序号自动递增
		private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dataGridView1.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
            dataGridView1.RowHeadersDefaultCellStyle.Font,
            rectangle,
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
            TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }


		// 查询按钮事件
        private void search_button_Click(object sender, EventArgs e)
        {
			//清空原有数据
			this.dataGridView1.Rows.Clear();



			//取出查询的条件
			string ID = this.studentId_textBox.Text.Trim();
            string CLASS = this.studentClass_textBox.Text.Trim();

			//MessageBox.Show(ID + " " + CLASS);

			//连接数据库
			//string constr = "DataBase = simsdbb; Data Source = 127.0.0.1;Port = 3306;User Id=root;Password=123456;pooling=false;CharSet=utf8;";

			//string constr = "DataBase = test; Data Source = 127.0.0.1;Port = 3307;User Id=root;Password=jlp1996;pooling=false;CharSet=utf8;";

			MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = DbConfig.ConnectionString;
            mycon.Open();

			//MessageBox.Show("mycon");

			MySqlCommand cmd = new MySqlCommand();
            //string s = "select student_name,subject_id,subject_name,score,only_id from score where student_id='" + ID+"'or student_class='"+CLASS+"'";
            string s = "select student_name,subject_id,subject_name,score,student_id,only_id from score where student_id='" + ID + "' or student_class='" + CLASS + "'";
			//MessageBox.Show("s");


            //如果ID和CLASS都为空，则查询所有数据
			if (ID =="" && CLASS == "")
            {
				s = "select student_name,subject_id,subject_name,score,student_id,only_id from score ";
			}
            cmd.CommandText = s;
            cmd.Connection = mycon;
            MySqlDataReader rec = cmd.ExecuteReader();


			//数据存储容器初始化
			GetInfoList.student_name.Clear();
            GetInfoList.subject_id.Clear();
            GetInfoList.subject_name.Clear();
            GetInfoList.student_score.Clear();
			GetInfoList.student_id.Clear();
			GetInfoList.only_id.Clear();

			//MessageBox.Show("rec");

			// erro

			int a = 0;  //计算成绩信息条数
            while (rec.Read())
            {
                GetInfoList.student_name.Add(rec.GetString(0)); //将学生姓名存储到容器
                GetInfoList.subject_id.Add(rec.GetString(1));  //将课程编号存储到容器
                GetInfoList.subject_name.Add(rec.GetString(2));  //将课程名称存储到容器
                GetInfoList.student_score.Add(rec.GetString(3));  //将成绩信息存储到容器
				GetInfoList.student_id.Add(rec.GetString(4));  //将学生id存储到容器
				GetInfoList.only_id.Add(rec.GetString(5));  


				a++;
            }
			//MessageBox.Show("rec1");

			for (int i = 0; i < GetInfoList.student_name.Count; i++)
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = GetInfoList.student_name[i];
                this.dataGridView1.Rows[index].Cells[1].Value = GetInfoList.subject_id[i];
                this.dataGridView1.Rows[index].Cells[2].Value = GetInfoList.subject_name[i];
                this.dataGridView1.Rows[index].Cells[3].Value = GetInfoList.student_score[i];
				this.dataGridView1.Rows[index].Cells[4].Value = GetInfoList.student_id[i];
				this.dataGridView1.Rows[index].Cells[5].Value = GetInfoList.only_id[i];


			}

			MessageBox.Show("查询到"+a+"条数据 ");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		// 清空按钮事件
        private void clear_button_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.studentId_textBox.Text = "";
            this.studentClass_textBox.Text = "";
            this.studentId_textBox.Focus();
			this.Updata_Boxtext.Text = "";
        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		// 加载搜索窗口该执行的操作
		private void search_Load(object sender, EventArgs e)
		{

		}


		// 删除按钮事件
		private void del_Click(object sender, EventArgs e)
		{
			// 判断单元格状态 如果选中了行 则根据only_id删除该行数据
			if (dataGridView1.CurrentRow != null)
			{
				int rowIndex = dataGridView1.CurrentRow.Index;
				// 获取当前行的 only_id
				string only_id = dataGridView1.CurrentRow.Cells["only_id"].Value.ToString();
				// 动态构建 SQL 语句
				using (MySqlConnection mycon = new MySqlConnection(DbConfig.ConnectionString))
				{
					try
					{
						mycon.Open();
						string sql = "DELETE FROM score WHERE only_id = @only_id";
						using (MySqlCommand cmd = new MySqlCommand(sql, mycon))
						{
							cmd.Parameters.AddWithValue("@only_id", only_id);
							int rowsAffected = cmd.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								MessageBox.Show($"成功删除 {rowsAffected} 条记录。");
								// 移除 DataGridView 中对应的行
								dataGridView1.Rows.RemoveAt(rowIndex);
							}
							else
							{
								MessageBox.Show("未找到要删除的记录。");
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"错误: {ex.Message}");
					}
				}
			}
			else
			{
				MessageBox.Show("未选择任何行。");
			}
		}


		private void Updata_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{

				// 获取当前单元格所在行的索引
				int rowIndex = dataGridView1.CurrentRow.Index;
				// 获取当前单元格所在列的索引
				int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
				//MessageBox.Show(rowIndex.ToString() + " " + columnIndex.ToString());

				string UpdataStr = Updata_Boxtext.Text;

				//MessageBox.Show(UpdataStr);	

				// 获取当前单元格所在行的唯一标识符
				string only_id = dataGridView1.CurrentRow.Cells["only_id"].Value.ToString();
				// 获取当前单元格所在列的列名
				string columnName = dataGridView1.Columns[columnIndex].Name;

				// 这里可以做一些安全检查，确保列名和值是有效的

				// 动态构建 SQL 语句
				string sql = $"UPDATE score SET {columnName} = @UpdataStr WHERE only_id = @only_id";

				using (MySqlConnection mycon = new MySqlConnection(DbConfig.ConnectionString))
				{
					try
					{
						mycon.Open();
						using (MySqlCommand cmd = new MySqlCommand(sql, mycon))
						{
							// 绑定参数
							cmd.Parameters.AddWithValue("@UpdataStr", UpdataStr);
							cmd.Parameters.AddWithValue("@only_id", only_id);

							// 执行更新操作
							int rowsAffected = cmd.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								MessageBox.Show($"成功更新 {rowsAffected} 条记录。");

								Updata_Boxtext.Text = ""; // 清空输入框内容

								// 在 DataGridView 中更新数据（这里会更合适地更新单元格，而不是移除行）
								dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = UpdataStr;
							}
							else
							{
								MessageBox.Show("未找到要更新的记录。");
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"错误: {ex.Message}");
					}
				}
			}
			else
			{
				MessageBox.Show("未选择任何行。");
			}
		}




		private void studentId_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void studentClass_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}

	
}
