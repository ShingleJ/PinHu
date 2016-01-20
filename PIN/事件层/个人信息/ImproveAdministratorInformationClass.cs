using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PIN
{
    class MoreAdminInfo
    {
        public String Sex;
        public String Age;
        public String Email;
        public String PhoneNumber;
        public String WorkPlace;
        public String NickName;
        public string Iconpath;


        //将数据插入数据库的方法
        public void GetInsert()
        {

            string connectionString = Parameters.user_info;
            string commandTextUpdate = "update AdminInfo set AdminInfo_Sex = '" + Sex + "',AdminInfo_Age = '" + Age + "',AdminInfo_Email ='" + Email + "',AdminInfo_PhoneNumber ='" + PhoneNumber + "' ,AdminInfo_WorkPlace = '" + WorkPlace
                                       + "',AdminInfo_NickName='" + NickName + "' ,StudentInfo_Icon = '" + Iconpath
                                                              + "' Where Name = '" + Parameters.username + "';";//用户名的问题
            DTConnection con = new DTConnection();
            con.UpdateCon(commandTextUpdate, connectionString);
        }
    }
}
