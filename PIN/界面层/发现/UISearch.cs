using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace PIN
{
    public partial class UISearch : Form
    {
        private string thiskey = null;
        public UISearch(string keyword)
        {
            InitializeComponent();
            thiskey = keyword;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            TabPage searchtab = new TabPage();
            searchtab.AutoScroll = true;
            searchtab.Width = 300;
            searchtab.Height = 370;
            String connectionString = Parameters.event_info;
            String commandTextQuery = "select * from AllEvents where Event_content like '%" + thiskey + "%' and Event_State='未拼' order by Event_PublishTime desc;";
            string userConstr = Parameters.user_info;
            DTConnection con = new DTConnection();
            String name = Parameters.username;

            //读数据库
            List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);

            //显示
            int tabflag = 0;//指示位置
            int eventnum = reader.Count();
            if (Parameters.haslogined)//已登陆
            {
                for (int k = 0; k < reader.Count; k++)//每条记录
                {
                    if (!reader[k][1].Contains("通知"))//非@事件
                    {
                        if (reader[k][5] == "1")//权限为所有好友
                        {
                            String SelectMeFollow = "select FollowUser_UserName from FollowUser where FollowUser_FollowerName = '" + name + "';";
                            List<String[]> MeFollow = con.ReadCon(SelectMeFollow, userConstr);//我关注的人
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

                        
                        searchtab.Controls.Add(Parameters.explore.AddShow(reader[k], tabflag++));
                    }
                }
            }
            else//未登录
            {
                for (int k = 0; k < reader.Count; k++)
                {
                    if (reader[k][1].Contains("通知"))
                    {
                        continue;
                    }
                    if (reader[k][5] == "0")
                    {
                        GroupBox groupb = Parameters.explore.AddShow(reader[k], tabflag++);//产生了一个tabpage
                       
                        searchtab.Controls.Add(groupb);
                    }
                }
            }

            searchtab.Text = "和“" + thiskey + "”有关的内容有:";
            Tabcon.Controls.Add(searchtab);
            Tabcon.SelectedTab = searchtab;
            if (tabflag == 0)
            {
                TextBox text = new TextBox();
                text.Multiline = true;
                text.Location = new System.Drawing.Point(50, 15);
                text.Width = 241;
                text.Height = 200;
                text.Text = "未找到和“" + thiskey + "”有关的内容";
                searchtab.Controls.Add(text);
            }

            LoadRelativeStnUsers();
        }

        private void LoadRelativeStnUsers()
        {
            String connectionString = Parameters.user_info;
            String commandTextQuery = "select * from StudentInfo where StudentInfo_NickName like '%" + thiskey + "%'order by StudentInfo_NickName desc;";
            string userConstr = Parameters.user_info;
            DTConnection con = new DTConnection();

            //读数据库
            List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);

            //显示
            ShowRelativeUsers(reader);

        }

        private void ShowRelativeUsers(List<String[]> read)
        {
            TabPage searchStudentUserTab = new TabPage();
            searchStudentUserTab.AutoScroll = true;
            searchStudentUserTab.Text = "相关学生用户有：";

            DTConnection con = new DTConnection();

            int flag = 0;
            if (read.Count != 0)
            {
                for (int i = 0; i < read.Count; i++)
                {
                    GroupBox studentUserGroup = new GroupBox();
                    studentUserGroup.Width = 400;
                    studentUserGroup.Height = 60;
                    PictureBox pictbox = new PictureBox();
                    pictbox.Width = 42;
                    pictbox.Height = 42;
                    pictbox.Location = new System.Drawing.Point(3, 15);

                    string tname = read[i][2];
                    string seleiconpath = "select * from StudentInfo where StudentInfo_NickName ='" + tname + "'";
                    string constr = Parameters.user_info;
                    List<String[]> reader2 = con.ReadCon(seleiconpath, constr);
                    string fllpath = new DirectoryInfo("../../../").FullName + reader2[0][11];
                    if (!File.Exists(fllpath))
                    {
                        fllpath = new DirectoryInfo("../../../").FullName + @"picture\icon\anonymity.bmp";
                    }
                    pictbox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictbox.Image = Image.FromFile(fllpath);

                    RichTextBox richtextbox = new RichTextBox();
                    richtextbox.Width = 200;
                    richtextbox.Height = 42;
                    //richtextbox.ScrollBars = both;
                    richtextbox.Location = new System.Drawing.Point(50, 15);
                    richtextbox.Text = read[i][2];

                    Button btnToKnowOther = new Button();
                    btnToKnowOther.Text = "详情";
                    btnToKnowOther.Name = read[i][2];
                    btnToKnowOther.Location = new System.Drawing.Point(260, 20);
                    btnToKnowOther.Width = 50;
                    btnToKnowOther.Height = 25;
                    btnToKnowOther.Click += new EventHandler(btnToKnowOther_Click);

                    Button btnFollow = new Button();
                    btnFollow.Name = read[i][2];
                    //查看是否已关注
                    string selectstr = "select * from FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + read[i][2] + "'";
                    List<String[]> haveFollow = con.ReadCon(selectstr, constr);
                    if (haveFollow.Count == 0)
                    {
                        btnFollow.Text = "关注TA";
                        btnFollow.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        btnFollow.Text = "取消关注";
                        btnFollow.BackColor = Color.LightGray;
                    }
                    btnFollow.Location = new System.Drawing.Point(320, 20);
                    btnFollow.Width = 70;
                    btnFollow.Height = 25;
                    btnFollow.Click += new EventHandler(btnFollow_Click);

                    studentUserGroup.Controls.Add(pictbox);
                    studentUserGroup.Controls.Add(btnToKnowOther);
                    studentUserGroup.Controls.Add(btnFollow);
                    studentUserGroup.Controls.Add(richtextbox);
                    studentUserGroup.Location = new System.Drawing.Point(10, 10 + (flag++) * 60);//相对应tabpage的

                    searchStudentUserTab.Controls.Add(studentUserGroup);
                }
            }
            else
            {
                TextBox text = new TextBox();
                text.Multiline = true;
                text.Location = new System.Drawing.Point(50, 15);
                text.Width = 241;
                text.Height = 200;
                text.Text = "未找到和“" + thiskey + "”有关的用户";
                searchStudentUserTab.Controls.Add(text);
            }
            Tabcon.Controls.Add(searchStudentUserTab);
        }

        //点击详情
        private void btnToKnowOther_Click(object sender, EventArgs e)
        {
                Button btndetail = sender as Button;
                string userName = btndetail.Name;
                UIOtherHomepage otherHomepage = new UIOtherHomepage(userName);
                otherHomepage.Show();
                this.Close();
        }

        //点击关注
        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (!Parameters.haslogined) { MessageBox.Show("请先登录！"); }
            else
            {
                Button btnfollow = sender as Button;
                string userName = btnfollow.Name;
                if (btnfollow.Text == "关注TA")
                {
                    DTConnection con = new DTConnection();
                    String connectionString = Parameters.user_info;
                    String insertStr = "insert into FollowUser(FollowUser_UserName,FollowUser_FollowerName) values('" + userName + "','" + Parameters.username + "')";
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

                    String deleStr = "Delete from  FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + userName + "'";
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
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Parameters.explore.Show();
            Parameters.explorestate = true;
        }

    }
}
