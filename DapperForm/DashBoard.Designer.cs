
namespace DapperForm
{
    partial class DashBoard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.emailAdressInsText = new System.Windows.Forms.TextBox();
            this.emailAdressInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 16;
            this.peopleFoundListBox.Location = new System.Drawing.Point(24, 142);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(647, 148);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(106, 50);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(219, 50);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(238, 22);
            this.lastNameText.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(167, 78);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 38);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(219, 317);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.ShortcutsEnabled = false;
            this.firstNameInsText.Size = new System.Drawing.Size(238, 22);
            this.firstNameInsText.TabIndex = 5;
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(106, 317);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameInsLabel.TabIndex = 4;
            this.firstNameInsLabel.Text = "First Name";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(219, 400);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(238, 22);
            this.phoneNumberInsText.TabIndex = 7;
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(106, 400);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberInsLabel.TabIndex = 6;
            this.phoneNumberInsLabel.Text = "Phone Number";
            // 
            // emailAdressInsText
            // 
            this.emailAdressInsText.Location = new System.Drawing.Point(219, 373);
            this.emailAdressInsText.Name = "emailAdressInsText";
            this.emailAdressInsText.Size = new System.Drawing.Size(238, 22);
            this.emailAdressInsText.TabIndex = 9;
            // 
            // emailAdressInsLabel
            // 
            this.emailAdressInsLabel.AutoSize = true;
            this.emailAdressInsLabel.Location = new System.Drawing.Point(106, 373);
            this.emailAdressInsLabel.Name = "emailAdressInsLabel";
            this.emailAdressInsLabel.Size = new System.Drawing.Size(90, 17);
            this.emailAdressInsLabel.TabIndex = 8;
            this.emailAdressInsLabel.Text = "Email Adress";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(219, 345);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(238, 22);
            this.lastNameInsText.TabIndex = 11;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(106, 345);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameInsLabel.TabIndex = 10;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(518, 362);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(113, 38);
            this.InsertRecordButton.TabIndex = 12;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.emailAdressInsText);
            this.Controls.Add(this.emailAdressInsLabel);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.peopleFoundListBox);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.TextBox emailAdressInsText;
        private System.Windows.Forms.Label emailAdressInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.Button InsertRecordButton;
    }
}

