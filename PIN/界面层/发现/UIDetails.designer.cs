namespace PIN
{
    partial class UIDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIDetails));
            this.content = new System.Windows.Forms.RichTextBox();
            this.lblHeadTitle = new System.Windows.Forms.Label();
            this.pboxPublisherIcon = new System.Windows.Forms.PictureBox();
            this.lblPublisherNme = new System.Windows.Forms.Label();
            this.lblSendTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentFollowers = new System.Windows.Forms.Label();
            this.rboxComments = new System.Windows.Forms.RichTextBox();
            this.tboxMyComment = new System.Windows.Forms.TextBox();
            this.collect = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.comment = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPageview = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFollowPublisher = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPublisherIcon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Location = new System.Drawing.Point(13, 122);
            this.content.Margin = new System.Windows.Forms.Padding(4);
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(921, 195);
            this.content.TabIndex = 0;
            this.content.Text = "";
            this.content.UseWaitCursor = true;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.AutoSize = true;
            this.lblHeadTitle.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHeadTitle.ForeColor = System.Drawing.Color.Black;
            this.lblHeadTitle.Location = new System.Drawing.Point(393, 5);
            this.lblHeadTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadTitle.Name = "lblHeadTitle";
            this.lblHeadTitle.Size = new System.Drawing.Size(89, 20);
            this.lblHeadTitle.TabIndex = 0;
            this.lblHeadTitle.Text = "事件详情";
            this.lblHeadTitle.UseWaitCursor = true;
            // 
            // pboxPublisherIcon
            // 
            this.pboxPublisherIcon.Location = new System.Drawing.Point(13, 34);
            this.pboxPublisherIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pboxPublisherIcon.Name = "pboxPublisherIcon";
            this.pboxPublisherIcon.Size = new System.Drawing.Size(56, 56);
            this.pboxPublisherIcon.TabIndex = 2;
            this.pboxPublisherIcon.TabStop = false;
            this.pboxPublisherIcon.UseWaitCursor = true;
            this.pboxPublisherIcon.Click += new System.EventHandler(this.pboxPublisherIcon_Click);
            // 
            // lblPublisherNme
            // 
            this.lblPublisherNme.AutoSize = true;
            this.lblPublisherNme.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisherNme.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPublisherNme.ForeColor = System.Drawing.Color.Black;
            this.lblPublisherNme.Location = new System.Drawing.Point(86, 38);
            this.lblPublisherNme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisherNme.Name = "lblPublisherNme";
            this.lblPublisherNme.Size = new System.Drawing.Size(69, 20);
            this.lblPublisherNme.TabIndex = 3;
            this.lblPublisherNme.Text = "发布者";
            this.lblPublisherNme.UseWaitCursor = true;
            // 
            // lblSendTime
            // 
            this.lblSendTime.AutoSize = true;
            this.lblSendTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSendTime.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSendTime.ForeColor = System.Drawing.Color.Black;
            this.lblSendTime.Location = new System.Drawing.Point(10, 98);
            this.lblSendTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendTime.Name = "lblSendTime";
            this.lblSendTime.Size = new System.Drawing.Size(109, 20);
            this.lblSendTime.TabIndex = 4;
            this.lblSendTime.Text = "发布日期：";
            this.lblSendTime.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblCurrentFollowers);
            this.groupBox2.Controls.Add(this.rboxComments);
            this.groupBox2.Controls.Add(this.tboxMyComment);
            this.groupBox2.Controls.Add(this.collect);
            this.groupBox2.Controls.Add(this.share);
            this.groupBox2.Controls.Add(this.comment);
            this.groupBox2.Controls.Add(this.btnAccept);
            this.groupBox2.Location = new System.Drawing.Point(13, 325);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(921, 352);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "评论：";
            this.label1.UseWaitCursor = true;
            // 
            // lblCurrentFollowers
            // 
            this.lblCurrentFollowers.AutoSize = true;
            this.lblCurrentFollowers.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentFollowers.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentFollowers.Location = new System.Drawing.Point(405, 3);
            this.lblCurrentFollowers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentFollowers.Name = "lblCurrentFollowers";
            this.lblCurrentFollowers.Size = new System.Drawing.Size(129, 20);
            this.lblCurrentFollowers.TabIndex = 5;
            this.lblCurrentFollowers.Text = "意向接洽者：";
            this.lblCurrentFollowers.UseWaitCursor = true;
            // 
            // rboxComments
            // 
            this.rboxComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rboxComments.Location = new System.Drawing.Point(-1, 34);
            this.rboxComments.Name = "rboxComments";
            this.rboxComments.ReadOnly = true;
            this.rboxComments.Size = new System.Drawing.Size(922, 183);
            this.rboxComments.TabIndex = 8;
            this.rboxComments.Text = "";
            this.rboxComments.UseWaitCursor = true;
            this.rboxComments.TextChanged += new System.EventHandler(this.rboxComments_TextChanged);
            // 
            // tboxMyComment
            // 
            this.tboxMyComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxMyComment.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tboxMyComment.Location = new System.Drawing.Point(-1, 235);
            this.tboxMyComment.Name = "tboxMyComment";
            this.tboxMyComment.Size = new System.Drawing.Size(832, 27);
            this.tboxMyComment.TabIndex = 7;
            this.tboxMyComment.Text = "有什么想说的？";
            this.tboxMyComment.UseWaitCursor = true;
            this.tboxMyComment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tboxMyComment_MouseDown);
            // 
            // collect
            // 
            this.collect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("collect.BackgroundImage")));
            this.collect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.collect.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.collect.ForeColor = System.Drawing.Color.Black;
            this.collect.Location = new System.Drawing.Point(83, 284);
            this.collect.Margin = new System.Windows.Forms.Padding(4);
            this.collect.Name = "collect";
            this.collect.Size = new System.Drawing.Size(63, 34);
            this.collect.TabIndex = 4;
            this.collect.Tag = "";
            this.collect.Text = "收藏";
            this.collect.UseVisualStyleBackColor = false;
            this.collect.UseWaitCursor = true;
            this.collect.Click += new System.EventHandler(this.collect_Click);
            // 
            // share
            // 
            this.share.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("share.BackgroundImage")));
            this.share.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.share.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.share.ForeColor = System.Drawing.Color.Black;
            this.share.Location = new System.Drawing.Point(156, 284);
            this.share.Margin = new System.Windows.Forms.Padding(4);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(63, 34);
            this.share.TabIndex = 3;
            this.share.Text = "转发";
            this.share.UseVisualStyleBackColor = false;
            this.share.UseWaitCursor = true;
            this.share.Click += new System.EventHandler(this.share_Click);
            // 
            // comment
            // 
            this.comment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comment.BackgroundImage")));
            this.comment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comment.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comment.ForeColor = System.Drawing.Color.Black;
            this.comment.Location = new System.Drawing.Point(838, 237);
            this.comment.Margin = new System.Windows.Forms.Padding(4);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(63, 40);
            this.comment.TabIndex = 2;
            this.comment.Text = "留言";
            this.comment.UseVisualStyleBackColor = false;
            this.comment.UseWaitCursor = true;
            this.comment.Click += new System.EventHandler(this.comment_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccept.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(-6, 284);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 34);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "我要拼";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.UseWaitCursor = true;
            this.btnAccept.Click += new System.EventHandler(this.transmit_Click);
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.BackColor = System.Drawing.Color.Transparent;
            this.lblDeadline.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeadline.ForeColor = System.Drawing.Color.Black;
            this.lblDeadline.Location = new System.Drawing.Point(257, 98);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(109, 20);
            this.lblDeadline.TabIndex = 2;
            this.lblDeadline.Text = "截至日期：";
            this.lblDeadline.UseWaitCursor = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(853, 98);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(49, 20);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "状态";
            this.lblState.UseWaitCursor = true;
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // lblPageview
            // 
            this.lblPageview.AutoSize = true;
            this.lblPageview.BackColor = System.Drawing.Color.Transparent;
            this.lblPageview.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageview.ForeColor = System.Drawing.Color.Black;
            this.lblPageview.Location = new System.Drawing.Point(568, 98);
            this.lblPageview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageview.Name = "lblPageview";
            this.lblPageview.Size = new System.Drawing.Size(89, 20);
            this.lblPageview.TabIndex = 11;
            this.lblPageview.Text = "浏览量：";
            this.lblPageview.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(950, 39);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(818, 611);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 66);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // btnFollowPublisher
            // 
            this.btnFollowPublisher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFollowPublisher.BackgroundImage")));
            this.btnFollowPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFollowPublisher.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFollowPublisher.ForeColor = System.Drawing.Color.Black;
            this.btnFollowPublisher.Location = new System.Drawing.Point(76, 64);
            this.btnFollowPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.btnFollowPublisher.Name = "btnFollowPublisher";
            this.btnFollowPublisher.Size = new System.Drawing.Size(92, 28);
            this.btnFollowPublisher.TabIndex = 29;
            this.btnFollowPublisher.Text = "关注";
            this.btnFollowPublisher.UseVisualStyleBackColor = false;
            this.btnFollowPublisher.UseWaitCursor = true;
            this.btnFollowPublisher.Click += new System.EventHandler(this.btnFollowUser_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(16, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 28);
            this.button3.TabIndex = 30;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("幼圆", 9F);
            this.button4.Location = new System.Drawing.Point(849, -3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 35);
            this.button4.TabIndex = 31;
            this.button4.Text = "举报";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UIDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 689);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFollowPublisher);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblPageview);
            this.Controls.Add(this.lblHeadTitle);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSendTime);
            this.Controls.Add(this.lblPublisherNme);
            this.Controls.Add(this.pboxPublisherIcon);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.content);
            this.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UIDetails";
            this.Text = "Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPublisherIcon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Label lblHeadTitle;
        private System.Windows.Forms.PictureBox pboxPublisherIcon;
        private System.Windows.Forms.Label lblPublisherNme;
        private System.Windows.Forms.Label lblSendTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button collect;
        private System.Windows.Forms.Button comment;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCurrentFollowers;
        private System.Windows.Forms.Label lblPageview;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFollowPublisher;
        private System.Windows.Forms.TextBox tboxMyComment;
        private System.Windows.Forms.RichTextBox rboxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}