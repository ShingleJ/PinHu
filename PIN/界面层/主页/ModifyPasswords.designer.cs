namespace PIN
{
    partial class ModifyPasswordcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyPasswordcs));
            this.back = new System.Windows.Forms.Label();
            this.usedPassword = new System.Windows.Forms.Label();
            this.tNewPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.Label();
            this.tConfirmNewPW = new System.Windows.Forms.TextBox();
            this.confirmNewPW = new System.Windows.Forms.Label();
            this.tIdentitifyCode = new System.Windows.Forms.TextBox();
            this.identitifyCode = new System.Windows.Forms.Label();
            this.displayPassword = new System.Windows.Forms.CheckBox();
            this.confirmPassword = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.back.Location = new System.Drawing.Point(12, 9);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 14);
            this.back.TabIndex = 0;
            this.back.Text = "<返回";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // usedPassword
            // 
            this.usedPassword.AutoSize = true;
            this.usedPassword.BackColor = System.Drawing.Color.Transparent;
            this.usedPassword.ForeColor = System.Drawing.Color.Black;
            this.usedPassword.Location = new System.Drawing.Point(138, 101);
            this.usedPassword.Name = "usedPassword";
            this.usedPassword.Size = new System.Drawing.Size(53, 12);
            this.usedPassword.TabIndex = 2;
            this.usedPassword.Text = "旧密码：";
            // 
            // tNewPassword
            // 
            this.tNewPassword.Location = new System.Drawing.Point(193, 145);
            this.tNewPassword.Multiline = true;
            this.tNewPassword.Name = "tNewPassword";
            this.tNewPassword.PasswordChar = '*';
            this.tNewPassword.Size = new System.Drawing.Size(155, 27);
            this.tNewPassword.TabIndex = 5;
            this.tNewPassword.TextChanged += new System.EventHandler(this.tNewPassword_TextChanged);
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.BackColor = System.Drawing.Color.Transparent;
            this.newPassword.ForeColor = System.Drawing.Color.Black;
            this.newPassword.Location = new System.Drawing.Point(138, 151);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(53, 12);
            this.newPassword.TabIndex = 4;
            this.newPassword.Text = "新密码：";
            // 
            // tConfirmNewPW
            // 
            this.tConfirmNewPW.Location = new System.Drawing.Point(193, 199);
            this.tConfirmNewPW.Multiline = true;
            this.tConfirmNewPW.Name = "tConfirmNewPW";
            this.tConfirmNewPW.PasswordChar = '*';
            this.tConfirmNewPW.Size = new System.Drawing.Size(155, 27);
            this.tConfirmNewPW.TabIndex = 7;
            // 
            // confirmNewPW
            // 
            this.confirmNewPW.AutoSize = true;
            this.confirmNewPW.BackColor = System.Drawing.Color.Transparent;
            this.confirmNewPW.ForeColor = System.Drawing.Color.Black;
            this.confirmNewPW.Location = new System.Drawing.Point(115, 205);
            this.confirmNewPW.Name = "confirmNewPW";
            this.confirmNewPW.Size = new System.Drawing.Size(77, 12);
            this.confirmNewPW.TabIndex = 6;
            this.confirmNewPW.Text = "确认新密码：";
            // 
            // tIdentitifyCode
            // 
            this.tIdentitifyCode.Location = new System.Drawing.Point(193, 256);
            this.tIdentitifyCode.Multiline = true;
            this.tIdentitifyCode.Name = "tIdentitifyCode";
            this.tIdentitifyCode.Size = new System.Drawing.Size(83, 27);
            this.tIdentitifyCode.TabIndex = 9;
            // 
            // identitifyCode
            // 
            this.identitifyCode.AutoSize = true;
            this.identitifyCode.BackColor = System.Drawing.Color.Transparent;
            this.identitifyCode.ForeColor = System.Drawing.Color.Black;
            this.identitifyCode.Location = new System.Drawing.Point(138, 262);
            this.identitifyCode.Name = "identitifyCode";
            this.identitifyCode.Size = new System.Drawing.Size(53, 12);
            this.identitifyCode.TabIndex = 8;
            this.identitifyCode.Text = "验证码：";
            // 
            // displayPassword
            // 
            this.displayPassword.AutoSize = true;
            this.displayPassword.BackColor = System.Drawing.Color.Transparent;
            this.displayPassword.Location = new System.Drawing.Point(193, 314);
            this.displayPassword.Name = "displayPassword";
            this.displayPassword.Size = new System.Drawing.Size(72, 16);
            this.displayPassword.TabIndex = 10;
            this.displayPassword.Text = "显示密码";
            this.displayPassword.UseVisualStyleBackColor = false;
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.confirmPassword.ForeColor = System.Drawing.Color.Black;
            this.confirmPassword.Location = new System.Drawing.Point(184, 357);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(126, 36);
            this.confirmPassword.TabIndex = 11;
            this.confirmPassword.Text = "确认密码";
            this.confirmPassword.UseVisualStyleBackColor = false;
            this.confirmPassword.Click += new System.EventHandler(this.confirmPassword_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(155, 27);
            this.textBox1.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(377, 377);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 66);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(202, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "修改密码";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(491, 28);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // ModifyPasswordcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.displayPassword);
            this.Controls.Add(this.tIdentitifyCode);
            this.Controls.Add(this.identitifyCode);
            this.Controls.Add(this.tConfirmNewPW);
            this.Controls.Add(this.confirmNewPW);
            this.Controls.Add(this.tNewPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.usedPassword);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyPasswordcs";
            this.Text = "ModifyPasswordcs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label usedPassword;
        private System.Windows.Forms.TextBox tNewPassword;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox tConfirmNewPW;
        private System.Windows.Forms.Label confirmNewPW;
        private System.Windows.Forms.TextBox tIdentitifyCode;
        private System.Windows.Forms.Label identitifyCode;
        private System.Windows.Forms.CheckBox displayPassword;
        private System.Windows.Forms.Button confirmPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}