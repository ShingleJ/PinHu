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
    public class SendMessageClass
    {
        public bool Insert(String InputContent,String InputDeadline,String Class1,string atfriends,string allowpeople)
        {
            //插入项
            String publisher = Parameters.username;
            String content = InputContent;
            String time = DateTime.Now.ToString("yyyy-MM-dd " + "HH:mm:ss");
            String deadline = InputDeadline;
            String classi = Class1;
            int authority = Parameters.messlevel;
            String state = "未拼";
            int pageview = 0;
            //连接事件数据库&空间数据库
            String conEventStr = Parameters.event_info;
            String conSpatialStr = Parameters.spatial_info;

            //插入发布人事件表
            String cmdEventInsert = "insert into AllEvents(Event_Publisher,Event_Content,Event_PublishTime,Event_Deadline,Event_Class,Event_Authority,Event_State,Event_Pageview,Event_At,Event_Allowpeople) values('" + publisher + "','" + content + "','" + time + "','" + deadline + "','" + classi + "','" + authority + "','" + state + "','" + pageview + "','" + atfriends + "','" + allowpeople+ "')";
            DTConnection con = new DTConnection();
            int result = con.UpdateCon(cmdEventInsert, conEventStr);
            //插入AT人事件表
            if (atfriends != null)
            {
                String state2 = "好友@";
                string[] atlist = atfriends.Split(',');
                for (int i = 0; i < atlist.Count(); i++)
                {
                    String cmdEventInsert2 = "insert into AllEvents(Event_Publisher,Event_Content,Event_PublishTime,Event_Deadline,Event_Class,Event_Authority,Event_State,Event_Pageview,Event_Allowpeople) values('" + atlist[i] + "','" + InputContent + "','" + time + "','" + deadline + "','" + classi + "','" + authority + "','" + state2 + "','" + pageview + "','" + allowpeople + "')";
                    DTConnection con2 = new DTConnection();
                    con2.UpdateCon(cmdEventInsert2, conEventStr);
                }
            }
            //空间数据库
            //查询对应的Eventid插入空间数据库aaaa
            String cmdEventSelect = "select Event_Id from AllEvents where Event_Id=(select max(Event_Id) from Allevents)";
            List<String[]> reader = con.ReadCon(cmdEventSelect, conEventStr);
            int id = int.Parse(reader[0][0]);
            //将该id和事件内容更新到对应的空间数据库中
            String cmdSpatialInsert = "update EventLocation set EL_EventId='" + id + "',EL_Content='" + content + "' where EL_LocateId=(select max(EL_LocateId) from EventLocation )";
            con.UpdateCon(cmdSpatialInsert, conSpatialStr);
            if (result == -1)
            {
                return false;//发布失败
            }
            else
            {
                return true;//发布成功
            }

        }
    }
}
