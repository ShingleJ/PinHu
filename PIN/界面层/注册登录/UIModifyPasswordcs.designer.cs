namespace PIN
{
    partial class UIModifyPassword
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
            this.back = new System.Windows.Forms.Label();
            this.modifyPassword = new System.Windows.Forms.Label();
            this.usedPassword = new System.Windows.Forms.Label();
            this.tOldPassword = new System.Windows.Forms.TextBox();
            this.tNewPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.Label();
            this.tConfirmNewPW = new System.Windows.Forms.TextBox();
            this.confirmNewPW = new System.Windows.Forms.Label();
            this.tIdentitifyCode = new System.Windows.Forms.TextBox();
            this.identitifyCode = new System.Windows.Forms.Label();
            this.displayPassword = new System.Windows.Forms.CheckBox();
            this.confirmPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(32, 24);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(35, 12);
            this.back.TabIndex = 0;
            this.back.Text = "<返回";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // modifyPassword
            // 
            this.modifyPassword.AutoSize = true;
            this.modifyPassword.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyPassword.Location = new System.Drawing.Point(115, 19);
            this.modifyPassword.Name = "modifyPassword";
            this.modifyPassword.Size = new System.Drawing.Size(94, 21);
            this.modifyPassword.TabIndex = 1;
            this.modifyPassword.Text = "修改密码";
            // 
            // usedPassword
            // 
            this.usedPassword.AutoSize = true;
            this.usedPassword.Location = new System.Drawing.Point(47, 83);
            this.usedPassword.Name = "usedPassword";
            this.usedPassword.Size = new System.Drawing.Size(53, 12);
            this.usedPassword.TabIndex = 2;
            this.usedPassword.Text = "旧密码：";
            // 
            // tOldPassword
            // 
            this.tOldPassword.Location = new System.Drawing.Point(102, 77);
            this.tOldPassword.Name = "tOldPassword";
            this.tOldPassword.PasswordChar = '*';
            this.tOldPassword.Size = new System.Drawing.Size(155, 21);
            this.tOldPassword.TabIndex = 3;
            // 
            // tNewPassword
            // 
            this.tNewPassword.Location = new System.Drawing.Point(102, 127);
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
            this.newPassword.Location = new System.Drawing.Point(47, 133);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(53, 12);
            this.newPassword.TabIndex = 4;
            this.newPassword.Text = "新密码：";
            // 
            // tConfirmNewPW
            // 
            this.tConfirmNewPW.Location = new System.Drawing.Point(102, 181);
            this.tConfirmNewPW.Multiline = true;
            this.tConfirmNewPW.Name = "tConfirmNewPW";
            this.tConfirmNewPW.PasswordChar = '*';
            this.tConfirmNewPW.Size = new System.Drawing.Size(155, 27);
            this.tConfirmNewPW.TabIndex = 7;
            // 
            // confirmNewPW
            // 
            this.confirmNewPW.AutoSize = true;
            this.confirmNewPW.Location = new System.Drawing.Point(32, 187);
            this.confirmNewPW.Name = "confirmNewPW";
            this.confirmNewPW.Size = new System.Drawing.Size(77, 12);
            this.confirmNewPW.TabIndex = 6;
            this.confirmNewPW.Text = "确认新密码：";
            // 
            // tIdentitifyCode
            // 
            this.tIdentitifyCode.Location = new System.Drawing.Point(102, 238);
            this.tIdentitifyCode.Multiline = true;
            this.tIdentitifyCode.Name = "tIdentitifyCode";
            this.tIdentitifyCode.Size = new System.Drawing.Size(83, 27);
            this.tIdentitifyCode.TabIndex = 9;
            // 
            // identitifyCode
            // 
            this.identitifyCode.AutoSize = true;
            this.identitifyCode.Location = new System.Drawing.Point(47, 244);
            this.identitifyCode.Name = "identitifyCode";
            this.identitifyCode.Size = new System.Drawing.Size(53, 12);
            this.identitifyCode.TabIndex = 8;
            this.identitifyCode.Text = "验证码：";
            // 
            // displayPassword
            // 
            this.displayPassword.AutoSize = true;
            this.displayPassword.Location = new System.Drawing.Point(102, 296);
            this.displayPassword.Name = "displayPassword";
            this.displayPassword.Size = new System.Drawing.Size(72, 16);
            this.displayPassword.TabIndex = 10;
            this.displayPassword.Text = "显示密码";
            this.displayPassword.UseVisualStyleBackColor = true;
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.PaleGreen;
            this.confirmPassword.Location = new System.Drawing.Point(93, 339);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(126, 36);
            this.confirmPassword.TabIndex = 11;
            this.confirmPassword.Text = "确认密码";
            this.confirmPassword.UseVisualStyleBackColor = false;
            this.confirmPassword.Click += new System.EventHandler(this.confirmPassword_Click);
            // 
            // ModifyPasswordcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 447);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.displayPassword);
            this.Controls.Add(this.tIdentitifyCode);
            this.Controls.Add(this.identitifyCode);
            this.Controls.Add(this.tConfirmNewPW);
            this.Controls.Add(this.confirmNewPW);
            this.Controls.Add(this.tNewPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.tOldPassword);
            this.Controls.Add(this.usedPassword);
            this.Controls.Add(this.modifyPassword);
            this.Controls.Add(this.back);
            this.Name = "ModifyPasswordcs";
            this.Text = "ModifyPasswordcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label modifyPassword;
        private System.Windows.Forms.Label usedPassword;
        private System.Windows.Forms.TextBox tOldPassword;
        private System.Windows.Forms.TextBox tNewPassword;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox tConfirmNewPW;
        private System.Windows.Forms.Label confirmNewPW;
        private System.Windows.Forms.TextBox tIdentitifyCode;
        private System.Windows.Forms.Label identitifyCode;
        private System.Windows.Forms.CheckBox displayPassword;
        private System.Windows.Forms.Button confirmPassword;
    }
}