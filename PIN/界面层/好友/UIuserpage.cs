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
    public partial class UIuserpage : Form
    {
        #region 初始化

        public int flag = 0;//控件位置
        public static UIDetails details;//详细情况
        TabControl tabcon = new TabControl();//搜素时要添加的控件
        Button fh = new Button();//搜索时“添加”的返回按钮
        public static bool searchnow = false;
        TabPage srchResult = new TabPage();
        /*************************************/

        public UIuserpage()
        {
            InitializeComponent();
            lblname.Text = Parameters.username;
            Parameters.userpagestate = true;

        }

        
        private void Form1_Load(object sender, EventArgs e)//载入信息
        {
            InitializeForm();
        }

        public void InitializeForm()
        {
            tabPage1.Text = "未拼";
            tabPage2.Text = "已拼";
            String connectionString = Parameters.event_info;
            String commandTextQuery = "select * from AllEvents where Event_State='未拼' order by Event_PublishTime desc";
            DTConnection con = new DTConnection();
            List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);
            //清空原TABPAGE
            tabPage1.Controls.Clear();
            AddKJ(reader, tabPage1);
            //读头像
            this.pboxFace.SizeMode = PictureBoxSizeMode.Zoom;
            this.pboxFace.Image = Image.FromFile(Parameters.iconfullpath);
        }

        #endregion

        #region 增加控件、留言、收藏、分享、详情，搜索事件，返回，tab切换
        //增加显示控件
        public void AddKJ(List<String[]> reader,TabPage tabpage)
        {
            int flag = 0;
            //对每条信息来说
            for (int i = 0; i < reader.Count; i++)
            {
                string userConstr = Parameters.user_info;
                DTConnection con = new DTConnection();
                String name = Parameters.username;
                
              //为@事件-不加载
                if (reader[i][1].Contains("通知"))
                {
                    continue;
                }

                //可见性
                if(int.Parse(reader[i][5].Trim())==1)
                {
                    //我关注的人可见
                    //获得关注者名单
                    String SelectMeFollow = "select FollowUser_UserName from FollowUser where FollowUser_FollowerName = '" + name + "';";
                    List<String[]> MeFollow = con.ReadCon(SelectMeFollow, userConstr);
                    bool MeFollowbool = false;
                    for (int j = 0; j < MeFollow.Count; j++)
                    {
                        if (MeFollow[j][0] == reader[i][2])
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
                else if (int.Parse(reader[i][5].Trim()) == 2)
                {
                    //部分我关注的人可见
                    //获得名单
                    List<String> MePartFollow = reader[i][11].Split(',').ToList();
                    bool MePartFollowbool = false;
                    for (int j = 0; j < MePartFollow.Count; j++)
                    {
                        if (MePartFollow[j] == reader[i][2])
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
                else if (int.Parse(reader[i][5].Trim()) == 3)
                {
                    //仅自己可见
                    if (name != reader[i][2].Trim())
                    {
                        continue;
                    }
                }
                //////
                GroupBox grbox = new GroupBox();
                grbox.Width = 320;
                grbox.Height = 125;

                //richtextbox
                RichTextBox richtextbox = new RichTextBox();
                richtextbox.Width = 241;
                richtextbox.Height = 74;
                //richtextbox.ScrollBars = both;
                richtextbox.Location = new System.Drawing.Point(50, 12);
                richtextbox.Text = reader[i][7];

                //头像的位置
                PictureBox pictbox = new PictureBox();
                pictbox.Width = 42;
                pictbox.Height = 42;
                pictbox.Location = new System.Drawing.Point(3, 35);
                pictbox.BackColor = Color.MistyRose;
                pictbox.Name = reader[i][2];
                string tname = reader[i][2];
                string seleiconpath = "select * from StudentInfo where StudentInfo_NickName ='" + tname + "'";
                string constr = Parameters.user_info;
                List<String[]> reader2 = con.ReadCon(seleiconpath, constr);
                string fllpath = new DirectoryInfo("../../../").FullName+reader2[0][11];
                if (!File.Exists(fllpath))
                {
                    fllpath =  new DirectoryInfo("../../../").FullName +@"picture\icon\doge.ico";
                }
                pictbox.SizeMode = PictureBoxSizeMode.Zoom;
                pictbox.Image = Image.FromFile(fllpath);
                pictbox.Click += new EventHandler(pictbox_Click);

                //在richBox之下
                //想拼
                LinkLabel llblAccept = new LinkLabel();
                llblAccept.Text = "我想拼";
                llblAccept.Location = new System.Drawing.Point(50, richtextbox.Height + 30);//相对应groupBox的
                llblAccept.Name = reader[i][0].ToString();
                llblAccept.Click += new EventHandler(llblAccept_Click);
                //收藏
                LinkLabel llblCollect = new LinkLabel();
                llblCollect.Text = "收藏";
                llblCollect.Location = new System.Drawing.Point(150, richtextbox.Height + 30);//相对应groupBox的
                llblCollect.Name = reader[i][0].ToString() + ',' + reader[i][1].ToString() + ',' + reader[i][2].ToString() + ',' + reader[i][3].ToString() + ',' + reader[i][4].ToString() + ',' + reader[i][5].ToString() + ',' + reader[i][6].ToString() + ',' + reader[i][7].ToString() + ',' + reader[i][8].ToString() + ',' + reader[i][9].ToString() + ',' + reader[i][10].ToString() + ',' + reader[i][11].ToString();
                llblCollect.Click += new EventHandler(llblCollect_Click);
                //更多
                LinkLabel llblMore = new LinkLabel();
                llblMore.Text = "详情";
                llblMore.Location = new System.Drawing.Point(260, richtextbox.Height + 30);//相对应groupBox的
                llblMore.Name = reader[i][0].ToString() + ',' + reader[i][2];
                llblMore.Click += new EventHandler(llblMore_Click);
                //用户名
                Label label = new Label();
                label.Text = reader[i][2];
                label.Location = new System.Drawing.Point(3, 78);
                //时间
                Label label1 = new Label();
                label1.Text = reader[i][4];
                label1.ForeColor = Color.DarkSlateGray;
                label1.Location = new System.Drawing.Point(richtextbox.Location.X + 100, richtextbox.Height + 10);
                Label label2 = new Label();
                label2.Text = "分类：" + reader[i][6];
                label2.ForeColor = Color.DarkSlateGray;
                label2.Location = new System.Drawing.Point(richtextbox.Location.X + 5, richtextbox.Height + 10);
                grbox.Controls.Add(label1);
                grbox.Controls.Add(label2);
                grbox.Controls.Add(richtextbox);
                grbox.Controls.Add(llblAccept);
                grbox.Controls.Add(llblCollect);
                grbox.Controls.Add(llblMore);
                grbox.Controls.Add(pictbox);
                grbox.Controls.Add(label);

                grbox.Location = new System.Drawing.Point(10, 10 + (flag++) * 120);//相对应tabpage的
                tabpage.Controls.Add(grbox);
            }
        }
        //更多
        void llblMore_Click(object sender, EventArgs e)
        {
            LinkLabel llbl = sender as LinkLabel;
            String[] temp = llbl.Name.Split(',');
            String username = temp[1];
            int eventid = int.Parse(temp[0]);
            UIuserpage.details = new UIDetails(username, eventid);
            UIuserpage.details.Show();

        }
        //收藏
        void llblCollect_Click(object sender, EventArgs e)
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
            con.InsertDelCon(insertStr, connectionString);

            MessageBox.Show("收藏成功");
        }
        //我想拼
        void llblAccept_Click(object sender, EventArgs e)
        {
            LinkLabel llbl = sender as LinkLabel;
            String id = llbl.Name;
            String connectionString = Parameters.event_info;
            DTConnection con = new DTConnection();
            String SeleStr = "select * from AllEvents where Event_Id ='" + id + "'";
            List<String[]> reader=con.ReadCon(SeleStr, connectionString);
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

        //搜素事件
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Remove(tabPage1);
            this.tabControl1.TabPages.Remove(tabPage2);
            srchResult.Name = "tabpageresult";
            srchResult.Text = "内容与‘" + tboxSrch.Text + "’有关的事件有";
            this.tabControl1.Controls.Add(srchResult);
            KeySearch ks = new KeySearch();
            List<String[]> keyResult = ks.KeySearchResult(tboxSrch.Text);
            AddKJ(keyResult, srchResult);
            //this.tabControl1.TabPages.Add(srchResult);
            this.btnBack.Text = "返回";
        }

        //切换显示已拼事件
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            String connectionString = Parameters.event_info;
            if (tabControl1.SelectedTab == tabPage1)
            {
                String commandTextQuery = "select * from AllEvents where Event_State='未拼' order by Event_PublishTime desc";
                DTConnection con = new DTConnection();
                List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);
                AddKJ(reader, tabPage1);
            }
            else
            {
                String commandTextQuery = "select * from AllEvents where Event_State='已拼' order by Event_PublishTime desc";
                DTConnection con = new DTConnection();
                List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);
                AddKJ(reader, tabPage2);
            }
        }

        //点击头像
        private void pictbox_Click(object sender, EventArgs e)
        {
            PictureBox pibox = sender as PictureBox;
            string userName = pibox.Name;
            UIOtherHomepage otherHomepage = new UIOtherHomepage(userName);
            otherHomepage.Show();
        }

        #endregion

        #region    界面跳转等设置
        //我的
        private void pboxuserpage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这就是我的页面~","提示");
        }
        //发布
        private void pboxSendmsge_Click(object sender, EventArgs e)
        {
            if (!Parameters.sendmessagestate)
            {
                Parameters.sendmessage.Show();
                Parameters.sendmessagestate = true;
                this.Hide();
            }
        }
        //地图
        private void btnMap_Click(object sender, EventArgs e)
        {
            if(!Parameters.showmap)
            { 
                 UIMap map = new UIMap();
                 Parameters.showmap = true;
                 map.Show();
                 this.Hide();
            }
        }
        //发现
        private void pboxexplore_Click(object sender, EventArgs e)
        {
            if (!Parameters.explorestate)
            {
                Parameters.explorestate = true;
                Parameters.explore.Refresh();
                Parameters.explore.Show();

                Parameters.userpagestate = false;
                this.Hide();
            }
            else 
            {
                MessageBox.Show("发现已经打开","提示");
            }
        }
        //主页
        private void pboxhomepage_Click(object sender, EventArgs e)
        {
            if (!Parameters.homepagestate)
            {
                Parameters.homepage.InitializeForm();
                Parameters.homepage.Refresh();
                Parameters.homepage.Show();
                Parameters.homepagestate = true;
                Parameters.userpagestate = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("主页已经打开", "提示");
            }
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.btnBack.Text == "返回")
            {
                this.btnBack.Text = "退出";
                this.tabControl1.TabPages.Add(tabPage1);
                this.tabControl1.TabPages.Add(tabPage2);
                this.tabControl1.TabPages.Remove(srchResult);
            }
            else
            {
                if (MessageBox.Show("是否要退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void tboxSrch_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void tboxSrch_MouseDown(object sender, MouseEventArgs e)
        {
            this.tboxSrch.ForeColor = Color.Black;
            this.tboxSrch.Text = "";
        }

    }
}
