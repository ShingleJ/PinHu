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
    public partial class 获取位置 : Form
    {
        SendMessage fbxx = new SendMessage();
        public 获取位置()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            fbxx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            fbxx.Show();
        }

        private void 获取位置_Load(object sender, EventArgs e)
        {

        }
    }
}
