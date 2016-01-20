using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace PIN
{
    public partial class UIhomepage : Form
    {
       

        #region 初始化
         int flagi = 0;// 控件位置标记

        public UIhomepage()
        {
            InitializeComponent();
        }    

        private void UIhomepage_Load(object sender, EventArgs e)//载入 显示
        {
            InitializeForm();
            Parameters.homepagestate = true;
            this.lblTitle.Text = Parameters.username+"的主页";
        }
        
        public void InitializeForm()
        {
            this.lblTitle.Text = Parameters.username;//窗口标题
            flagi = 0;
            this.panel1.Controls.Clear();//清空控件
            String Event_constr = Parameters.event_info;
            string User_constr = Parameters.user_info;
            /************************/
            //加载自己发布的所有拼事件
            String name = Parameters.username;
            String QueryMyEvents = "select * from AllEvents where Event_Publisher = '" + name + "' order by Event_PublishTime desc;";
            DTConnection con = new DTConnection();
            List<String[]> record = con.ReadCon(QueryMyEvents, Event_constr);
            //通过循环列表显示查询结果集
            int recordnum = record.Count;
            if (recordnum > 0)
            {
                for (int i = 0; i < recordnum; i++)
                {
                    //ID，content，类别，发布时间
                    this.panel1.Controls.Add(AddControl(int.Parse(record[i][0].ToString()), record[i][7].ToString(), record[i][6].ToString(), record[i][3].ToString(), record[i][1].ToString()));
                }
            }
            else
            {
                //MessageBox.Show("你还没有发布信息哦！");
            }
            //读头像
            string fieldname = Parameters.userFieldname[Parameters.usertype] + "_NickName";
            string tablename = Parameters.userTablename[Parameters.usertype];
            String QueryMyIcon = "select * from " + tablename + " where " + fieldname + " = '" + Parameters.username + "' ;";
            List<String[]> iconlist = con.ReadCon(QueryMyIcon, User_constr);
            string tpath = new DirectoryInfo("../../../").FullName+iconlist[0][11].ToString();
            //头像和ID
            Parameters.id = iconlist[0][10].ToString();
            if (File.Exists(tpath))
            {
                Parameters.iconfullpath = tpath;
            }
            this.pboxFace.SizeMode = PictureBoxSizeMode.Zoom;
            this.pboxFace.Image = Image.FromFile(Parameters.iconfullpath);
            UpdateTag();
 

        }

        //粉丝数，事件数，关注数更新
        public void UpdateTag()
        {
            DTConnection con = new DTConnection();
            String name = Parameters.username;
            //粉丝数
            String SelectFollower = "select * from FollowUser where FollowUser_UserName = '" + name + "';";
            string userConstr = Parameters.user_info;
            List<String[]> Follower = con.ReadCon(SelectFollower, userConstr);
            this.lblFollowerNum.Text = Follower.Count.ToString();
            //关注数
            String SelectFollow = "select * from FollowUser where FollowUser_FollowerName = '" + name + "';";
            List<String[]> record2 = con.ReadCon(SelectFollow, userConstr);
            this.lblFollowNum.Text = record2.Count.ToString();
            //事件数
            String SelectEvent = "select * from AllEvents where Event_Publisher = '" + name + "';";
            string eventConstr = Parameters.event_info;
            List<String[]> record3 = con.ReadCon(SelectEvent, eventConstr);
            this.lblEventnum.Text = record3.Count.ToString();
        }
        //向GroupBox添加控件
        public GroupBox AddControl(int id,String information, String Class1, String date,String State)
        {
            //每一个消息 一个GroupBox
            //////
            GroupBox grbox = new GroupBox();
            grbox.Name = id.ToString();
            grbox.Width = 320;
            grbox.Height = 125;
            grbox.Location = new System.Drawing.Point(10, 10 + flagi++ * 120);

            //richtextbox 消息内容
            RichTextBox richtextbox = new RichTextBox();
            richtextbox.Width = 250;
            richtextbox.Height = 74;
            //richtextbox.ScrollBars = both;
            richtextbox.Location = new System.Drawing.Point(20, 12);
            richtextbox.Text = information;

            //在richBox之下 显示已拼还是未拼
            //button
            Button statei = new Button();
            statei.Width = 80;
            statei.Text = State.Trim();
            if (State.Trim() == "未拼")
            {
                statei.BackColor = Color.Red;
            }
            else if (State.Trim() == "已拼")
            {
                statei.BackColor = Color.Green;
            }
            else if (State.Trim() == "收藏")
            {
                statei.BackColor = Color.Yellow;
            }
            else if (State.Trim() == "好友分享")
            {
                statei.BackColor = Color.PaleGreen;
            }
            else if (State.Trim() == "好友@")
            {
                statei.BackColor = Color.Purple;
            }
            else
            {
                statei.BackColor = Color.Blue;
            }
            
            statei.Location = new System.Drawing.Point(richtextbox.Location.X, richtextbox.Height + 15);
            statei.Name = id.ToString();
            statei.Click += new EventHandler(statei_Click);
            //statei.Click += state_Click;
            //state.Add(statei);
            //删除按钮
            Button delete = new Button();
            delete.Width = 40;
            delete.Text = "删除";
            delete.Location = new System.Drawing.Point(richtextbox.Location.X + 210, richtextbox.Height + 15);
            delete.Name = id.ToString();
            delete.Click +=new EventHandler(deleteEvent);
            //选择好友     
            ComboBox select = null;
            if (State.Trim() == "未拼")
            {
                select = new ComboBox();
                select.Text = "选择拼友";
                select.Location = new System.Drawing.Point(richtextbox.Location.X + 85, richtextbox.Height + 16);
                select.Name = id.ToString();
                select.Click += new EventHandler(addCandi_Follower);
                select.SelectedIndexChanged += new EventHandler(chooseFollower);
            }

            //时间
            Label label1 = new Label();
            label1.Text = date;
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new System.Drawing.Point(richtextbox.Location.X + 100, richtextbox.Height - 10);
            //分类
            Label label2 = new Label();
            label2.Text = "分类：" + Class1;
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new System.Drawing.Point(richtextbox.Location.X + 10, richtextbox.Height - 10);

            grbox.Controls.Add(label1);
            grbox.Controls.Add(label2);
            grbox.Controls.Add(richtextbox);
            grbox.Controls.Add(statei);
            grbox.Controls.Add(delete);
            grbox.Controls.Add(select);
            return grbox;
        }

        #endregion

        #region    按钮：更改事件状态，加载合拼者，删除事件，选择合拼者,编辑资料，设置
        
        //点击未拼更改拼状态
        void statei_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "未拼")
            {
                btn.BackColor = Color.Green;
                btn.Text = "已拼";
                int IDc = int.Parse(btn.Name);
                String connectionString = Parameters.event_info;
                DTConnection con = new DTConnection();
                String commandUpdate = "update AllEvents set Event_State = " + "'已拼'" + " where Event_Id = " + IDc + ";";
                con.UpdateCon(commandUpdate, connectionString);
            }
            else
            {
                MessageBox.Show("事件已拼成功");
            }
        }


        //下拉框加载拼友
        void addCandi_Follower(object sender, EventArgs e)
        {
            ComboBox cbox = sender as ComboBox;
            cbox.Items.Clear();
            int id = int.Parse(cbox.Name);
            String connectionString = Parameters.event_info;
            String commandSelect = "select Event_Follower from AllEvents where Event_Id = " + id + ";";
            DTConnection con = new DTConnection();
            List<String[]> reader = con.ReadCon(commandSelect, connectionString);
            string[] friendArray = reader[0][0].Split(',');
            if (reader.Count > 0)
            {
                for (int i = 0; i < friendArray.Length; i++)
                {
                    cbox.Items.Add(friendArray[i]);
                }
            }
            else
            {
                MessageBox.Show("暂无接洽者，请耐心等待！");
            }
        }

        // 删除信息
        void deleteEvent(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int idc = int.Parse(btn.Name);
            String connectionString = Parameters.event_info;
            String commandDelete = "Delete from AllEvents where Event_Id = " + idc + ";";
            DTConnection con = new DTConnection();
            int result = con.InsertDelCon(commandDelete, connectionString);
            if (result == 1)
            {
                panel1.Refresh();
                this.Refresh();
                InitializeForm();
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
            UpdateTag();
        }

        // 下拉框选择拼友
        private void chooseFollower(object sender, EventArgs e)
        {
            ComboBox cbox = sender as ComboBox;
            int idc = int.Parse(cbox.Name);
            int select = cbox.SelectedIndex;
            String connectionString = Parameters.event_info;
            String followername = cbox.SelectedItem.ToString();
            String commandUpdate = "update AllEvents set Event_Follower = '" + followername + "' where Event_Id=" + idc + ";";
            DTConnection con = new DTConnection();
            try
            {
                con.UpdateCon(commandUpdate, connectionString);
                cbox.Visible = false;
                MessageBox.Show("此事件接洽成功！\n系统将立即通知[" + followername + "],也请您尽快与之联系.");
                //修改数据库
                int IDc = int.Parse(cbox.Name);
                String constr = Parameters.event_info;
                String Update = "update AllEvents set Event_State = " + "'已拼'" + " where Event_Id = " + IDc + ";";
                con.UpdateCon(Update, constr);
                InitializeForm();
            }
            catch
            {
                MessageBox.Show("对不起，请稍后重试！");
            }
            
        }

        //点击个人信息按钮，获得用户类型，打开编辑资料窗口 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int flag = Parameters.usertype;
            if (flag == 0)
            {
                UIMoreStudentInfo ipi = new UIMoreStudentInfo();
                ipi.Show();
            }
            else if (flag == 1)
            {
                UIMoreMerchantInfo imi = new UIMoreMerchantInfo();
                imi.Show();
            }
            else if (flag == 2)
            {
                UIMoreAdminInfo iai = new UIMoreAdminInfo();
                iai.Show();
            }
            
        }

        //点击设置按钮，打开设置窗口
        private void btnSet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parameters.homepagestate = false;
            if(!Parameters.settingstate)
            {
                UISetting set = new UISetting(this);
                set.Show();
            }
            
        }

        #endregion

        #region 界面转换:   点击拼乎图标、主页、发现、发布、我、退出

        //点击拼乎图标，转到朋友圈事件
        private void pboxIcon_Click(object sender, EventArgs e)
        {
            if (!Parameters.userpagestate && Parameters.haslogined)
            {
                //主页-信息未打开且已登陆
                //this.Hide();对应hide
                Parameters.homepage.Show();
                Parameters.homepagestate= true;
            }
        }

        //点击1-主页，提示已在主页
        private void pbxHomepage_Click(object sender, EventArgs e)
        {
            if (!Parameters.homepagestate)
            {
                this.Close();
                Parameters.homepage.Show();
                Parameters.homepagestate = true;
            }
            else
            {
                MessageBox.Show("这就是主页！", "提示");
            }
        }

        //点击“2-发现”，打开发现窗口(不一定要注册)
        private void pboxExplore_Click(object sender, EventArgs e)
        {
            if (!Parameters.explorestate)
            { 
                this.Hide();
                Parameters.homepagestate = false;

                Parameters.explore.Show();
                Parameters.explorestate = true;
            }
        }

        //点击“3-发步”，打开发布信息窗口
        private void pboxSendmsge_Click(object sender, EventArgs e)
        {
            if (!Parameters.sendmessagestate&&Parameters.haslogined)
            {
                this.Hide();
                UISendMessage smg = new UISendMessage();
                Parameters.sendmessage = smg;
                Parameters.sendmessage.Show();
                Parameters.sendmessagestate = true;
            }
        }

        //点击“4-我”，转到好友圈事件
        private void pboxUserpage_Click(object sender, EventArgs e)
        {

            if (!Parameters.userpagestate && Parameters.haslogined)
            {
                Parameters.userpage.InitializeForm();
                Parameters.userpage.Show();
                Parameters.userpagestate = true;
                this.Hide();
                Parameters.homepagestate = false;
            }
            else 
            {
                MessageBox.Show("已经打开了~","提示");
            }
        }

        //点击退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要退出本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }  
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {
            //查看关注的人
            UIFollowList followlist = new UIFollowList();
            followlist.Show();
        }

        private void lblEventnum_Click(object sender, EventArgs e)
        {

        }

        private void lblFollower_Click(object sender, EventArgs e)
        {
            //查看粉丝
            UIFansList fanlist = new UIFansList();
            fanlist.Show();
        }



        

    }
}
