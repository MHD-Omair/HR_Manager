namespace HR_Manager_AD0667
{
    partial class frmHRManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHRManager));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUNBar = new System.Windows.Forms.Label();
            this.lblPWBar = new System.Windows.Forms.Label();
            this.lblHRManeger = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlToNavi = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(537, 347);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 27);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(440, 231);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(125, 32);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(571, 242);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(571, 291);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(201, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Tag = "";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(447, 283);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(118, 32);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblUNBar
            // 
            this.lblUNBar.AutoSize = true;
            this.lblUNBar.Location = new System.Drawing.Point(755, 245);
            this.lblUNBar.Name = "lblUNBar";
            this.lblUNBar.Size = new System.Drawing.Size(13, 13);
            this.lblUNBar.TabIndex = 7;
            this.lblUNBar.Text = "×";
            this.lblUNBar.Click += new System.EventHandler(this.lblUNBar_Click_1);
            // 
            // lblPWBar
            // 
            this.lblPWBar.AutoSize = true;
            this.lblPWBar.Location = new System.Drawing.Point(754, 294);
            this.lblPWBar.Name = "lblPWBar";
            this.lblPWBar.Size = new System.Drawing.Size(13, 13);
            this.lblPWBar.TabIndex = 8;
            this.lblPWBar.Text = "×";
            this.lblPWBar.Click += new System.EventHandler(this.lblPWBar_Click_1);
            // 
            // lblHRManeger
            // 
            this.lblHRManeger.AutoSize = true;
            this.lblHRManeger.Font = new System.Drawing.Font("Lucida Calligraphy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRManeger.Location = new System.Drawing.Point(147, 47);
            this.lblHRManeger.Name = "lblHRManeger";
            this.lblHRManeger.Size = new System.Drawing.Size(504, 83);
            this.lblHRManeger.TabIndex = 9;
            this.lblHRManeger.Text = "HR Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnlToNavi
            // 
            this.pnlToNavi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToNavi.Location = new System.Drawing.Point(0, 0);
            this.pnlToNavi.Name = "pnlToNavi";
            this.pnlToNavi.Size = new System.Drawing.Size(804, 481);
            this.pnlToNavi.TabIndex = 10;
            // 
            // frmHRManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblHRManeger);
            this.Controls.Add(this.lblPWBar);
            this.Controls.Add(this.lblUNBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlToNavi);
            this.Name = "frmHRManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUNBar;
        private System.Windows.Forms.Label lblPWBar;
        private System.Windows.Forms.Label lblHRManeger;
        private System.Windows.Forms.Panel pnlToNavi;
    }
}

