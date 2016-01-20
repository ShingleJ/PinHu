using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace PIN
{
    public class Parameters
    {
        #region 测试DB连接
        /***************************数据库连接语句***************************/
        //事件数据库
        public static String event_info = null;// @"Server = localhost;database = Event_info;User ID = sa;Password = sasa;";
        //空间位置数据库
        public static String spatial_info=null;// @"Server = localhost;database = Spatial_info;User ID = sa;Password = sasa;";
        //用户数据库
        public static String user_info = null;//@"Server = localhost;database = User_info;User ID = sa;Password = sasa;";



        
        #endregion 
        
        #region 待用的窗口
        public static UISendMessage sendmessage=new UISendMessage();
        public static UIatFriends friends;
        public static UIhomepage homepage = new UIhomepage();
        public static UIExplore explore = new UIExplore();
        public static UIuserpage userpage= new UIuserpage();
        public static UIAdmin admin = new UIAdmin();
        //记录窗口是否打开
        public static bool tempstate = false;
        public static bool userpagestate = false;
        public static bool sendmessagestate = false;
        public static bool explorestate = false;
        public static bool homepagestate = false;
        public static bool haslogined = false;
        public static bool showmap = false;
        public static bool settingstate = false;
        public static bool loginstate = false; 
        public static bool atfristate = false;
        public static bool detailstate = false;
        public static bool adminstate = false;

        

        #endregion

        public static void loadPinhu()
        {
            tempstate = false;
            userpagestate = false;
            sendmessagestate = false;
            explorestate = false;
            homepagestate = false;
            haslogined = false;
            showmap = false;
            settingstate = false;
            loginstate = false;
            detailstate = false;

            username = null;
            password = null;
            iconfullpath= new DirectoryInfo("../../../").FullName +@"picture\icon\doge.ico";
            usertype = 4;
            atfriend = null;

        }
        // public static ModifyPasswordcs modifyPassword;
        /**********************************/
        //关于相关类的介绍
        //Classify：配合classify使用，用于“信息分类显示”使用，不同类别载入不同界面
        //Connection：“连接”类 完成数据库的连接 目前还没有实现
        //KeySearch：关键字“搜素”
        //LoginClass：完成实现“注册”相关事项
        //MyMessage：“查看个人已发布事件”
        //RegistereClass:“登陆系统”时的相关事项
        //SaveBasedSort：完成实现“分类存储”
        //SendMessageClass：“发布事件”相关事项类


        /****************************************/
        //文件夹的介绍

        //个人
        //个人发布的所有信息
        //个人的好友
        //完善资料
        //修改密码

        //信息
        //分类显示信息
        //在个人主页显示信息
        //查看、评论、留言、分享信息
        //搜索信息

        //发布信息
        //信息内容、地址、时间、分类...等等的实现
        
        /*****************************************/
       //一些全局变量
        //public static String str = null;

        //用户名
        public static String username = null;
        //用户密码
        public static String password = null;
        //用户ID
        public static String id = null;
        //用户类型
        public static int usertype = 4;//0为学生，1为商家，2为管理员

        public static string[] userFieldname = new string[3] { "StudentInfo", "Merchant", "AdminInfo" };

        public static string[] userTablename = new string[3] { "StudentInfo", "MerchantInfo", "AdminInfo" };

        public static string iconfullpath= new DirectoryInfo("../../../").FullName +@"picture\icon\doge.ico";

        #region 测试DB连接
        //DB用户名
        public static String dbusername=null;

        //DB用户密码
        public static String dbpassword=null;
        //朋友列表
        public static String atfriend = null;
      
        #endregion  
       
        //分享范围
        //public static int sharetype;
        //消息等级，0为公开，1为好友圈，2指定部分好友可见，3仅自己可见
        public static int messlevel=0;

        //循环插入赋值
        public void Correspond(SqlCommand command, List<String> corr1, List<String> corr2)
        {
            for (int i = 0; i < corr1.Count; i++)
            {
                command.Parameters.AddWithValue(corr1[i], corr2[i]);
            }
        }

    }
}
