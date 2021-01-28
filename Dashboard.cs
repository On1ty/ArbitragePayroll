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
            timer1.Start();
            loadDashboardTable();
            loadAttendanceTable();
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
            collapseAnimation.Start();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pages.SetPage("attendance");
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            pages.SetPage("payslip");
        }

        private void btnPayrollHistory_Click(object sender, EventArgs e)
        {
            pages.SetPage("payroll_history");
        }

        private void b_Click(object sender, EventArgs e)
        {
            pages.SetPage("attendance_history");
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            pages.SetPage("leave");
        }

        private void btnHoliday_Click(object sender, EventArgs e)
        {
            pages.SetPage("holiday");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pages.SetPage("dashboard");
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
                        "(emp_id,last,first,middle,address,dob,civil,nationality,sss,philhealth,pagibig,tin,email,mobile,position,class,basic,allowance)" +
                        "VALUES " +
                        "(@emp_id,@last,@first,@middle,@address,@dob,@civil,@nationality,@sss,@philhealth,@pagibig,@tin,@email,@mobile,@position,@class,@basic,@allowance)";

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
                    command.Parameters.AddWithValue("@basic", txtBasic.Text);
                    command.Parameters.AddWithValue("@allowance", txtAllowance.Text);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("New Employee inserted!", "Success");
                        empTbl.Rows.Clear();
                        attendanceTbl.Rows.Clear();
                        loadAttendanceTable();
                        loadDashboardTable();
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
        
        private void loadDashboardTable()
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

        private void loadAttendanceTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection(database.ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string query = @"SELECT a.id, e.emp_id, last, first, middle, time_in, time_out, date_in " +
                                    "FROM EMP_TBL as e LEFT JOIN ATTENDANCE as a ON e.emp_id = a.emp_id AND date_in = date('now')";

                    command.CommandText = query;
                    command.Connection = conn;

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            attendanceTbl.Rows.Add(new object[]
                            {
                                reader.GetValue(reader.GetOrdinal("id")),
                                reader.GetValue(reader.GetOrdinal("emp_id")),
                                reader.GetValue(reader.GetOrdinal("last")),
                                reader.GetValue(reader.GetOrdinal("first")),
                                reader.GetValue(reader.GetOrdinal("middle")),
                                reader.GetValue(reader.GetOrdinal("time_in")),
                                reader.GetValue(reader.GetOrdinal("time_out")),
                                reader.GetValue(reader.GetOrdinal("date_in")),
                            });
                        }
                    }
                }
                conn.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private bool isCollapsed = false;
        private void collapseAnimation_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelCollapse.Height += 10;
                adjustPanel.Location = new Point(adjustPanel.Location.X, adjustPanel.Location.Y + 10);

                if(panelCollapse.Size == panelCollapse.MaximumSize)
                {
                    collapseAnimation.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelCollapse.Height -= 10;
                adjustPanel.Location = new Point(adjustPanel.Location.X, adjustPanel.Location.Y - 10);

                if (panelCollapse.Size == panelCollapse.MinimumSize)
                {
                    collapseAnimation.Stop();
                    isCollapsed = true;
                }
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

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            string last_name = attendanceTbl.Rows[attendanceTbl.CurrentRow.Index].Cells[2].Value.ToString();
            string emp_id = attendanceTbl.Rows[attendanceTbl.CurrentRow.Index].Cells[1].Value.ToString();

            DialogResult confirmation = MessageBox.Show($"Are you sure to time in {last_name}?", "Confirmation", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.No) 
                return;

            using (SQLiteConnection conn = new SQLiteConnection(database.ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string query = @"INSERT INTO ATTENDANCE " +
                        "(emp_id,date_in,time_in,status)" +
                        "VALUES " +
                        "(@emp_id,@date_in,@time_in,@status)";

                    command.CommandText = query;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@emp_id", emp_id);
                    command.Parameters.AddWithValue("@date_in", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@time_in", DateTime.Now.ToShortTimeString());
                    command.Parameters.AddWithValue("@status", "present");

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show($"{last_name} successfully timed in", "Success");
                        attendanceTbl.Rows.Clear();
                        loadAttendanceTable();
                    }
                    else MessageBox.Show("There is a problem while inserting the data. Call the Programmer to resolve this problem.", "Error");
                }
                conn.Close();
            }
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            bool isTimeIn = false;
            string rowId = attendanceTbl.Rows[attendanceTbl.CurrentRow.Index].Cells[0].Value.ToString();
            string empId = attendanceTbl.Rows[attendanceTbl.CurrentRow.Index].Cells[1].Value.ToString();
            string last_name = attendanceTbl.Rows[attendanceTbl.CurrentRow.Index].Cells[2].Value.ToString();

            DialogResult confirmation = MessageBox.Show($"Are you sure to time out {last_name}?", "Confirmation", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.No)
                return;

            using (SQLiteConnection conn = new SQLiteConnection(database.ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string query = @"SELECT * FROM ATTENDANCE WHERE emp_id=@empid AND date_in=date('now')";
                    command.CommandText = query;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@empid", empId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) isTimeIn = true;
                    }

                    if (isTimeIn)
                    {
                        query = @"UPDATE ATTENDANCE SET date_out=@date_out, time_out=@time_out WHERE id = @id";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@id", rowId);
                        command.Parameters.AddWithValue("@date_out", DateTime.Now.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@time_out", DateTime.Now.ToShortTimeString());

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show($"{last_name} successfully timed out", "Success");
                            attendanceTbl.Rows.Clear();
                            loadAttendanceTable();
                        }
                        else MessageBox.Show("There is a problem while inserting the data. Call the Programmer to resolve this problem.", "Error");
                    }
                    else MessageBox.Show($"{last_name} need to time in first!", "Error");
                }
                conn.Close();
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            SelectLeave selectLeave = new SelectLeave();
            selectLeave.ShowDialog();
        }
    }
}
