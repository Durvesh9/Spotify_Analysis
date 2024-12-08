using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Spotify_Analysis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
                
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            MessageBox.Show($"Attempting login for: {user}");

            string connectionString = "server=DURVESH\\SQLEXPRESS;database=spotify;integrated Security=SSPI;";

            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                try
                {
                    _con.Open();  // Try opening the connection
                    MessageBox.Show("Database connection successful");

                    string queryStatement = "SELECT * FROM users WHERE username = @username AND password = @password";
                    using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                    {
                        _cmd.Parameters.AddWithValue("@username", user);
                        _cmd.Parameters.AddWithValue("@password", pass);

                        DataTable customerTable = new DataTable();
                        SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                        _dap.Fill(customerTable);

                        if (customerTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();  // Hide the login form
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    _con.Close();  // Make sure the connection is closed
                }
            }
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
