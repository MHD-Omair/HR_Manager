namespace HR_Manager_AD0667
{
    partial class frmAddDegree
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
            this.btnAddDegree = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddDegree = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddDegree
            // 
            this.btnAddDegree.AutoSize = true;
            this.btnAddDegree.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDegree.Location = new System.Drawing.Point(27, 28);
            this.btnAddDegree.Name = "btnAddDegree";
            this.btnAddDegree.Size = new System.Drawing.Size(115, 21);
            this.btnAddDegree.TabIndex = 0;
            this.btnAddDegree.Text = "Add Degree";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(165, 62);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(256, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // txtAddDegree
            // 
            this.txtAddDegree.Location = new System.Drawing.Point(141, 30);
            this.txtAddDegree.Name = "txtAddDegree";
            this.txtAddDegree.Size = new System.Drawing.Size(229, 20);
            this.txtAddDegree.TabIndex = 3;
            // 
            // frmAddDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 96);
            this.Controls.Add(this.txtAddDegree);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAddDegree);
            this.Name = "frmAddDegree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Degree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnAddDegree;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddDegree;
    }
}