﻿namespace Login
{
    partial class statistics
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(4);
			this.label1.Size = new System.Drawing.Size(106, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "请选择班级";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "计算机1501",
            "计算机1502",
            "计算机1503"});
			this.comboBox1.Location = new System.Drawing.Point(176, 28);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(180, 26);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(456, 24);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "选修情况统计";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(662, 24);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 34);
			this.button2.TabIndex = 3;
			this.button2.Text = "返回";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(42, 110);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(340, 352);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "整体情况";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(189, 264);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(98, 28);
			this.textBox3.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(189, 180);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(98, 28);
			this.textBox2.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(189, 99);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(98, 28);
			this.textBox1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 268);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(3);
			this.label4.Size = new System.Drawing.Size(149, 24);
			this.label4.TabIndex = 1;
			this.label4.Text = "选择B类课程人数";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 184);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(3);
			this.label3.Size = new System.Drawing.Size(149, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "选择A类课程人数";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 104);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(3);
			this.label2.Size = new System.Drawing.Size(86, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "班级人数";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(412, 110);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(382, 352);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "学分情况";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(198, 279);
			this.textBox7.Margin = new System.Windows.Forms.Padding(4);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(97, 28);
			this.textBox7.TabIndex = 7;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(198, 213);
			this.textBox6.Margin = new System.Windows.Forms.Padding(4);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(97, 28);
			this.textBox6.TabIndex = 6;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(198, 141);
			this.textBox5.Margin = new System.Windows.Forms.Padding(4);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(97, 28);
			this.textBox5.TabIndex = 5;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(198, 78);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(97, 28);
			this.textBox4.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(68, 284);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(3);
			this.label8.Size = new System.Drawing.Size(95, 24);
			this.label8.TabIndex = 3;
			this.label8.Tag = "";
			this.label8.Text = "0学分人数";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(68, 218);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 18);
			this.label7.TabIndex = 2;
			this.label7.Text = "1学分人数";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(68, 146);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(3);
			this.label6.Size = new System.Drawing.Size(95, 24);
			this.label6.TabIndex = 1;
			this.label6.Text = "2学分人数";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(68, 82);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(3);
			this.label5.Size = new System.Drawing.Size(95, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "3学分人数";
			// 
			// statistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 518);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "statistics";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "班级选项情况统计";
			this.Load += new System.EventHandler(this.statistics_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}