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
    public class RegisterClass//注册
    {
        public static List<String> corr1 = new List<string>();
        public static List<String> corr2 = new List<string>();

        public void Insert(String name, String password, int sort)
        {
            //匹配
            corr1.Add("@username");
            corr1.Add("@password");
            corr2.Add(name);
            corr2.Add(password);

            String insertText = null;
            switch (sort)
            {
                case 0:
                    {
                        insertText = "Insert Into StudentInfo(StudentInfo_NickName,StudentInfo_Password) values('" + name + "','" + password + "')";
                        break;
                    }
                case 1:
                    {
                        insertText = "Insert Into MerchantInfo(Merchant_Name,Merchant_Password) values('" + name + "','" + password + "')";
                        break;
                    }
                case 2:
                    {
                        insertText = "Insert Into AdminInfo(AdminInfo_NickName,AdminInfo_Password) values('" + name + "','" + password + "')";
                        break;
                    }
            }
            String connectionString = Parameters.user_info;
            DTConnection con = new DTConnection();

            string a = "insert into StudentInfo(StudentInfo_NickName,StudentInfo_Password) values('" + name + "','" + password  + "')";
            
            //插入信息
            int result = con.UpdateCon(insertText, connectionString);
            if (result == 1)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }

            UILogin r = new UILogin();
            r.Show();
        }
    }
}


