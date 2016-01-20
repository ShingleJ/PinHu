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

namespace PIN
{
    public partial class UIDetails : Form
    {
        /*****************************/
        //相关变量
        //事件的ID号
        //发布人
        private String PublisherName;
        public int thiseventid;
        List<String[]> readEvent;
        public String comments = null;
        /*************************/
        public UIDetails(String _PublisherName,int _eventId)
        {
            InitializeComponent();
            PublisherName = _PublisherName;
            thiseventid = _eventId;
            Parameters.detailstate = true;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            //根据ID，查询事件
            String constr = Parameters.event_info;
            String commandTextQuery1 = "select * from AllEvents where Event_Id = '" + thiseventid + "'";
            DTConnection con = new DTConnection();
            readEvent = con.ReadCon(commandTextQuery1, constr);

            //加载发布人姓名
            lblPublisherNme.Text = readEvent[0][2].ToString();
            //加载事件状态
            lblState.Text = "事件："+readEvent[0][1].ToString();
            //加载发布时间，截止时间
            lblSendTime.Text = "发送时间："+readEvent[0][3].ToString();
            lblDeadline.Text = "截至时间："+readEvent[0][4].ToString();
            //发布人头像
            string connectionString= Parameters.user_info;
            String SlctIcon = "select * from StudentInfo where StudentInfo_NickName = '" + PublisherName + "'";
            List<String[]> readIcon=con.ReadCon(SlctIcon, connectionString);
            string iconpath = new DirectoryInfo("../../../").FullName+readIcon[0][11];
            this.pboxPublisherIcon.SizeMode = PictureBoxSizeMode.Zoom;
            this.pboxPublisherIcon.Image = Image.FromFile(iconpath);
            //关注按钮文本

            string selectstr = "select * from FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + this.PublisherName + "'";
            List<String[]> haveFollow = con.ReadCon(selectstr, connectionString);
            if (haveFollow.Count == 0)
            {
                this.btnFollowPublisher.Text = "关注TA";
            }
            else
            {
                this.btnFollowPublisher.Text = "取消关注";
            }

            //事件内容
            String EventContent = readEvent[0][7].ToString();
            content.Text = EventContent.Substring(0, EventContent.IndexOf("】") + 1);
            content.Text += "\n     " + EventContent.Substring(EventContent.IndexOf("】") + 1, EventContent.Length - EventContent.IndexOf("】") - 1);
            pboxPublisherIcon.BackColor = Color.MistyRose;
            //浏览量
            int ViewNum = int.Parse(readEvent[0][8].ToString());
            //加载意向接洽者
            if (readEvent[0][9].ToString().Length > 0)
            {
                lblCurrentFollowers.Text = "目前有" + readEvent[0][9].ToString() + "愿意接洽该事件";
            }
            else
            {
                lblCurrentFollowers.Text = "暂时无人接洽该事件";
            }
            ViewNum++;
            lblPageview.Text = "浏览量:" + ViewNum + "次";
            //更新浏览量
            String commandUpdate = "update AllEvents set Event_Pageview ='" + ViewNum + "' where Event_Id = '" + thiseventid + "';";
            con.UpdateCon(commandUpdate, constr);
            

            //显示评论
            String selectStr = "select* from Event_Comments where Comment_EventId = '" + thiseventid + "'";
            List<String[]> readComments = con.ReadCon(selectStr, constr);
            //通过循环列表显示查询结果集
            for (int ii = 0; ii < readComments.Count; ii++)
            {
                if (readComments[ii][3] != null)
                {
                    //用户 内容 发布时间 
                    String comment = readComments[ii][4].ToString().Trim() + "说:   " + "     " + readComments[ii][3].ToString().Trim() + "\n";
                    this.rboxComments.AppendText(comment);
                    this.rboxComments.Refresh();
                }
            }
        }


        #region
        //private void laud_Click(object sender, EventArgs e)//点赞
        //{
        //    //关注
        //    if (laud.BackColor != Color.Green)
        //    {
        //        laud.BackColor = Color.Green;
        //        laud.Text = "已关注";
         
        //        //更新内容
        //        //根据ID，查询显示事件
        //        String connectionString1 = Parameters.event_info;
        //        String commandTextQuery1 = "select Event_Follower from AllEvents where Event_Id = '" + eventid + "'";

        //        using (SqlConnection connection = new SqlConnection(connectionString1))
        //        {
        //            connection.Open();
        //            //读取必要信息

        //            SqlCommand cmdQuery = new SqlCommand(commandTextQuery1, connection);
        //            SqlDataReader reader1 = cmdQuery.ExecuteReader();
        //            reader1.Read();
        //            //浏览量
        //            if (reader1[0] != null)
        //            {
        //                String follwer = reader1[0].ToString().Trim();
        //                String addtion = "[" + Parameters.username + "]";
        //                follwer += addtion;
        //                reader1.Close();
        //                String commandUpdate = "update AllInformation set Follower = '" + follwer + "' where ID = " + eventid + ";";
        //                SqlCommand cmdUpdate = new SqlCommand(commandUpdate, connection);
        //                cmdUpdate.ExecuteNonQuery();
        //                String Followers = "[" + Parameters.username + "]";
        //                lblCurrentFollowers.Text += Followers;
        //            }
        //        }
        //    }
        //        //取消关注
        //    else
        //    {
        //        laud.BackColor = SystemColors.Control;
        //        laud.Text = "关注";

        //        String connectionString1 = Parameters.event_info;
        //        /************************/
        //        using (SqlConnection connection = new SqlConnection(connectionString1))
        //        {
        //            connection.Open();
        //            //读取必要信息
        //            String commandTextQuery1 = "select Follower from AllInformation where ID = " + eventid;
        //            SqlCommand cmdQuery = new SqlCommand(commandTextQuery1, connection);
        //            SqlDataReader reader1 = cmdQuery.ExecuteReader();
        //            reader1.Read();

        //            String trim = "[" + Parameters.username + "]";
        //            String follower = reader1[0].ToString().Remove(reader1[0].ToString().IndexOf(trim));
        //            lblCurrentFollowers.Text = lblCurrentFollowers.Text.ToString().Remove(lblCurrentFollowers.Text.ToString().IndexOf(trim));
        //            //浏览量
        //            if (reader1[0] != null)
        //            {
        //                reader1.Close();
        //                String commandUpdate = "update AllInformation set Follower = '" + follower + "' where ID = " + eventid + ";";
        //                SqlCommand cmdUpdate = new SqlCommand(commandUpdate, connection);
        //                cmdUpdate.ExecuteNonQuery();
                        
        //            }
        //        }
        //    }
        //}

        //回复留言
        private void comment_Click(object sender, EventArgs e)
        {
            DTConnection con = new DTConnection();
            string content = this.tboxMyComment.Text;
            String time = DateTime.Now.ToString("yyyy-MM-dd " + "HH:mm:ss");
            string Commentator = Parameters.username;
            string BeCommentedUser = lblPublisherNme.Text;
            int EventId = thiseventid;
            string connectionString = Parameters.event_info;
            String insertStr = "insert into Event_Comments(Comment_Content,Comment_CommentatorId,Comment_BeCommentedUserId,Comment_Time,Comment_EventId) values('" + content + "','" + Commentator + "','" + BeCommentedUser + "','" + time + "','" + EventId +"')";
            int re=con.InsertDelCon(insertStr, connectionString);
            if (re == -1)
            {
                MessageBox.Show("系统繁忙，请重试！");
            }
            else 
            {
                MessageBox.Show("评论发布成功");
                this.rboxComments.Clear();
                String selectStr = "select* from Event_Comments where Comment_EventId = '" + thiseventid + "'";
                List<String[]> readComments = con.ReadCon(selectStr, connectionString);
                //通过循环列表显示查询结果集
                for (int ii = 0; ii < readComments.Count; ii++)
                {
                    if (readComments[ii][3] != null)
                    {
                        //用户 内容 发布时间 
                        String comment = readComments[ii][4].ToString().Trim() + "说:   " + "     " + readComments[ii][3].ToString().Trim() + "\n";
                        this.rboxComments.AppendText(comment);
                        this.rboxComments.Refresh();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)//判断是否能够给看信息
        {

        }

        private void content_TextChanged(object sender, EventArgs e)
        {

        }

        private void share_Click(object sender, EventArgs e)
        {
            string[] rea = readEvent[0];
            UIShareWithFriends swf = new UIShareWithFriends(rea);
            swf.Show();
        }

        private void transmit_Click(object sender, EventArgs e)
        {
            string follower = Parameters.username;
            string tempfollow = readEvent[0][9].ToString();
            string connectionString = Parameters.event_info;
            if (tempfollow.Length == 0)
            {
                tempfollow += follower;
            }
            else
            {
                tempfollow += "," + follower;
            }
            String Updatestr = "update AllEvents set Event_Follower = '" + tempfollow + " 'where Event_Id = " + thiseventid + ";";
            DTConnection con = new DTConnection();
            con.UpdateCon(Updatestr, connectionString);
            MessageBox.Show("请求已发送");
        }
        //关注
        private void btnFollowUser_Click(object sender, EventArgs e)
        {
            if (this.btnFollowPublisher.Text == "关注TA")
            {
                String connectionString = Parameters.user_info;
                DTConnection con = new DTConnection();
                //查看是否已关注
                string selectstr = "select * from FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + this.PublisherName+"'";
                List<String[]> haveFollow = con.ReadCon(selectstr, connectionString);

                if (haveFollow.Count == 0)//无此关注
                {
                    String insertStr = "insert into FollowUser(FollowUser_UserName,FollowUser_FollowerName) values('" + PublisherName + "','" + Parameters.username + "')";
                    int re = con.InsertDelCon(insertStr, connectionString);
                    if (re == -1)
                    {
                        MessageBox.Show("系统繁忙，请重试");
                    }
                    else
                    {
                        MessageBox.Show("已成功关注");
                        this.btnFollowPublisher.Text = "取消关注";
                    }
                }
                else 
                {
                    MessageBox.Show("已关注此人");
                    this.btnFollowPublisher.Text = "取消关注";
                }
            }
            else if (this.btnFollowPublisher.Text == "取消关注")
            {
                String connectionString = Parameters.user_info;
                DTConnection con = new DTConnection();
                //查看是否已关注
                string selectstr = "select * from FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + this.PublisherName + "'";
                List<String[]> haveFollow = con.ReadCon(selectstr, connectionString);

                if (haveFollow.Count == 0)//无此关注
                {
                    MessageBox.Show("未关注此人");
                    this.btnFollowPublisher.Text = "关注TA";
                }
                else
                {
                    String deleStr = "Delete from  FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + this.PublisherName + "'";
                    int re = con.InsertDelCon(deleStr, connectionString);
                    if (re == -1)
                    {
                        MessageBox.Show("系统繁忙，请重试");
                    }
                    else
                    {
                        MessageBox.Show("已取关此人！");
                        this.btnFollowPublisher.Text = "关注TA";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Parameters.detailstate = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UIReportReason UIR = new UIReportReason(thiseventid, this);
            UIR.Show();
            //String connectionString1 = Parameters.event_info;
            //using (SqlConnection connection = new SqlConnection(connectionString1))
            //{
            //    connection.Open();
            //    //String commandTextQuery1 = "select * from ReportedInformation where ID = " + eventIdDetail;
            //    //SqlCommand cmdQuery = new SqlCommand(commandTextQuery1, connection);
            //    //SqlDataReader reader = cmdQuery.ExecuteReader();
            //    //reader.Read();
            //    //if (reader.HasRows == false)//还没有人举报
            //    //{
            //    String commandInsert = "Insert INTO ReportedInformation(InformationID,ReportPeople,ReportTime)VALUES(@InformationID,@ReportPeople,@ReportTime)";
            //    SqlCommand cmdInsert = new SqlCommand(commandInsert, connection);
            //    cmdInsert.Parameters.AddWithValue("@ReportPeople", Parameters.username);
            //    cmdInsert.Parameters.AddWithValue("@ReportTime", DateTime.Now.ToString("yyyy-MM-dd " + "HH:mm:ss"));
            //    cmdInsert.Parameters.AddWithValue("@InformationID", thiseventid);
            //    //SqlDataReader reader1 = cmdInsert.ExecuteReader();
            //    int r = cmdInsert.ExecuteNonQuery();
            //    if (r >= 1)
            //    {
            //        MessageBox.Show("举报成功！请等待处理结果！");
            //    }
            //    //}
            //}
        }

        private void tboxMyComment_MouseDown(object sender, MouseEventArgs e)
        {
            this.tboxMyComment.ForeColor = Color.Black;
            this.tboxMyComment.Text = "";
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void rboxComments_TextChanged(object sender, EventArgs e)
        {

        }

        private void collect_Click(object sender, EventArgs e)
        {
            string Event_Publisher = Parameters.username;
            string Event_PublishTime = readEvent[0][3].ToString();
            string Event_Deadline = readEvent[0][4].ToString();
            string Event_Authority = readEvent[0][5].ToString();
            string Event_Class = readEvent[0][6].ToString();
            string Event_Content = readEvent[0][7].ToString();
            string Event_Pageview = readEvent[0][8].ToString();
            string Event_Follower = readEvent[0][9].ToString();
            string Event_At = readEvent[0][10].ToString();
            string Event_Allowpeople = readEvent[0][11].ToString();
            int eventid = thiseventid;

            String connectionString = Parameters.event_info;
            DTConnection con = new DTConnection();
            String insertStr = "insert into AllEvents(Event_Publisher,Event_Content,Event_PublishTime,Event_Deadline,Event_Class,Event_Authority,Event_State,Event_Pageview,Event_Allowpeople) values('" + Event_Publisher + "','" + Event_Content + "','" + Event_PublishTime + "','" + Event_Deadline + "','" + Event_Class + "','" + Event_Authority + "','" + "收藏" + "','" + Event_Pageview + "','" + Event_Allowpeople + "')";
            con.InsertDelCon(insertStr, connectionString);

            MessageBox.Show("收藏成功");
        }
#endregion

        private void pboxPublisherIcon_Click(object sender, EventArgs e)
        {
            //加载联系方式
        }

    }
}
