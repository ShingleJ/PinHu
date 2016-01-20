using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;

namespace PIN
{
    public partial class UIMoreStudentInfo : Form
    {
        ImproveStudentInformationClass im = new ImproveStudentInformationClass();

        public UIMoreStudentInfo()
        {
            InitializeComponent();
            this.pboxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            this.tNickName.Enabled = false;
        }     

        private void modifyPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//修改密码
        {
           UIModifyPassword mp = new UIModifyPassword();
            mp.Show();
        }

        private void backHome_Click(object sender, EventArgs e)//返回
        {
            this.Close();
            Parameters.homepage.Refresh();
            Parameters.homepage.InitializeForm();
            Parameters.homepagestate = true;
            Parameters.homepage.Show();
        }

        private void save_Click(object sender, EventArgs e)//保存
        {
            //保存数据
            im.Academy = tCollege.Text;
            im.Degree = tGrade.Text;
            im.Email = tEmail.Text;
            //im.enrollmentdate = t
            im.NickName = tNickName.Text;
            im.PhoneNumber = tCellphoneNumber.Text;
            im.Gender = tSex.Text;
            im.Address = tLocation.Text;
            im.StudentId = tStudentNumber.Text;
            im.Sign = tSign.Text;
            //Update
            im.GetInsert();//调用插入方法
            MessageBox.Show("保存成功");

        }  


        //////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////
        /**********这一块是选择照片上传头像，仍然存在问题，我没有改动***********/
        //private void FacePic_Click(object sender, EventArgs e)//上传头像
        //{
        //    byte[] imagebytes = null;
        //    //打开数据库
        //    string connstring = Parameters.user_info;
        //    SqlConnection conn = new SqlConnection(connstring);
        //    SqlCommand cmd = new SqlCommand("select top 1* from Image", conn);
        //    conn.Open();

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while(dr.Read())
        //    {
        //        imagebytes = (byte[])dr.GetValue(1);
        //    }
        //    dr.Close();
        //    cmd.Clone();
        //    conn.Close();
        //    MemoryStream ms = new MemoryStream(imagebytes);
        //    Bitmap bmpt = new Bitmap(ms);
        //    picBox.Image = bmpt;
        //}


        //private void picBox_Click(object sender, EventArgs e)//选择照片
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
        //        String connstring = Parameters.user_info;
        //        SqlConnection conn = new SqlConnection(connstring);
        //        SqlCommand cmd = new SqlCommand("Insert into Image values(@ImageList)", conn);
        //        conn.Open();

        //        cmd.Parameters.Add("ImageList", SqlDbType.Image);
        //        cmd.Parameters["ImageList"].Value = imagebytes;
        //        cmd.ExecuteNonQuery();
        //        conn.Close();//从数据库中读取图片
        //    }
        //}


        private void browse_Click(object sender, EventArgs e)
        {

        }

        private void ImprovePersonalInformation_Load(object sender, EventArgs e)
        {
            tNickName.Text = Parameters.username;
            string name = tNickName.Text;
            //已有信息显示
            String connectionString = Parameters.user_info;
            DTConnection con = new DTConnection();
            String commandTextQuery = "select * from StudentInfo where StudentInfo_NickName = '" + name + "'";
            List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);
            int count = reader.Count;
            foreach (String[] temp in reader)
            {
                if (count > 0)
                {
                    tStudentNumber.Text = reader[count - 1][3].ToString();
                    tSex.Text = reader[count - 1][4].ToString();
                    tEmail.Text = reader[count - 1][7].ToString();
                    tLocation.Text = reader[count - 1][10].ToString();
                    tCollege.Text = reader[count - 1][5].ToString();
                    tGrade.Text = reader[count - 1][6].ToString();
                    tCellphoneNumber.Text = reader[count - 1][8].ToString();
                    tSign.Text = reader[count - 1][10].ToString();
                    if (File.Exists(reader[count - 1][11].ToString().Trim()))
                    {
                        Parameters.iconfullpath = new DirectoryInfo("../../../").FullName+reader[count - 1][11].ToString().Trim();
                    }
                    this.pboxIcon.Image = Image.FromFile(Parameters.iconfullpath);
                }
                else
                {
                    MessageBox.Show("系统繁忙，请稍等");
                }
                count--;
            }
        }
        //上传头像
        private void btnUploadicon_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDUploadicon = new OpenFileDialog();
            OFDUploadicon.Filter = "图片文件(*.bmp;*.gif;*.jpg;*.ico)|*.bmp;*.gif;*.jpg;*.ico";
            if (OFDUploadicon.ShowDialog() == DialogResult.OK)//获得图片路径，存入程序自己的icon文件夹中。并在数据库中存入路径。
            {
                string wholeIconPath = OFDUploadicon.FileName;
                string destPath = Path.Combine(@"picture\icon", Parameters.username + System.Guid.NewGuid().ToString().Substring(1, 6) + Path.GetFileName(wholeIconPath)); 
                string destfullpath = new DirectoryInfo("../../../").FullName + destPath;
                if (!File.Exists(new DirectoryInfo("../../../").FullName+destPath))
                {
                    System.IO.File.Copy(wholeIconPath, destfullpath);
                    im.Iconpath = destPath;
                    im.Academy = tCollege.Text;
                    im.Degree = tGrade.Text;
                    im.Email = tEmail.Text;
                    im.NickName = tNickName.Text;
                    im.PhoneNumber = tCellphoneNumber.Text;
                    im.Gender = tSex.Text;
                    im.Address = tLocation.Text;
                    im.StudentId = tStudentNumber.Text;
                    im.Sign = tSign.Text;
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


    }
}
