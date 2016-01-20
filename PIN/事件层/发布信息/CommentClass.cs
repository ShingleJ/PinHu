using System;
using System.Data.SqlClient;
namespace PIN
{
    class CommentClass
    {
        public int ID;
        public int CommentID;
        public String CommentContent;
        public String CommentUser;
        public DateTime CommentTime;
        public int result = 0;
        /*****************/
        //此类适用于所有用的“评论”这一功能的地方 主要是为了实现将评论插入数据库中
        public void InsertComment()
        {
            //连接数据库
            String connectionString = Parameters.user_info;
            
            String commandTextInsert = "Insert INTO AllInformationComments(ID,CommentID,CommentContent,CommentUser,CommentTime)VALUES(@ID,@CommentID,@CommentContent,@CommentUser,@CommentTime)";
            /************************/
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandTextInsert, connection);
                //设置输入参数
                cmdInsert.Parameters.AddWithValue("@ID", ID);
                cmdInsert.Parameters.AddWithValue("@CommentID", CommentID);
                cmdInsert.Parameters.AddWithValue("@CommentContent", CommentContent);
                cmdInsert.Parameters.AddWithValue("@CommentUser", CommentUser);
                cmdInsert.Parameters.AddWithValue("@CommentTime", CommentTime);
                result = cmdInsert.ExecuteNonQuery();


            }
        }
    }
}
