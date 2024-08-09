using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_final
{
    public partial class BorrowingManagementForm : Form
    {
        public BorrowingManagementForm()
        {
            InitializeComponent();
            LoadBorrowers();
            LoadBooks();
            LoadTickets();
        }

        private void BorrowingManagementForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadBorrowers()
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT borrower_id, borrower_name FROM Borrowers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBorrowers.DataSource = dt;
                cmbBorrowers.DisplayMember = "borrower_name";
                cmbBorrowers.ValueMember = "borrower_id";
            }
        }

        private void LoadBooks()
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT book_id, book_name FROM Books";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBooks.DataSource = dt;
                cmbBooks.DisplayMember = "book_name";
                cmbBooks.ValueMember = "book_id";
            }
        }

        private void LoadTickets()
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Tickets";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTickets.DataSource = dt;
            }
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Tickets (book_id, borrower_id, borrow_date, return_date) " +
                               "VALUES (@book_id, @borrower_id, @borrow_date, @return_date)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@book_id", cmbBooks.SelectedValue);
                cmd.Parameters.AddWithValue("@borrower_id", cmbBorrowers.SelectedValue);
                cmd.Parameters.AddWithValue("@borrow_date", dtpBorrowDate.Value);
                cmd.Parameters.AddWithValue("@return_date", dtpReturnDate.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book borrowed successfully.");
                LoadTickets();
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Tickets SET return_date = @return_date WHERE ticket_id = @ticket_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ticket_id", Convert.ToInt32(txtTicketID.Text));
                cmd.Parameters.AddWithValue("@return_date", DateTime.Now);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book returned successfully.");
                LoadTickets();
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtTicketID.Clear();
            cmbBooks.SelectedIndex = -1;
            cmbBorrowers.SelectedIndex = -1;
            dtpBorrowDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today;
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTickets.Rows[e.RowIndex];
                txtTicketID.Text = row.Cells["ticket_id"].Value.ToString();
                cmbBooks.SelectedValue = row.Cells["book_id"].Value;
                cmbBorrowers.SelectedValue = row.Cells["borrower_id"].Value;
                dtpBorrowDate.Value = Convert.ToDateTime(row.Cells["borrow_date"].Value);
                dtpReturnDate.Value = Convert.ToDateTime(row.Cells["return_date"].Value);
            }
        }
    }
}
