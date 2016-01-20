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
    public partial class UIChooseFriends : Form
    {
        private string thislist=null;
        UISendMessage thissmg;
        public UIChooseFriends(UISendMessage smg)
        {
            InitializeComponent();
            thissmg = smg;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchword = this.tboxSearch.Text;
            int friNum = this.lboxFriends.Items.Count;
            bool chosen = false;
            if (friNum > 0 && searchword.Length != 0)
            {
                for (int i = 0; i < friNum; i++)
                {
                    bool t = this.lboxFriends.Items[i].ToString().Contains(searchword);
                    if (t)
                    {
                        this.lboxFriends.SetSelected(i, t);
                        chosen = true;
                    }
                }
            }
            if (!chosen)
            {
                MessageBox.Show("无匹配好友！");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (Parameters.atfriend != null)
            {
                thissmg.allowpeople = thislist;
            }
            this.Close();
        }

        private void UIChooseFriends_Load(object sender, EventArgs e)
        {
            String connectionString = Parameters.user_info;
            String commandTextQuery = "select * from FollowUser where FollowUser_FollowerName ='" + Parameters.username + "'";
            DTConnection con = new DTConnection();
            List<String[]> reader = con.ReadCon(commandTextQuery, connectionString);
            for (int i = 0; i < reader.Count(); i++)
            {
                this.lboxFriends.Items.Add(reader[i][1]);
            }
        }

        private void lboxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (lboxFriends.SelectedIndex != -1)//选中
            {
                this.lboxChosenFriends.Items.Add(lboxFriends.SelectedItem);
                this.lboxFriends.Items.Remove(lboxFriends.SelectedItem);
                lboxFriends.SelectedIndex = -1;
            }
        }

        private void btnChooseBack_Click(object sender, EventArgs e)
        {
            if (lboxChosenFriends.SelectedIndex != -1)//选中
            {
                this.lboxFriends.Items.Add(lboxChosenFriends.SelectedItem);
                this.lboxChosenFriends.Items.Remove(lboxChosenFriends.SelectedItem);
                lboxChosenFriends.SelectedIndex = -1;
            }
        }
        //重置
        private void button1_Click(object sender, EventArgs e)
        {
            this.lboxFriends.Items.AddRange(lboxChosenFriends.Items);
            this.lboxChosenFriends.Items.Clear();
        }
        //全选
        private void button2_Click(object sender, EventArgs e)
        {
            this.lboxChosenFriends.Items.AddRange(lboxFriends.Items);
            this.lboxFriends.Items.Clear();
        }

        private void btnEnsure_Click(object sender, EventArgs e)
        {
            if (thislist == null)
            {
                thislist = this.lboxChosenFriends.Items[0].ToString().Trim();
                //存入数据库
                for (int i = 1; i < this.lboxChosenFriends.Items.Count; i++)
                {
                    thislist += "," + this.lboxChosenFriends.Items[i].ToString().Trim();
                }
                MessageBox.Show("@人选已确定~");
            }
            else
            {
                MessageBox.Show("@人选已确定~");
            }
        }


    }
}
