namespace HR_Manager_AD0667
{
    partial class frmAttendance
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
            this.lblAttendance = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.dtpEmployeeDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCertificate = new System.Windows.Forms.Label();
            this.lblDayOfBirthday = new System.Windows.Forms.Label();
            this.lstCertificate = new System.Windows.Forms.ListBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(12, 28);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(194, 36);
            this.lblAttendance.TabIndex = 25;
            this.lblAttendance.Text = "Attendance";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(481, 163);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(549, 289);
            this.dgvAttendance.TabIndex = 26;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(179, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 27;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(179, 185);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(227, 22);
            this.txtEmployeeName.TabIndex = 29;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblEmployeeName.Location = new System.Drawing.Point(4, 181);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(169, 25);
            this.lblEmployeeName.TabIndex = 30;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblEmployeeId.Location = new System.Drawing.Point(37, 133);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(133, 25);
            this.lblEmployeeId.TabIndex = 31;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // dtpEmployeeDOB
            // 
            this.dtpEmployeeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmployeeDOB.Location = new System.Drawing.Point(179, 229);
            this.dtpEmployeeDOB.Name = "dtpEmployeeDOB";
            this.dtpEmployeeDOB.Size = new System.Drawing.Size(227, 22);
            this.dtpEmployeeDOB.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "a->z",
            "z ->a"});
            this.comboBox1.Location = new System.Drawing.Point(315, 358);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 23);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCertificate
            // 
            this.lblCertificate.AutoSize = true;
            this.lblCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificate.Location = new System.Drawing.Point(64, 284);
            this.lblCertificate.Name = "lblCertificate";
            this.lblCertificate.Size = new System.Drawing.Size(109, 25);
            this.lblCertificate.TabIndex = 34;
            this.lblCertificate.Text = "Certificate";
            // 
            // lblDayOfBirthday
            // 
            this.lblDayOfBirthday.AutoSize = true;
            this.lblDayOfBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfBirthday.Location = new System.Drawing.Point(10, 230);
            this.lblDayOfBirthday.Name = "lblDayOfBirthday";
            this.lblDayOfBirthday.Size = new System.Drawing.Size(163, 25);
            this.lblDayOfBirthday.TabIndex = 33;
            this.lblDayOfBirthday.Text = "Day Of Birthday";
            // 
            // lstCertificate
            // 
            this.lstCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCertificate.FormattingEnabled = true;
            this.lstCertificate.ItemHeight = 16;
            this.lstCertificate.Items.AddRange(new object[] {
            "Tawjihi",
            "Bachelor",
            "Master",
            "PhD"});
            this.lstCertificate.Location = new System.Drawing.Point(179, 274);
            this.lstCertificate.Name = "lstCertificate";
            this.lstCertificate.Size = new System.Drawing.Size(227, 68);
            this.lstCertificate.TabIndex = 32;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(42, 429);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(126, 34);
            this.btnAddEmployee.TabIndex = 38;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdata
            // 
            this.btnUpdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdata.Location = new System.Drawing.Point(174, 429);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(126, 34);
            this.btnUpdata.TabIndex = 39;
            this.btnUpdata.Text = "Updata";
            this.btnUpdata.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(306, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 34);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 513);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdata);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dtpEmployeeDOB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCertificate);
            this.Controls.Add(this.lblDayOfBirthday);
            this.Controls.Add(this.lstCertificate);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.lblAttendance);
            this.Name = "frmAttendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.DateTimePicker dtpEmployeeDOB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCertificate;
        public System.Windows.Forms.Label lblDayOfBirthday;
        private System.Windows.Forms.ListBox lstCertificate;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btnDelete;
    }
}