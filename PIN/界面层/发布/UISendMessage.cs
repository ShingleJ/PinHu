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
using System.IO;

namespace PIN
{
    public partial class UISendMessage : Form
    {
        /*******************************/
        public String SortClass1 = "购物";
        public String Content = null;
        ImageList imageList;
        UIFaceImageList faceimage;
        public string allowpeople = null;
        /*******************************/
        #region 初始化
        public UISendMessage()
        {
            InitializeComponent();
            this.rbtnAnyone.Checked = true;
        }
               
        private void SendMessage_Load(object sender, EventArgs e)
        {
            //日历
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm";
            //表情
            imageList = new ImageList();
            imageList.ImageSize = new Size(32,32);
            imageList.ColorDepth = ColorDepth.Depth24Bit;     //24位的带alpha通道的可以直接透明
            imageList.Images.AddStrip(new Bitmap(GetType(),"face.bmp"));  //加载资源表情图片
            faceimage = new UIFaceImageList();
            faceimage.Init(imageList, 8, 8, 19, 6);
            faceimage.ItemClick += new FaceImagelistEventHandler(faceimage_ItemClick);
        }
        #endregion  

        #region  位置、发布、选择表情、@某人、字数统计、关闭表单
        //位置按钮
        private void btnLocate_Click(object sender, EventArgs e)
        {
            UILocate locate = new UILocate();
            locate.Show();
        }

        //发布按钮
        private void btnSendout_Click(object sender, EventArgs e)
        {
            if(this.tboxcontent.Text.Length!=0)
            {
                //先存到整的数据库里面
              SendMessageClass sm = new SendMessageClass();
               if (sm.Insert(tboxcontent.Text, dateTimePicker1.Value.ToString(), SortClass1,Parameters.atfriend,allowpeople))
               {

                   MessageBox.Show("发布成功！");
                   this.tboxcontent.Text = "";
                   allowpeople = null;
                   Parameters.atfriend = null;
                   dateTimePicker1.Value = DateTime.Now;
               }
               else 
               {

                   MessageBox.Show("发布失败！");
               } 
            }
            else
            {
                MessageBox.Show("请先填写事件内容");
            }
            ////再存到分的数据库里面
            //SaveBasedSort sbs = new SaveBasedSort();
            //sbs.InsertClassDatabase(richTextBox1.Text, dateTimePicker1.Value.ToString(), SortClass1);
            //Parameters.personahomepage = new personalHomepage();
            //Parameters.personahomepage.Show();    
       
        }

        //选择了某个表情
        void faceimage_ItemClick(object sender, FaceImageListEventArgs ilpea)
        {
            Image img = imageList.Images[ilpea.SelectedItem];
            Clipboard.SetDataObject(img);
            tboxcontent.ReadOnly = false;
            tboxcontent.Paste(DataFormats.GetFormat(DataFormats.Bitmap));  
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            if(!Parameters.atfristate)
            {
                UIatFriends atfr = new UIatFriends(this);
                atfr.Show();
            }
       
        }

        private void tboxcontent_TextChanged(object sender, EventArgs e)
        {
            tboxcontent.ForeColor = Color.Black;
            int textlength = 140 - tboxcontent.Text.Length;
            lblWordnum.Text = textlength.ToString()+"/140字";
            
        }

        private void btnFace_Click(object sender, EventArgs e)//添加表情
        {
            Point pt = PointToScreen(new Point(this.btnFace.Left, btnFace.Top));
            faceimage.Show(pt.X, pt.Y + 200);
        }

        private void llblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Parameters.homepage.InitializeForm();
            Parameters.userpage.InitializeForm();
            if (Parameters.explorestate)//刚才是发现
            {
                Parameters.explore.Refresh();
                Parameters.explorestate = true;
                Parameters.explore.Show();
            }
            else if (Parameters.userpagestate)//刚才是-我
            {
                Parameters.userpage.Refresh();
                Parameters.userpagestate = true;
                Parameters.userpage.Show();
            }
            else if (Parameters.homepagestate)//刚才是主页
            {
                Parameters.homepage.Refresh();
                Parameters.homepagestate = true;
                Parameters.homepage.Show();
            }
            Parameters.sendmessagestate = false;
            Parameters.atfriend = null;
            this.Hide();//关闭此窗口

        }
        #endregion

        #region 选择分类
        private void btnTravel_Click(object sender, EventArgs e)
        {
            tboxcontent.Text = "【"+btnTravel.Text+"】" + tboxcontent.Text;
            SortClass1 = "旅游";
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            tboxcontent.Text = "【" + btnCar.Text + "】" + tboxcontent.Text;
            SortClass1 = "拼车";
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            tboxcontent.Text = "【" + btnFood.Text + "】" + tboxcontent.Text;
            SortClass1 = "美食";
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            tboxcontent.Text = "【" + btnShopping.Text + "】" + tboxcontent.Text;
            SortClass1 = "购物";
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            tboxcontent.Text = "【" + btnSport.Text + "】" + tboxcontent.Text;
            SortClass1 = "健身";
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            tboxcontent.Text = "【" + btnFilm.Text + "】" + tboxcontent.Text;
            SortClass1 = "电影";
        }
        #endregion

        #region 选择可见性 
        //所有人
        private void rbtnAnyone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAnyone.Checked)
            {
                rbtnPartFriend.Checked = false;
                rbtnFriend.Checked = false;
                rbtnPrivate.Checked = false;
                Parameters.messlevel = 0;
            }
        }
        //部分好友
        private void rbtnFriend_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFriend.Checked)
            {
                rbtnAnyone.Checked = false;
                rbtnPartFriend.Checked = false;
                rbtnPrivate.Checked = false;
                Parameters.messlevel = 2;
                UIChooseFriends cfr = new UIChooseFriends(this);
                cfr.Show();
            }
        }
        //
        private void rbtnPartFriend_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPartFriend.Checked)
            {
                rbtnAnyone.Checked = false;
                rbtnFriend.Checked = false;
                rbtnPrivate.Checked = false;
                Parameters.messlevel = 1;
            }
        }
        private void rbtnPrivate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrivate.Checked)
            {
                rbtnAnyone.Checked = false;
                rbtnPartFriend.Checked = false;
                rbtnFriend.Checked = false;
                Parameters.messlevel = 3;
            }
        }

        public RichTextBox RTBtest
        {
            get
            {
                return this.tboxcontent;
            }
        }
                #endregion        

        #region 无引用
        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnTravel.BackColor = System.Drawing.Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnTravel.BackColor = this.BackColor;
        }

        #endregion
    }
}
