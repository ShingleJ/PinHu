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
    public partial class UIReportReason : Form
    {
        #region 变量
        /**********/
        public int thiseventid ;
        public String  ReportReason;
        UIDetails UIdetails;
        #endregion

        public UIReportReason(int EventIDc,UIDetails uidetails)
        {
            thiseventid = EventIDc;
            UIdetails = uidetails;
            InitializeComponent();
        }

        private void UIReportReason_Load(object sender, EventArgs e)//显示举报信息
        {
            String connectionString1 = Parameters.event_info;
            String commandQuery = "Select Event_Publisher,Event_Content from AllEvents where Event_Id = "+thiseventid+";";
            DTConnection dt = new DTConnection();
            List<String[]> reader = dt.ReadCon(commandQuery,connectionString1);
            richTextBox1.Text = reader[0][1].ToString().Trim(); 
            label1.Text = "举报用户" + reader[0][0].ToString().ToString().Trim()+ "的事件：";
        }
        #region 生成举报信息
        private void button1_Click(object sender, EventArgs e)
        {
            String Reporters = null;
            int count = 0;
             String connectionString1 = Parameters.event_info;
            //查询是否已经存在
             using (SqlConnection connection = new SqlConnection(connectionString1))
             {
                 connection.Open();
                 String commandQuery = "Select ReportEvent_Reporters,ReportEvent_ReportCount from ReportEvent where ReportEvent_EventID = " + thiseventid + ";";
                 SqlCommand cmdQuery = new SqlCommand(commandQuery, connection);
                 SqlDataReader sdr = cmdQuery.ExecuteReader();
                 sdr.Read();
                 if (sdr.HasRows == false)//没有插入
                 {
                     sdr.Close();
                     connection.Close();
                     connection.Open();
                     String commandInsert = "Insert INTO ReportEvent(ReportEvent_EventID,ReportEvent_Reporters,ReportEvent_Reason,ReportEvent_ReportCount)VALUES(@ReportEvent_EventID,@ReportEvent_Reporters,@ReportEvent_Reason,@ReportEvent_ReportCount)";
                     SqlCommand cmdInsert = new SqlCommand(commandInsert, connection);
                     cmdInsert.Parameters.AddWithValue("@ReportEvent_EventID", thiseventid);
                     cmdInsert.Parameters.AddWithValue("@ReportEvent_Reporters", Parameters.username);
                     cmdInsert.Parameters.AddWithValue("@ReportEvent_Reason", ReportReason);
                     cmdInsert.Parameters.AddWithValue("@ReportEvent_ReportCount", 1);
                     int r = cmdInsert.ExecuteNonQuery();
                     if (r >= 1)
                     {
                         MessageBox.Show("举报成功！请等待拼乎管理员处理！谢谢合作！");
                     }
                 }
                 else if (sdr.HasRows == true)//已存在
                 {
                     //稍微处理一下
               
                     count = int.Parse(sdr[1].ToString());
                     count++;
                     Reporters = sdr[0].ToString();
                     Reporters += "、"+Parameters.username;
                     //更新信息
                     sdr.Close();
                     connection.Close();
                     connection.Open();
                     String commandInsert = "update ReportEvent set ReportEvent_Reporters = '" + Reporters + "',ReportEvent_ReportCount =" + count + " where ReportEvent_EventId = " + thiseventid + ";";
                     //String commandInsert = "Update ReportEvent(ReportEvent_Reporters,ReportEvent_ReportCount)VALUES(@ReportEvent_ReporterID,@ReportEvent_ReportCount) where ;
                     SqlCommand cmdInsert = new SqlCommand(commandInsert, connection);
                     ////cmdInsert.Parameters.AddWithValue("@ReportEvent_EventID", thiseventid);
                     //cmdInsert.Parameters.AddWithValue("@Reporters", Reporters);
                     ////cmdInsert.Parameters.AddWithValue("@ReportEvent_Reason", ReportReason);
                     //cmdInsert.Parameters.AddWithValue("@ReportEvent_ReportCount", count);
                     int r = cmdInsert.ExecuteNonQuery();
                     if (r >= 1)
                     {
                         MessageBox.Show("举报成功！请等待拼乎管理员处理！谢谢合作！");

                     }
                 }
             }            
        }
        #endregion

        #region 控件问题
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //垃圾营销
            ReportReason = "垃圾营销";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           //淫秽色情
            ReportReason = "淫秽色情";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           //敏感信息
            ReportReason = "敏感信息";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           //虚假中奖
            ReportReason = "虚假中奖";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           //过期信息
            ReportReason = "过期信息";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           //抄袭内容
            ReportReason = "抄袭内容";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
           //不实信息
            ReportReason = "不实信息";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //其他
            ReportReason = "其他";
        }
       #endregion

        private void button2_Click(object sender, EventArgs e)
        {
           
            UIdetails.Show();
            this.Close();
        }
    }
}
