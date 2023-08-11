namespace DemoApp
{
    partial class frmLINQDemo
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            gbCRUDSelect = new GroupBox();
            btnMinimumSalary = new Button();
            btnLastNameAscending = new Button();
            txtMinimumSalary = new TextBox();
            lblResults = new Label();
            lblTitle = new Label();
            gbAddEmployee = new GroupBox();
            btnAddEmployee = new Button();
            txtAddSalary = new TextBox();
            lblAddSalary = new Label();
            txtAddDeptName = new TextBox();
            lblAddDeptName = new Label();
            txtAddLastName = new TextBox();
            lblAddLastName = new Label();
            txtAddFirstName = new TextBox();
            lblAddFirstName = new Label();
            gbDeleteEmployee = new GroupBox();
            btnDeleteEmployee = new Button();
            cboDeleteEmployeeID = new ComboBox();
            lblDeleteEmployeeID = new Label();
            gbUpdateEmployee = new GroupBox();
            cboUpdateEmployeeID = new ComboBox();
            lblUpdateEmployeeID = new Label();
            btnUpdateEmployee = new Button();
            txtUpdateSalary = new TextBox();
            lblUpdateSalary = new Label();
            txtUpdateDeptName = new TextBox();
            lblUpdateDeptName = new Label();
            txtUpdateLastName = new TextBox();
            lblUpdateLastName = new Label();
            txtUpdateFirstName = new TextBox();
            lblUpdateFirstName = new Label();
            gbCRUDSelect.SuspendLayout();
            gbAddEmployee.SuspendLayout();
            gbDeleteEmployee.SuspendLayout();
            gbUpdateEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // gbCRUDSelect
            // 
            gbCRUDSelect.BackColor = Color.Fuchsia;
            gbCRUDSelect.Controls.Add(btnMinimumSalary);
            gbCRUDSelect.Controls.Add(btnLastNameAscending);
            gbCRUDSelect.Controls.Add(txtMinimumSalary);
            gbCRUDSelect.Controls.Add(lblResults);
            gbCRUDSelect.Controls.Add(lblTitle);
            gbCRUDSelect.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbCRUDSelect.Location = new Point(22, 43);
            gbCRUDSelect.Name = "gbCRUDSelect";
            gbCRUDSelect.Size = new Size(584, 522);
            gbCRUDSelect.TabIndex = 0;
            gbCRUDSelect.TabStop = false;
            gbCRUDSelect.Text = "Select and Query Info";
            // 
            // btnMinimumSalary
            // 
            btnMinimumSalary.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimumSalary.Location = new Point(83, 454);
            btnMinimumSalary.Name = "btnMinimumSalary";
            btnMinimumSalary.Size = new Size(400, 36);
            btnMinimumSalary.TabIndex = 4;
            btnMinimumSalary.Text = "Minimum Salary";
            btnMinimumSalary.UseVisualStyleBackColor = true;
            btnMinimumSalary.Click += btnMinimumSalary_Click;
            // 
            // btnLastNameAscending
            // 
            btnLastNameAscending.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastNameAscending.Location = new Point(85, 412);
            btnLastNameAscending.Name = "btnLastNameAscending";
            btnLastNameAscending.Size = new Size(400, 36);
            btnLastNameAscending.TabIndex = 3;
            btnLastNameAscending.Text = "By Last Name ASC";
            btnLastNameAscending.UseVisualStyleBackColor = true;
            btnLastNameAscending.Click += btnLastNameAscending_Click;
            // 
            // txtMinimumSalary
            // 
            txtMinimumSalary.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMinimumSalary.Location = new Point(83, 371);
            txtMinimumSalary.Name = "txtMinimumSalary";
            txtMinimumSalary.Size = new Size(401, 32);
            txtMinimumSalary.TabIndex = 2;
            txtMinimumSalary.Tag = "minsalary";
            txtMinimumSalary.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResults
            // 
            lblResults.BackColor = Color.FromArgb(255, 192, 255);
            lblResults.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblResults.Location = new Point(84, 66);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(401, 289);
            lblResults.TabIndex = 1;
            lblResults.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(255, 192, 255);
            lblTitle.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(83, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(401, 23);
            lblTitle.TabIndex = 0;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbAddEmployee
            // 
            gbAddEmployee.BackColor = Color.Fuchsia;
            gbAddEmployee.Controls.Add(btnAddEmployee);
            gbAddEmployee.Controls.Add(txtAddSalary);
            gbAddEmployee.Controls.Add(lblAddSalary);
            gbAddEmployee.Controls.Add(txtAddDeptName);
            gbAddEmployee.Controls.Add(lblAddDeptName);
            gbAddEmployee.Controls.Add(txtAddLastName);
            gbAddEmployee.Controls.Add(lblAddLastName);
            gbAddEmployee.Controls.Add(txtAddFirstName);
            gbAddEmployee.Controls.Add(lblAddFirstName);
            gbAddEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbAddEmployee.Location = new Point(665, 43);
            gbAddEmployee.Name = "gbAddEmployee";
            gbAddEmployee.Size = new Size(584, 355);
            gbAddEmployee.TabIndex = 1;
            gbAddEmployee.TabStop = false;
            gbAddEmployee.Text = "Add Employee";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEmployee.Location = new Point(75, 261);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(400, 36);
            btnAddEmployee.TabIndex = 10;
            btnAddEmployee.Text = "Add New Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // txtAddSalary
            // 
            txtAddSalary.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddSalary.Location = new Point(291, 207);
            txtAddSalary.Name = "txtAddSalary";
            txtAddSalary.Size = new Size(234, 32);
            txtAddSalary.TabIndex = 9;
            txtAddSalary.Tag = "salary";
            txtAddSalary.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAddSalary
            // 
            lblAddSalary.BackColor = Color.FromArgb(255, 192, 255);
            lblAddSalary.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddSalary.Location = new Point(32, 207);
            lblAddSalary.Name = "lblAddSalary";
            lblAddSalary.Size = new Size(214, 23);
            lblAddSalary.TabIndex = 8;
            lblAddSalary.Text = "Salary:";
            lblAddSalary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddDeptName
            // 
            txtAddDeptName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddDeptName.Location = new Point(291, 149);
            txtAddDeptName.Name = "txtAddDeptName";
            txtAddDeptName.Size = new Size(234, 32);
            txtAddDeptName.TabIndex = 7;
            txtAddDeptName.Tag = "deptname";
            txtAddDeptName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAddDeptName
            // 
            lblAddDeptName.BackColor = Color.FromArgb(255, 192, 255);
            lblAddDeptName.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddDeptName.Location = new Point(32, 149);
            lblAddDeptName.Name = "lblAddDeptName";
            lblAddDeptName.Size = new Size(214, 23);
            lblAddDeptName.TabIndex = 6;
            lblAddDeptName.Text = "Department Name:";
            lblAddDeptName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddLastName
            // 
            txtAddLastName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddLastName.Location = new Point(291, 91);
            txtAddLastName.Name = "txtAddLastName";
            txtAddLastName.Size = new Size(234, 32);
            txtAddLastName.TabIndex = 5;
            txtAddLastName.Tag = "lastname";
            txtAddLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAddLastName
            // 
            lblAddLastName.BackColor = Color.FromArgb(255, 192, 255);
            lblAddLastName.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddLastName.Location = new Point(32, 91);
            lblAddLastName.Name = "lblAddLastName";
            lblAddLastName.Size = new Size(214, 23);
            lblAddLastName.TabIndex = 4;
            lblAddLastName.Text = "Last Name:";
            lblAddLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddFirstName
            // 
            txtAddFirstName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddFirstName.Location = new Point(291, 35);
            txtAddFirstName.Name = "txtAddFirstName";
            txtAddFirstName.Size = new Size(234, 32);
            txtAddFirstName.TabIndex = 3;
            txtAddFirstName.Tag = "firstname";
            txtAddFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAddFirstName
            // 
            lblAddFirstName.BackColor = Color.FromArgb(255, 192, 255);
            lblAddFirstName.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddFirstName.Location = new Point(32, 35);
            lblAddFirstName.Name = "lblAddFirstName";
            lblAddFirstName.Size = new Size(214, 23);
            lblAddFirstName.TabIndex = 1;
            lblAddFirstName.Text = "First Name:";
            lblAddFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbDeleteEmployee
            // 
            gbDeleteEmployee.BackColor = Color.Fuchsia;
            gbDeleteEmployee.Controls.Add(btnDeleteEmployee);
            gbDeleteEmployee.Controls.Add(cboDeleteEmployeeID);
            gbDeleteEmployee.Controls.Add(lblDeleteEmployeeID);
            gbDeleteEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbDeleteEmployee.Location = new Point(22, 589);
            gbDeleteEmployee.Name = "gbDeleteEmployee";
            gbDeleteEmployee.Size = new Size(584, 200);
            gbDeleteEmployee.TabIndex = 1;
            gbDeleteEmployee.TabStop = false;
            gbDeleteEmployee.Text = "Delete Employee";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.Location = new Point(96, 96);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(400, 36);
            btnDeleteEmployee.TabIndex = 4;
            btnDeleteEmployee.Text = "Delete Existing Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // cboDeleteEmployeeID
            // 
            cboDeleteEmployeeID.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            cboDeleteEmployeeID.FormattingEnabled = true;
            cboDeleteEmployeeID.Location = new Point(379, 32);
            cboDeleteEmployeeID.Name = "cboDeleteEmployeeID";
            cboDeleteEmployeeID.Size = new Size(117, 33);
            cboDeleteEmployeeID.TabIndex = 2;
            // 
            // lblDeleteEmployeeID
            // 
            lblDeleteEmployeeID.BackColor = Color.FromArgb(255, 192, 255);
            lblDeleteEmployeeID.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeleteEmployeeID.Location = new Point(103, 36);
            lblDeleteEmployeeID.Name = "lblDeleteEmployeeID";
            lblDeleteEmployeeID.Size = new Size(214, 23);
            lblDeleteEmployeeID.TabIndex = 1;
            lblDeleteEmployeeID.Text = "Employee ID:";
            lblDeleteEmployeeID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbUpdateEmployee
            // 
            gbUpdateEmployee.BackColor = Color.Fuchsia;
            gbUpdateEmployee.Controls.Add(cboUpdateEmployeeID);
            gbUpdateEmployee.Controls.Add(lblUpdateEmployeeID);
            gbUpdateEmployee.Controls.Add(btnUpdateEmployee);
            gbUpdateEmployee.Controls.Add(txtUpdateSalary);
            gbUpdateEmployee.Controls.Add(lblUpdateSalary);
            gbUpdateEmployee.Controls.Add(txtUpdateDeptName);
            gbUpdateEmployee.Controls.Add(lblUpdateDeptName);
            gbUpdateEmployee.Controls.Add(txtUpdateLastName);
            gbUpdateEmployee.Controls.Add(lblUpdateLastName);
            gbUpdateEmployee.Controls.Add(txtUpdateFirstName);
            gbUpdateEmployee.Controls.Add(lblUpdateFirstName);
            gbUpdateEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbUpdateEmployee.Location = new Point(665, 434);
            gbUpdateEmployee.Name = "gbUpdateEmployee";
            gbUpdateEmployee.Size = new Size(584, 355);
            gbUpdateEmployee.TabIndex = 1;
            gbUpdateEmployee.TabStop = false;
            gbUpdateEmployee.Text = "Update Employee";
            // 
            // cboUpdateEmployeeID
            // 
            cboUpdateEmployeeID.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            cboUpdateEmployeeID.FormattingEnabled = true;
            cboUpdateEmployeeID.Location = new Point(304, 25);
            cboUpdateEmployeeID.Name = "cboUpdateEmployeeID";
            cboUpdateEmployeeID.Size = new Size(121, 33);
            cboUpdateEmployeeID.TabIndex = 21;
            cboUpdateEmployeeID.SelectedIndexChanged += cboUpdateEmployeeID_SelectedIndexChanged;
            // 
            // lblUpdateEmployeeID
            // 
            lblUpdateEmployeeID.BackColor = Color.FromArgb(255, 192, 255);
            lblUpdateEmployeeID.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdateEmployeeID.Location = new Point(45, 28);
            lblUpdateEmployeeID.Name = "lblUpdateEmployeeID";
            lblUpdateEmployeeID.Size = new Size(214, 23);
            lblUpdateEmployeeID.TabIndex = 20;
            lblUpdateEmployeeID.Text = "Employee ID:";
            lblUpdateEmployeeID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEmployee.Location = new Point(88, 293);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(400, 36);
            btnUpdateEmployee.TabIndex = 19;
            btnUpdateEmployee.Text = "Update Existing Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // txtUpdateSalary
            // 
            txtUpdateSalary.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtUpdateSalary.Location = new Point(304, 239);
            txtUpdateSalary.Name = "txtUpdateSalary";
            txtUpdateSalary.Size = new Size(234, 32);
            txtUpdateSalary.TabIndex = 18;
            txtUpdateSalary.Tag = "salary";
            // 
            // lblUpdateSalary
            // 
            lblUpdateSalary.BackColor = Color.FromArgb(255, 192, 255);
            lblUpdateSalary.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdateSalary.Location = new Point(45, 239);
            lblUpdateSalary.Name = "lblUpdateSalary";
            lblUpdateSalary.Size = new Size(214, 23);
            lblUpdateSalary.TabIndex = 17;
            lblUpdateSalary.Text = "Salary:";
            lblUpdateSalary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUpdateDeptName
            // 
            txtUpdateDeptName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtUpdateDeptName.Location = new Point(304, 181);
            txtUpdateDeptName.Name = "txtUpdateDeptName";
            txtUpdateDeptName.Size = new Size(234, 32);
            txtUpdateDeptName.TabIndex = 16;
            txtUpdateDeptName.Tag = "deptname";
            // 
            // lblUpdateDeptName
            // 
            lblUpdateDeptName.BackColor = Color.FromArgb(255, 192, 255);
            lblUpdateDeptName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdateDeptName.Location = new Point(45, 181);
            lblUpdateDeptName.Name = "lblUpdateDeptName";
            lblUpdateDeptName.Size = new Size(214, 23);
            lblUpdateDeptName.TabIndex = 15;
            lblUpdateDeptName.Text = "Department Name:";
            lblUpdateDeptName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUpdateLastName
            // 
            txtUpdateLastName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtUpdateLastName.Location = new Point(304, 123);
            txtUpdateLastName.Name = "txtUpdateLastName";
            txtUpdateLastName.Size = new Size(234, 32);
            txtUpdateLastName.TabIndex = 14;
            txtUpdateLastName.Tag = "lastname";
            // 
            // lblUpdateLastName
            // 
            lblUpdateLastName.BackColor = Color.FromArgb(255, 192, 255);
            lblUpdateLastName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdateLastName.Location = new Point(45, 123);
            lblUpdateLastName.Name = "lblUpdateLastName";
            lblUpdateLastName.Size = new Size(214, 23);
            lblUpdateLastName.TabIndex = 13;
            lblUpdateLastName.Text = "Last Name:";
            lblUpdateLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUpdateFirstName
            // 
            txtUpdateFirstName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtUpdateFirstName.Location = new Point(304, 67);
            txtUpdateFirstName.Name = "txtUpdateFirstName";
            txtUpdateFirstName.Size = new Size(234, 32);
            txtUpdateFirstName.TabIndex = 12;
            txtUpdateFirstName.Tag = "firstname";
            // 
            // lblUpdateFirstName
            // 
            lblUpdateFirstName.BackColor = Color.FromArgb(255, 192, 255);
            lblUpdateFirstName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdateFirstName.Location = new Point(45, 67);
            lblUpdateFirstName.Name = "lblUpdateFirstName";
            lblUpdateFirstName.Size = new Size(214, 23);
            lblUpdateFirstName.TabIndex = 11;
            lblUpdateFirstName.Text = "First Name:";
            lblUpdateFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLINQDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1284, 811);
            Controls.Add(gbUpdateEmployee);
            Controls.Add(gbDeleteEmployee);
            Controls.Add(gbAddEmployee);
            Controls.Add(gbCRUDSelect);
            Name = "frmLINQDemo";
            Text = "LINQ Demo";
            gbCRUDSelect.ResumeLayout(false);
            gbCRUDSelect.PerformLayout();
            gbAddEmployee.ResumeLayout(false);
            gbAddEmployee.PerformLayout();
            gbDeleteEmployee.ResumeLayout(false);
            gbUpdateEmployee.ResumeLayout(false);
            gbUpdateEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox gbCRUDSelect;
        private Button btnMinimumSalary;
        private Button btnLastNameAscending;
        private TextBox txtMinimumSalary;
        private Label lblResults;
        private Label lblTitle;
        private GroupBox gbAddEmployee;
        private Button btnAddEmployee;
        private TextBox txtAddSalary;
        private Label lblAddSalary;
        private TextBox txtAddDeptName;
        private Label lblAddDeptName;
        private TextBox txtAddLastName;
        private Label lblAddLastName;
        private TextBox txtAddFirstName;
        private Label lblAddFirstName;
        private GroupBox gbDeleteEmployee;
        private Button btnDeleteEmployee;
        private ComboBox cboDeleteEmployeeID;
        private Label lblDeleteEmployeeID;
        private GroupBox gbUpdateEmployee;
        private ComboBox cboUpdateEmployeeID;
        private Label lblUpdateEmployeeID;
        private Button btnUpdateEmployee;
        private TextBox txtUpdateSalary;
        private Label lblUpdateSalary;
        private TextBox txtUpdateDeptName;
        private Label lblUpdateDeptName;
        private TextBox txtUpdateLastName;
        private Label lblUpdateLastName;
        private TextBox txtUpdateFirstName;
        private Label lblUpdateFirstName;
    }
}