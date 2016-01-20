using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PIN
{
    public partial class 权限设置 : Form
    {
        public int QuanXian = 0;//默认为所有好友可见
        SendMessage fbxx = new SendMessage();
        public 权限设置 ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanXian = comboBox1.SelectedIndex;
            
            //QuanXian = this.QuanXian;
            //int quanxian = comboBox1.SelectedIndex;
            //switch (quanxian)
            //{
            //    case 0://所有人可见
            //    {
            //        break;
            //    }
            //    case 1://关注我的人可见
            //    {
            //        break;
            //    }
            //    case 2://指定好友可见
            //    {
            //        break;
            //    }
            //    case 3://仅自己可见
            //    {
            //        break;
            //    }
            //    default:
            //    {
            //        MessageBox.Show("出错！");
            //        break;
            //    }
            //}
            this.Close();
            //fbxx.QuanXian = QuanXian;
            //fbxx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            fbxx.Show();
        }

        private void 权限设置_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("所有人可见");
            comboBox1.Items.Add("关注我的人可见");
            comboBox1.Items.Add("指定好友可见");
            comboBox1.Items.Add("仅自己可见");
        }

        private void comboBox1_DragDrop(object sender, DragEventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
        }
    }
}
