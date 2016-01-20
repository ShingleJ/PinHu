using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PIN
{
    class ImproveMerchantInformationClass
    {
        //构造用户实体类，方便赋值用户所有信息
        public String Email;
        public String CellphoneNumber;
        public String Address;
        public String Telephone;
        public String Name;
        public String BusinessHour;
        public String ShopAge;
        public String Sign;
        public String ShopName;

        //将数据插入数据库的方法
        public void GetInsert()
        {

            string connectionString = Parameters.user_info;
            string commandTextUpdate = "update MerchantInfo set Merchant_ShopName='" + ShopName + "',Merchant_BusinessHour = '" + BusinessHour + "',Merchant_Name = '" + Name + "',Merchant_Address ='" + Address + "',Merchant_Telephone ='" + Telephone
                                       + "',Merchant_ShopAge = '" + ShopAge + "',Merchant_Email ='" + Email + "',Merchant_CellphoneNumber ='" + CellphoneNumber + "' ,Merchant_Sign = '" + Sign
                                       + "' Where Name = '" + Parameters.username + "';";
            DTConnection con = new DTConnection();
            con.UpdateCon(commandTextUpdate, connectionString);
        }
    }
}
