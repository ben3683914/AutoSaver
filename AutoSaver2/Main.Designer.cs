namespace AutoSaver2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "test",
            "test2"}, -1);
            this.ServiceControlButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.GamesListBox = new System.Windows.Forms.ListBox();
            this.ServiceStatus = new System.Windows.Forms.Label();
            this.ServiceStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MonitorStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SavesListBox = new System.Windows.Forms.ListView();
            this.fileName = new System.Windows.Forms.ColumnHeader();
            this.createdTime = new System.Windows.Forms.ColumnHeader();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.RestoreLatestButton = new System.Windows.Forms.Button();
            this.SelectedGameLabel = new System.Windows.Forms.Label();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripServiceStatusIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripMonitoredGameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveFileWatcher = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveFileWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceControlButton
            // 
            this.ServiceControlButton.Location = new System.Drawing.Point(398, 17);
            this.ServiceControlButton.Name = "ServiceControlButton";
            this.ServiceControlButton.Size = new System.Drawing.Size(84, 23);
            this.ServiceControlButton.TabIndex = 0;
            this.ServiceControlButton.Text = "{Text}";
            this.ServiceControlButton.UseVisualStyleBackColor = true;
            this.ServiceControlButton.Click += new System.EventHandler(this.ServiceControlButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.MenuAddGame,
            this.MenuEditGame,
            this.MenuDeleteGame,
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultGamesToolStripMenuItem,
            this.MenuOpenLogs,
            this.MenuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDefaultGamesToolStripMenuItem
            // 
            this.loadDefaultGamesToolStripMenuItem.Name = "loadDefaultGamesToolStripMenuItem";
            this.loadDefaultGamesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadDefaultGamesToolStripMenuItem.Text = "Load Default Games";
            this.loadDefaultGamesToolStripMenuItem.Click += new System.EventHandler(this.MenuLoadDefaultList_Click);
            // 
            // MenuOpenLogs
            // 
            this.MenuOpenLogs.Name = "MenuOpenLogs";
            this.MenuOpenLogs.Size = new System.Drawing.Size(180, 22);
            this.MenuOpenLogs.Text = "Open Log Location";
            this.MenuOpenLogs.Click += new System.EventHandler(this.MenuOpenLogs_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(180, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuAddGame
            // 
            this.MenuAddGame.Name = "MenuAddGame";
            this.MenuAddGame.Size = new System.Drawing.Size(75, 20);
            this.MenuAddGame.Text = "Add Game";
            this.MenuAddGame.Click += new System.EventHandler(this.MenuAddGame_Click);
            // 
            // MenuEditGame
            // 
            this.MenuEditGame.Name = "MenuEditGame";
            this.MenuEditGame.Size = new System.Drawing.Size(73, 20);
            this.MenuEditGame.Text = "Edit Game";
            this.MenuEditGame.Click += new System.EventHandler(this.MenuEditGame_Click);
            // 
            // MenuDeleteGame
            // 
            this.MenuDeleteGame.Name = "MenuDeleteGame";
            this.MenuDeleteGame.Size = new System.Drawing.Size(86, 20);
            this.MenuDeleteGame.Text = "Delete Game";
            this.MenuDeleteGame.Click += new System.EventHandler(this.MenuDeleteGame_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuAbout.Text = "About";
            // 
            // GamesListBox
            // 
            this.GamesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GamesListBox.DisplayMember = "Title";
            this.GamesListBox.FormattingEnabled = true;
            this.GamesListBox.ItemHeight = 15;
            this.GamesListBox.Location = new System.Drawing.Point(0, 27);
            this.GamesListBox.Name = "GamesListBox";
            this.GamesListBox.Size = new System.Drawing.Size(157, 379);
            this.GamesListBox.Sorted = true;
            this.GamesListBox.TabIndex = 2;
            this.GamesListBox.SelectedIndexChanged += new System.EventHandler(this.GamesListBox_SelectedIndexChanged);
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.AutoSize = true;
            this.ServiceStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServiceStatus.Location = new System.Drawing.Point(6, 19);
            this.ServiceStatus.Name = "ServiceStatus";
            this.ServiceStatus.Size = new System.Drawing.Size(109, 21);
            this.ServiceStatus.TabIndex = 3;
            this.ServiceStatus.Text = "Service Status:";
            // 
            // ServiceStatusLabel
            // 
            this.ServiceStatusLabel.AutoSize = true;
            this.ServiceStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServiceStatusLabel.Location = new System.Drawing.Point(110, 19);
            this.ServiceStatusLabel.Name = "ServiceStatusLabel";
            this.ServiceStatusLabel.Size = new System.Drawing.Size(69, 21);
            this.ServiceStatusLabel.TabIndex = 4;
            this.ServiceStatusLabel.Text = "{Status}";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MonitorStatusLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServiceStatusLabel);
            this.groupBox1.Controls.Add(this.ServiceStatus);
            this.groupBox1.Controls.Add(this.ServiceControlButton);
            this.groupBox1.Location = new System.Drawing.Point(163, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Control";
            // 
            // MonitorStatusLabel
            // 
            this.MonitorStatusLabel.AutoSize = true;
            this.MonitorStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonitorStatusLabel.Location = new System.Drawing.Point(125, 45);
            this.MonitorStatusLabel.Name = "MonitorStatusLabel";
            this.MonitorStatusLabel.Size = new System.Drawing.Size(35, 15);
            this.MonitorStatusLabel.TabIndex = 5;
            this.MonitorStatusLabel.Text = "{title}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currently Monitoring:";
            // 
            // SavesListBox
            // 
            this.SavesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SavesListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.createdTime});
            this.SavesListBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.SavesListBox.Location = new System.Drawing.Point(174, 139);
            this.SavesListBox.MultiSelect = false;
            this.SavesListBox.Name = "SavesListBox";
            this.SavesListBox.Size = new System.Drawing.Size(477, 267);
            this.SavesListBox.TabIndex = 6;
            this.SavesListBox.UseCompatibleStateImageBehavior = false;
            this.SavesListBox.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "File Name";
            this.fileName.Width = 250;
            // 
            // createdTime
            // 
            this.createdTime.Text = "Created";
            this.createdTime.Width = 200;
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreButton.Location = new System.Drawing.Point(477, 110);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(75, 23);
            this.RestoreButton.TabIndex = 7;
            this.RestoreButton.Text = "Restore";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // RestoreLatestButton
            // 
            this.RestoreLatestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreLatestButton.Location = new System.Drawing.Point(558, 110);
            this.RestoreLatestButton.Name = "RestoreLatestButton";
            this.RestoreLatestButton.Size = new System.Drawing.Size(92, 23);
            this.RestoreLatestButton.TabIndex = 8;
            this.RestoreLatestButton.Text = "Restore Latest";
            this.RestoreLatestButton.UseVisualStyleBackColor = true;
            this.RestoreLatestButton.Click += new System.EventHandler(this.RestoreLatestButton_Click);
            // 
            // SelectedGameLabel
            // 
            this.SelectedGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedGameLabel.AutoSize = true;
            this.SelectedGameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedGameLabel.Location = new System.Drawing.Point(174, 112);
            this.SelectedGameLabel.Name = "SelectedGameLabel";
            this.SelectedGameLabel.Size = new System.Drawing.Size(117, 21);
            this.SelectedGameLabel.TabIndex = 9;
            this.SelectedGameLabel.Text = "{selectedGame}";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripServiceStatusIndicator,
            this.ToolStripMonitoredGameLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 409);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(663, 22);
            this.MainStatusStrip.SizingGrip = false;
            this.MainStatusStrip.TabIndex = 10;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // ToolStripServiceStatusIndicator
            // 
            this.ToolStripServiceStatusIndicator.Name = "ToolStripServiceStatusIndicator";
            this.ToolStripServiceStatusIndicator.Size = new System.Drawing.Size(19, 17);
            this.ToolStripServiceStatusIndicator.Text = "⚫";
            // 
            // ToolStripMonitoredGameLabel
            // 
            this.ToolStripMonitoredGameLabel.Name = "ToolStripMonitoredGameLabel";
            this.ToolStripMonitoredGameLabel.Size = new System.Drawing.Size(67, 17);
            this.ToolStripMonitoredGameLabel.Text = "{gameTitle}";
            // 
            // SaveFileWatcher
            // 
            this.SaveFileWatcher.EnableRaisingEvents = true;
            this.SaveFileWatcher.SynchronizingObject = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 431);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.SelectedGameLabel);
            this.Controls.Add(this.RestoreLatestButton);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.SavesListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GamesListBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoSaver2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveFileWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ServiceControlButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem MenuExit;
        private ListBox GamesListBox;
        private ToolStripMenuItem MenuAddGame;
        private ToolStripMenuItem loadDefaultGamesToolStripMenuItem;
        private ToolStripMenuItem MenuAbout;
        private ToolStripMenuItem MenuEditGame;
        private ToolStripMenuItem MenuDeleteGame;
        private Label ServiceStatus;
        private Label ServiceStatusLabel;
        private GroupBox groupBox1;
        private Label label1;
        private ListView SavesListBox;
        private Button RestoreButton;
        private Button RestoreLatestButton;
        private ColumnHeader fileName;
        private ColumnHeader createdTime;
        private Label MonitorStatusLabel;
        private Label SelectedGameLabel;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel ToolStripServiceStatusIndicator;
        private ToolStripStatusLabel ToolStripMonitoredGameLabel;
        private ToolStripMenuItem MenuOpenLogs;
        public FileSystemWatcher SaveFileWatcher;
    }
}