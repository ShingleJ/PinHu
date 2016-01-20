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
    public class ClassifyShow
    {
        public SqlDataReader ShowBasedSort(String Class1)
        {
            String connectionString = Parameters.event_info;
            //判断插入信息的数据库
            String commandTextInsert = null;
            switch (Class1)
            {
                case "拼车":
                    {
                        commandTextInsert = "select * from PinCar order by Time desc;";
                        break;
                    }
                case "购物":
                    {
                        commandTextInsert = "select * from PinShopping order by Time desc;";
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
                SqlDataReader reader = cmdInsert.ExecuteReader();
                return reader;
                //通过循环列表显示查询结果集
                //int i = 1;
                //while (reader.Read())
                //{//用户 内容 发布时间 
                //    AddKJ(reader[1].ToString(), reader[4].ToString(), reader[2].ToString(), reader[6].ToString());
                //}
                //reader.Close();
            }
        }
    }
}
