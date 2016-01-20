namespace PIN
{
    partial class UIChooseFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIChooseFriends));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblAtFriends = new System.Windows.Forms.Label();
            this.lblMyFriends = new System.Windows.Forms.Label();
            this.btnChooseBack = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lboxChosenFriends = new System.Windows.Forms.ListBox();
            this.lboxFriends = new System.Windows.Forms.ListBox();
            this.btnEnsure = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFinalChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 41);
            this.btnReturn.TabIndex = 69;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblAtFriends
            // 
            this.lblAtFriends.AutoSize = true;
            this.lblAtFriends.Location = new System.Drawing.Point(401, 124);
            this.lblAtFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtFriends.Name = "lblAtFriends";
            this.lblAtFriends.Size = new System.Drawing.Size(53, 18);
            this.lblAtFriends.TabIndex = 67;
            this.lblAtFriends.Text = "@好友";
            // 
            // lblMyFriends
            // 
            this.lblMyFriends.AutoSize = true;
            this.lblMyFriends.Location = new System.Drawing.Point(9, 124);
            this.lblMyFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyFriends.Name = "lblMyFriends";
            this.lblMyFriends.Size = new System.Drawing.Size(80, 18);
            this.lblMyFriends.TabIndex = 66;
            this.lblMyFriends.Text = "我的好友";
            // 
            // btnChooseBack
            // 
            this.btnChooseBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnChooseBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChooseBack.ForeColor = System.Drawing.Color.Black;
            this.btnChooseBack.Location = new System.Drawing.Point(325, 301);
            this.btnChooseBack.Name = "btnChooseBack";
            this.btnChooseBack.Size = new System.Drawing.Size(72, 30);
            this.btnChooseBack.TabIndex = 65;
            this.btnChooseBack.Text = "<-";
            this.btnChooseBack.UseVisualStyleBackColor = false;
            this.btnChooseBack.Click += new System.EventHandler(this.btnChooseBack_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoose.ForeColor = System.Drawing.Color.Black;
            this.btnChoose.Location = new System.Drawing.Point(325, 261);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(72, 34);
            this.btnChoose.TabIndex = 64;
            this.btnChoose.Text = "->";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lboxChosenFriends
            // 
            this.lboxChosenFriends.FormattingEnabled = true;
            this.lboxChosenFriends.ItemHeight = 18;
            this.lboxChosenFriends.Location = new System.Drawing.Point(404, 165);
            this.lboxChosenFriends.Margin = new System.Windows.Forms.Padding(4);
            this.lboxChosenFriends.Name = "lboxChosenFriends";
            this.lboxChosenFriends.Size = new System.Drawing.Size(307, 364);
            this.lboxChosenFriends.TabIndex = 63;
            // 
            // lboxFriends
            // 
            this.lboxFriends.FormattingEnabled = true;
            this.lboxFriends.ItemHeight = 18;
            this.lboxFriends.Location = new System.Drawing.Point(13, 165);
            this.lboxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.lboxFriends.Name = "lboxFriends";
            this.lboxFriends.Size = new System.Drawing.Size(302, 364);
            this.lboxFriends.TabIndex = 62;
            this.lboxFriends.SelectedIndexChanged += new System.EventHandler(this.lboxFriends_SelectedIndexChanged);
            // 
            // btnEnsure
            // 
            this.btnEnsure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnEnsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnsure.ForeColor = System.Drawing.Color.Black;
            this.btnEnsure.Location = new System.Drawing.Point(735, 496);
            this.btnEnsure.Name = "btnEnsure";
            this.btnEnsure.Size = new System.Drawing.Size(84, 29);
            this.btnEnsure.TabIndex = 60;
            this.btnEnsure.Text = "确定";
            this.btnEnsure.UseVisualStyleBackColor = false;
            this.btnEnsure.Click += new System.EventHandler(this.btnEnsure_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(735, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 39);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(644, 718);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 10);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(310, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 33);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "想让谁看到？";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-16, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(855, 42);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // btnFinalChoice
            // 
            this.btnFinalChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnFinalChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFinalChoice.ForeColor = System.Drawing.Color.Black;
            this.btnFinalChoice.Location = new System.Drawing.Point(735, 515);
            this.btnFinalChoice.Name = "btnFinalChoice";
            this.btnFinalChoice.Size = new System.Drawing.Size(84, 10);
            this.btnFinalChoice.TabIndex = 55;
            this.btnFinalChoice.Text = "确定";
            this.btnFinalChoice.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-19, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 10);
            this.label1.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-640, 708);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // tboxSearch
            // 
            this.tboxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.tboxSearch.Location = new System.Drawing.Point(13, 81);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(698, 28);
            this.tboxSearch.TabIndex = 53;
            this.tboxSearch.Text = "搜索";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(735, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 70;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(325, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 30);
            this.button2.TabIndex = 71;
            this.button2.Text = "全选";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UIChooseFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblAtFriends);
            this.Controls.Add(this.lblMyFriends);
            this.Controls.Add(this.btnChooseBack);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lboxChosenFriends);
            this.Controls.Add(this.lboxFriends);
            this.Controls.Add(this.btnEnsure);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFinalChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tboxSearch);
            this.Name = "UIChooseFriends";
            this.Text = "UIChooseFriends";
            this.Load += new System.EventHandler(this.UIChooseFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblAtFriends;
        private System.Windows.Forms.Label lblMyFriends;
        private System.Windows.Forms.Button btnChooseBack;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ListBox lboxChosenFriends;
        private System.Windows.Forms.ListBox lboxFriends;
        private System.Windows.Forms.Button btnEnsure;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFinalChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}