using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PIN
{
    public partial class UIMoreMerchantInfo : Form
    {
        ImproveMerchantInformationClass im = new ImproveMerchantInformationClass();

        public UIMoreMerchantInfo()
        {
            InitializeComponent();
        }

        private void MRevise_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UIModifyPassword mp = new UIModifyPassword();
            mp.Show();
        }

        private void MReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////上传头像
        //private void UpHeadbutton1_Click(object sender, EventArgs e)
        //{
        //    byte[] imagebytes = null;
        //    //打开数据库
        //    string connstring = Parameters.user_info;
        //    SqlConnection conn = new SqlConnection(connstring);
        //    SqlCommand cmd = new SqlCommand("select top 1* from Image", conn);
        //    conn.Open();

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        imagebytes = (byte[])dr.GetValue(1);
        //    }
        //    dr.Close();
        //    cmd.Clone();
        //    conn.Close();
        //    MemoryStream ms = new MemoryStream(imagebytes);
        //    Bitmap bmpt = new Bitmap(ms);
        //    pictureBox1.Image = bmpt;
        //}

        ////选择照片
        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog OFD1 = new OpenFileDialog();
        //    OFD1.Filter = "*.jpg|*.JPG|*.BMP|*.bmp";

        //    if (OFD1.ShowDialog() == DialogResult.OK)
        //    {
        //        string fullpath = OFD1.FileName;//文件路径
        //        FileStream fs = new FileStream(fullpath, FileMode.Open);
        //        byte[] imagebytes = new byte[fs.Length];
        //        BinaryReader br = new BinaryReader(fs);
        //        imagebytes = br.ReadBytes(Convert.ToInt32(fs.Length));
        //        //打开数据库
        //        string connstring = Parameters.user_info;
        //        SqlConnection conn = new SqlConnection(connstring);
        //        SqlCommand cmd = new SqlCommand("Insert into Image values(@ImageList)", conn);
        //        conn.Open();

        //        cmd.Parameters.Add("ImageList", SqlDbType.Image);
        //        cmd.Parameters["ImageList"].Value = imagebytes;
        //        cmd.ExecuteNonQuery();
        //        conn.Close();//从数据库中读取图片
        //    }

        //}

        private void MSave_Click(object sender, EventArgs e)
        {
            //保存数据
            im.ShopName = MShopText.Text;
            im.Name = MEntryText.Text;
            im.BusinessHour = MBussinessHourText.Text;
            im.ShopAge = MAgeText.Text;
            im.Address = MAddressText.Text;
            im.Email = MEmailText.Text;
            im.CellphoneNumber = MCellPText.Text;
            im.Telephone = MphoneText.Text;
            im.Sign = MSign.Text;

            //update
            im.GetInsert();//调用插入方法
            MessageBox.Show("保存成功");
            this.Hide();
        }

        private void ImproveMerchantInformation_Load(object sender, EventArgs e)
        {
            MEntryText.Text = Parameters.username;
            string name = MEntryText.Text;
            //连接数据库
            String connectionString = Parameters.user_info;
            String commandTextQuery = "select * from MerchantInfo where Merchant_Name =  '" + name + "'";
            DTConnection con = new DTConnection();
            List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);
            int count=reader.Count;
            foreach(String[] temp in reader)
            {
                if (count > 0)
                {
                    MEmailText.Text = reader[count-1][2].ToString();
                    MCellPText.Text = reader[count - 1][3].ToString();
                    MAddressText.Text = reader[count - 1][5].ToString();
                    MphoneText.Text = reader[count - 1][6].ToString();
                    MEntryText.Text = reader[count - 1][1].ToString();
                    MBussinessHourText.Text = reader[count - 1][7].ToString();
                    MAgeText.Text = reader[count - 1][10].ToString();
                    MSign.Text = reader[count - 1][9].ToString();
                    MShopText.Text = reader[count - 1][11].ToString();
                }
                else
                {
                    MessageBox.Show("对不起，信息加载出错");
                }
                count--;
            }
        }
    }
}
