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
            this.ServiceControlButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteGame = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceControlButton
            // 
            this.ServiceControlButton.Location = new System.Drawing.Point(353, 203);
            this.ServiceControlButton.Name = "ServiceControlButton";
            this.ServiceControlButton.Size = new System.Drawing.Size(75, 23);
            this.ServiceControlButton.TabIndex = 0;
            this.ServiceControlButton.Text = "button1";
            this.ServiceControlButton.UseVisualStyleBackColor = true;
            this.ServiceControlButton.Click += new System.EventHandler(this.ServiceControlButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.gamesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSave,
            this.MenuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(180, 22);
            this.MenuSave.Text = "Save";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(180, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // startStopToolStripMenuItem
            // 
            this.startStopToolStripMenuItem.Name = "startStopToolStripMenuItem";
            this.startStopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startStopToolStripMenuItem.Text = "{StartStop}";
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewGame,
            this.MenuEditGame,
            this.MenuDeleteGame});
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // MenuNewGame
            // 
            this.MenuNewGame.Name = "MenuNewGame";
            this.MenuNewGame.Size = new System.Drawing.Size(180, 22);
            this.MenuNewGame.Text = "New";
            this.MenuNewGame.Click += new System.EventHandler(this.MenuNewGame_Click);
            // 
            // MenuEditGame
            // 
            this.MenuEditGame.Name = "MenuEditGame";
            this.MenuEditGame.Size = new System.Drawing.Size(180, 22);
            this.MenuEditGame.Text = "Edit";
            // 
            // MenuDeleteGame
            // 
            this.MenuDeleteGame.Name = "MenuDeleteGame";
            this.MenuDeleteGame.Size = new System.Drawing.Size(180, 22);
            this.MenuDeleteGame.Text = "Delete";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ServiceControlButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ServiceControlButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem MenuSave;
        private ToolStripMenuItem MenuExit;
        private ToolStripMenuItem serviceToolStripMenuItem;
        private ToolStripMenuItem startStopToolStripMenuItem;
        private ListBox listBox1;
        private ToolStripMenuItem gamesToolStripMenuItem;
        private ToolStripMenuItem MenuNewGame;
        private ToolStripMenuItem MenuEditGame;
        private ToolStripMenuItem MenuDeleteGame;
    }
}