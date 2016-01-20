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
    public partial class UIFollowList : Form
    {
        public UIFollowList()
        {
            InitializeComponent();
        }


        private void UIFollowList_Load(object sender, EventArgs e)
        {
            LoadFollowList();
        }

        private void LoadFollowList()
        {
            String connectionString = Parameters.user_info;
            String commandTextQuery = "select FollowUser_UserName from FollowUser where FollowUser_FollowerName = '" + Parameters.username + "';";
            string userConstr = Parameters.user_info;
            DTConnection con = new DTConnection();

            //读数据库
            List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);

            //显示
            ShowFollowList(reader);

        }

        private void ShowFollowList(List<String[]> read)
        {
            panel1.AutoScroll = true;

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

                    string tname = read[i][0];
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
                    richtextbox.Text = read[i][0];

                    Button btnToKnowOther = new Button();
                    btnToKnowOther.Text = "详情";
                    btnToKnowOther.Name = read[i][0];
                    btnToKnowOther.Location = new System.Drawing.Point(260, 20);
                    btnToKnowOther.Width = 50;
                    btnToKnowOther.Height = 25;
                    btnToKnowOther.Click += new EventHandler(btnToKnowOther_Click);

                    Button btnFollow = new Button();
                    btnFollow.Name = read[i][0];
                    //查看是否已关注
                    string selectstr = "select * from FollowUser where FollowUser_FollowerName ='" + Parameters.username + "' and FollowUser_UserName='" + read[i][0] + "'";
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
                    panel1.Controls.Add(studentUserGroup);
                }
            }
            else
            {
                TextBox text = new TextBox();
                text.Multiline = true;
                text.Location = new System.Drawing.Point(50, 15);
                text.Width = 241;
                text.Height = 200;
                text.Text = "您暂无粉丝";
                panel1.Controls.Add(text);
            }
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

       //返回
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
