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
            this.btnAddDegree = new System.Windows.Forms.Button();
            this.lblEmployeeDegree = new System.Windows.Forms.Label();
            this.txtEmployeeLast = new System.Windows.Forms.TextBox();
            this.lblEmpLsetName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lstAddDegree = new System.Windows.Forms.ListBox();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtEmployeeNo = new System.Windows.Forms.TextBox();
            this.lblEmployeeNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddDegree
            // 
            this.btnAddDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDegree.Location = new System.Drawing.Point(370, 380);
            this.btnAddDegree.Name = "btnAddDegree";
            this.btnAddDegree.Size = new System.Drawing.Size(130, 33);
            this.btnAddDegree.TabIndex = 19;
            this.btnAddDegree.Text = "Add";
            this.btnAddDegree.UseVisualStyleBackColor = true;
            this.btnAddDegree.Click += new System.EventHandler(this.btnAddDegree_Click);
            // 
            // lblEmployeeDegree
            // 
            this.lblEmployeeDegree.AutoSize = true;
            this.lblEmployeeDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDegree.Location = new System.Drawing.Point(172, 258);
            this.lblEmployeeDegree.Name = "lblEmployeeDegree";
            this.lblEmployeeDegree.Size = new System.Drawing.Size(183, 25);
            this.lblEmployeeDegree.TabIndex = 18;
            this.lblEmployeeDegree.Text = "Employee Degree";
            // 
            // txtEmployeeLast
            // 
            this.txtEmployeeLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLast.Location = new System.Drawing.Point(361, 185);
            this.txtEmployeeLast.Name = "txtEmployeeLast";
            this.txtEmployeeLast.Size = new System.Drawing.Size(413, 31);
            this.txtEmployeeLast.TabIndex = 17;
            // 
            // lblEmpLsetName
            // 
            this.lblEmpLsetName.AutoSize = true;
            this.lblEmpLsetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLsetName.Location = new System.Drawing.Point(124, 188);
            this.lblEmpLsetName.Name = "lblEmpLsetName";
            this.lblEmpLsetName.Size = new System.Drawing.Size(231, 25);
            this.lblEmpLsetName.TabIndex = 16;
            this.lblEmpLsetName.Text = "Employee\'s Last Name";
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
            // lstAddDegree
            // 
            this.lstAddDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAddDegree.FormattingEnabled = true;
            this.lstAddDegree.ItemHeight = 25;
            this.lstAddDegree.Items.AddRange(new object[] {
            "HTC"});
            this.lstAddDegree.Location = new System.Drawing.Point(361, 245);
            this.lstAddDegree.Name = "lstAddDegree";
            this.lstAddDegree.Size = new System.Drawing.Size(335, 129);
            this.lstAddDegree.TabIndex = 13;
            this.lstAddDegree.Click += new System.EventHandler(this.lstAddDegree_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(545, 381);
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
            // txtEmployeeNo
            // 
            this.txtEmployeeNo.Enabled = false;
            this.txtEmployeeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNo.Location = new System.Drawing.Point(361, 83);
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.Size = new System.Drawing.Size(256, 31);
            this.txtEmployeeNo.TabIndex = 28;
            // 
            // lblEmployeeNo
            // 
            this.lblEmployeeNo.AutoSize = true;
            this.lblEmployeeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNo.Location = new System.Drawing.Point(215, 86);
            this.lblEmployeeNo.Name = "lblEmployeeNo";
            this.lblEmployeeNo.Size = new System.Drawing.Size(140, 25);
            this.lblEmployeeNo.TabIndex = 27;
            this.lblEmployeeNo.Text = "Employee No";
            // 
            // frmAddEmolpyees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 513);
            this.Controls.Add(this.txtEmployeeNo);
            this.Controls.Add(this.lblEmployeeNo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAddEmployee);
            this.Controls.Add(this.btnAddDegree);
            this.Controls.Add(this.lblEmployeeDegree);
            this.Controls.Add(this.txtEmployeeLast);
            this.Controls.Add(this.lblEmpLsetName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lstAddDegree);
            this.Name = "frmAddEmolpyees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Emolpyees";
            this.Activated += new System.EventHandler(this.frmNavigation_Activated);
            this.Load += new System.EventHandler(this.frmNavigation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddDegree;
        private System.Windows.Forms.Label lblEmployeeDegree;
        private System.Windows.Forms.TextBox txtEmployeeLast;
        private System.Windows.Forms.Label lblEmpLsetName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.ListBox lstAddDegree;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtEmployeeNo;
        private System.Windows.Forms.Label lblEmployeeNo;
    }
}