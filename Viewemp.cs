using ArbitragePayroll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_payroll
{
    public partial class Viewemp : Form
    {
        public Viewemp()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            pages.SetPage("tabDetails");
         }

        private void btnPayrollhistory_Click(object sender, EventArgs e)
        {
            pages.SetPage("tabPayroll");
        }

        private void btnAttendancehistory_Click(object sender, EventArgs e)
        {
            pages.SetPage("tabAttendance");
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            pages.SetPage("tabLeave");
        }

        private void btnHoliday_Click(object sender, EventArgs e)
        {
            pages.SetPage("tabHoliday");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }
    }
}
