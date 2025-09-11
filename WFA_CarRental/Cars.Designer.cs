namespace WFA_CarRental
{
    partial class FormCars
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
            dgvCars = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDailyPrice = new TextBox();
            txtPlateNumber = new TextBox();
            txtYear = new TextBox();
            txtModel = new TextBox();
            txtBrand = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            cmbGearType = new ComboBox();
            txtMileAge = new TextBox();
            cmbFuelType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Dock = DockStyle.Top;
            dgvCars.Location = new Point(0, 0);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersWidth = 51;
            dgvCars.Size = new Size(1126, 447);
            dgvCars.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(859, 475);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 15;
            label1.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 475);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 14;
            label2.Text = "PlateNum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 475);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 13;
            label3.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 475);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 12;
            label4.Text = "Model:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 475);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 11;
            label5.Text = "Brand:";
            // 
            // txtDailyPrice
            // 
            txtDailyPrice.Location = new Point(909, 472);
            txtDailyPrice.Name = "txtDailyPrice";
            txtDailyPrice.Size = new Size(125, 27);
            txtDailyPrice.TabIndex = 4;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(722, 472);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(125, 27);
            txtPlateNumber.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(511, 472);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(334, 472);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 1;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(145, 472);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(125, 27);
            txtBrand.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(631, 618);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(380, 618);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(511, 618);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Guncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbGearType
            // 
            cmbGearType.FormattingEnabled = true;
            cmbGearType.Items.AddRange(new object[] { "Manual", "Automatic" });
            cmbGearType.Location = new Point(511, 532);
            cmbGearType.Name = "cmbGearType";
            cmbGearType.Size = new Size(125, 28);
            cmbGearType.TabIndex = 6;
            // 
            // txtMileAge
            // 
            txtMileAge.Location = new Point(741, 534);
            txtMileAge.Name = "txtMileAge";
            txtMileAge.Size = new Size(125, 27);
            txtMileAge.TabIndex = 7;
            // 
            // cmbFuelType
            // 
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Items.AddRange(new object[] { "Petrol", "Diesel", "Electric" });
            cmbFuelType.Location = new Point(283, 534);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(125, 28);
            cmbFuelType.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(667, 535);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 18;
            label6.Text = "MileAge:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 535);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 17;
            label7.Text = "GearType:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 538);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 16;
            label8.Text = "FuelType:";
            // 
            // FormCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 783);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbFuelType);
            Controls.Add(txtMileAge);
            Controls.Add(cmbGearType);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(txtBrand);
            Controls.Add(txtModel);
            Controls.Add(txtYear);
            Controls.Add(txtPlateNumber);
            Controls.Add(txtDailyPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCars);
            Name = "FormCars";
            Text = "Cars";
            Load += FormCars_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCars;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDailyPrice;
        private TextBox txtPlateNumber;
        private TextBox txtYear;
        private TextBox txtModel;
        private TextBox txtBrand;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private ComboBox cmbGearType;
        private TextBox txtMileAge;
        private ComboBox cmbFuelType;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}