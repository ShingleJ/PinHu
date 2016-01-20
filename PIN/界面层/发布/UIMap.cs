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
    public partial class UIMap : Form
    {
        public UIMap()
        {
            InitializeComponent();
        }

        private void map_DoubleClick(object sender, EventArgs e)
        {
        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UIuserpage n = new UIuserpage();
            n.Show();
            this.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy年MM月dd日 HH:mm";
        }
        //}
    }
}
