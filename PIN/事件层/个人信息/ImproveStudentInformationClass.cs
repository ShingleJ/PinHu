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
    public class ImproveStudentInformationClass
    {
        //构造用户实体类，方便赋值用户所有信息
        public String NickName;
        public String Gender;
        public String Degree;
        public String Address;
        public String StudentId;
        public String Email;
        public String Academy;
        public String PhoneNumber;
        public String Sign;
        public String Iconpath;

        //将数据插入数据库
        public void GetInsert()
        {

            string connectionString = Parameters.user_info;
            string commandTextUpdate = "update StudentInfo set StudentInfo_Gender = '" + Gender + "',StudentInfo_NickName = '" + NickName + "',StudentInfo_Address ='" + Address + "',StudentInfo_Degree ='" + Degree
                                                  + "',StudentInfo_StudentId = '" + StudentId + "',StudentInfo_Email ='" + Email + "',StudentInfo_Academy = '" + Academy
                                                          + "',StudentInfo_PhoneNumber ='" + PhoneNumber + "' ,StudentInfo_Sign = '" + Sign + "' ,StudentInfo_Icon = '" +Iconpath
                                                              + "' Where StudentInfo_NickName = '" + Parameters.username + "';";
            /************************/
            DTConnection con = new DTConnection();
            con.UpdateCon(commandTextUpdate, connectionString);
        }
    }
}
