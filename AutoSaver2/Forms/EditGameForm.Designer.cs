namespace AutoSaver2.Forms
{
    partial class EditGameForm
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
            this.components = new System.ComponentModel.Container();
            this.GameNameTextbox = new System.Windows.Forms.TextBox();
            this.SaveLocationTextBox = new System.Windows.Forms.TextBox();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PickButton = new System.Windows.Forms.Button();
            this.IsWatchSaveFolder = new System.Windows.Forms.CheckBox();
            this.ArchiveSaveFrequencyLabel = new System.Windows.Forms.Label();
            this.ArchiveCountLabel = new System.Windows.Forms.Label();
            this.ArchiveSaveFrequencySecondsLabel = new System.Windows.Forms.Label();
            this.ArchiveSaveFrequencyNumber = new System.Windows.Forms.NumericUpDown();
            this.KeepAmountNumber = new System.Windows.Forms.NumericUpDown();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SaveGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveSaveFrequencyNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeepAmountNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // GameNameTextbox
            // 
            this.GameNameTextbox.Location = new System.Drawing.Point(199, 9);
            this.GameNameTextbox.Name = "GameNameTextbox";
            this.GameNameTextbox.Size = new System.Drawing.Size(134, 23);
            this.GameNameTextbox.TabIndex = 0;
            this.GameNameTextbox.Text = "Game Title";
            // 
            // SaveLocationTextBox
            // 
            this.SaveLocationTextBox.Location = new System.Drawing.Point(199, 38);
            this.SaveLocationTextBox.Name = "SaveLocationTextBox";
            this.SaveLocationTextBox.Size = new System.Drawing.Size(325, 23);
            this.SaveLocationTextBox.TabIndex = 1;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.Location = new System.Drawing.Point(72, 9);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(121, 23);
            this.GameNameLabel.TabIndex = 2;
            this.GameNameLabel.Text = "Name:";
            this.GameNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Save Location:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SaveLocationDialog
            // 
            this.SaveLocationDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.SaveLocationDialog.ShowNewFolderButton = false;
            // 
            // PickButton
            // 
            this.PickButton.Location = new System.Drawing.Point(530, 38);
            this.PickButton.Name = "PickButton";
            this.PickButton.Size = new System.Drawing.Size(75, 23);
            this.PickButton.TabIndex = 4;
            this.PickButton.Text = "Pick";
            this.PickButton.UseVisualStyleBackColor = true;
            this.PickButton.Click += new System.EventHandler(this.PickButton_Click);
            // 
            // IsWatchSaveFolder
            // 
            this.IsWatchSaveFolder.AutoSize = true;
            this.IsWatchSaveFolder.Checked = true;
            this.IsWatchSaveFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsWatchSaveFolder.Location = new System.Drawing.Point(199, 67);
            this.IsWatchSaveFolder.Name = "IsWatchSaveFolder";
            this.IsWatchSaveFolder.Size = new System.Drawing.Size(123, 19);
            this.IsWatchSaveFolder.TabIndex = 5;
            this.IsWatchSaveFolder.Text = "Watch Save Folder";
            this.IsWatchSaveFolder.UseVisualStyleBackColor = true;
            this.IsWatchSaveFolder.CheckedChanged += new System.EventHandler(this.IsWatchSaveFolder_CheckedChanged);
            // 
            // ArchiveSaveFrequencyLabel
            // 
            this.ArchiveSaveFrequencyLabel.Location = new System.Drawing.Point(13, 94);
            this.ArchiveSaveFrequencyLabel.Name = "ArchiveSaveFrequencyLabel";
            this.ArchiveSaveFrequencyLabel.Size = new System.Drawing.Size(180, 23);
            this.ArchiveSaveFrequencyLabel.TabIndex = 7;
            this.ArchiveSaveFrequencyLabel.Text = "Archive Save Frequency:";
            this.ArchiveSaveFrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip.SetToolTip(this.ArchiveSaveFrequencyLabel, "How often should the program archive the save file in the save location");
            // 
            // ArchiveCountLabel
            // 
            this.ArchiveCountLabel.Location = new System.Drawing.Point(12, 121);
            this.ArchiveCountLabel.Name = "ArchiveCountLabel";
            this.ArchiveCountLabel.Size = new System.Drawing.Size(180, 23);
            this.ArchiveCountLabel.TabIndex = 9;
            this.ArchiveCountLabel.Text = "Keep Amount:";
            this.ArchiveCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip.SetToolTip(this.ArchiveCountLabel, "Max amount of saves to keep archived. Oldest save will be deleted upon new save o" +
        "ver the amount");
            // 
            // ArchiveSaveFrequencySecondsLabel
            // 
            this.ArchiveSaveFrequencySecondsLabel.AutoSize = true;
            this.ArchiveSaveFrequencySecondsLabel.Location = new System.Drawing.Point(280, 94);
            this.ArchiveSaveFrequencySecondsLabel.Name = "ArchiveSaveFrequencySecondsLabel";
            this.ArchiveSaveFrequencySecondsLabel.Size = new System.Drawing.Size(50, 15);
            this.ArchiveSaveFrequencySecondsLabel.TabIndex = 10;
            this.ArchiveSaveFrequencySecondsLabel.Text = "seconds";
            // 
            // ArchiveSaveFrequencyNumber
            // 
            this.ArchiveSaveFrequencyNumber.Location = new System.Drawing.Point(199, 92);
            this.ArchiveSaveFrequencyNumber.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.ArchiveSaveFrequencyNumber.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ArchiveSaveFrequencyNumber.Name = "ArchiveSaveFrequencyNumber";
            this.ArchiveSaveFrequencyNumber.Size = new System.Drawing.Size(75, 23);
            this.ArchiveSaveFrequencyNumber.TabIndex = 11;
            this.ToolTip.SetToolTip(this.ArchiveSaveFrequencyNumber, "How often should the program archive the save file in the save location");
            this.ArchiveSaveFrequencyNumber.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // KeepAmountNumber
            // 
            this.KeepAmountNumber.Location = new System.Drawing.Point(199, 121);
            this.KeepAmountNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.KeepAmountNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.KeepAmountNumber.Name = "KeepAmountNumber";
            this.KeepAmountNumber.Size = new System.Drawing.Size(75, 23);
            this.KeepAmountNumber.TabIndex = 12;
            this.ToolTip.SetToolTip(this.KeepAmountNumber, "Max amount of saves to keep archived. Oldest save will be deleted upon new save o" +
        "ver the amount");
            this.KeepAmountNumber.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Location = new System.Drawing.Point(199, 166);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(88, 33);
            this.SaveGameButton.TabIndex = 13;
            this.SaveGameButton.Text = "Save";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // EditGameForm
            // 
            this.AcceptButton = this.SaveGameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 218);
            this.Controls.Add(this.SaveGameButton);
            this.Controls.Add(this.KeepAmountNumber);
            this.Controls.Add(this.ArchiveSaveFrequencyNumber);
            this.Controls.Add(this.ArchiveSaveFrequencySecondsLabel);
            this.Controls.Add(this.ArchiveCountLabel);
            this.Controls.Add(this.ArchiveSaveFrequencyLabel);
            this.Controls.Add(this.IsWatchSaveFolder);
            this.Controls.Add(this.PickButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.SaveLocationTextBox);
            this.Controls.Add(this.GameNameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditGameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Game";
            this.Load += new System.EventHandler(this.EditGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveSaveFrequencyNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeepAmountNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox GameNameTextbox;
        private TextBox SaveLocationTextBox;
        private Label GameNameLabel;
        private Label label1;
        private FolderBrowserDialog SaveLocationDialog;
        private Button PickButton;
        private CheckBox IsWatchSaveFolder;
        private Label ArchiveSaveFrequencyLabel;
        private Label ArchiveCountLabel;
        private Label ArchiveSaveFrequencySecondsLabel;
        private NumericUpDown ArchiveSaveFrequencyNumber;
        private NumericUpDown KeepAmountNumber;
        private ToolTip ToolTip;
        private Button SaveGameButton;
    }
}