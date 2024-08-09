namespace database_final
{
    partial class BorrowerManagementForm
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
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.txtBorrowerName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAddBorrower = new System.Windows.Forms.Button();
            this.btnUpdateBorrower = new System.Windows.Forms.Button();
            this.btnDeleteBorrower = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.Location = new System.Drawing.Point(136, 105);
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(100, 22);
            this.txtBorrowerID.TabIndex = 0;
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.Location = new System.Drawing.Point(136, 169);
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.Size = new System.Drawing.Size(100, 22);
            this.txtBorrowerName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(136, 239);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(632, 105);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(632, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(632, 226);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 6;
            // 
            // btnAddBorrower
            // 
            this.btnAddBorrower.Location = new System.Drawing.Point(125, 592);
            this.btnAddBorrower.Name = "btnAddBorrower";
            this.btnAddBorrower.Size = new System.Drawing.Size(75, 23);
            this.btnAddBorrower.TabIndex = 7;
            this.btnAddBorrower.Text = "Add";
            this.btnAddBorrower.UseVisualStyleBackColor = true;
            this.btnAddBorrower.Click += new System.EventHandler(this.btnAddBorrower_Click);
            // 
            // btnUpdateBorrower
            // 
            this.btnUpdateBorrower.Location = new System.Drawing.Point(285, 592);
            this.btnUpdateBorrower.Name = "btnUpdateBorrower";
            this.btnUpdateBorrower.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBorrower.TabIndex = 8;
            this.btnUpdateBorrower.Text = "Update";
            this.btnUpdateBorrower.UseVisualStyleBackColor = true;
            this.btnUpdateBorrower.Click += new System.EventHandler(this.btnUpdateBorrower_Click);
            // 
            // btnDeleteBorrower
            // 
            this.btnDeleteBorrower.Location = new System.Drawing.Point(485, 592);
            this.btnDeleteBorrower.Name = "btnDeleteBorrower";
            this.btnDeleteBorrower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteBorrower.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBorrower.TabIndex = 9;
            this.btnDeleteBorrower.Text = "Delete";
            this.btnDeleteBorrower.UseVisualStyleBackColor = true;
            this.btnDeleteBorrower.Click += new System.EventHandler(this.btnDeleteBorrower_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(742, 592);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(102, 23);
            this.btnClearFields.TabIndex = 10;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // dgvBorrowers
            // 
            this.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowers.Location = new System.Drawing.Point(82, 307);
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.RowHeadersWidth = 51;
            this.dgvBorrowers.RowTemplate.Height = 24;
            this.dgvBorrowers.Size = new System.Drawing.Size(762, 230);
            this.dgvBorrowers.TabIndex = 11;
            this.dgvBorrowers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Borrower ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Borrower Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "DOB";
            // 
            // BorrowerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 686);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBorrowers);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDeleteBorrower);
            this.Controls.Add(this.btnUpdateBorrower);
            this.Controls.Add(this.btnAddBorrower);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBorrowerName);
            this.Controls.Add(this.txtBorrowerID);
            this.Name = "BorrowerManagementForm";
            this.Text = "BorrowerManagementForm";
            this.Load += new System.EventHandler(this.BorrowerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.TextBox txtBorrowerName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnAddBorrower;
        private System.Windows.Forms.Button btnUpdateBorrower;
        private System.Windows.Forms.Button btnDeleteBorrower;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}