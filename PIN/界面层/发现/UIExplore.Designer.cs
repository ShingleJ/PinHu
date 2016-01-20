namespace PIN
{
    partial class UIExplore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIExplore));
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTravel = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnSports = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.lblMe = new System.Windows.Forms.Label();
            this.lblSendmge = new System.Windows.Forms.Label();
            this.lblExplore = new System.Windows.Forms.Label();
            this.lblHomepage = new System.Windows.Forms.Label();
            this.pboxMe = new System.Windows.Forms.PictureBox();
            this.pboxSendmsge = new System.Windows.Forms.PictureBox();
            this.pboxExplore = new System.Windows.Forms.PictureBox();
            this.pboxHomepage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSendmsge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExplore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHomepage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(46, 48);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 22);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(141, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "吃喝玩乐，想拼啥？";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(713, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTravel
            // 
            this.btnTravel.BackColor = System.Drawing.SystemColors.Control;
            this.btnTravel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTravel.BackgroundImage")));
            this.btnTravel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTravel.Location = new System.Drawing.Point(16, 79);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(260, 240);
            this.btnTravel.TabIndex = 3;
            this.btnTravel.Text = "旅游";
            this.btnTravel.UseVisualStyleBackColor = false;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFood.BackgroundImage")));
            this.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFood.Location = new System.Drawing.Point(282, 325);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(260, 240);
            this.btnFood.TabIndex = 4;
            this.btnFood.Text = "美食";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnSports
            // 
            this.btnSports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSports.BackgroundImage")));
            this.btnSports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSports.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSports.Location = new System.Drawing.Point(283, 79);
            this.btnSports.Name = "btnSports";
            this.btnSports.Size = new System.Drawing.Size(260, 240);
            this.btnSports.TabIndex = 5;
            this.btnSports.Text = "健身";
            this.btnSports.UseVisualStyleBackColor = true;
            this.btnSports.Click += new System.EventHandler(this.btnSports_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCar.BackgroundImage")));
            this.btnCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCar.Location = new System.Drawing.Point(548, 79);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(260, 240);
            this.btnCar.TabIndex = 6;
            this.btnCar.Text = "拼车";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnShopping
            // 
            this.btnShopping.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShopping.BackgroundImage")));
            this.btnShopping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShopping.Location = new System.Drawing.Point(548, 325);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(260, 240);
            this.btnShopping.TabIndex = 7;
            this.btnShopping.Text = "购物";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilm.BackgroundImage")));
            this.btnFilm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFilm.Location = new System.Drawing.Point(16, 325);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(260, 240);
            this.btnFilm.TabIndex = 8;
            this.btnFilm.Text = "电影";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.BackColor = System.Drawing.Color.Transparent;
            this.lblMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMe.ForeColor = System.Drawing.Color.Black;
            this.lblMe.Location = new System.Drawing.Point(298, 637);
            this.lblMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(38, 16);
            this.lblMe.TabIndex = 23;
            this.lblMe.Text = "好友";
            // 
            // lblSendmge
            // 
            this.lblSendmge.AutoSize = true;
            this.lblSendmge.BackColor = System.Drawing.Color.Transparent;
            this.lblSendmge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSendmge.ForeColor = System.Drawing.Color.Black;
            this.lblSendmge.Location = new System.Drawing.Point(193, 635);
            this.lblSendmge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendmge.Name = "lblSendmge";
            this.lblSendmge.Size = new System.Drawing.Size(38, 16);
            this.lblSendmge.TabIndex = 22;
            this.lblSendmge.Text = "发布";
            // 
            // lblExplore
            // 
            this.lblExplore.AutoSize = true;
            this.lblExplore.BackColor = System.Drawing.Color.Transparent;
            this.lblExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExplore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExplore.Location = new System.Drawing.Point(102, 637);
            this.lblExplore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExplore.Name = "lblExplore";
            this.lblExplore.Size = new System.Drawing.Size(40, 16);
            this.lblExplore.TabIndex = 21;
            this.lblExplore.Text = "发现";
            // 
            // lblHomepage
            // 
            this.lblHomepage.AutoSize = true;
            this.lblHomepage.BackColor = System.Drawing.Color.Transparent;
            this.lblHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHomepage.ForeColor = System.Drawing.Color.Black;
            this.lblHomepage.Location = new System.Drawing.Point(14, 635);
            this.lblHomepage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomepage.Name = "lblHomepage";
            this.lblHomepage.Size = new System.Drawing.Size(38, 16);
            this.lblHomepage.TabIndex = 20;
            this.lblHomepage.Text = "主页";
            // 
            // pboxMe
            // 
            this.pboxMe.BackColor = System.Drawing.Color.Transparent;
            this.pboxMe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxMe.BackgroundImage")));
            this.pboxMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxMe.Image = ((System.Drawing.Image)(resources.GetObject("pboxMe.Image")));
            this.pboxMe.Location = new System.Drawing.Point(282, 583);
            this.pboxMe.Margin = new System.Windows.Forms.Padding(4);
            this.pboxMe.Name = "pboxMe";
            this.pboxMe.Size = new System.Drawing.Size(50, 50);
            this.pboxMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMe.TabIndex = 19;
            this.pboxMe.TabStop = false;
            this.pboxMe.Click += new System.EventHandler(this.pboxMe_Click);
            // 
            // pboxSendmsge
            // 
            this.pboxSendmsge.BackColor = System.Drawing.Color.Transparent;
            this.pboxSendmsge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSendmsge.BackgroundImage")));
            this.pboxSendmsge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxSendmsge.Image = ((System.Drawing.Image)(resources.GetObject("pboxSendmsge.Image")));
            this.pboxSendmsge.Location = new System.Drawing.Point(195, 583);
            this.pboxSendmsge.Margin = new System.Windows.Forms.Padding(4);
            this.pboxSendmsge.Name = "pboxSendmsge";
            this.pboxSendmsge.Size = new System.Drawing.Size(50, 50);
            this.pboxSendmsge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSendmsge.TabIndex = 18;
            this.pboxSendmsge.TabStop = false;
            this.pboxSendmsge.Click += new System.EventHandler(this.pboxSendmsge_Click);
            // 
            // pboxExplore
            // 
            this.pboxExplore.BackColor = System.Drawing.Color.Transparent;
            this.pboxExplore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxExplore.BackgroundImage")));
            this.pboxExplore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxExplore.Image = ((System.Drawing.Image)(resources.GetObject("pboxExplore.Image")));
            this.pboxExplore.Location = new System.Drawing.Point(106, 583);
            this.pboxExplore.Margin = new System.Windows.Forms.Padding(4);
            this.pboxExplore.Name = "pboxExplore";
            this.pboxExplore.Size = new System.Drawing.Size(50, 50);
            this.pboxExplore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxExplore.TabIndex = 17;
            this.pboxExplore.TabStop = false;
            this.pboxExplore.Click += new System.EventHandler(this.pboxExplore_Click);
            // 
            // pboxHomepage
            // 
            this.pboxHomepage.BackColor = System.Drawing.Color.Transparent;
            this.pboxHomepage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxHomepage.BackgroundImage")));
            this.pboxHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxHomepage.Image = ((System.Drawing.Image)(resources.GetObject("pboxHomepage.Image")));
            this.pboxHomepage.Location = new System.Drawing.Point(16, 583);
            this.pboxHomepage.Margin = new System.Windows.Forms.Padding(4);
            this.pboxHomepage.Name = "pboxHomepage";
            this.pboxHomepage.Size = new System.Drawing.Size(50, 50);
            this.pboxHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHomepage.TabIndex = 16;
            this.pboxHomepage.TabStop = false;
            this.pboxHomepage.Click += new System.EventHandler(this.pboxHomepage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(832, 30);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(380, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "发现精彩";
            this.label2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(713, 594);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 66);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-22, -22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(751, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 25);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UIExplore
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(828, 658);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.lblSendmge);
            this.Controls.Add(this.lblExplore);
            this.Controls.Add(this.lblHomepage);
            this.Controls.Add(this.pboxMe);
            this.Controls.Add(this.pboxSendmsge);
            this.Controls.Add(this.pboxExplore);
            this.Controls.Add(this.pboxHomepage);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnShopping);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnSports);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btnTravel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIExplore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "首页";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSendmsge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExplore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHomepage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnSports;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.Label lblSendmge;
        private System.Windows.Forms.Label lblExplore;
        private System.Windows.Forms.Label lblHomepage;
        private System.Windows.Forms.PictureBox pboxMe;
        private System.Windows.Forms.PictureBox pboxSendmsge;
        private System.Windows.Forms.PictureBox pboxExplore;
        private System.Windows.Forms.PictureBox pboxHomepage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;

    }
}

