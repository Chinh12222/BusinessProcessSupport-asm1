namespace database_final
{
    partial class BorrowingManagementForm
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
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.cmbBorrowers = new System.Windows.Forms.ComboBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(60, 40);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(121, 24);
            this.cmbBooks.TabIndex = 0;
            // 
            // cmbBorrowers
            // 
            this.cmbBorrowers.FormattingEnabled = true;
            this.cmbBorrowers.Location = new System.Drawing.Point(60, 97);
            this.cmbBorrowers.Name = "cmbBorrowers";
            this.cmbBorrowers.Size = new System.Drawing.Size(121, 24);
            this.cmbBorrowers.TabIndex = 1;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(503, 38);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBorrowDate.TabIndex = 2;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(503, 100);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 22);
            this.dtpReturnDate.TabIndex = 3;
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(503, 151);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(100, 22);
            this.txtTicketID.TabIndex = 4;
            // 
            // dgvTickets
            // 
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(12, 194);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 24;
            this.dgvTickets.Size = new System.Drawing.Size(776, 188);
            this.dgvTickets.TabIndex = 5;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(165, 402);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(75, 23);
            this.btnBorrowBook.TabIndex = 6;
            this.btnBorrowBook.Text = "Borrow";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(393, 402);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btnReturnBook.TabIndex = 7;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(599, 402);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(75, 23);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Borrowers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Borrow Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Return Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ticket ID";
            // 
            // BorrowingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.txtTicketID);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.cmbBorrowers);
            this.Controls.Add(this.cmbBooks);
            this.Name = "BorrowingManagementForm";
            this.Text = "BorrowingManagementForm";
            this.Load += new System.EventHandler(this.BorrowingManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.ComboBox cmbBorrowers;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}