using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_payroll;

namespace ArbitragePayroll
{
    public partial class Dashboard : Form
    {
        Database database;

        public Dashboard()
        {
            InitializeComponent();
            database = new Database();
            database.GetConnection();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadEmployeeTable();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin dashboard = new frmLogin();
            dashboard.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pages.SetPage("add");
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pages.SetPage("employees");
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pages.SetPage("attendance");
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            pages.SetPage("payslip");
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            bool error = false;

            foreach (Control control in tabPage1.Controls)
            {
                if (control is BunifuTextBox)
                {
                    BunifuTextBox textBox = control as BunifuTextBox;
                    if (textBox.Text == string.Empty)
                    {
                        string[] optionalFields = {"txtMiddle", "txtSss", "txtTin", "txtPhilhealth", "txtPagibig"};

                        if (!optionalFields.Contains(textBox.Name)) error = true;
                    }
                }
                else if (control is BunifuDropdown)
                {
                    BunifuDropdown jobType = control as BunifuDropdown;

                    if (jobType.SelectedIndex == -1) error = true;
                }
            }

            if (error)
            {
                MessageBox.Show("Fill all required fields!", "Error");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(database.ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string query = @"INSERT INTO EMP_TBL " +
                        "(emp_id,last,first,middle,address,dob,civil,nationality,sss,philhealth,pagibig,tin,email,mobile,position,class)" +
                        "VALUES " +
                        "(@emp_id,@last,@first,@middle,@address,@dob,@civil,@nationality,@sss,@philhealth,@pagibig,@tin,@email,@mobile,@position,@class)";

                    command.CommandText = query;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@emp_id", txtEmpId.Text);
                    command.Parameters.AddWithValue("@last", txtLast.Text);
                    command.Parameters.AddWithValue("@first", txtFirst.Text);
                    command.Parameters.AddWithValue("@middle", txtMiddle.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@dob", txtDob.Value.ToString("MM-dd-yy"));
                    command.Parameters.AddWithValue("@civil", txtCivil.Text);
                    command.Parameters.AddWithValue("@nationality", txtNationality.Text);
                    command.Parameters.AddWithValue("@sss", txtSss.Text);
                    command.Parameters.AddWithValue("@philhealth", txtPhilhealth.Text);
                    command.Parameters.AddWithValue("@pagibig", txtPagibig.Text);
                    command.Parameters.AddWithValue("@tin", txtTin.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@mobile", txtMobile.Text);
                    command.Parameters.AddWithValue("@position", txtPosition.Text);
                    command.Parameters.AddWithValue("@class", txtType.GetItemText(txtType.SelectedItem));

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("New Employee inserted!", "Success");
                        empTbl.Rows.Clear();
                        loadEmployeeTable();
                        clear();
                    }
                    else MessageBox.Show("There is a problem while inserting the data. Call the Programmer to resolve this problem.", "Error");
                }
                conn.Close();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            empTbl.Rows.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(database.ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string query = @"SELECT * FROM EMP_TBL WHERE emp_id LIKE @filter " +
                                         "OR last LIKE @filter " +
                                         "OR first LIKE @filter " +
                                         "OR middle LIKE @filter " +
                                         "OR position LIKE @filter " +
                                         "OR email LIKE @filter " +
                                         "OR mobile LIKE @filter";
                    command.CommandText = query;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@filter", $"%{txtSearch.Text}%");

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empTbl.Rows.Add(new object[]
                            {
                                reader.GetValue(reader.GetOrdinal("emp_id")),
                                reader.GetValue(reader.GetOrdinal("last")),
                                reader.GetValue(reader.GetOrdinal("first")),
                                reader.GetValue(reader.GetOrdinal("middle")),
                                reader.GetValue(reader.GetOrdinal("position")),
                                reader.GetValue(reader.GetOrdinal("email")),
                                reader.GetValue(reader.GetOrdinal("mobile")),
                            });
                        }
                    }
                }
                conn.Close();
            }
        }

        private void clear()
        {
            txtType.SelectedIndex = -1;
            foreach (Control control in tabPage1.Controls)
            {
                if (control is BunifuTextBox)
                    ((BunifuTextBox)control).Clear();
            }
        }

        private void loadEmployeeTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection(database.ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string query = @"SELECT * FROM EMP_TBL";
                    command.CommandText = query;
                    command.Connection = conn;

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empTbl.Rows.Add(new object[]
                            {
                                reader.GetValue(reader.GetOrdinal("emp_id")),
                                reader.GetValue(reader.GetOrdinal("last")),
                                reader.GetValue(reader.GetOrdinal("first")),
                                reader.GetValue(reader.GetOrdinal("middle")),
                                reader.GetValue(reader.GetOrdinal("position")),
                                reader.GetValue(reader.GetOrdinal("email")),
                                reader.GetValue(reader.GetOrdinal("mobile")),
                            });
                        }
                    }
                }
                conn.Close();
            }
        }

    }
}
