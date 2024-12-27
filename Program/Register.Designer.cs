namespace Login
{
    partial class Register
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
			this.label1 = new System.Windows.Forms.Label();
			this.Username = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.RePassword = new System.Windows.Forms.TextBox();
			this.RegBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.studentId = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(92, 35);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(2);
			this.label1.Size = new System.Drawing.Size(79, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名:";
			// 
			// Username
			// 
			this.Username.Location = new System.Drawing.Point(186, 35);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(116, 28);
			this.Username.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(106, 163);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(2);
			this.label2.Size = new System.Drawing.Size(69, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "密码：";
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(186, 157);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(116, 28);
			this.Password.TabIndex = 3;
			this.Password.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(87, 213);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(2);
			this.label3.Size = new System.Drawing.Size(98, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "确认密码:";
			// 
			// RePassword
			// 
			this.RePassword.Location = new System.Drawing.Point(186, 207);
			this.RePassword.Name = "RePassword";
			this.RePassword.Size = new System.Drawing.Size(116, 28);
			this.RePassword.TabIndex = 5;
			this.RePassword.UseSystemPasswordChar = true;
			// 
			// RegBtn
			// 
			this.RegBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RegBtn.Location = new System.Drawing.Point(109, 269);
			this.RegBtn.Name = "RegBtn";
			this.RegBtn.Size = new System.Drawing.Size(91, 41);
			this.RegBtn.TabIndex = 6;
			this.RegBtn.Text = "注册";
			this.RegBtn.UseVisualStyleBackColor = true;
			this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CancelBtn.Location = new System.Drawing.Point(259, 269);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(103, 41);
			this.CancelBtn.TabIndex = 7;
			this.CancelBtn.Text = "取消";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(106, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "学号：";
			// 
			// studentId
			// 
			this.studentId.Location = new System.Drawing.Point(186, 82);
			this.studentId.Name = "studentId";
			this.studentId.Size = new System.Drawing.Size(116, 28);
			this.studentId.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(106, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "姓名：";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// nName
			// 
			this.nName.Location = new System.Drawing.Point(186, 116);
			this.nName.Name = "nName";
			this.nName.Size = new System.Drawing.Size(116, 28);
			this.nName.TabIndex = 11;
			// 
			// Register
			// 
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(441, 366);
			this.Controls.Add(this.nName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.studentId);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.RegBtn);
			this.Controls.Add(this.RePassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.MenuText;
			this.Name = "Register";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "注册";
			this.Load += new System.EventHandler(this.Register_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RePassword;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox studentId;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox nName;
	}
}