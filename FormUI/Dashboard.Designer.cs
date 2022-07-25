namespace FormUI
{
    partial class Dashboard
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
            this.searchButton = new System.Windows.Forms.Button();
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.emailAddressInsText = new System.Windows.Forms.TextBox();
            this.emailAddressInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberNameInsLabel = new System.Windows.Forms.Label();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(143, 103);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 41);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 15;
            this.peopleFoundListBox.Location = new System.Drawing.Point(35, 161);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(365, 244);
            this.peopleFoundListBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(35, 70);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(104, 67);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(296, 23);
            this.lastNameText.TabIndex = 3;
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(667, 113);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(296, 23);
            this.firstNameInsText.TabIndex = 5;
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(579, 116);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameInsLabel.TabIndex = 4;
            this.firstNameInsLabel.Text = "First Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(667, 156);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(296, 23);
            this.lastNameInsText.TabIndex = 7;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(579, 159);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameInsLabel.TabIndex = 6;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // emailAddressInsText
            // 
            this.emailAddressInsText.Location = new System.Drawing.Point(667, 198);
            this.emailAddressInsText.Name = "emailAddressInsText";
            this.emailAddressInsText.Size = new System.Drawing.Size(296, 23);
            this.emailAddressInsText.TabIndex = 9;
            // 
            // emailAddressInsLabel
            // 
            this.emailAddressInsLabel.AutoSize = true;
            this.emailAddressInsLabel.Location = new System.Drawing.Point(579, 201);
            this.emailAddressInsLabel.Name = "emailAddressInsLabel";
            this.emailAddressInsLabel.Size = new System.Drawing.Size(81, 15);
            this.emailAddressInsLabel.TabIndex = 8;
            this.emailAddressInsLabel.Text = "Email Address";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(667, 244);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(296, 23);
            this.phoneNumberInsText.TabIndex = 11;
            // 
            // phoneNumberNameInsLabel
            // 
            this.phoneNumberNameInsLabel.AutoSize = true;
            this.phoneNumberNameInsLabel.Location = new System.Drawing.Point(579, 247);
            this.phoneNumberNameInsLabel.Name = "phoneNumberNameInsLabel";
            this.phoneNumberNameInsLabel.Size = new System.Drawing.Size(63, 15);
            this.phoneNumberNameInsLabel.TabIndex = 10;
            this.phoneNumberNameInsLabel.Text = "Phone No.";
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(748, 300);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(134, 41);
            this.InsertRecordButton.TabIndex = 12;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.phoneNumberNameInsLabel);
            this.Controls.Add(this.emailAddressInsText);
            this.Controls.Add(this.emailAddressInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.peopleFoundListBox);
            this.Controls.Add(this.searchButton);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchButton;
        private ListBox peopleFoundListBox;
        private Label lastNameLabel;
        private TextBox lastNameText;
        private TextBox firstNameInsText;
        private Label firstNameInsLabel;
        private TextBox lastNameInsText;
        private Label lastNameInsLabel;
        private TextBox emailAddressInsText;
        private Label emailAddressInsLabel;
        private TextBox phoneNumberInsText;
        private Label phoneNumberNameInsLabel;
        private Button InsertRecordButton;
    }
}