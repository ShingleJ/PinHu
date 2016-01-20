using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PIN
{
    public partial class UILogin : Form//登录窗口
    {
        #region 初始化
        public UILogin()
        {
            InitializeComponent();
        }
        /*********/
        String SelePwStr = null;//从用户表中选择密码的语句
        /**************/
        private void login_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.ForeColor = Color.Black;
            //this.Hide();
        }

        #endregion

        #region 按钮： 退出，登陆
        //点击退出按钮,退出整个系统
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
            { 
                Application.Exit(); 
            } 
        }

        //点击登录按钮,非游客-验证用户是否存在，存在至主页，不存在提示；游客直接进入发现
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {//游客直接进入发现
                Parameters.haslogined = false;
                if (!Parameters.explorestate)
                {
                    this.Hide();
                    Parameters.explore.Show();
                    Parameters.explorestate = true;
                }

            }
            else if (comboBox1.SelectedIndex == 1) 
            { 
                MessageBox.Show("商家用户入口暂未开放，尽请期待！"); 
            } 
            else
            {
                Parameters.usertype = this.comboBox1.SelectedIndex;
                Parameters.username = this.TxtBxNme.Text;
                LoginClass lc = new LoginClass();
                bool Haveuser = lc.Login(SelePwStr, TxtBxPW.Text, TxtBxNme.Text);
                if (!Parameters.homepagestate && Haveuser)
                {
                    this.Hide();
                    if (Parameters.usertype == 0)//学生
                    {
                        Parameters.homepage.Show();
                        Parameters.homepagestate = true;
                        Parameters.haslogined = true;
                        Parameters.homepage.InitializeForm();
                    }
                    else if (Parameters.usertype == 2)//管理员
                    {
                        Parameters.admin.Show();
                        Parameters.adminstate = true;
                        Parameters.haslogined = true;
                    }

                }

            }            
        }

        #endregion

        #region linklabel:  注册、忘记密码
        //注册账号
        private void llblregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UIRegister l = new UIRegister();
            l.Show();
        }
        #endregion

        #region textbox:   查看用户是否存在
        //已知用户名和用户类别，从各类用户表中选择密码
        private void TxtBxPW_Click(object sender, EventArgs e)
        {
            
            String inputname = TxtBxNme.Text;//查询关键字
            String SeleAllstr = null;//选择用户名为输入项的所有值
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Parameters.usertype = 0;
                        SeleAllstr = "select * from StudentInfo where StudentInfo_NickName = '" + inputname + "';";
                        SelePwStr="select StudentInfo_Password from StudentInfo where StudentInfo_NickName = '" + inputname + "';";
                        break;
                    }
                case 1:
                    {
                        Parameters.usertype = 1;
                        SeleAllstr = "select * from  MerchantInfo where Merchant_Name = '" + inputname + "';";
                        SelePwStr = "select Merchant_Password from MerchantInfo where Merchant_Name = '" + inputname + "';";
                        break;
                    }
                case 2:
                    {
                        Parameters.usertype = 2;
                        SeleAllstr = "select * from AdminInfo where AdminInfo_NickName = '" + inputname + "';";
                        SelePwStr = "select AdminInfo_Password from AdminInfo where AdminInfo_NickName = '" + inputname + "';";
                        break;
                    }
            }
            String connectionString = Parameters.user_info;
            DTConnection con = new DTConnection();
            List<String[]> result = con.ReadCon(SeleAllstr, connectionString);
            //验证用户是否存在
            if (result.Count==0)
            {
                MessageBox.Show("用户不存在,请先注册!");
            }
        }

        #endregion

        #region  checkBox： 密码是否明文显示，游客登录不可用用户名和密码
        //密码是否明文显示
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.TxtBxPW.PasswordChar = '\0';
            }
            else
            {
                this.TxtBxPW.PasswordChar = '*';
            }
        }

        //游客登录时，无需填写用户名密码
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                this.TxtBxNme.Enabled = false;
                this.TxtBxPW.Enabled = false;
            }
            else
            {
                this.TxtBxNme.Enabled = true;
                this.TxtBxPW.Enabled = true;
            }
        }

        #endregion

 

       
        
    }
}
