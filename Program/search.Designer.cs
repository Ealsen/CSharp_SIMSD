namespace Login
{
    partial class search
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
			this.studentId_label = new System.Windows.Forms.Label();
			this.studentClass_label = new System.Windows.Forms.Label();
			this.studentId_textBox = new System.Windows.Forms.TextBox();
			this.studentClass_textBox = new System.Windows.Forms.TextBox();
			this.search_button = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.back_button = new System.Windows.Forms.Button();
			this.clear_button = new System.Windows.Forms.Button();
			this.del = new System.Windows.Forms.Button();
			this.Updata = new System.Windows.Forms.Button();
			this.Updata_Boxtext = new System.Windows.Forms.TextBox();
			this.Updata_lable = new System.Windows.Forms.Label();
			this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.only_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// studentId_label
			// 
			this.studentId_label.AutoSize = true;
			this.studentId_label.Location = new System.Drawing.Point(46, 13);
			this.studentId_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.studentId_label.Name = "studentId_label";
			this.studentId_label.Padding = new System.Windows.Forms.Padding(3);
			this.studentId_label.Size = new System.Drawing.Size(104, 24);
			this.studentId_label.TabIndex = 0;
			this.studentId_label.Text = "请输入学号";
			this.studentId_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// studentClass_label
			// 
			this.studentClass_label.AutoSize = true;
			this.studentClass_label.Location = new System.Drawing.Point(100, 51);
			this.studentClass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.studentClass_label.Name = "studentClass_label";
			this.studentClass_label.Padding = new System.Windows.Forms.Padding(3);
			this.studentClass_label.Size = new System.Drawing.Size(50, 24);
			this.studentClass_label.TabIndex = 2;
			this.studentClass_label.Text = "班级";
			this.studentClass_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// studentId_textBox
			// 
			this.studentId_textBox.Location = new System.Drawing.Point(174, 9);
			this.studentId_textBox.Margin = new System.Windows.Forms.Padding(4);
			this.studentId_textBox.Name = "studentId_textBox";
			this.studentId_textBox.Size = new System.Drawing.Size(162, 28);
			this.studentId_textBox.TabIndex = 4;
			this.studentId_textBox.TextChanged += new System.EventHandler(this.studentId_textBox_TextChanged);
			// 
			// studentClass_textBox
			// 
			this.studentClass_textBox.Location = new System.Drawing.Point(174, 45);
			this.studentClass_textBox.Margin = new System.Windows.Forms.Padding(4);
			this.studentClass_textBox.Name = "studentClass_textBox";
			this.studentClass_textBox.Size = new System.Drawing.Size(162, 28);
			this.studentClass_textBox.TabIndex = 6;
			this.studentClass_textBox.TextChanged += new System.EventHandler(this.studentClass_textBox_TextChanged);
			// 
			// search_button
			// 
			this.search_button.Location = new System.Drawing.Point(357, 13);
			this.search_button.Margin = new System.Windows.Forms.Padding(4);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(115, 95);
			this.search_button.TabIndex = 7;
			this.search_button.Text = "成绩查询";
			this.search_button.UseVisualStyleBackColor = true;
			this.search_button.Click += new System.EventHandler(this.search_button_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_name,
            this.subject_id,
            this.subject_name,
            this.score,
            this.student_id,
            this.only_id});
			this.dataGridView1.Location = new System.Drawing.Point(18, 116);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(976, 690);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
			// 
			// back_button
			// 
			this.back_button.Location = new System.Drawing.Point(632, 70);
			this.back_button.Margin = new System.Windows.Forms.Padding(4);
			this.back_button.Name = "back_button";
			this.back_button.Size = new System.Drawing.Size(93, 38);
			this.back_button.TabIndex = 9;
			this.back_button.Text = "返回";
			this.back_button.UseVisualStyleBackColor = true;
			this.back_button.Click += new System.EventHandler(this.back_button_Click);
			// 
			// clear_button
			// 
			this.clear_button.Location = new System.Drawing.Point(494, 70);
			this.clear_button.Margin = new System.Windows.Forms.Padding(4);
			this.clear_button.Name = "clear_button";
			this.clear_button.Size = new System.Drawing.Size(110, 38);
			this.clear_button.TabIndex = 10;
			this.clear_button.Text = "清除";
			this.clear_button.UseVisualStyleBackColor = true;
			this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
			// 
			// del
			// 
			this.del.Location = new System.Drawing.Point(632, 13);
			this.del.Name = "del";
			this.del.Size = new System.Drawing.Size(93, 39);
			this.del.TabIndex = 11;
			this.del.Text = "删除";
			this.del.UseVisualStyleBackColor = true;
			this.del.Click += new System.EventHandler(this.del_Click);
			// 
			// Updata
			// 
			this.Updata.Location = new System.Drawing.Point(494, 13);
			this.Updata.Name = "Updata";
			this.Updata.Size = new System.Drawing.Size(110, 37);
			this.Updata.TabIndex = 12;
			this.Updata.Text = "更新";
			this.Updata.UseVisualStyleBackColor = true;
			this.Updata.Click += new System.EventHandler(this.Updata_Click);
			// 
			// Updata_Boxtext
			// 
			this.Updata_Boxtext.Location = new System.Drawing.Point(174, 80);
			this.Updata_Boxtext.Name = "Updata_Boxtext";
			this.Updata_Boxtext.Size = new System.Drawing.Size(162, 28);
			this.Updata_Boxtext.TabIndex = 13;
			// 
			// Updata_lable
			// 
			this.Updata_lable.AutoSize = true;
			this.Updata_lable.Location = new System.Drawing.Point(88, 84);
			this.Updata_lable.Name = "Updata_lable";
			this.Updata_lable.Size = new System.Drawing.Size(62, 18);
			this.Updata_lable.TabIndex = 14;
			this.Updata_lable.Text = "更新值";
			// 
			// student_name
			// 
			this.student_name.HeaderText = "姓名";
			this.student_name.MinimumWidth = 8;
			this.student_name.Name = "student_name";
			this.student_name.Width = 150;
			// 
			// subject_id
			// 
			this.subject_id.HeaderText = "课程编号";
			this.subject_id.MinimumWidth = 8;
			this.subject_id.Name = "subject_id";
			this.subject_id.Width = 90;
			// 
			// subject_name
			// 
			this.subject_name.HeaderText = "课程名称";
			this.subject_name.MinimumWidth = 8;
			this.subject_name.Name = "subject_name";
			this.subject_name.Width = 130;
			// 
			// score
			// 
			this.score.HeaderText = "成绩";
			this.score.MinimumWidth = 8;
			this.score.Name = "score";
			this.score.Width = 90;
			// 
			// student_id
			// 
			this.student_id.HeaderText = "学号";
			this.student_id.MinimumWidth = 8;
			this.student_id.Name = "student_id";
			this.student_id.Width = 150;
			// 
			// only_id
			// 
			this.only_id.HeaderText = "标识号";
			this.only_id.MinimumWidth = 8;
			this.only_id.Name = "only_id";
			this.only_id.Width = 150;
			// 
			// search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 855);
			this.Controls.Add(this.Updata_lable);
			this.Controls.Add(this.Updata_Boxtext);
			this.Controls.Add(this.Updata);
			this.Controls.Add(this.del);
			this.Controls.Add(this.clear_button);
			this.Controls.Add(this.back_button);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.search_button);
			this.Controls.Add(this.studentClass_textBox);
			this.Controls.Add(this.studentId_textBox);
			this.Controls.Add(this.studentClass_label);
			this.Controls.Add(this.studentId_label);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "search";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "学成成绩查询";
			this.Load += new System.EventHandler(this.search_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentId_label;
        private System.Windows.Forms.Label studentClass_label;
        private System.Windows.Forms.TextBox studentId_textBox;
        private System.Windows.Forms.TextBox studentClass_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button clear_button;
		private System.Windows.Forms.Button del;
		private System.Windows.Forms.Button Updata;
		private System.Windows.Forms.TextBox Updata_Boxtext;
		private System.Windows.Forms.Label Updata_lable;
		private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn score;
		private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn only_id;
	}
}