namespace database_final
{
    partial class AdminForm
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
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageBorrowers = new System.Windows.Forms.Button();
            this.btnManageBorrowing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(173, 263);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(143, 31);
            this.btnManageBooks.TabIndex = 0;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnManageBorrowers
            // 
            this.btnManageBorrowers.Location = new System.Drawing.Point(280, 158);
            this.btnManageBorrowers.Name = "btnManageBorrowers";
            this.btnManageBorrowers.Size = new System.Drawing.Size(155, 23);
            this.btnManageBorrowers.TabIndex = 1;
            this.btnManageBorrowers.Text = "Manage Borrowers";
            this.btnManageBorrowers.UseVisualStyleBackColor = true;
            this.btnManageBorrowers.Click += new System.EventHandler(this.btnManageBorrowers_Click_1);
            // 
            // btnManageBorrowing
            // 
            this.btnManageBorrowing.Location = new System.Drawing.Point(523, 263);
            this.btnManageBorrowing.Name = "btnManageBorrowing";
            this.btnManageBorrowing.Size = new System.Drawing.Size(142, 23);
            this.btnManageBorrowing.TabIndex = 2;
            this.btnManageBorrowing.Text = "Manage Borrowing";
            this.btnManageBorrowing.UseVisualStyleBackColor = true;
            this.btnManageBorrowing.Click += new System.EventHandler(this.btnManageBorrowing_Click_1);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageBorrowing);
            this.Controls.Add(this.btnManageBorrowers);
            this.Controls.Add(this.btnManageBooks);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageBorrowers;
        private System.Windows.Forms.Button btnManageBorrowing;
    }
}