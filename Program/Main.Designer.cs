namespace Login
{
    partial class Main
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
			this.manager_button = new System.Windows.Forms.Button();
			this.search_button = new System.Windows.Forms.Button();
			this.Header = new System.Windows.Forms.Label();
			this.quit = new System.Windows.Forms.Button();
			this.logout = new System.Windows.Forms.Button();
			this.fenxi_button = new System.Windows.Forms.Button();
			this.tongji_button = new System.Windows.Forms.Button();
			this.hello = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// manager_button
			// 
			this.manager_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.manager_button.Location = new System.Drawing.Point(118, 176);
			this.manager_button.Margin = new System.Windows.Forms.Padding(4);
			this.manager_button.Name = "manager_button";
			this.manager_button.Size = new System.Drawing.Size(286, 87);
			this.manager_button.TabIndex = 0;
			this.manager_button.Text = "成绩录入";
			this.manager_button.UseVisualStyleBackColor = true;
			this.manager_button.Click += new System.EventHandler(this.manager_button_Click);
			// 
			// search_button
			// 
			this.search_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.search_button.Location = new System.Drawing.Point(118, 299);
			this.search_button.Margin = new System.Windows.Forms.Padding(4);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(286, 88);
			this.search_button.TabIndex = 1;
			this.search_button.Text = "成绩查询";
			this.search_button.UseVisualStyleBackColor = true;
			this.search_button.Click += new System.EventHandler(this.search_button_Click);
			// 
			// Header
			// 
			this.Header.AutoSize = true;
			this.Header.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Header.Location = new System.Drawing.Point(245, 110);
			this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(365, 39);
			this.Header.TabIndex = 2;
			this.Header.Text = "学生信息（成绩）管理系统";
			this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Header.Click += new System.EventHandler(this.Header_Click);
			// 
			// quit
			// 
			this.quit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.quit.Location = new System.Drawing.Point(453, 445);
			this.quit.Margin = new System.Windows.Forms.Padding(4);
			this.quit.Name = "quit";
			this.quit.Size = new System.Drawing.Size(106, 50);
			this.quit.TabIndex = 3;
			this.quit.Text = "退出";
			this.quit.UseVisualStyleBackColor = true;
			this.quit.Click += new System.EventHandler(this.quit_Click);
			// 
			// logout
			// 
			this.logout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.logout.Location = new System.Drawing.Point(298, 445);
			this.logout.Margin = new System.Windows.Forms.Padding(4);
			this.logout.Name = "logout";
			this.logout.Size = new System.Drawing.Size(106, 50);
			this.logout.TabIndex = 4;
			this.logout.Text = "注销";
			this.logout.UseVisualStyleBackColor = true;
			this.logout.Click += new System.EventHandler(this.logout_Click);
			// 
			// fenxi_button
			// 
			this.fenxi_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.fenxi_button.Location = new System.Drawing.Point(453, 176);
			this.fenxi_button.Margin = new System.Windows.Forms.Padding(4);
			this.fenxi_button.Name = "fenxi_button";
			this.fenxi_button.Size = new System.Drawing.Size(286, 87);
			this.fenxi_button.TabIndex = 5;
			this.fenxi_button.Text = "成绩分析";
			this.fenxi_button.UseVisualStyleBackColor = true;
			this.fenxi_button.Click += new System.EventHandler(this.fenxi_button_Click);
			// 
			// tongji_button
			// 
			this.tongji_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tongji_button.Location = new System.Drawing.Point(453, 299);
			this.tongji_button.Margin = new System.Windows.Forms.Padding(4);
			this.tongji_button.Name = "tongji_button";
			this.tongji_button.Size = new System.Drawing.Size(286, 87);
			this.tongji_button.TabIndex = 6;
			this.tongji_button.Text = "选课统计";
			this.tongji_button.UseVisualStyleBackColor = true;
			this.tongji_button.Click += new System.EventHandler(this.tongji_button_Click);
			// 
			// hello
			// 
			this.hello.BackColor = System.Drawing.Color.LightSkyBlue;
			this.hello.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hello.Location = new System.Drawing.Point(12, 12);
			this.hello.Name = "hello";
			this.hello.Size = new System.Drawing.Size(304, 21);
			this.hello.TabIndex = 7;
			this.hello.Text = "欢迎";
			this.hello.TextChanged += new System.EventHandler(this.hello_TextChanged);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(893, 595);
			this.Controls.Add(this.hello);
			this.Controls.Add(this.tongji_button);
			this.Controls.Add(this.fenxi_button);
			this.Controls.Add(this.logout);
			this.Controls.Add(this.quit);
			this.Controls.Add(this.Header);
			this.Controls.Add(this.search_button);
			this.Controls.Add(this.manager_button);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "选修课成绩管理";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_close);
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manager_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button fenxi_button;
        private System.Windows.Forms.Button tongji_button;
		private System.Windows.Forms.TextBox hello;
	}
}