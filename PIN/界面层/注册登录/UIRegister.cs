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
using Microsoft.VisualBasic;

namespace PIN
{
    public partial class UIRegister : Form
    {
        public UIRegister()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)//返回首页
        {
            this.Hide();
            UILogin hp = new UILogin();
            hp.Show();
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_DropDown(object sender, EventArgs e)//改变下拉菜单的颜色
        {
            comboBox1.ForeColor = Color.Black;
            comboBox1.Items.Add("学生");
            comboBox1.Items.Add("商家");
            comboBox1.Items.Add("管理员");
        }
        private void CompleteLogin_Click(object sender, EventArgs e)
        {
            if (tboxPw.Text.Length<6)
            {
                MessageBox.Show("密码应至少有6位");
            }
            else if (tboxPw.Text != tboxPw2.Text)
            {
                while (tboxPw.Text != tboxPw2.Text)
                {
                    MessageBox.Show("两次输入密码不同，请修正！");
                    tboxPw.Text = null;
                    tboxPw2.Text = null;
                };
            }
            else if (tboxPw.Text == tboxPw2.Text)
            {
                RegisterClass lc = new RegisterClass();
                lc.Insert(tboxUsername.Text, tboxPw2.Text, comboBox1.SelectedIndex);
                this.Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //用户名重复
            String inputname = tboxUsername.Text;//查询关键字
            String SeleAllstr = null;//选择用户名为输入项的所有值
            string SelePwStr = null;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Parameters.usertype = 0;
                        SeleAllstr = "select * from StudentInfo where StudentInfo_NickName = '" + inputname + "';";
                        SelePwStr = "select StudentInfo_Password from StudentInfo where StudentInfo_NickName = '" + inputname + "';";
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

            //提示，清空用户名

            //验证用户是否存在
            if (result.Count != 0)
            {
                MessageBox.Show("用户已存在!");
                tboxUsername.Text = null;
                tboxPw.Text = null;
            }
        }
    }
}
