/*
 *      1.  After creating the new Windows Forms App,
 *          NOT Windows Forms App (.NET Framework),
 *          create the GUI.
 *      
 *      2.  Create the Employee.cs class. Then
 *          create the EmployeeContext.cs class.
 *          Then create the Validator.cs class.
 *          
 *      3. Then, go to
 *      
 *      Tools / NuGet Package Manager / Manage Packages for Solution...
 *      
 *      Under the Browse searchbox, enter MicrosoftEntityFramework
 *      
 *      Install the following packages (latest version):
 *      
 *      Microsoft.EntityFrameworkCore.Tools
 *      
 *      Then install:
 *      
 *      Microsoft.EntityFrameworkCore.SqlServer
 *      
 *      4.  From the Nuget Package Manager / Package Manager Console, enter:
 *      
 *      Add-Migration CreateDB          <enter>
 *      
 *      That should create your Migrations folder and your file with 
 *      the Up() and Down() methods. If this file is open in the editor,
 *      close it now.
 *      
 *      From the Nuget Package Manager / Package Manager Console, enter:
 *      
 *      Update-Database                 <enter>
 *      
 *      5.  Key in the code shown below.
 */

using System.Data;

namespace DemoApp
{
    public partial class frmLINQDemo : Form
    {
        //  Global constants
        const decimal MINSALARY = 10000.00M;
        const decimal MAXSALARY = 500000.00M;

        //  Global variables
        EmployeeContext employeeData;           //  DB Context Connection
        List<Employee> employeeList;            //  List of employees
        private int _employeeUpdateID;          //  Use in our Update routine
        private Employee? updateEmployee;       //  Employee to be updated
        decimal salary = 0.00m;                 //  Employee salary
        bool showEmployeesAscending = false;    //  Boolean flag
        bool showMoreThanMinSalary  = false;    //  Boolean flag
        bool showAddedNewEmployee   = false;    //  Boolean flag
        bool showDeletedEmployee    = false;    //  Boolean flag
        bool showUpdatedEmployee    = false;    //  Boolean flag

        public frmLINQDemo()
        {
            //  Initialize the EmployeeContext (employeeData)
            employeeData = new EmployeeContext();

            InitializeComponent();

            //  Show All Current Employees
            ShowEmployees();
        }

        private void ShowEmployees()
        {
            //  Clear out both comboboxes
            cboDeleteEmployeeID.Items.Clear();
            cboUpdateEmployeeID.Items.Clear();

            if (showEmployeesAscending) { }
            else if (showMoreThanMinSalary) { }
            else if (showAddedNewEmployee) { }
            else if (showDeletedEmployee) { }
            else if (showUpdatedEmployee) { }
            else
            {
                //  Set our title textbox accordingly
                if (lblTitle.Text.Trim() == "")
                {
                    lblTitle.Text = "Employees in Original Order";
                }

                LINQToShowAllEmployees();
            }

            //  Clear out lblResults label before display
            lblResults.Text = "";

            //  Display all current employees in lblResults
            foreach (Employee emp in employeeList)
            {
                //  Add each employee to lblResults label text
                lblResults.Text += emp.ToString() + "\n";

                //  Add Employee IDs to Delete and Update ComboBoxes
                cboDeleteEmployeeID.Items.Add(emp.EmployeeID);
                cboUpdateEmployeeID.Items.Add(emp.EmployeeID);
            }

            //  Reset all boolean flags to false
            showEmployeesAscending = false;
            showMoreThanMinSalary = false;

        }

        private void LINQToShowAllEmployees()
        {
            //  List all current employees
            //  in their original order.
            employeeList = employeeData
                           .Employees
                           .Select(e => e)
                           .ToList();
        }

        private void btnLastNameAscending_Click(object sender, EventArgs e)
        {
            ByLastNameAscending();
        }

        private void ByLastNameAscending()
        {
            //  Set our title textbox accordingly
            lblTitle.Text = "Last Name Ascending Order";

            //  List all current employees
            employeeList = employeeData
                           .Employees
                           .OrderBy(e => e.LastName)
                           .Select(e => e)
                           .ToList();

            //  Call ShowEmployees() to show the
            //  updated employee list (ascending
            //  order last name).
            showEmployeesAscending = true;
            ShowEmployees();
        }

        private void btnMinimumSalary_Click(object sender, EventArgs e)
        {
            ListAllEmployeesAboveMinimumSalaryShown();
        }

        private void ListAllEmployeesAboveMinimumSalaryShown()
        {
            bool result = true;

            //  Check for nothing in txtMinimumSalary textbox
            if (txtMinimumSalary.Text.Trim() == "")
            {
                ShowMessage("Minimum Salary TextBox Cannot Be Empty",
                            "SALARY TEXTBOX EMPTY!");
                txtMinimumSalary.Focus();
                return;
            }

            //  There was something inputted into the
            //  txtMinimumSalary textbox. Verify that:
            //
            //  1.  It is numeric.
            //  2.  It is positive (> 0).
            result = Decimal.TryParse(txtMinimumSalary.Text, out salary);

            if ((!result) || (salary <= 0))
            {
                ShowMessage("Minimum Salary TextBox Must Be Numeric & > 0",
                            "SALARY TEXTBOX NON-NUMERIC OR <= 0");
                txtMinimumSalary.Text = "";
                txtMinimumSalary.Focus();
                return;
            }

            //  Set our title textbox accordingly
            lblTitle.Text = "Employees Making > " + salary.ToString("c");

            //  Set boolean flag to true
            showMoreThanMinSalary = true;

            //  There was a numeric salary > 0 inputted
            //  into the txtMinimumSalary textbox.
            employeeList = employeeData
                            .Employees
                            .OrderByDescending(e => e.Salary)
                            .Where(e => e.Salary > salary)
                            .ToList();

            ShowEmployees();
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AttemptToAddNewEmployee();
        }

        private void AttemptToAddNewEmployee()
        {
            if (IsValidDataAdd())
            {
                //  Set boolean flag to true
                showAddedNewEmployee = true;

                //  Create a new employee object
                Employee addEmployee = new()
                {
                    FirstName = txtAddFirstName.Text,
                    LastName = txtAddLastName.Text,
                    DeptName = txtAddDeptName.Text,
                    Salary = salary
                };

                //  Attempt to add the new employee
                try
                {
                    //  Attempt to add new employee to
                    //  the RankenEmps DB Employee table.
                    employeeData.Employees.Add(addEmployee);

                    //  Attempting to write add to the DB
                    employeeData.SaveChanges();

                    //  MessageBox showing the add worked
                    MessageBox.Show("Employee Record Added",
                                    "SUCCESSFUL ADD",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    //  Set our title textbox accordingly
                    lblTitle.Text = "New Employee " +
                                    addEmployee.FirstName + " " +
                                    addEmployee.LastName +
                                    " Added";

                    ClearAddEmployeeTextBoxes();

                    ShowEmployees();
                }
                catch (Exception ex)
                {
                    ShowMessage("Error Attempting Record Add\n\n" +
                                ex.Message,
                                "ERROR ADDING RECORD");
                }

                LINQToShowAllEmployees();
                ShowEmployees();
            }
        }

        private void ClearAddEmployeeTextBoxes()
        {
            txtAddFirstName.Text    = "";
            txtAddLastName.Text     = "";
            txtAddDeptName.Text     = "";
            txtAddSalary.Text       = "";
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            AttemptToDeleteExistingEmployee();
        }

        private void AttemptToDeleteExistingEmployee()
        {
            int employeeIDToDelete = (int)cboDeleteEmployeeID.SelectedItem;
            Employee? employeeToDelete = employeeData
                                         .Employees
                                         .Find(employeeIDToDelete);

            //  Attempt the delete
            if (employeeToDelete != null)
            {
                try
                {
                    DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Delete Employee " +
                        employeeToDelete.FirstName + " " +
                        employeeToDelete.LastName + "?",
                        "DELETE THIS EMPLOYEE?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    //  Verify this is the employee to delete
                    if (dialog == DialogResult.No)
                    {
                        return;
                    }

                    //  Delete this employee
                    employeeData.Employees.Remove(employeeToDelete);
                    employeeData.SaveChanges();

                    MessageBox.Show("Employee " +
                                     employeeToDelete.FirstName + " " +
                                     employeeToDelete.LastName + " Was Deleted",
                        "SUCCESSFUL DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    //  Set boolean flag to true
                    showDeletedEmployee = true;

                    //  Set our title textbox accordingly
                    lblTitle.Text = "Employee " +
                                     employeeToDelete.FirstName + " " +
                                     employeeToDelete.LastName + " Was Deleted";
                }
                catch (Exception ex)
                {
                    ShowMessage("Error Attempting Record Delete\n" +
                                ex.Message,
                                "ERROR DELETING RECORD");
                }

                LINQToShowAllEmployees();
                ShowEmployees();
            }
            else
            {
                MessageBox.Show("Must Be Null", "NULL");
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            AttemptToUpdateExistingEmployee();
        }

        private void AttemptToUpdateExistingEmployee()
        {
            if (updateEmployee != null)
            {
                if (IsValidDataUpdate())
                {
                    MessageBox.Show("IsValidData() returned true!!!",
                                    "TRUE RETURNED");

                    //  Set boolean flag to true
                    showUpdatedEmployee = true;

                    //  Fill the update employee textboxes
                    //  from the database.
                    updateEmployee.FirstName = txtUpdateFirstName.Text;
                    updateEmployee.LastName = txtUpdateLastName.Text;
                    updateEmployee.DeptName = txtUpdateDeptName.Text;
                    updateEmployee.Salary = Decimal.Parse(txtUpdateSalary.Text);

                    //  Attempt to perform the update
                    try
                    {
                        DialogResult dialog = MessageBox.Show(
                            "Do You Really Want To Update Employee " +
                            updateEmployee.FirstName + " " +
                            updateEmployee.LastName + "?",
                            "UPDATE THIS EMPLOYEE?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        //  Verify this is the employee to delete
                        if (dialog == DialogResult.No)
                        {
                            return;
                        }

                        //  Perform update
                        employeeData.Employees.Update(updateEmployee);
                        employeeData.SaveChanges();

                        //  Set boolean flag to true
                        showUpdatedEmployee = true;

                        //  Alert user update made
                        MessageBox.Show("Employee " +
                                         updateEmployee.FirstName + " " +
                                         updateEmployee.LastName + " Was Updated",
                                         "SUCCESSFUL UPDATE",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

                        //  Set our title textbox accordingly
                        lblTitle.Text = "Employee " +
                                         updateEmployee.FirstName + " " +
                                         updateEmployee.LastName + " Was Updated";
                    }
                    catch (Exception ex)
                    {
                        ShowMessage("Error Attempting Record Update\n" +
                                    ex.Message,
                                    "ERROR Updating RECORD");
                    }

                    LINQToShowAllEmployees();
                    ShowEmployees();
                }
            }
        }

        private void cboUpdateEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillInCurrentEmployeeToUpdateInfo();
        }

        private void FillInCurrentEmployeeToUpdateInfo()
        {
            _employeeUpdateID = (int)cboUpdateEmployeeID.SelectedItem;

            updateEmployee = employeeData.Employees.Find(_employeeUpdateID);

            if (updateEmployee != null)
            {
                //  Copy from database to textboxes
                txtUpdateFirstName.Text = updateEmployee.FirstName;
                txtUpdateLastName.Text  = updateEmployee.LastName;
                txtUpdateDeptName.Text  = updateEmployee.DeptName;
                txtUpdateSalary.Text    = updateEmployee.Salary.ToString();
            }
        }

        private bool IsValidDataAdd()
        {
            return Validator.IsPresent(txtAddFirstName) &&
                   Validator.IsPresent(txtAddLastName) &&
                   Validator.IsPresent(txtAddDeptName) &&
                   Validator.IsPresent(txtAddSalary) &&
                   Validator.IsDecimal(txtAddSalary) &&
                   Validator.IsWithinRange(txtAddSalary, MINSALARY, MAXSALARY);
        }

        private bool IsValidDataUpdate()
        {
            return Validator.IsPresent(txtUpdateFirstName) &&
                   Validator.IsPresent(txtUpdateLastName) &&
                   Validator.IsPresent(txtUpdateDeptName) &&
                   Validator.IsPresent(txtUpdateSalary) &&
                   Validator.IsDecimal(txtUpdateSalary) &&
                   Validator.IsWithinRange(txtUpdateSalary, MINSALARY, MAXSALARY);
        }
    }
}