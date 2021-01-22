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

        private void Viewemp_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

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
          
        }
    }
}
