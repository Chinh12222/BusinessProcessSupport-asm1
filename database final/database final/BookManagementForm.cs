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
    public partial class BookManagementForm : Form
    {
        public BookManagementForm()
        {
            InitializeComponent();
            LoadBooks();
            LoadAuthors();
            LoadCategories();
            LoadPublishers();
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadBooks()
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Books";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBooks.DataSource = dt;
            }
        }
    

        private void LoadAuthors()
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT author_id, author_name FROM Authors";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbAuthors.DataSource = dt;
                cmbAuthors.DisplayMember = "author_name";
                cmbAuthors.ValueMember = "author_id";
            }
        }

        private void LoadCategories()
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT category_id, category_name FROM Categories";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCategories.DataSource = dt;
                cmbCategories.DisplayMember = "category_name";
                cmbCategories.ValueMember = "category_id";
            }
        }

        private void LoadPublishers()
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            
            {
                conn.Open();
                string query = "SELECT publisher_id, publisher_name FROM Publishers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbPublishers.DataSource = dt;
                cmbPublishers.DisplayMember = "publisher_name";
                cmbPublishers.ValueMember = "publisher_id";
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Books (book_name, author_id, category_id, publisher_id, publishing_data) " +
                               "VALUES (@name, @auth_id, @cat_id, @pub_id, @pub_date)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtBookName.Text);
                cmd.Parameters.AddWithValue("@auth_id", cmbAuthors.SelectedValue);
                cmd.Parameters.AddWithValue("@cat_id", cmbCategories.SelectedValue);
                cmd.Parameters.AddWithValue("@pub_id", cmbPublishers.SelectedValue);
                cmd.Parameters.AddWithValue("@pub_date", dtpPublishDate.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book added successfully.");
                LoadBooks();
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Books SET book_name = @name, author_id = @auth_id, category_id = @cat_id, " +
                               "publisher_id = @pub_id, publishing_data = @pub_date WHERE book_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtBookID.Text));
                cmd.Parameters.AddWithValue("@name", txtBookName.Text);
                cmd.Parameters.AddWithValue("@auth_id", cmbAuthors.SelectedValue);
                cmd.Parameters.AddWithValue("@cat_id", cmbCategories.SelectedValue);
                cmd.Parameters.AddWithValue("@pub_id", cmbPublishers.SelectedValue);
                cmd.Parameters.AddWithValue("@pub_date", dtpPublishDate.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book updated successfully.");
                LoadBooks();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPCUACHINHS\\SQLEXPRESS;Initial Catalog=LibraryManagementDatabase;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Books WHERE book_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtBookID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book deleted successfully.");
                LoadBooks();
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBooks.Rows[e.RowIndex];
                txtBookID.Text = row.Cells["book_id"].Value.ToString();
                txtBookName.Text = row.Cells["book_name"].Value.ToString();
                cmbAuthors.SelectedValue = row.Cells["author_id"].Value;
                cmbCategories.SelectedValue = row.Cells["category_id"].Value;
                cmbPublishers.SelectedValue = row.Cells["publisher_id"].Value;
                dtpPublishDate.Value = Convert.ToDateTime(row.Cells["publishing_data"].Value);
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtBookName.Clear();
            cmbAuthors.SelectedIndex = -1;
            cmbCategories.SelectedIndex = -1;
            cmbPublishers.SelectedIndex = -1;
            dtpPublishDate.Value = DateTime.Today;
        }
    }
}
