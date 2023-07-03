namespace 用户登录
{
    partial class 登录页面
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
            this.button1 = new System.Windows.Forms.Button();
            this.username_notice = new System.Windows.Forms.Label();
            this.psw_notice = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.ComboBox();
            this.student = new System.Windows.Forms.RadioButton();
            this.teacher = new System.Windows.Forms.RadioButton();
            this.te = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.choose_notice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(152, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // username_notice
            // 
            this.username_notice.AutoSize = true;
            this.username_notice.Location = new System.Drawing.Point(179, 54);
            this.username_notice.Name = "username_notice";
            this.username_notice.Size = new System.Drawing.Size(0, 15);
            this.username_notice.TabIndex = 4;
            // 
            // psw_notice
            // 
            this.psw_notice.AutoSize = true;
            this.psw_notice.Location = new System.Drawing.Point(177, 114);
            this.psw_notice.Name = "psw_notice";
            this.psw_notice.Size = new System.Drawing.Size(0, 15);
            this.psw_notice.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(177, 131);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(183, 25);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.m_password_TextChanged);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.FormattingEnabled = true;
            this.username.ItemHeight = 18;
            this.username.Items.AddRange(new object[] {
            "admin",
            "6930",
            "22920192204013",
            "22920192204014"});
            this.username.Location = new System.Drawing.Point(177, 74);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(183, 26);
            this.username.TabIndex = 7;
            this.username.SelectedIndexChanged += new System.EventHandler(this.m_name_SelectedIndexChanged_1);
            this.username.Click += new System.EventHandler(this.m_name_Click);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.BackColor = System.Drawing.Color.Transparent;
            this.student.Location = new System.Drawing.Point(85, 212);
            this.student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(58, 19);
            this.student.TabIndex = 10;
            this.student.TabStop = true;
            this.student.Text = "学生";
            this.student.UseVisualStyleBackColor = false;
            this.student.CheckedChanged += new System.EventHandler(this.student_CheckedChanged_1);
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.BackColor = System.Drawing.Color.Transparent;
            this.teacher.Location = new System.Drawing.Point(287, 212);
            this.teacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(73, 19);
            this.teacher.TabIndex = 11;
            this.teacher.TabStop = true;
            this.teacher.Text = "管理员";
            this.teacher.UseVisualStyleBackColor = false;
            this.teacher.CheckedChanged += new System.EventHandler(this.admin_CheckedChanged);
            // 
            // te
            // 
            this.te.AutoSize = true;
            this.te.BackColor = System.Drawing.Color.Transparent;
            this.te.Location = new System.Drawing.Point(190, 212);
            this.te.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.te.Name = "te";
            this.te.Size = new System.Drawing.Size(58, 19);
            this.te.TabIndex = 12;
            this.te.TabStop = true;
            this.te.Text = "老师";
            this.te.UseVisualStyleBackColor = false;
            this.te.CheckedChanged += new System.EventHandler(this.teacher_CheckedChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 25);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "用户名";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 131);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 25);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "密码";
            // 
            // choose_notice
            // 
            this.choose_notice.AutoSize = true;
            this.choose_notice.Location = new System.Drawing.Point(85, 192);
            this.choose_notice.Name = "choose_notice";
            this.choose_notice.Size = new System.Drawing.Size(0, 15);
            this.choose_notice.TabIndex = 15;
            // 
            // 登录页面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 361);
            this.Controls.Add(this.choose_notice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.te);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.student);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.psw_notice);
            this.Controls.Add(this.username_notice);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "登录页面";
            this.Text = "登录页面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.主窗口_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label username_notice;
        private System.Windows.Forms.Label psw_notice;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox username;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.RadioButton teacher;
        private System.Windows.Forms.RadioButton te;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label choose_notice;
    }
}

