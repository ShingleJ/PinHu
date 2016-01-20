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
    public class LoginClass //登录-验证密码是否正确
    {
        /************************/
        //验证登录
        /// <summary>
        /// 验证是否有此用户，是-返回true，否-弹出消息
        /// </summary>
        /// <param name="QueryUserStr">语句查询</param>
        /// <param name="inputPassword">密码</param>
        /// <param name="inputUsername">用户名</param>
        /// <returns></returns>
        public bool Login(String QueryUserStr, String inputPassword, String inputUsername)
        {
            bool r = false;
            String conDBStr = Parameters.user_info;
            DTConnection con = new DTConnection();
            List<String[]> reader = con.ReadCon(QueryUserStr, conDBStr);
            //验证密码是否正确
            int num = reader.Count;
            while (num>0)
            {
                String password = reader[0][0].ToString();
                if (password == inputPassword)
                {
                    r = true;
                    break;
                }
                else if (reader.Count==0)//没有内容
                {
                    MessageBox.Show("用户类型不正确！");
                }
                else if (password != inputPassword)//密码不匹配
                {
                    MessageBox.Show("账户与密码不匹配！");
                }
                num--;
            }
            return r;
        }
    }
}
