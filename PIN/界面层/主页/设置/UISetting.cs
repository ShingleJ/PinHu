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
    public partial class UISetting : Form
    {
        UIhomepage thishp;
        public UISetting(UIhomepage uihp)
        {
            InitializeComponent();
            thishp = uihp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            UINomalSettings nm = new UINomalSettings();
            nm.Show();
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            if (!Parameters.homepagestate)
            {
                Parameters.homepagestate = true;
                Parameters.homepage.Show();
                this.Close();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            
            Parameters.settingstate = false;
            if (Parameters.haslogined&&!Parameters.loginstate)
            {
                Parameters.haslogined = false;
                Parameters.loginstate = true;
                Parameters.loadPinhu();
                UILogin ulg = new UILogin();
                ulg.Show();
            }

            this.Close();
        }

        private void information_Click(object sender, EventArgs e)
        {
            switch (Parameters.usertype)
            {
                case 0:
                    {
                        UIMoreStudentInfo isi = new UIMoreStudentInfo();
                        isi.Show();
                    }
                    break;
                case 1:
                    {
                        UIMoreMerchantInfo imi = new UIMoreMerchantInfo();
                        imi.Show();
                    }
                    break;
                case 2:
                    {
                        UIMoreAdminInfo iai = new UIMoreAdminInfo();
                        iai.Show();
                    }
                    break;
            }
        }

        private void Version_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这里是PinhuPc V1.0");
        }

        private void UISetting_Load(object sender, EventArgs e)
        {
            DTConnection con = new DTConnection();
            string tname = Parameters.username;
            string seleiconpath = "select * from StudentInfo where StudentInfo_NickName ='" + tname + "'";
            string constr = Parameters.user_info;
            List<String[]> reader2 = con.ReadCon(seleiconpath, constr);
            string fllpath = new DirectoryInfo("../../../").FullName + reader2[0][11];
            if (!File.Exists(fllpath))
            {
                fllpath = new DirectoryInfo("../../../").FullName + @"picture\icon\doge.ico";
            }
            pboxIco.SizeMode = PictureBoxSizeMode.Zoom;
            pboxIco.Image = Image.FromFile(fllpath);
            this.lblNme.Text = Parameters.username;
        }

        private void aboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我们是Pinhu小组！");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!Parameters.homepagestate)
            {
                Parameters.homepagestate = true;
                Parameters.homepage.Show();
                this.Close();
            }
        }
    }
}
