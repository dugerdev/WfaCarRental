namespace WFA_CarRental
{
    partial class Customer
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
            dgvCustomers = new DataGridView();
            txtDriverLicense = new TextBox();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl3 = new Label();
            btnDelete = new Button();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            mainMenu = new MenuStrip();
            tablesToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            carsToolStripMenuItem = new ToolStripMenuItem();
            rentalToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Dock = DockStyle.Top;
            dgvCustomers.Location = new Point(0, 28);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1126, 447);
            dgvCustomers.TabIndex = 0;
            // 
            // txtDriverLicense
            // 
            txtDriverLicense.Location = new Point(919, 503);
            txtDriverLicense.Name = "txtDriverLicense";
            txtDriverLicense.Size = new Size(144, 27);
            txtDriverLicense.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(691, 502);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(144, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(47, 501);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(144, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(253, 502);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(485, 502);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(135, 27);
            txtPhone.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 504);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 11;
            label1.Text = "Ad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 506);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 13;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 505);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 15;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(636, 505);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 12;
            label4.Text = "Email:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(860, 506);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(56, 20);
            lbl3.TabIndex = 14;
            lbl3.Text = "Ehliyet:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(682, 622);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(327, 622);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(118, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Listele";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(573, 622);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Guncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(462, 622);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { tablesToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1126, 28);
            mainMenu.TabIndex = 10;
            mainMenu.Text = "menuStrip1";
            // 
            // tablesToolStripMenuItem
            // 
            tablesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeesToolStripMenuItem, carsToolStripMenuItem, rentalToolStripMenuItem });
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new Size(64, 24);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(164, 26);
            employeesToolStripMenuItem.Text = "Employees";
            employeesToolStripMenuItem.Click += employeesToolStripMenuItem_Click;
            // 
            // carsToolStripMenuItem
            // 
            carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            carsToolStripMenuItem.Size = new Size(164, 26);
            carsToolStripMenuItem.Text = "Cars";
            carsToolStripMenuItem.Click += carsToolStripMenuItem_Click;
            // 
            // rentalToolStripMenuItem
            // 
            rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            rentalToolStripMenuItem.Size = new Size(164, 26);
            rentalToolStripMenuItem.Text = "Rental";
            rentalToolStripMenuItem.Click += rentalToolStripMenuItem_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 783);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(lbl3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Controls.Add(txtDriverLicense);
            Controls.Add(dgvCustomers);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "Customer";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private TextBox txtDriverLicense;
        private TextBox txtEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl3;
        private Button btnDelete;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnAdd;
        private MenuStrip mainMenu;
        private ToolStripMenuItem tablesToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem carsToolStripMenuItem;
        private ToolStripMenuItem rentalToolStripMenuItem;
    }
}
