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
    public partial class BorrowerManagementForm : Form
    {
        public BorrowerManagementForm()
        {
            InitializeComponent();
            LoadBorrowers();
        }

        private void BorrowerManagementForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadBorrowers()
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Borrowers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBorrowers.DataSource = dt;
            }
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Borrowers (borrower_name, borrower_DOB, borrower_address, borrower_phone, borrower_email) " +
                               "VALUES (@name, @dob, @address, @phone, @email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtBorrowerName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Borrower added successfully.");
                LoadBorrowers();
                ClearFields();
            }

        }

        private void btnUpdateBorrower_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Borrowers SET borrower_name = @name, borrower_DOB = @dob, borrower_address = @address, borrower_phone = @phone, borrower_email = @email " +
                               "WHERE borrower_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtBorrowerID.Text));
                cmd.Parameters.AddWithValue("@name", txtBorrowerName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Borrower updated successfully.");
                LoadBorrowers();
                ClearFields();
            }
        }

        private void btnDeleteBorrower_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Borrowers WHERE borrower_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtBorrowerID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Borrower deleted successfully.");
                LoadBorrowers();
                ClearFields();
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvBorrowers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBorrowers.Rows[e.RowIndex];
                txtBorrowerID.Text = row.Cells["borrower_id"].Value.ToString();
                txtBorrowerName.Text = row.Cells["borrower_name"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells["borrower_DOB"].Value);
                txtAddress.Text = row.Cells["borrower_address"].Value.ToString();
                txtPhone.Text = row.Cells["borrower_phone"].Value.ToString();
                txtEmail.Text = row.Cells["borrower_email"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            txtBorrowerID.Clear();
            txtBorrowerName.Clear();
            dtpDOB.Value = DateTime.Today;
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }
    }
}
