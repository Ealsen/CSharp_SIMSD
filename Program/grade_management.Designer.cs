namespace Login
{
    partial class grade_management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.student_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.comboBox1.Items.AddRange(new object[] {
            "英语视听说",
            "英语协作",
            "书法鉴赏",
            "市场营销导论",
            "知识产权保护",
            "计算机导论",
            "数据结构",
            "人工智能导论",
            "云计算基础",
            "大数据分析",
            "机器学习",
            "网络安全",
            "计算机视觉",
            "深度学习",
            "嵌入式系统",
            "数据库管理系统",
            "算法设计与分析",
            "软件工程导论",
            "操作系统原理"});
			this.comboBox1.Location = new System.Drawing.Point(146, 10);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 26);
			this.comboBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(18, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(104, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "请选择课程";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.student_name,
            this.student_class,
            this.score});
			this.dataGridView1.Location = new System.Drawing.Point(18, 50);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(765, 436);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
			// 
			// 学号
			// 
			this.学号.HeaderText = "学号";
			this.学号.MinimumWidth = 8;
			this.学号.Name = "学号";
			this.学号.Width = 110;
			// 
			// student_name
			// 
			this.student_name.HeaderText = "姓名";
			this.student_name.MinimumWidth = 8;
			this.student_name.Name = "student_name";
			this.student_name.Width = 110;
			// 
			// student_class
			// 
			this.student_class.HeaderText = "专业班级";
			this.student_class.MinimumWidth = 8;
			this.student_class.Name = "student_class";
			this.student_class.Width = 135;
			// 
			// score
			// 
			this.score.HeaderText = "成绩";
			this.score.MinimumWidth = 8;
			this.score.Name = "score";
			this.score.Width = 150;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(177, 495);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 40);
			this.button1.TabIndex = 3;
			this.button1.Text = "确定";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(486, 495);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 39);
			this.button2.TabIndex = 4;
			this.button2.Text = "返回";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// grade_management
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(801, 543);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "grade_management";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "成绩录入";
			this.Load += new System.EventHandler(this.grade_management_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
    }
}