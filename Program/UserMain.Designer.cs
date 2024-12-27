namespace Login
{
	partial class UserMain
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
			this.quit = new System.Windows.Forms.Button();
			this.hello = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.LoginOut = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// quit
			// 
			this.quit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.quit.Location = new System.Drawing.Point(1217, 720);
			this.quit.Name = "quit";
			this.quit.Size = new System.Drawing.Size(101, 53);
			this.quit.TabIndex = 1;
			this.quit.Text = "退出";
			this.quit.UseVisualStyleBackColor = true;
			this.quit.Click += new System.EventHandler(this.quit_Click_2);
			// 
			// hello
			// 
			this.hello.ForeColor = System.Drawing.Color.Black;
			this.hello.Location = new System.Drawing.Point(12, 12);
			this.hello.Name = "hello";
			this.hello.Size = new System.Drawing.Size(228, 28);
			this.hello.TabIndex = 0;
			this.hello.Text = "欢迎：";
			this.hello.TextChanged += new System.EventHandler(this.hello_TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(1, 46);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 30;
			this.dataGridView1.Size = new System.Drawing.Size(1317, 668);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// LoginOut
			// 
			this.LoginOut.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LoginOut.Location = new System.Drawing.Point(1095, 720);
			this.LoginOut.Name = "LoginOut";
			this.LoginOut.Size = new System.Drawing.Size(96, 53);
			this.LoginOut.TabIndex = 3;
			this.LoginOut.Text = "注销";
			this.LoginOut.UseVisualStyleBackColor = true;
			this.LoginOut.Click += new System.EventHandler(this.LoginOut_Click);
			// 
			// UserMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1330, 785);
			this.Controls.Add(this.LoginOut);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.quit);
			this.Controls.Add(this.hello);
			this.Name = "UserMain";
			this.Text = "UserMain";
			this.Load += new System.EventHandler(this.UserMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button quit;
		private System.Windows.Forms.TextBox hello;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button LoginOut;
	}
}