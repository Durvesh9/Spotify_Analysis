namespace Spotify_Analysis
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button tablesButton;
        private System.Windows.Forms.Button visualizeButton;
        private System.Windows.Forms.Button analyticsButton;
        private System.Windows.Forms.DataGridView recentActivityGrid;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label totalStreamsLabel;
        private System.Windows.Forms.Label mostPlayedLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.tablesButton = new System.Windows.Forms.Button();
            this.visualizeButton = new System.Windows.Forms.Button();
            this.analyticsButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.recentActivityGrid = new System.Windows.Forms.DataGridView();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.totalStreamsLabel = new System.Windows.Forms.Label();
            this.mostPlayedLabel = new System.Windows.Forms.Label();
            this.sideMenuPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentActivityGrid)).BeginInit();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.Black;
            this.sideMenuPanel.Controls.Add(this.homeButton);
            this.sideMenuPanel.Controls.Add(this.tablesButton);
            this.sideMenuPanel.Controls.Add(this.visualizeButton);
            this.sideMenuPanel.Controls.Add(this.analyticsButton);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 80);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 688);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(0, 50);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 44);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // tablesButton
            // 
            this.tablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesButton.ForeColor = System.Drawing.Color.White;
            this.tablesButton.Location = new System.Drawing.Point(0, 100);
            this.tablesButton.Name = "tablesButton";
            this.tablesButton.Size = new System.Drawing.Size(200, 44);
            this.tablesButton.TabIndex = 1;
            this.tablesButton.Text = "Tables";
            this.tablesButton.Click += new System.EventHandler(this.tablesButton_Click);
            // 
            // visualizeButton
            // 
            this.visualizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizeButton.ForeColor = System.Drawing.Color.White;
            this.visualizeButton.Location = new System.Drawing.Point(0, 150);
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(200, 44);
            this.visualizeButton.TabIndex = 2;
            this.visualizeButton.Text = "Visualize";
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // analyticsButton
            // 
            this.analyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyticsButton.ForeColor = System.Drawing.Color.White;
            this.analyticsButton.Location = new System.Drawing.Point(0, 200);
            this.analyticsButton.Name = "analyticsButton";
            this.analyticsButton.Size = new System.Drawing.Size(200, 44);
            this.analyticsButton.TabIndex = 3;
            this.analyticsButton.Text = "Analytics";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1024, 80);
            this.headerPanel.TabIndex = 1;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(220, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(100, 23);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Spotify Analysis Dashboard";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Gray;
            this.contentPanel.Controls.Add(this.recentActivityGrid);
            this.contentPanel.Controls.Add(this.statsPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1024, 768);
            this.contentPanel.TabIndex = 2;
            // 
            // recentActivityGrid
            // 
            this.recentActivityGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recentActivityGrid.BackgroundColor = System.Drawing.Color.Black;
            this.recentActivityGrid.ColumnHeadersHeight = 29;
            this.recentActivityGrid.Location = new System.Drawing.Point(220, 280);
            this.recentActivityGrid.Name = "recentActivityGrid";
            this.recentActivityGrid.RowHeadersWidth = 51;
            this.recentActivityGrid.Size = new System.Drawing.Size(700, 300);
            this.recentActivityGrid.TabIndex = 0;
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.DarkGray;
            this.statsPanel.Controls.Add(this.totalStreamsLabel);
            this.statsPanel.Controls.Add(this.mostPlayedLabel);
            this.statsPanel.Location = new System.Drawing.Point(220, 100);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(700, 150);
            this.statsPanel.TabIndex = 1;
            // 
            // totalStreamsLabel
            // 
            this.totalStreamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalStreamsLabel.ForeColor = System.Drawing.Color.White;
            this.totalStreamsLabel.Location = new System.Drawing.Point(20, 20);
            this.totalStreamsLabel.Name = "totalStreamsLabel";
            this.totalStreamsLabel.Size = new System.Drawing.Size(186, 23);
            this.totalStreamsLabel.TabIndex = 0;
            this.totalStreamsLabel.Text = "Total Streams: 0";
            // 
            // mostPlayedLabel
            // 
            this.mostPlayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mostPlayedLabel.ForeColor = System.Drawing.Color.White;
            this.mostPlayedLabel.Location = new System.Drawing.Point(20, 60);
            this.mostPlayedLabel.Name = "mostPlayedLabel";
            this.mostPlayedLabel.Size = new System.Drawing.Size(197, 23);
            this.mostPlayedLabel.TabIndex = 1;
            this.mostPlayedLabel.Text = "Most Played: N/A";
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.contentPanel);
            this.Name = "Dashboard";
            this.Text = "Spotify Analysis Dashboard";
            this.sideMenuPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recentActivityGrid)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
