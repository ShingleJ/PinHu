using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PIN
{
    public class SaveBasedSort
    {
        public void InsertClassDatabase(String InputContent,String InputDeadline, String Class1)
        {
            String connectionString = Parameters.user_info;
            //判断插入信息的数据库
            String commandTextInsert = null;
            switch (Class1)
            {
                case "拼车":
                    {
                        commandTextInsert = "Insert INTO PinCar (Name,Content,Time,Deadline)VALUES(@username,@nr,@fbsj,@deadline)";
                        break;
                    }
                case "购物":
                        {
                            commandTextInsert = "Insert INTO PinShopping (Name,Content,Time,Deadline)VALUES(@username,@nr,@fbsj,@deadline)";
                            break;
                        }
                default:
                    {
                        break;
                    }
            }
            //插入信息
            /************************/
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandTextInsert, connection);
                //设置输入参数
                //cmdInsert.Parameters.AddWithValue("@username", Parameters.username);
                cmdInsert.Parameters.AddWithValue("@username", "lixin");
                cmdInsert.Parameters.AddWithValue("@nr", InputContent);
                cmdInsert.Parameters.AddWithValue("@fbsj", DateTime.Now.ToString("yyyy-MM-dd " + "HH:mm:ss"));
                cmdInsert.Parameters.AddWithValue("@deadline", InputDeadline);
               
                //cmdInsert.Parameters.AddWithValue("@class1", Class1);
                int result = cmdInsert.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("发布成功！");
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
            }
        }
    }
}
