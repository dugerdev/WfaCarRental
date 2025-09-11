namespace WFA_CarRental
{
    partial class FormRentals
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
            cmbCustomer = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbCar = new ComboBox();
            label3 = new Label();
            dtpRentDate = new DateTimePicker();
            label4 = new Label();
            dtpExpectedReturnDate = new DateTimePicker();
            label5 = new Label();
            dtpActualReturnDate = new DateTimePicker();
            ToplamUcret = new Label();
            txtTotalAmount = new TextBox();
            Durum = new Label();
            cmbStatus = new ComboBox();
            dgvRentals = new DataGridView();
            cmbEmployee = new ComboBox();
            label6 = new Label();
            btnDeleteRental = new Button();
            btnUpdateRental = new Button();
            btnAddRental = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRentals).BeginInit();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.DisplayMember = "CustomerID";
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(21, 485);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(151, 28);
            cmbCustomer.TabIndex = 0;
            cmbCustomer.ValueMember = "CustomerID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 462);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Musteri:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 532);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Arac:";
            // 
            // cmbCar
            // 
            cmbCar.DisplayMember = "CarID";
            cmbCar.FormattingEnabled = true;
            cmbCar.Location = new Point(21, 555);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(151, 28);
            cmbCar.TabIndex = 3;
            cmbCar.ValueMember = "CarID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 463);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 4;
            label3.Text = "Kiralama Tarihi:";
            // 
            // dtpRentDate
            // 
            dtpRentDate.Location = new Point(384, 486);
            dtpRentDate.Name = "dtpRentDate";
            dtpRentDate.Size = new Size(250, 27);
            dtpRentDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(728, 462);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 6;
            label4.Text = "Beklenen Teslim Tarihi:";
            // 
            // dtpExpectedReturnDate
            // 
            dtpExpectedReturnDate.Location = new Point(678, 486);
            dtpExpectedReturnDate.Name = "dtpExpectedReturnDate";
            dtpExpectedReturnDate.Size = new Size(250, 27);
            dtpExpectedReturnDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 532);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 8;
            label5.Text = "Gercek Teslim Tarihi:";
            // 
            // dtpActualReturnDate
            // 
            dtpActualReturnDate.Location = new Point(384, 556);
            dtpActualReturnDate.Name = "dtpActualReturnDate";
            dtpActualReturnDate.Size = new Size(250, 27);
            dtpActualReturnDate.TabIndex = 9;
            // 
            // ToplamUcret
            // 
            ToplamUcret.AutoSize = true;
            ToplamUcret.Location = new Point(129, 613);
            ToplamUcret.Name = "ToplamUcret";
            ToplamUcret.Size = new Size(97, 20);
            ToplamUcret.TabIndex = 10;
            ToplamUcret.Text = "ToplamUcret:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(111, 636);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(151, 27);
            txtTotalAmount.TabIndex = 11;
            // 
            // Durum
            // 
            Durum.AutoSize = true;
            Durum.Location = new Point(236, 532);
            Durum.Name = "Durum";
            Durum.Size = new Size(57, 20);
            Durum.TabIndex = 12;
            Durum.Text = "Durum:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Aktif", "Teslim edildi", "Iptal" });
            cmbStatus.Location = new Point(200, 555);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 13;
            // 
            // dgvRentals
            // 
            dgvRentals.AllowUserToAddRows = false;
            dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentals.Dock = DockStyle.Top;
            dgvRentals.Location = new Point(0, 0);
            dgvRentals.MultiSelect = false;
            dgvRentals.Name = "dgvRentals";
            dgvRentals.ReadOnly = true;
            dgvRentals.RowHeadersWidth = 51;
            dgvRentals.Size = new Size(1126, 447);
            dgvRentals.TabIndex = 17;
            // 
            // cmbEmployee
            // 
            cmbEmployee.DisplayMember = "EmployeeID";
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(200, 485);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(151, 28);
            cmbEmployee.TabIndex = 18;
            cmbEmployee.ValueMember = "EmployeeID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 462);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 19;
            label6.Text = "Calisan:";
            // 
            // btnDeleteRental
            // 
            btnDeleteRental.Location = new Point(565, 719);
            btnDeleteRental.Name = "btnDeleteRental";
            btnDeleteRental.Size = new Size(94, 29);
            btnDeleteRental.TabIndex = 20;
            btnDeleteRental.Text = "Sil";
            btnDeleteRental.UseVisualStyleBackColor = true;
            btnDeleteRental.Click += btnDeleteRental_Click;
            // 
            // btnUpdateRental
            // 
            btnUpdateRental.Location = new Point(442, 719);
            btnUpdateRental.Name = "btnUpdateRental";
            btnUpdateRental.Size = new Size(94, 29);
            btnUpdateRental.TabIndex = 21;
            btnUpdateRental.Text = "Duzenle";
            btnUpdateRental.UseVisualStyleBackColor = true;
            btnUpdateRental.Click += btnUpdateRental_Click;
            // 
            // btnAddRental
            // 
            btnAddRental.Location = new Point(318, 719);
            btnAddRental.Name = "btnAddRental";
            btnAddRental.Size = new Size(94, 29);
            btnAddRental.TabIndex = 22;
            btnAddRental.Text = "Ekle";
            btnAddRental.UseVisualStyleBackColor = true;
            btnAddRental.Click += btnAddRental_Click;
            // 
            // FormRentals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 783);
            Controls.Add(btnAddRental);
            Controls.Add(btnUpdateRental);
            Controls.Add(btnDeleteRental);
            Controls.Add(label6);
            Controls.Add(cmbEmployee);
            Controls.Add(dgvRentals);
            Controls.Add(cmbStatus);
            Controls.Add(Durum);
            Controls.Add(txtTotalAmount);
            Controls.Add(ToplamUcret);
            Controls.Add(dtpActualReturnDate);
            Controls.Add(label5);
            Controls.Add(dtpExpectedReturnDate);
            Controls.Add(label4);
            Controls.Add(dtpRentDate);
            Controls.Add(label3);
            Controls.Add(cmbCar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCustomer);
            Name = "FormRentals";
            Text = "FormRentals";
            Load += FormRentals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomer;
        private Label label1;
        private Label label2;
        private ComboBox cmbCar;
        private Label label3;
        private DateTimePicker dtpRentDate;
        private Label label4;
        private DateTimePicker dtpExpectedReturnDate;
        private Label label5;
        private DateTimePicker dtpActualReturnDate;
        private Label ToplamUcret;
        private TextBox txtTotalAmount;
        private Label Durum;
        private ComboBox cmbStatus;
        private DataGridView dgvRentals;
        private ComboBox cmbEmployee;
        private Label label6;
        private Button btnDeleteRental;
        private Button btnUpdateRental;
        private Button btnAddRental;
    }
}