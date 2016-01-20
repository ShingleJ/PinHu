namespace PIN
{
    partial class UISetting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UISetting));
            this.pboxIco = new System.Windows.Forms.PictureBox();
            this.lblNme = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Button();
            this.aboutUs = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxIco
            // 
            this.pboxIco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxIco.Location = new System.Drawing.Point(188, 41);
            this.pboxIco.Name = "pboxIco";
            this.pboxIco.Size = new System.Drawing.Size(131, 127);
            this.pboxIco.TabIndex = 2;
            this.pboxIco.TabStop = false;
            // 
            // lblNme
            // 
            this.lblNme.AutoSize = true;
            this.lblNme.BackColor = System.Drawing.Color.Transparent;
            this.lblNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNme.ForeColor = System.Drawing.Color.Black;
            this.lblNme.Location = new System.Drawing.Point(191, 171);
            this.lblNme.Name = "lblNme";
            this.lblNme.Size = new System.Drawing.Size(114, 25);
            this.lblNme.TabIndex = 3;
            this.lblNme.Text = "昵称：XXX";
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.settings.ForeColor = System.Drawing.Color.Black;
            this.settings.Location = new System.Drawing.Point(80, 227);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(325, 42);
            this.settings.TabIndex = 5;
            this.settings.Text = "通用设置";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Version.ForeColor = System.Drawing.Color.Black;
            this.Version.Location = new System.Drawing.Point(80, 270);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(325, 42);
            this.Version.TabIndex = 7;
            this.Version.Text = "版本信息";
            this.Version.UseVisualStyleBackColor = false;
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // aboutUs
            // 
            this.aboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.aboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aboutUs.ForeColor = System.Drawing.Color.Black;
            this.aboutUs.Location = new System.Drawing.Point(80, 315);
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Size = new System.Drawing.Size(325, 42);
            this.aboutUs.TabIndex = 8;
            this.aboutUs.Text = "关于我们";
            this.aboutUs.UseVisualStyleBackColor = false;
            this.aboutUs.Click += new System.EventHandler(this.aboutUs_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(171, 428);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(148, 38);
            this.Logout.TabIndex = 9;
            this.Logout.TabStop = false;
            this.Logout.Text = "退出当前账号";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(495, 28);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "设置";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(378, 428);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 66);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(12, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 33);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UISetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 495);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.aboutUs);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.lblNme);
            this.Controls.Add(this.pboxIco);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UISetting";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.UISetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxIco;
        private System.Windows.Forms.Label lblNme;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button Version;
        private System.Windows.Forms.Button aboutUs;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBack;

    }
}

