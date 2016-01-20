using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace PIN
{
    public class DTConnection
    {

        //数据库读取&查询
        public List<String[]> ReadCon(String selectstring,String constring)
        {
            List<String[]> record = new List<string[]>();
            using (SqlConnection connection=new SqlConnection(constring))
            {
                connection.Open();
                SqlCommand query = new SqlCommand(selectstring,connection);
                try
                {
                    SqlDataReader sdr = query.ExecuteReader();
                    while(sdr.Read())
                    {
                        String[] temp = new String[sdr.FieldCount];
                        for (int i = 0; i < sdr.FieldCount; i++)
                            temp[i] = sdr[i].ToString().Trim();
                        record.Add(temp);                          
                    }
                }
                catch
                {
                    MessageBox.Show("对不起，系统繁忙，请稍后重试");
                }
                //释放资源
                connection.Close();
            }
            return record;//返回读取结果
        }


        //数据库插入& 删除，主要是验证密码
        public int InsertDelCon(String insertstring, String constring)
        {
            int result = -1;
            using(SqlConnection connection=new SqlConnection(constring))
            {
                connection.Open();
                SqlCommand insertdel = new SqlCommand(insertstring, connection);
                Parameters pf = new Parameters();
                pf.Correspond(insertdel, RegisterClass.corr1, RegisterClass.corr2);
                try
                {
                   result=insertdel.ExecuteNonQuery();//执行操作
                }
                catch (Exception )
                {
                    MessageBox.Show("失败，请重试！");
                }
                connection.Close();
            }
            return result;
        }

        //数据库更新
        public int UpdateCon(String updatestring, String constring)
        {
            int num = -1;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                connection.Open();
                SqlCommand update = new SqlCommand(updatestring, connection);
                try
                {
                    num = update.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("修改失败，请重试！");
                    //}
                    connection.Close();
                }
                return num;
            }
        }

        //测试数据库连接
        public bool TestDBConn()
        {
            /************************/
            string connectionString = Parameters.user_info;
            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }



}
