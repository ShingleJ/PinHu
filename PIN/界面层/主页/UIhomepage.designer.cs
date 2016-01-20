namespace PIN
{
    partial class UIhomepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIhomepage));
            this.pboxFace = new System.Windows.Forms.PictureBox();
            this.lblFollower = new System.Windows.Forms.Label();
            this.lblFollow = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEventnum = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblFriends = new System.Windows.Forms.Label();
            this.lblSndmsg = new System.Windows.Forms.Label();
            this.lblExplore = new System.Windows.Forms.Label();
            this.lblHmepage = new System.Windows.Forms.Label();
            this.pboxUserpage = new System.Windows.Forms.PictureBox();
            this.pboxSendmsge = new System.Windows.Forms.PictureBox();
            this.pboxExplore = new System.Windows.Forms.PictureBox();
            this.pbxHomepage = new System.Windows.Forms.PictureBox();
            this.pboxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFollowNum = new System.Windows.Forms.Label();
            this.lblFollowerNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUserpage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSendmsge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExplore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHomepage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxFace
            // 
            this.pboxFace.Image = ((System.Drawing.Image)(resources.GetObject("pboxFace.Image")));
            this.pboxFace.Location = new System.Drawing.Point(12, 54);
            this.pboxFace.Name = "pboxFace";
            this.pboxFace.Size = new System.Drawing.Size(74, 81);
            this.pboxFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFace.TabIndex = 0;
            this.pboxFace.TabStop = false;
            // 
            // lblFollower
            // 
            this.lblFollower.AutoSize = true;
            this.lblFollower.BackColor = System.Drawing.Color.Transparent;
            this.lblFollower.ForeColor = System.Drawing.Color.Black;
            this.lblFollower.Location = new System.Drawing.Point(125, 92);
            this.lblFollower.Name = "lblFollower";
            this.lblFollower.Size = new System.Drawing.Size(29, 12);
            this.lblFollower.TabIndex = 2;
            this.lblFollower.Text = "粉丝";
            this.lblFollower.Click += new System.EventHandler(this.lblFollower_Click);
            // 
            // lblFollow
            // 
            this.lblFollow.AutoSize = true;
            this.lblFollow.BackColor = System.Drawing.Color.Transparent;
            this.lblFollow.ForeColor = System.Drawing.Color.Black;
            this.lblFollow.Location = new System.Drawing.Point(189, 92);
            this.lblFollow.Name = "lblFollow";
            this.lblFollow.Size = new System.Drawing.Size(29, 12);
            this.lblFollow.TabIndex = 3;
            this.lblFollow.Text = "关注";
            this.lblFollow.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.BackColor = System.Drawing.Color.Transparent;
            this.lblEvents.ForeColor = System.Drawing.Color.Black;
            this.lblEvents.Location = new System.Drawing.Point(247, 92);
            this.lblEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(29, 12);
            this.lblEvents.TabIndex = 13;
            this.lblEvents.Text = "事件";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(555, 104);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 31);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "个人信息";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSet.Location = new System.Drawing.Point(472, 104);
            this.btnSet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(56, 31);
            this.btnSet.TabIndex = 25;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 284);
            this.panel1.TabIndex = 26;
            // 
            // lblEventnum
            // 
            this.lblEventnum.AutoSize = true;
            this.lblEventnum.BackColor = System.Drawing.Color.Transparent;
            this.lblEventnum.Location = new System.Drawing.Point(235, 118);
            this.lblEventnum.Name = "lblEventnum";
            this.lblEventnum.Size = new System.Drawing.Size(41, 12);
            this.lblEventnum.TabIndex = 27;
            this.lblEventnum.Text = "事件数";
            this.lblEventnum.Click += new System.EventHandler(this.lblEventnum_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(664, 525);
            this.shapeContainer1.TabIndex = 28;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -3;
            this.lineShape3.X2 = 673;
            this.lineShape3.Y1 = 434;
            this.lineShape3.Y2 = 434;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Black;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 230;
            this.lineShape2.X2 = 230;
            this.lineShape2.Y1 = 87;
            this.lineShape2.Y2 = 129;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Black;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 172;
            this.lineShape1.X2 = 172;
            this.lineShape1.Y1 = 87;
            this.lineShape1.Y2 = 129;
            // 
            // lblFriends
            // 
            this.lblFriends.AutoSize = true;
            this.lblFriends.BackColor = System.Drawing.Color.Transparent;
            this.lblFriends.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFriends.ForeColor = System.Drawing.Color.Black;
            this.lblFriends.Location = new System.Drawing.Point(281, 498);
            this.lblFriends.Name = "lblFriends";
            this.lblFriends.Size = new System.Drawing.Size(32, 17);
            this.lblFriends.TabIndex = 57;
            this.lblFriends.Text = "好友";
            // 
            // lblSndmsg
            // 
            this.lblSndmsg.AutoSize = true;
            this.lblSndmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblSndmsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSndmsg.ForeColor = System.Drawing.Color.Black;
            this.lblSndmsg.Location = new System.Drawing.Point(191, 498);
            this.lblSndmsg.Name = "lblSndmsg";
            this.lblSndmsg.Size = new System.Drawing.Size(32, 17);
            this.lblSndmsg.TabIndex = 56;
            this.lblSndmsg.Text = "发布";
            // 
            // lblExplore
            // 
            this.lblExplore.AutoSize = true;
            this.lblExplore.BackColor = System.Drawing.Color.Transparent;
            this.lblExplore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExplore.ForeColor = System.Drawing.Color.Black;
            this.lblExplore.Location = new System.Drawing.Point(105, 498);
            this.lblExplore.Name = "lblExplore";
            this.lblExplore.Size = new System.Drawing.Size(32, 17);
            this.lblExplore.TabIndex = 55;
            this.lblExplore.Text = "发现";
            // 
            // lblHmepage
            // 
            this.lblHmepage.AutoSize = true;
            this.lblHmepage.BackColor = System.Drawing.Color.Transparent;
            this.lblHmepage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHmepage.ForeColor = System.Drawing.Color.Black;
            this.lblHmepage.Location = new System.Drawing.Point(31, 498);
            this.lblHmepage.Name = "lblHmepage";
            this.lblHmepage.Size = new System.Drawing.Size(32, 17);
            this.lblHmepage.TabIndex = 54;
            this.lblHmepage.Text = "主页";
            // 
            // pboxUserpage
            // 
            this.pboxUserpage.BackColor = System.Drawing.Color.Transparent;
            this.pboxUserpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxUserpage.BackgroundImage")));
            this.pboxUserpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxUserpage.Image = ((System.Drawing.Image)(resources.GetObject("pboxUserpage.Image")));
            this.pboxUserpage.Location = new System.Drawing.Point(274, 445);
            this.pboxUserpage.Name = "pboxUserpage";
            this.pboxUserpage.Size = new System.Drawing.Size(50, 50);
            this.pboxUserpage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxUserpage.TabIndex = 53;
            this.pboxUserpage.TabStop = false;
            this.pboxUserpage.Click += new System.EventHandler(this.pboxUserpage_Click);
            // 
            // pboxSendmsge
            // 
            this.pboxSendmsge.BackColor = System.Drawing.Color.Transparent;
            this.pboxSendmsge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSendmsge.BackgroundImage")));
            this.pboxSendmsge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxSendmsge.Image = ((System.Drawing.Image)(resources.GetObject("pboxSendmsge.Image")));
            this.pboxSendmsge.Location = new System.Drawing.Point(190, 445);
            this.pboxSendmsge.Name = "pboxSendmsge";
            this.pboxSendmsge.Size = new System.Drawing.Size(50, 50);
            this.pboxSendmsge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSendmsge.TabIndex = 52;
            this.pboxSendmsge.TabStop = false;
            this.pboxSendmsge.Click += new System.EventHandler(this.pboxSendmsge_Click);
            // 
            // pboxExplore
            // 
            this.pboxExplore.BackColor = System.Drawing.Color.Transparent;
            this.pboxExplore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxExplore.BackgroundImage")));
            this.pboxExplore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxExplore.Image = ((System.Drawing.Image)(resources.GetObject("pboxExplore.Image")));
            this.pboxExplore.Location = new System.Drawing.Point(104, 445);
            this.pboxExplore.Name = "pboxExplore";
            this.pboxExplore.Size = new System.Drawing.Size(50, 50);
            this.pboxExplore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxExplore.TabIndex = 51;
            this.pboxExplore.TabStop = false;
            this.pboxExplore.Click += new System.EventHandler(this.pboxExplore_Click);
            // 
            // pbxHomepage
            // 
            this.pbxHomepage.BackColor = System.Drawing.Color.Transparent;
            this.pbxHomepage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxHomepage.BackgroundImage")));
            this.pbxHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxHomepage.Image = ((System.Drawing.Image)(resources.GetObject("pbxHomepage.Image")));
            this.pbxHomepage.Location = new System.Drawing.Point(24, 445);
            this.pbxHomepage.Name = "pbxHomepage";
            this.pbxHomepage.Size = new System.Drawing.Size(50, 50);
            this.pbxHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHomepage.TabIndex = 50;
            this.pbxHomepage.TabStop = false;
            this.pbxHomepage.Click += new System.EventHandler(this.pbxHomepage_Click);
            // 
            // pboxIcon
            // 
            this.pboxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pboxIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxIcon.BackgroundImage")));
            this.pboxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxIcon.Location = new System.Drawing.Point(542, 455);
            this.pboxIcon.Name = "pboxIcon";
            this.pboxIcon.Size = new System.Drawing.Size(117, 66);
            this.pboxIcon.TabIndex = 58;
            this.pboxIcon.TabStop = false;
            this.pboxIcon.Click += new System.EventHandler(this.pboxIcon_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(290, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 24);
            this.lblTitle.TabIndex = 60;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(0, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(664, 28);
            this.pictureBox7.TabIndex = 59;
            this.pictureBox7.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(8, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 21);
            this.btnExit.TabIndex = 61;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFollowNum
            // 
            this.lblFollowNum.AutoSize = true;
            this.lblFollowNum.BackColor = System.Drawing.Color.Transparent;
            this.lblFollowNum.Location = new System.Drawing.Point(182, 118);
            this.lblFollowNum.Name = "lblFollowNum";
            this.lblFollowNum.Size = new System.Drawing.Size(41, 12);
            this.lblFollowNum.TabIndex = 62;
            this.lblFollowNum.Text = "关注数";
            // 
            // lblFollowerNum
            // 
            this.lblFollowerNum.AutoSize = true;
            this.lblFollowerNum.BackColor = System.Drawing.Color.Transparent;
            this.lblFollowerNum.ForeColor = System.Drawing.Color.Black;
            this.lblFollowerNum.Location = new System.Drawing.Point(125, 118);
            this.lblFollowerNum.Name = "lblFollowerNum";
            this.lblFollowerNum.Size = new System.Drawing.Size(41, 12);
            this.lblFollowerNum.TabIndex = 63;
            this.lblFollowerNum.Text = "粉丝数";
            // 
            // UIhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 525);
            this.Controls.Add(this.lblFollowerNum);
            this.Controls.Add(this.lblFollowNum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pboxIcon);
            this.Controls.Add(this.lblFriends);
            this.Controls.Add(this.lblSndmsg);
            this.Controls.Add(this.lblExplore);
            this.Controls.Add(this.lblHmepage);
            this.Controls.Add(this.pboxUserpage);
            this.Controls.Add(this.pboxSendmsge);
            this.Controls.Add(this.pboxExplore);
            this.Controls.Add(this.pbxHomepage);
            this.Controls.Add(this.lblEventnum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblFollow);
            this.Controls.Add(this.lblFollower);
            this.Controls.Add(this.pboxFace);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIhomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My_messages";
            this.Load += new System.EventHandler(this.UIhomepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUserpage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSendmsge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExplore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHomepage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFace;
        private System.Windows.Forms.Label lblFollower;
        private System.Windows.Forms.Label lblFollow;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEventnum;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label lblFriends;
        private System.Windows.Forms.Label lblSndmsg;
        private System.Windows.Forms.Label lblExplore;
        private System.Windows.Forms.Label lblHmepage;
        private System.Windows.Forms.PictureBox pboxUserpage;
        private System.Windows.Forms.PictureBox pboxSendmsge;
        private System.Windows.Forms.PictureBox pboxExplore;
        private System.Windows.Forms.PictureBox pbxHomepage;
        private System.Windows.Forms.PictureBox pboxIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFollowNum;
        private System.Windows.Forms.Label lblFollowerNum;
    }
}