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
using System.Drawing.Drawing2D;
using System.IO;
//using PIN.界面层;

namespace PIN
{
    public partial class UIExplore : Form
    {
        public UIExplore()
        {
            InitializeComponent();
        }
        /*******************************/
        //搜素后显示

        TabControl tabcon = new TabControl();
        public bool searchpage = false;

        //初始化，加载tab
        private void Form1_Load(object sender, EventArgs e)
        {
            this.pboxExplore.BackColor = Color.Gray;
            tabcon.Width = 340;
            tabcon.Height = 300;
            tabcon.Location = new System.Drawing.Point(10, textBox1.Location.Y + 40);
            //tabcon.Controls.Add(tabpage);
            this.Controls.Add(tabcon);
            Parameters.explorestate = true;

        }
 
        //增加显示控件
        public GroupBox AddShow(String[]reader,int flag)
        {
            String username=reader[2];
            String information = reader[7];

            GroupBox grbox = new GroupBox();

            grbox.Width = 300;
            grbox.Height = 120;

            //richtextbox
            RichTextBox richtextbox = new RichTextBox();
            richtextbox.Width = 241;
            richtextbox.Height = 74;
            //richtextbox.ScrollBars = both;
            richtextbox.Location = new System.Drawing.Point(50, 15);
            richtextbox.Text = information;
            //头像的位置
            PictureBox pictbox = new PictureBox();
            pictbox.Width = 42;
            pictbox.Height = 42;
            pictbox.Location = new System.Drawing.Point(3, 35);
            pictbox.BackColor = Color.MistyRose;
            DTConnection con = new DTConnection();
            string tname = reader[2];
            string seleiconpath = "select * from StudentInfo where StudentInfo_NickName ='" + tname + "'";
            string constr = Parameters.user_info;
            List<String[]> reader2 = con.ReadCon(seleiconpath, constr);
            string fllpath = new DirectoryInfo("../../../").FullName + reader2[0][11];
            if (!File.Exists(fllpath))
            {
                fllpath = new DirectoryInfo("../../../").FullName + @"picture\icon\doge.ico";
            }
            pictbox.SizeMode = PictureBoxSizeMode.Zoom;
            pictbox.Image = Image.FromFile(fllpath);
            //在richBox之下
            //想拼
            LinkLabel llblAccept = new LinkLabel();
            llblAccept.Text = "我想拼";
            llblAccept.Location = new System.Drawing.Point(50, 94);//相对应groupBox的
            llblAccept.Name = reader[0].ToString();
            llblAccept.Click += new EventHandler(llblAccept_Click);
            //收藏
            LinkLabel llblCollect = new LinkLabel();
            llblCollect.Text = "收藏";
            llblCollect.Location = new System.Drawing.Point(150, 94);//相对应groupBox的
            llblCollect.Name = reader[0].ToString() + ',' + reader[1].ToString() + ',' + reader[2].ToString() + ',' + reader[3].ToString() + ',' + reader[4].ToString() + ',' + reader[5].ToString() + ',' + reader[6].ToString() + ',' + reader[7].ToString() + ',' + reader[8].ToString() + ',' + reader[9].ToString() + ',' + reader[10].ToString() + ',' + reader[11].ToString();
            llblCollect.Click += new EventHandler(llblCollect_Click);
            //更多
            LinkLabel llblMore = new LinkLabel();
            llblMore.Text = "更多";
            llblMore.Location = new System.Drawing.Point(260, 94);//相对应groupBox的
            llblMore.Name = reader[0].ToString() + ',' + reader[2];
            llblMore.Click += new EventHandler(llblMore_Click);
            //用户名
            Label label = new Label();
            label.Text = username;
            label.Location = new System.Drawing.Point(3, 78);

            grbox.Controls.Add(richtextbox);
            grbox.Controls.Add(llblAccept);
            grbox.Controls.Add(llblCollect);
            grbox.Controls.Add(llblMore);
            grbox.Controls.Add(pictbox);
            grbox.Controls.Add(label);
            grbox.Location = new System.Drawing.Point(10, 10 + (flag++) * 120);//相对应tabpage的
            return grbox;

        }

        #region 按钮：登陆，退出，搜索，旅游，健身，拼车，电影，美食，购物
        //点击登录,若未登录则登陆，若已登陆则提示
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Parameters.haslogined)
            {  //未登录
                this.Hide();
                Parameters.explorestate = false;
                UILogin r = new UILogin();
                r.Show();
            }
            else
            {
                MessageBox.Show("您已登陆！");
            }
           
        }
        
        //点击搜索后,加载搜索结果
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length!=0)
            {
                String keyword = textBox1.Text;//搜素关键字
                UISearch srch = new UISearch(keyword);
                srch.Show();
            }
            else
            {
                MessageBox.Show("输入搜索项");
            }

        }


        //点击退出后,退出发现界面
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("现在退出拼乎吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }


        //点击旅游，分类显示相关信息
        private void btnTravel_Click(object sender, EventArgs e)
        {
            String keyword ="旅游";//搜素关键字
            UISearch srch = new UISearch(keyword);
            srch.Show();
            this.Hide();
            
        }

        //点击健身，分类显示相关信息
        private void btnSports_Click(object sender, EventArgs e)
        {
            String keyword = "健身";//搜素关键字
            UISearch srch = new UISearch(keyword);
            srch.Show();
            this.Hide();
        }

        //点击拼车，分类显示相关信息
        private void btnCar_Click(object sender, EventArgs e)
        {
            String keyword = "拼车";//搜素关键字
            UISearch srch = new UISearch(keyword);
            srch.Show();
            this.Hide();
        }

        //点击电影，分类显示相关信息
        private void btnFilm_Click(object sender, EventArgs e)
        {
            String keyword = "电影";//搜素关键字
            UISearch srch = new UISearch(keyword);
            srch.Show();
            this.Hide();
        }

        //点击美食，分类显示相关信息
        private void btnFood_Click(object sender, EventArgs e)
        {
            String keyword = "美食";//搜素关键字
            UISearch srch = new UISearch(keyword);
            srch.Show();
            this.Hide();
        }

        //点击购物，分类显示相关信息
        private void btnShopping_Click(object sender, EventArgs e)
        {
            String keyword = "购物";//搜素关键字
            UISearch srch = new UISearch(keyword);
            srch.Show();
            this.Hide();
        }
        #endregion

        #region 按钮: 主页，发现，发布，我
        //跳转到主页
        private void pboxHomepage_Click(object sender, EventArgs e)
        {
            
            if (!Parameters.homepagestate && Parameters.haslogined)
            {
                //主页未打开且已登陆
                this.Close();
                Parameters.homepage.Show();
                Parameters.homepagestate = true;
                Parameters.explorestate = false;
            }
            else if (!Parameters.haslogined)
            {
                MessageBox.Show("请先登录!", "提示");
            }
            else
            {
                MessageBox.Show("主页已打开!", "提示");
            }

        }

        //点击发现后
        private void pboxExplore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这就是发现!", "提示");
        }

        //跳转到发布
        private void pboxSendmsge_Click(object sender, EventArgs e)
        {
            if (!Parameters.sendmessagestate && Parameters.haslogined)
            {
                //发布信息未打开且已登陆
                this.Hide();//一会儿还要弹出
                Parameters.sendmessage.Show();
                Parameters.sendmessagestate = true;
            }
            else if (!Parameters.haslogined)//未登录
            {
                MessageBox.Show("请先登录!", "提示");
            }
            else//其他情况
            {
                MessageBox.Show("发布已打开!", "提示");
            }
            //this.Close();
            //UISendMessage sm = new UISendMessage();
            //sm.Show();
        }

        //跳转到我
        private void pboxMe_Click(object sender, EventArgs e)
        {
            if (!Parameters.userpagestate && Parameters.haslogined)
            {
                //我-信息未打开且已登陆
                this.Hide();
                Parameters.userpage.Show();
                Parameters.explorestate = false;
                Parameters.userpagestate = true;
            }
            else if (!Parameters.haslogined)
            {
                MessageBox.Show("请先登录!", "提示");
            }
            else
            {
                MessageBox.Show("已打开!", "提示");
            }
            //this.Close();
            //UIpersonalHomepage ph = new UIpersonalHomepage();
            //ph.Show();
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

        #endregion



        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBox1.ForeColor = Color.Black;
            this.textBox1.Text = "";
        }
    }
}
