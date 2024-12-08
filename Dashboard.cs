using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Spotify_Analysis
{
    public partial class Dashboard : Form
    {
        private string connectionString = "server=DURVESH\\SQLEXPRESS;database=spotify;integrated Security=SSPI;";

        public Dashboard()
        {
            InitializeComponent();
            LoadDashboardStats();
            LoadRecentActivity();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "Home button clicked.\r\n";
            visualizationPanel.Controls.Clear();
            // Add more code for Home button functionality
        }

        private void tablesButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text += "Tables button clicked.\r\n";
            visualizationPanel.Controls.Clear();
            // Add more code for Tables button functionality
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text += "Visualize button clicked.\r\n";
            visualizationPanel.Controls.Clear();
            // Add more code for Visualize button functionality
        }

        private void analyticsButton_Click(object sender, EventArgs e)
        {
            // Add code for Analytics button functionality
        }

        // Define additional methods as necessary
    }
}
