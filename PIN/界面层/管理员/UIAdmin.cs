using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace PIN
{
    public partial class UIAdmin : Form
    {

        #region 初始化
         int flagi = 0;// 控件位置标记
         List<String[]> readerResult1 = new List<string[]>();
         DTConnection dtcon = new DTConnection();
         public UIAdmin()
        {
            InitializeComponent();
        }    

        private void UIhomepage_Load(object sender, EventArgs e)//载入 显示
        {
            //InitializeForm();
            Parameters.adminstate = true;
            this.lblEvents.Text = "管理员:"+Parameters.username;
            lblEventnum.Text = "待处理事件数："+Select().ToString();
        }
        #endregion

        #region 查询显示
        public int Select()
        {
            String connectionString = Parameters.event_info;
            String commandQuery = "Select * from ReportEvent order by ReportEvent_ReportCount;";
            List<String[]> readerResult = dtcon.ReadCon(commandQuery,connectionString);
            //显示
            for(int i = 0;i < readerResult.Count;i++)
            {
                //读取事件内容
                 String connectionString1 = Parameters.event_info;
                 int ID = int.Parse(readerResult[i][0].ToString());
                 String commandQuery1 = "Select Event_Content from AllEvents where Event_Id = "+ ID +";";
                readerResult1 = dtcon.ReadCon(commandQuery1,connectionString1);
                String EventContent = readerResult1[0][0].ToString();
                //现在在控件里
                this.panel1.Controls.Add(AddControl(int.Parse(readerResult[i][0]), int.Parse(readerResult[i][3]), readerResult[i][1], EventContent, readerResult[i][2]));
            }
            int count = readerResult.Count;
            return count;
        }
        #endregion
      
        #region 布置界面、控件
        public GroupBox AddControl(int EventId,int ReportCount,String reporters,String EventContent, String Reason)
        {
            //谁举报
            int count = ReportCount;
            String ThreeNames = reporters;
            GroupBox grbox = new GroupBox();
            grbox.Text = ThreeNames +"等人" + count + "举报";
            grbox.Name = EventId.ToString();
            grbox.Width = 620;
            grbox.Height = 130;
            grbox.Location = new System.Drawing.Point(10, 15 + flagi++ * 130);

            //richtextbox 消息内容
            RichTextBox richtextbox = new RichTextBox();
            richtextbox.Width = 580;
            richtextbox.Height = 65;
            richtextbox.Location = new System.Drawing.Point(20, 15);
            richtextbox.Text = EventContent;

           
            //选择处理结果   
            ComboBox select = new ComboBox();
            select.Width = 200;
                select.Text = "选择处理意见";
                select.Items.Add("举报通过审核，冻结事件！");
                select.Items.Add("驳回举报，不冻结事件！");

                select.Location = new System.Drawing.Point(richtextbox.Location.X + 350, richtextbox.Height + 20);
                select.Name = EventId.ToString();
                //select.Click += new EventHandler(select_Click);
                select.SelectedIndexChanged += new EventHandler(chooseControl);

            //举报原因
            Label label1 = new Label();
            label1.Width = 150;
            label1.Text = "举报原因："+Reason;
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new System.Drawing.Point(richtextbox.Location.X + 15, richtextbox.Height + 20);
            //处理意见：
            Label label2 = new Label();
            label2.Width = 70;
            label2.Text = "处理意见";
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new System.Drawing.Point(richtextbox.Location.X + 280, richtextbox.Height + 20);

            grbox.Controls.Add(label1);
            grbox.Controls.Add(label2);
            grbox.Controls.Add(richtextbox);
            grbox.Controls.Add(select);
            return grbox;
        }
        #endregion

        #region   下拉框选择处理意见
        private void chooseControl(object sender, EventArgs e)
        {
            ComboBox cbox = sender as ComboBox;
            int idc = int.Parse(cbox.Name);
            int select = cbox.SelectedIndex;
            //举报事件信息
            String connectionString = Parameters.event_info;
            String commandQuery = "Select * from ReportEvent where ReportEvent_EventId = " + idc + ";";
            List<String[]> readerResult = dtcon.ReadCon(commandQuery, connectionString);
            //获取发布者、事件内容
            String commandQuery1 = "Select Event_Publisher,Event_content from AllEvents where Event_Id = " + idc + ";";
            List<String[]> readerResult1 = dtcon.ReadCon(commandQuery1, connectionString);
            if (select == 0)//冻结
            {
                //记录此次处理举报事件的行为   
                //插入到冻结数据库中
                String Event_Publisher = readerResult1[0][0].ToString();
                String reason = readerResult[0][2].ToString();
                String Reporters = readerResult[0][1].ToString();
                String admin = Parameters.username;
                String dealtime = DateTime.Now.ToString("yyyy-MM-dd " + "HH:mm:ss");
                string insertStr = "insert into FrozenEvent(FrozenEvent_EventID,FrozenEvent_Publisher,FrozenEvent_Reporters,FrozenEvent_Reason,FrozenEvent_Admin,FrozenEvent_DealTime)VALUES(" + idc + ",'" + Event_Publisher + "','" + Reporters + "','" + reason + "','" + admin + "','" + dealtime + "');";      
                dtcon.InsertDelCon(insertStr, connectionString);
                //在AllEvent中将这个事件的状态改为冻结
                String connectionString3 = Parameters.event_info;
                String commandUpdate = "Update AllEvents set Event_State = " + "'冻结'" + "where Event_Id = " + idc + ";";
                dtcon.UpdateCon(commandUpdate, connectionString3);
                //通知发布者
                //插入项
                String Event_content = readerResult1[0][1].ToString();
                String publisher = Event_Publisher;
                String content = "您发布的消息:" + Event_content + " 因[" + reason + "]被人举报,经审核,已被删除！";
                int authority = Parameters.messlevel;
                String state = "通知";
                String cmdEventInsert = "insert into AllEvents(Event_Publisher,Event_Content,Event_Authority,Event_State) values('" + publisher + "','" + content + "','" + authority + "','" + state + "');";
                dtcon.InsertDelCon(cmdEventInsert, connectionString);
                //通知所有举报者

                //此页面刷新一次，此事件不显示，从举报数据库中删除
                String connectionString4 = Parameters.event_info;
                String commandDelete = "Delete from ReportEvent where ReportEvent_EventId = " + idc + ";";
                int r = dtcon.InsertDelCon(commandDelete, connectionString4);
                if (r >= 1)
                {
                    MessageBox.Show("事件已冻结！");
                }
                else
                {
                    MessageBox.Show(" 操作失败！");
                }
                readerResult.Clear();
                readerResult1.Clear();
                flagi = 0;
                panel1.Controls.Clear();
                lblEventnum.Text = "待处理事件数：" + Select().ToString();
                this.panel1.Refresh();
                this.Refresh();
            }
            else if (select == 1)//未通过举报
            {
                //通知所有举报者
                //插入项
                String Event_content = readerResult1[0][1].ToString();//事件内容
                String reporters = readerResult[0][1].ToString();//举报者
                //List<String> repo = new List<String>();
                String[] friendArray;
                if(reporters.Contains("、"))//有多个举报者
                {
                    friendArray = reporters.Split('、');
                    for (int i = 0; i < friendArray.GetLength(0); i++)
                    {
                        String reporter = friendArray[i];
                        String content = "您举报的消息:" + Event_content + " 并无违规现象，未通过审核！";
                        int authority = Parameters.messlevel;
                        String state = "通知";
                        String cmdEventInsert = "insert into AllEvents(Event_Publisher,Event_Content,Event_Authority,Event_State) values('" + reporter + "','" + content + "','" + authority + "','" + state + "');";
                        dtcon.InsertDelCon(cmdEventInsert, connectionString);
                    }
                }
                else//只有一个举报者
                {
                    String reporter = reporters;
                    String content = "您举报的消息:" + Event_content + "并无违规现象，未通过审核！";
                    int authority = Parameters.messlevel;
                    String state = "通知";
                    String cmdEventInsert = "insert into AllEvents(Event_Publisher,Event_Content,Event_Authority,Event_State) values('" + reporter + "','" + content + "','" + authority + "','" + state + "');";
                    dtcon.InsertDelCon(cmdEventInsert, connectionString);
                }
                MessageBox.Show(" 已通知举报者！");
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
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {

        }



        

    }
}
