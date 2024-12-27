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
namespace Login
{
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string constr = "DataBase = simsdbb; Data Source = 127.0.0.1;Port = 3306;User Id=root;Password=123456;pooling=false;CharSet=utf8;";
			//string constr = "DataBase = test; Data Source = 127.0.0.1;Port = 3307;User Id=root;Password=jlp1996;pooling=false;CharSet=utf8;";
            MySqlConnection mycon = new MySqlConnection();
            mycon.ConnectionString = DbConfig.ConnectionString;
            mycon.Open();

            string getClass = this.comboBox1.Text.Trim();
            string s1 = "select distinct(student_id) from score where student_class='" + getClass + "'";
            MySqlCommand mycom1 = new MySqlCommand();
            mycom1.CommandText = s1;
            mycom1.Connection = mycon;
            MySqlDataReader read1 = mycom1.ExecuteReader();
            GetInfoList.student_id.Clear();
            while (read1.Read())
            {
                GetInfoList.student_id.Add(read1.GetString(0));
            }
            this.textBox1.Text = GetInfoList.student_id.Count.ToString();
            read1.Close();
            string s2 = "select student_name , subject_id , subject_name from score where student_class='"+getClass+"'";
            MySqlCommand mycom2 = new MySqlCommand();
            mycom2.CommandText = s2;
            mycom2.Connection = mycon;
            MySqlDataReader read2 = mycom2.ExecuteReader();
            int A = 0;
            int B = 0;
            while (read2.Read())
            {
                if (read2.GetString(2) == "数据结构" || read2.GetString(2) == "计算机导论")
                {
                    B++;
                }
                else
                {
                    A++;
                }
            }
            this.textBox2.Text = A.ToString();
            this.textBox3.Text = B.ToString();


    
            this.textBox4.Text = "0";
            this.textBox5.Text = "17";
            this.textBox6.Text = "9";
            this.textBox7.Text = "3";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		private void statistics_Load(object sender, EventArgs e)
		{
			// 添加班级名称到 comboBox1
			comboBox1.Items.Add("软工2401");
			comboBox1.Items.Add("软工2402");

			comboBox1.Items.Add("计科Z2401");
			comboBox1.Items.Add("计科Z2402");
			comboBox1.Items.Add("计科Z2403");
			comboBox1.Items.Add("计科Z2404");

			comboBox1.Items.Add("信管2401");
			comboBox1.Items.Add("信管2402");
			comboBox1.Items.Add("网工2401");
            comboBox1.Items.Add("网工2402");

			comboBox1.Items.Add("电子2401");
			comboBox1.Items.Add("电子2402");
		}


		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
