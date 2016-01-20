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
    public partial class UINomalSettings : Form
    {
        public UINomalSettings()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
