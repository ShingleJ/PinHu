namespace PIN
{
    partial class UITestDBCon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxname = new System.Windows.Forms.TextBox();
            this.tboxpw = new System.Windows.Forms.TextBox();
            this.conDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // tboxname
            // 
            this.tboxname.Location = new System.Drawing.Point(85, 32);
            this.tboxname.Margin = new System.Windows.Forms.Padding(2);
            this.tboxname.Name = "tboxname";
            this.tboxname.Size = new System.Drawing.Size(68, 21);
            this.tboxname.TabIndex = 2;
            // 
            // tboxpw
            // 
            this.tboxpw.Location = new System.Drawing.Point(85, 65);
            this.tboxpw.Margin = new System.Windows.Forms.Padding(2);
            this.tboxpw.Name = "tboxpw";
            this.tboxpw.Size = new System.Drawing.Size(68, 21);
            this.tboxpw.TabIndex = 3;
            // 
            // conDB
            // 
            this.conDB.Location = new System.Drawing.Point(48, 105);
            this.conDB.Margin = new System.Windows.Forms.Padding(2);
            this.conDB.Name = "conDB";
            this.conDB.Size = new System.Drawing.Size(90, 27);
            this.conDB.TabIndex = 4;
            this.conDB.Text = "连接数据库";
            this.conDB.UseVisualStyleBackColor = true;
            this.conDB.Click += new System.EventHandler(this.conDB_Click);
            // 
            // UITestDBCon
            // 
            this.AcceptButton = this.conDB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(185, 163);
            this.Controls.Add(this.conDB);
            this.Controls.Add(this.tboxpw);
            this.Controls.Add(this.tboxname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UITestDBCon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接数据库";
            this.Load += new System.EventHandler(this.TestDBCon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxname;
        private System.Windows.Forms.TextBox tboxpw;
        private System.Windows.Forms.Button conDB;
    }
}