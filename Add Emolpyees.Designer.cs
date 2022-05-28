namespace HR_Manager_AD0667
{
    partial class frmAddEmolpyees
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
            this.lblCertificate = new System.Windows.Forms.Label();
            this.lblDayOfBirthday = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lstCertificate = new System.Windows.Forms.ListBox();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtEmployeeDi = new System.Windows.Forms.TextBox();
            this.lblEmployeeDi = new System.Windows.Forms.Label();
            this.dtpEmployeeDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAddCertificate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCertificate
            // 
            this.lblCertificate.AutoSize = true;
            this.lblCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificate.Location = new System.Drawing.Point(246, 254);
            this.lblCertificate.Name = "lblCertificate";
            this.lblCertificate.Size = new System.Drawing.Size(109, 25);
            this.lblCertificate.TabIndex = 18;
            this.lblCertificate.Text = "Certificate";
            // 
            // lblDayOfBirthday
            // 
            this.lblDayOfBirthday.AutoSize = true;
            this.lblDayOfBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfBirthday.Location = new System.Drawing.Point(192, 191);
            this.lblDayOfBirthday.Name = "lblDayOfBirthday";
            this.lblDayOfBirthday.Size = new System.Drawing.Size(163, 25);
            this.lblDayOfBirthday.TabIndex = 16;
            this.lblDayOfBirthday.Text = "Day Of Birthday";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(361, 133);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(413, 31);
            this.txtEmployeeName.TabIndex = 15;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(186, 136);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(169, 25);
            this.lblEmpName.TabIndex = 14;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lstCertificate
            // 
            this.lstCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCertificate.FormattingEnabled = true;
            this.lstCertificate.ItemHeight = 25;
            this.lstCertificate.Items.AddRange(new object[] {
            "Tawjihi",
            "Bachelor",
            "Master",
            "PhD"});
            this.lstCertificate.Location = new System.Drawing.Point(361, 245);
            this.lstCertificate.Name = "lstCertificate";
            this.lstCertificate.Size = new System.Drawing.Size(335, 104);
            this.lstCertificate.TabIndex = 13;
            this.lstCertificate.Click += new System.EventHandler(this.lstAddDegree_Click);
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(12, 23);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(238, 36);
            this.lblAddEmployee.TabIndex = 24;
            this.lblAddEmployee.Text = "Add Employee";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "a->z",
            "z ->a"});
            this.comboBox1.Location = new System.Drawing.Point(545, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(297, 449);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(503, 37);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtEmployeeDi
            // 
            this.txtEmployeeDi.Enabled = false;
            this.txtEmployeeDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeDi.Location = new System.Drawing.Point(361, 83);
            this.txtEmployeeDi.Name = "txtEmployeeDi";
            this.txtEmployeeDi.Size = new System.Drawing.Size(256, 31);
            this.txtEmployeeDi.TabIndex = 28;
            // 
            // lblEmployeeDi
            // 
            this.lblEmployeeDi.AutoSize = true;
            this.lblEmployeeDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDi.Location = new System.Drawing.Point(222, 86);
            this.lblEmployeeDi.Name = "lblEmployeeDi";
            this.lblEmployeeDi.Size = new System.Drawing.Size(133, 25);
            this.lblEmployeeDi.TabIndex = 27;
            this.lblEmployeeDi.Text = "Employee DI";
            // 
            // dtpEmployeeDOB
            // 
            this.dtpEmployeeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmployeeDOB.Location = new System.Drawing.Point(361, 190);
            this.dtpEmployeeDOB.Name = "dtpEmployeeDOB";
            this.dtpEmployeeDOB.Size = new System.Drawing.Size(282, 26);
            this.dtpEmployeeDOB.TabIndex = 29;
            // 
            // btnAddCertificate
            // 
            this.btnAddCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCertificate.Location = new System.Drawing.Point(370, 359);
            this.btnAddCertificate.Name = "btnAddCertificate";
            this.btnAddCertificate.Size = new System.Drawing.Size(130, 33);
            this.btnAddCertificate.TabIndex = 19;
            this.btnAddCertificate.Text = "Add";
            this.btnAddCertificate.UseVisualStyleBackColor = true;
            this.btnAddCertificate.Click += new System.EventHandler(this.btnAddDegree_Click);
            // 
            // frmAddEmolpyees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 513);
            this.Controls.Add(this.dtpEmployeeDOB);
            this.Controls.Add(this.txtEmployeeDi);
            this.Controls.Add(this.lblEmployeeDi);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAddEmployee);
            this.Controls.Add(this.btnAddCertificate);
            this.Controls.Add(this.lblCertificate);
            this.Controls.Add(this.lblDayOfBirthday);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lstCertificate);
            this.Name = "frmAddEmolpyees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Emolpyees";
            this.Activated += new System.EventHandler(this.frmNavigation_Activated);
            this.Load += new System.EventHandler(this.frmNavigation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCertificate;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.ListBox lstCertificate;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtEmployeeDi;
        private System.Windows.Forms.Label lblEmployeeDi;
        public System.Windows.Forms.Label lblDayOfBirthday;
        private System.Windows.Forms.DateTimePicker dtpEmployeeDOB;
        private System.Windows.Forms.Button btnAddCertificate;
    }
}