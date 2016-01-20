namespace PIN
{
    partial class UIAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIAdmin));
            this.pboxFace = new System.Windows.Forms.PictureBox();
            this.lblFollower = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEventnum = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pboxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).BeginInit();
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
            this.lblFollower.Size = new System.Drawing.Size(0, 12);
            this.lblFollower.TabIndex = 2;
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
            this.lblEventnum.Location = new System.Drawing.Point(136, 119);
            this.lblEventnum.Name = "lblEventnum";
            this.lblEventnum.Size = new System.Drawing.Size(53, 12);
            this.lblEventnum.TabIndex = 27;
            this.lblEventnum.Text = "事件数：";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(662, 525);
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
            this.lineShape2.X1 = 111;
            this.lineShape2.X2 = 111;
            this.lineShape2.Y1 = 58;
            this.lineShape2.Y2 = 130;
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(12, 470);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 44);
            this.btnExit.TabIndex = 61;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 64;
            this.label1.Text = "举报事件处理窗口";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.BackColor = System.Drawing.Color.Transparent;
            this.lblEvents.ForeColor = System.Drawing.Color.Black;
            this.lblEvents.Location = new System.Drawing.Point(136, 58);
            this.lblEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(53, 12);
            this.lblEvents.TabIndex = 13;
            this.lblEvents.Text = "管理员：";
            // 
            // UIAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pboxIcon);
            this.Controls.Add(this.lblEventnum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblFollower);
            this.Controls.Add(this.pboxFace);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My_messages";
            this.Load += new System.EventHandler(this.UIhomepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFace;
        private System.Windows.Forms.Label lblFollower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEventnum;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.PictureBox pboxIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEvents;
    }
}