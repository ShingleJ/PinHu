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
using System.IO;
using System.Windows;

namespace PIN
{
    class ModifyPasswordClass
    {

        string connectionString = Parameters.user_info;
        //验证旧密码
        public int CheckOldPassword(String OldPassword)
        {
            int check = 0;
            string commandText = @"Select Password from Student Where Name = '" + Parameters.username + "';";
            DTConnection con = new DTConnection();
            List<String[]> record = con.ReadCon(connectionString, commandText);
            if (record.Count >0)//查询到结果
            {
                int num=record.Count;
                while (num>0)
                {
                    String OldPass = record[num][1].ToString();
                    if (OldPassword == OldPass)
                    {
                        check = 1;
                    }
                    num--;
                }
            }
            return check;
        }
 
        //修改密码
        public int ModifyPassword(String NewPassword)
        {

            string commandTextUpdate = @"update Student set Password = '" + NewPassword + "' Where Name = '" + Parameters.username + "';";
            DTConnection con = new DTConnection();
            int num = con.UpdateCon(connectionString, commandTextUpdate);
            return num;
        }
    }
}
