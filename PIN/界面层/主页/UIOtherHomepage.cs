using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PIN
{
    public partial class UIOtherHomepage : Form
    {
        string pageHosterName;
        int flag = 0;

        public UIOtherHomepage()
        {
            InitializeComponent();
        }

        public UIOtherHomepage(string userName)
        {
            InitializeComponent();
            this.pageHosterName = userName;            
        }

        private void UIOtherHomepage_Load(object sender, EventArgs e)
        {
            
            InitializeThisForm();
        }

        private void InitializeThisForm()
        {
            title.Text = pageHosterName + "的主页";

            DTConnection con = new DTConnection();
            string constr = Parameters.user_info;
            string selectstr = "select * from FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + pageHosterName + "'";
            List<String[]> haveFollow = con.ReadCon(selectstr, constr);
            if (haveFollow.Count == 0)
            {
                btnfollow.Text = "关注TA";
                btnfollow.BackColor = Color.GreenYellow;
            }
            else
            {
                btnfollow.Text = "取消关注";
                btnfollow.BackColor = Color.LightGray;
            }

            tabPage1.AutoScroll = true;

            //清空控件
            tabPage1.Controls.Clear();

            String Event_constr = Parameters.event_info;
            string User_constr = Parameters.user_info;
            /************************/
            //加载自己发布的所有拼事件（需要判断该事件的权限，根据权限来决定显示给哪些用户看）
            String commandTextQuery = "select * from AllEvents where Event_Publisher='" + pageHosterName + "' and Event_State='未拼' order by Event_PublishTime desc";
            List<String[]> reader = con.ReadCon(commandTextQuery, Event_constr);
            String name = Parameters.username;

            int recordnum = reader.Count;
            if (recordnum == 0)
            {
                Label label = new Label();
                label.Text = "该用户潜水很深，还没有动态...";
                label.Font = new Font("宋体", 18);
                label.AutoSize = true;
                label.ForeColor = Color.DarkSlateGray;
                label.Location = new System.Drawing.Point(tabPage1.Location.X + 80, tabPage1.Height - 160);
                tabPage1.Controls.Add(label);
            }
            else
            {
                int tabflag = 0;//指示位置
                int eventnum = reader.Count();
                for (int k = 0; k < reader.Count; k++)//每条记录
                {
                    if (reader[k][5] == "1")//权限为所有好友
                    {
                        String SelectMeFollow = "select FollowUser_UserName from FollowUser where FollowUser_FollowerName = '" + name + "';";
                        List<String[]> MeFollow = con.ReadCon(SelectMeFollow, User_constr);//我关注的人
                        bool MeFollowbool = false;
                        for (int j = 0; j < MeFollow.Count; j++)
                        {
                            if (MeFollow[j][0] == reader[k][2])
                            {
                                MeFollowbool = true;
                                break;
                            }
                        }
                        if (!MeFollowbool)//未关注-不加载
                        {
                            continue;
                        }
                    }
                    else if (reader[k][5] == "2")
                    {
                        List<String> MePartFollow = reader[k][11].Split(',').ToList();
                        bool MePartFollowbool = false;
                        for (int j = 0; j < MePartFollow.Count; j++)
                        {
                            if (MePartFollow[j] == reader[k][2])
                            {
                                MePartFollowbool = true;
                                break;
                            }
                        }
                        if (!MePartFollowbool)
                        {
                            continue;
                        }
                    }
                    else if (reader[k][5] == "3")
                    {
                        //仅自己可见
                        if (name != reader[k][2].Trim())
                        {
                            continue;
                        }
                    }
                    this.tabPage1.Controls.Add(Parameters.explore.AddShow(reader[k], tabflag++));
                }
            }
            //读头像
            string fieldname = Parameters.userFieldname[Parameters.usertype] + "_NickName";
            string tablename = Parameters.userTablename[Parameters.usertype];
            String QueryMyIcon = "select * from " + tablename + " where " + fieldname + " = '" + pageHosterName + "' ;";
            List<String[]> iconlist = con.ReadCon(QueryMyIcon, User_constr);
            string tpath = new DirectoryInfo("../../../").FullName + iconlist[0][11].ToString();
            //头像和ID
            Parameters.id = iconlist[0][10].ToString();
            if (!File.Exists(tpath))
            {
                tpath = new DirectoryInfo("../../../").FullName + @"picture\icon\anonymity.bmp";
            }
            this.pboxFace.SizeMode = PictureBoxSizeMode.Zoom;
            this.pboxFace.Image = Image.FromFile(tpath);
            UpdateTag();
        }

        //粉丝数，事件数，关注数更新
        public void UpdateTag()
        {
            DTConnection con = new DTConnection();
            //粉丝数
            String SelectFollower = "select * from FollowUser where FollowUser_UserName = '" + pageHosterName + "';";
            string userConstr = Parameters.user_info;
            List<String[]> Follower = con.ReadCon(SelectFollower, userConstr);
            this.lblFollowerNum.Text = Follower.Count.ToString();
            //关注数
            String SelectFollow = "select * from FollowUser where FollowUser_FollowerName = '" + pageHosterName + "';";
            List<String[]> record2 = con.ReadCon(SelectFollow, userConstr);
            this.lblFollowNum.Text = record2.Count.ToString();
            //事件数
            String SelectEvent = "select * from AllEvents where Event_Publisher = '" + pageHosterName + "';";
            string eventConstr = Parameters.event_info;
            List<String[]> record3 = con.ReadCon(SelectEvent, eventConstr);
            this.lblEventnum.Text = record3.Count.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnfollow.Text == "关注TA")
            {
                DTConnection con = new DTConnection();
                String connectionString = Parameters.user_info;
                String insertStr = "insert into FollowUser(FollowUser_UserName,FollowUser_FollowerName) values('" + pageHosterName + "','" + Parameters.username + "')";
                int re = con.InsertDelCon(insertStr, connectionString);
                if (re == -1)
                {
                    MessageBox.Show("系统繁忙，请重试");
                }
                else
                {
                    MessageBox.Show("已成功关注");
                    btnfollow.Text = "取消关注";
                    btnfollow.BackColor = Color.LightGray;
                }
            }
            else if (btnfollow.Text == "取消关注")
            {
                String connectionString = Parameters.user_info;
                DTConnection con = new DTConnection();

                String deleStr = "Delete from  FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + pageHosterName + "'";
                int re = con.InsertDelCon(deleStr, connectionString);
                if (re == -1)
                {
                    MessageBox.Show("系统繁忙，请重试");
                }
                else
                {
                    MessageBox.Show("已取关此人！");
                    btnfollow.Text = "关注TA";
                    btnfollow.BackColor = Color.GreenYellow;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //我想拼
        void llblAccept_Click(object sender, EventArgs e)
        {
            if (Parameters.haslogined)
            {
                LinkLabel llbl = sender as LinkLabel;
                String id = llbl.Name;
                String connectionString = Parameters.event_info;
                DTConnection con = new DTConnection();
                String SeleStr = "select * from AllEvents where Event_Id ='" + id + "'";
                List<String[]> reader = con.ReadCon(SeleStr, connectionString);
                string followers = Parameters.username;
                string tempfollow = reader[0][9];
                if (tempfollow.Length == 0)
                {
                    tempfollow += followers;
                }
                else
                {
                    tempfollow += "," + followers;
                }
                String Updatestr = "update AllEvents set Event_Follower = '" + tempfollow + " 'where Event_Id = " + id + ";";
                con.UpdateCon(Updatestr, connectionString);
                MessageBox.Show("请求已发送");
            }
            else
            {
                MessageBox.Show("请先登录!");
            }
        }
        //收藏
        void llblCollect_Click(object sender, EventArgs e)
        {
            if (Parameters.haslogined)
            {
                LinkLabel llbl = sender as LinkLabel;
                String[] temp = llbl.Name.Split(',');
                string Event_Publisher = Parameters.username;
                string Event_PublishTime = temp[3];
                string Event_Deadline = temp[4];
                string Event_Authority = temp[5];
                string Event_Class = temp[6];
                string Event_Content = temp[7];
                string Event_Pageview = temp[8];
                string Event_Follower = temp[9];
                string Event_At = temp[10];
                string Event_Allowpeople = temp[11];
                int eventid = int.Parse(temp[0]);

                String connectionString = Parameters.event_info;
                DTConnection con = new DTConnection();
                String insertStr = "insert into AllEvents(Event_Publisher,Event_Content,Event_PublishTime,Event_Deadline,Event_Class,Event_Authority,Event_State,Event_Pageview,Event_Allowpeople) values('" + Event_Publisher + "','" + temp[7] + "','" + temp[3] + "','" + temp[4] + "','" + temp[6] + "','" + temp[5] + "','" + "收藏" + "','" + temp[8] + "','" + temp[11] + "')";
                int re = con.InsertDelCon(insertStr, connectionString);
                if (re != -1)
                {
                    MessageBox.Show("收藏成功");
                }
            }
            else
            {
                MessageBox.Show("请先登录!");
            }

        }
        //更多
        void llblMore_Click(object sender, EventArgs e)
        {
            if (Parameters.haslogined)
            {
                LinkLabel llbl = sender as LinkLabel;
                String[] temp = llbl.Name.Split(',');
                String username = temp[1];
                int eventid = int.Parse(temp[0]);
                UIuserpage.details = new UIDetails(username, eventid);
                UIuserpage.details.Show();
            }
            else
            {
                MessageBox.Show("请先登录!");
            }
        }
        private void pictbox_Click(object sender, EventArgs e)
        {
            PictureBox pibox = sender as PictureBox;
            string userName = pibox.Name;
            UIOtherHomepage otherHomepage = new UIOtherHomepage(userName);
            otherHomepage.Show();
        }

    }
}
