using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PIN
{
    public partial class UITestDBCon : Form//数据库连接界面
    {
        public UITestDBCon()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获得用户名和密码后，点击连接按钮conDB后，查看能否连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conDB_Click(object sender, EventArgs e)
        {
            Parameters.dbusername = this.tboxname.Text.Trim();
            Parameters.dbpassword = this.tboxpw.Text.Trim();
            Parameters.user_info = @"Server = localhost;database = User_info;User ID = " + Parameters.dbusername + ";Password = " + Parameters.dbpassword + ";";
            Parameters.event_info = @"Server = localhost;database = Event_info;User ID = " + Parameters.dbusername + ";Password = " + Parameters.dbpassword + ";";
            Parameters.spatial_info = @"Server = localhost;database = Spatial_info;User ID = " + Parameters.dbusername + ";Password = " + Parameters.dbpassword + ";";

             
            
            //测试能否连接数据库
            DTConnection conn = new DTConnection();
            //显示登录情况
            if (conn.TestDBConn())
            {
                this.Hide();
                MessageBox.Show("数据库连接成功！");
                UILogin log = new UILogin();//打开登录界面
                log.Show();
            }
            else
            {
                MessageBox.Show("数据库连接失败！");
            }
        }

        private void TestDBCon_Load(object sender, EventArgs e)
        {

        }
    }
}
