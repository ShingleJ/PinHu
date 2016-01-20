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
    public partial class ModifyPasswordcs : Form
    {
        ModifyPasswordClass md = new ModifyPasswordClass();
        public ModifyPasswordcs()
        {
            InitializeComponent();
        }

        private void confirmPassword_Click(object sender, EventArgs e)
        {
            if (tConfirmNewPW.Text != tNewPassword.Text)
            {
                MessageBox.Show("两次密码不一样！请再次确认！");
            }
            else
            {
                int re = md.ModifyPassword(tNewPassword.Text);
                if (re == 1)
                {
                    MessageBox.Show("密码修改成功！");
                }
            }
            //this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            //this.Close();
        }

        private void tNewPassword_TextChanged(object sender, EventArgs e)
        {
            int Check = md.CheckOldPassword(tOldPassword.Text);
            if (Check == 0)
            {
                MessageBox.Show("密码不正确！");
            }
        }
    }
}
