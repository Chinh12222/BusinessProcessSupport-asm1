using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_final
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            BookManagementForm bookForm = new BookManagementForm();
            bookForm.Show();
        }
        private void btnManageBorrowers_Click(object sender, EventArgs e)
        {

        }

        private void btnManageBorrowing_Click(object sender, EventArgs e)
        {
           
        }

        private void btnManageBorrowers_Click_1(object sender, EventArgs e)
        {
            BorrowerManagementForm borrowerForm = new BorrowerManagementForm();
            borrowerForm.Show();
        }

        private void btnManageBorrowing_Click_1(object sender, EventArgs e)
        {
            BorrowingManagementForm borrowingForm = new BorrowingManagementForm();
            borrowingForm.Show();
        }
    }
}
