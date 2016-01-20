namespace PIN
{
    partial class UISearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UISearch));
            this.Tabcon = new System.Windows.Forms.TabControl();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tabcon
            // 
            resources.ApplyResources(this.Tabcon, "Tabcon");
            this.Tabcon.Name = "Tabcon";
            this.Tabcon.SelectedIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UISearch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Tabcon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UISearch";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabcon;
        private System.Windows.Forms.Button btnExit;

    }
}