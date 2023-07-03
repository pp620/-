using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace 用户登录
{



    public partial class 登录页面 : Form
    {

        int sg;
        public 登录页面()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        static class CreateSqlConn
        {
            public static string ConnectionString = "Data Source=.;Initial Catalog= 学生成绩管理;Integrated Security=SSPI";
            //连接数据库字段，作为非系统管理员
            public static SqlConnection con = new SqlConnection(ConnectionString);  //创建一个连接对象
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 主窗口_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void m_password_MouseClick(object sender, MouseEventArgs e)
        {
            password.Text = "";
        }

        private void m_name_MouseClick(object sender, MouseEventArgs e)
        {
            username.Text = "";
            if (username.Text.Trim() == "")
                password.Text = "";
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            choose_notice.Text = "";
            username_notice.Text = "";

            switch (sg)
            {

                case 1:
                    if (username.Text.Trim() == "")   //m_name可能是文本框
                        username_notice.Text = "请输入学号！";
                    else
                    {
                        CreateSqlConn.con.Open();
                        SqlCommand myCom = new SqlCommand("select scode from student where sno ='" + username.Text.Trim() + "'", CreateSqlConn.con);
                        if (password.Text.Trim() == "")
                            psw_notice.Text = "请输入密码！";
                        else if (null != myCom.ExecuteScalar() && password.Text.Trim() == myCom.ExecuteScalar().ToString())
                        {
                            //CreateSqlConn.con.Close();
                            //学生窗口 stu = new 学生窗口(username.Text.Trim());
                            //stu.Show();
                            //this.Hide();
                        }
                        else
                        {
                            psw_notice.Text = "请输入正确密码！";
                            CreateSqlConn.con.Close();
                        }
                    }
                    break;

                case 2:
                    if (username.Text.Trim() == "")
                        username_notice.Text = "请输入教工号";
                    else
                    {
                        CreateSqlConn.con.Open();
                        SqlCommand myCom = new SqlCommand("select TCode from Teacher where Tno ='" + username.Text.Trim() + "'", CreateSqlConn.con);
                        if (password.Text.Trim() == "")
                            psw_notice.Text = "请输入密码！";
                        else if (null != myCom.ExecuteScalar() && password.Text.Trim() == myCom.ExecuteScalar().ToString())
                        {
                            //CreateSqlConn.con.Close();
                            //老师窗口 tea = new 老师窗口(username.Text.Trim());
                            //tea.Show();
                            ////this.Hide();
                        }
                        else
                        {
                            psw_notice.Text = "请输入正确密码";
                            CreateSqlConn.con.Close();
                        }
                    }
                    break;
                case 3:
                    if (username.Text.Trim() == "")
                        username_notice.Text = "请输入管理员账号";
                    //else if (name.Text.Trim() != "admin")
                    //label4.Text = "请输入正确的管理员账号！";
                    else
                    {
                        CreateSqlConn.con.Open();
                        SqlCommand myCom = new SqlCommand("select acode from adminn ", CreateSqlConn.con);
                        if (password.Text.Trim() == "")
                            psw_notice.Text = "请输入密码！";
                        else if (null != myCom.ExecuteScalar() && password.Text.Trim() == myCom.ExecuteScalar().ToString())
                        {
                            //CreateSqlConn.con.Close();
                            //管理员界面 tea = new 管理员界面();
                            //tea.Show();
                            ////this.Hide();
                        }
                        else
                        {
                            psw_notice.Text = "请输入正确密码！";
                            CreateSqlConn.con.Close();
                        }

                    }
                    break;
                default:
                    choose_notice.Text = "请选择登录类型！";
                    break;




            }
        }

        private void m_name_Click(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void m_name_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (username.Text.Trim() == "admin")
            //{
            //    password.Text = "123456";
            //}
            //if (username.Text.Trim() == "6930")
            //{
            //    password.Text = "123456";
            //}

            //if (username.Text.Trim() == "22920192204013")
            //{
            //    password.Text = "123456";
            //}
            //if (username.Text.Trim() == "22920192204014")
            //{
            //    password.Text = "123456";
            //}


        }
        private void student_CheckedChanged_1(object sender, EventArgs e)
        {
            sg = 1;
        }
        private void teacher_CheckedChanged_1(object sender, EventArgs e)
        {
            sg = 2;
        }
     

        private void admin_CheckedChanged(object sender, EventArgs e)
        {
            sg = 3;
        }

        private void m_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
