namespace Login
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.registerBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.UserLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(173, 215);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(173, 340);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "密 码：";
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Location = new System.Drawing.Point(308, 215);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(230, 28);
			this.txtName.TabIndex = 2;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(308, 340);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(230, 28);
			this.txtPwd.TabIndex = 3;
			this.txtPwd.UseSystemPasswordChar = true;
			// 
			// loginBtn
			// 
			this.loginBtn.BackColor = System.Drawing.Color.Transparent;
			this.loginBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.loginBtn.Location = new System.Drawing.Point(358, 440);
			this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(125, 58);
			this.loginBtn.TabIndex = 4;
			this.loginBtn.Text = "管理员登录";
			this.loginBtn.UseVisualStyleBackColor = false;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
			this.cancelBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cancelBtn.Location = new System.Drawing.Point(534, 440);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(125, 58);
			this.cancelBtn.TabIndex = 5;
			this.cancelBtn.Text = "退 出";
			this.cancelBtn.UseVisualStyleBackColor = false;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// registerBtn
			// 
			this.registerBtn.BackColor = System.Drawing.Color.Transparent;
			this.registerBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.registerBtn.Location = new System.Drawing.Point(556, 208);
			this.registerBtn.Margin = new System.Windows.Forms.Padding(4);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(103, 36);
			this.registerBtn.TabIndex = 6;
			this.registerBtn.Text = "用户注册";
			this.registerBtn.UseVisualStyleBackColor = false;
			this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 22F);
			this.label3.Location = new System.Drawing.Point(139, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(547, 44);
			this.label3.TabIndex = 7;
			this.label3.Text = "学生信息（成绩）管理系统";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// UserLogin
			// 
			this.UserLogin.BackColor = System.Drawing.Color.Transparent;
			this.UserLogin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.UserLogin.Location = new System.Drawing.Point(205, 440);
			this.UserLogin.Name = "UserLogin";
			this.UserLogin.Size = new System.Drawing.Size(109, 58);
			this.UserLogin.TabIndex = 8;
			this.UserLogin.Text = "用户登录";
			this.UserLogin.UseVisualStyleBackColor = false;
			this.UserLogin.Click += new System.EventHandler(this.UserLogin_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(829, 590);
			this.Controls.Add(this.UserLogin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.registerBtn);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登录";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button registerBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button UserLogin;
	}
}

