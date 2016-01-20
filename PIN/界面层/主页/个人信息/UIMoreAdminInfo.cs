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
    public partial class UIMoreAdminInfo : Form
    {
        MoreAdminInfo im = new MoreAdminInfo();

        public UIMoreAdminInfo()
        {
            InitializeComponent();
        }

        private void MRevise_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UIModifyPassword mp = new UIModifyPassword();
            mp.Show();
        }

        private void MEmail_Click(object sender, EventArgs e)
        {

        }

        private void MSave_Click(object sender, EventArgs e)
        {
            im.Sex = ASexText.Text;
            im.Age = AAgeText.Text;
            im.Email = AEmailText.Text;
            im.PhoneNumber = ACellPText.Text;
            im.WorkPlace = AWorkPlaceText.Text;
            im.NickName = AEntryText.Text;
            //update
            im.GetInsert();//调用插入方法
            MessageBox.Show("保存成功");
            this.Hide();
        }

        private void MReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Parameters.homepage.Refresh();
            Parameters.homepage.InitializeForm();
            Parameters.homepagestate = true;
            Parameters.homepage.Show();
        }

    

        private void ImproveAdministratorInformation_Load(object sender, EventArgs e)
        {
            AEntryText.Text = Parameters.username;
            string name = AEntryText.Text;
            //连接数据库
            String connectionString = Parameters.user_info;
            String commandTextQuery = "select * from AdminInfo where AdminInfo_NickName = '" + name + "'";
            DTConnection con = new DTConnection();
            List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);
            int count = reader.Count;
            foreach (String[] temp in reader)
            {
                if (count > 0)
                {
                    ASexText.Text = reader[count-1][3].ToString();
                    AAgeText.Text = reader[count - 1][4].ToString();
                    AEmailText.Text = reader[count - 1][5].ToString();
                    ACellPText.Text = reader[count - 1][6].ToString();
                    AWorkPlaceText.Text = reader[count - 1][7].ToString();
                    AEntryText.Text = reader[count - 1][1].ToString();
                    if (File.Exists(reader[count - 1][11].ToString().Trim()))
                    {
                        Parameters.iconfullpath = new DirectoryInfo("../../../").FullName+reader[count - 1][11].ToString().Trim();
                    }
                    this.pboxIcon.Image = Image.FromFile(Parameters.iconfullpath);
                }
                else
                {
                    MessageBox.Show("对不起，信息加载出错");
                }
                count--;
            }

        }

        private void UpHeadbutton1_Click(object sender, EventArgs e)
        {

            OpenFileDialog OFDUploadicon = new OpenFileDialog();
            OFDUploadicon.Filter = "图片文件(*.bmp;*.gif;*.jpg;*.ico)|*.bmp;*.gif;*.jpg;*.ico";
            if (OFDUploadicon.ShowDialog() == DialogResult.OK)//获得图片路径，存入程序自己的icon文件夹中。并在数据库中存入路径。
            {
                string wholeIconPath = OFDUploadicon.FileName;
                string destPath = Path.Combine(@"picture\icon", Parameters.username + System.Guid.NewGuid().ToString().Substring(1, 6) + Path.GetFileName(wholeIconPath));
                string destfullpath = new DirectoryInfo("../../../").FullName + destPath;
                if (!File.Exists(destfullpath))
                {
                    System.IO.File.Copy(wholeIconPath, destfullpath);
                    im.Iconpath = destPath;
                    im.Sex = ASexText.Text;
                    im.Age = AAgeText.Text;
                    im.Email = AEmailText.Text;
                    im.PhoneNumber = ACellPText.Text;
                    im.WorkPlace = AWorkPlaceText.Text;
                    im.NickName = AEntryText.Text;
                    im.GetInsert();//插入数据库
                    Parameters.iconfullpath = destfullpath;
                    this.pboxIcon.Image = Image.FromFile(Parameters.iconfullpath);//显示于picturebox

                    MessageBox.Show("图片上传成功");


                }
                else
                {
                    MessageBox.Show("图片已存在");
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}

