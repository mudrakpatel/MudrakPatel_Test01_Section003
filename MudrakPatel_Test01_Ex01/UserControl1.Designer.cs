namespace MudrakPatel_Test01_Ex01
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlGroupBox = new System.Windows.Forms.GroupBox();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deliveryAddressLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.updateDetailsButton = new System.Windows.Forms.Button();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.userControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControlGroupBox
            // 
            this.userControlGroupBox.Controls.Add(this.contactTextBox);
            this.userControlGroupBox.Controls.Add(this.addressTextBox);
            this.userControlGroupBox.Controls.Add(this.nameTextBox);
            this.userControlGroupBox.Controls.Add(this.orderNumberTextBox);
            this.userControlGroupBox.Controls.Add(this.updateDetailsButton);
            this.userControlGroupBox.Controls.Add(this.contactLabel);
            this.userControlGroupBox.Controls.Add(this.deliveryAddressLabel);
            this.userControlGroupBox.Controls.Add(this.nameLabel);
            this.userControlGroupBox.Controls.Add(this.orderNumberLabel);
            this.userControlGroupBox.Location = new System.Drawing.Point(4, 4);
            this.userControlGroupBox.Name = "userControlGroupBox";
            this.userControlGroupBox.Size = new System.Drawing.Size(263, 176);
            this.userControlGroupBox.TabIndex = 0;
            this.userControlGroupBox.TabStop = false;
            this.userControlGroupBox.Text = "Customer details";
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(32, 26);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(74, 13);
            this.orderNumberLabel.TabIndex = 0;
            this.orderNumberLabel.Text = "Order number:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(68, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // deliveryAddressLabel
            // 
            this.deliveryAddressLabel.AutoSize = true;
            this.deliveryAddressLabel.Location = new System.Drawing.Point(18, 83);
            this.deliveryAddressLabel.Name = "deliveryAddressLabel";
            this.deliveryAddressLabel.Size = new System.Drawing.Size(88, 13);
            this.deliveryAddressLabel.TabIndex = 0;
            this.deliveryAddressLabel.Text = "Delivery address:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(59, 108);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(47, 13);
            this.contactLabel.TabIndex = 0;
            this.contactLabel.Text = "Contact:";
            // 
            // updateDetailsButton
            // 
            this.updateDetailsButton.Location = new System.Drawing.Point(62, 142);
            this.updateDetailsButton.Name = "updateDetailsButton";
            this.updateDetailsButton.Size = new System.Drawing.Size(161, 23);
            this.updateDetailsButton.TabIndex = 1;
            this.updateDetailsButton.Text = "Update customer details";
            this.updateDetailsButton.UseVisualStyleBackColor = true;
            this.updateDetailsButton.Click += new System.EventHandler(this.updateDetailsButton_Click);
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(113, 26);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(110, 20);
            this.orderNumberTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(113, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(112, 80);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(110, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(112, 106);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(110, 20);
            this.contactTextBox.TabIndex = 2;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlGroupBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(281, 190);
            this.userControlGroupBox.ResumeLayout(false);
            this.userControlGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox userControlGroupBox;
        public System.Windows.Forms.Label contactLabel;
        public System.Windows.Forms.Label deliveryAddressLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label orderNumberLabel;
        public System.Windows.Forms.Button updateDetailsButton;
        public System.Windows.Forms.TextBox orderNumberTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox contactTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
    }
}
