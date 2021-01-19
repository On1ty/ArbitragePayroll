using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MaterialSkin;
using MaterialSkin.Controls;

namespace UI_payroll
{
    public partial class frmLogin : MaterialForm
    {
        Database database;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            database = new Database();
            database.GetConnection();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtAdmin.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                using (SQLiteConnection conn = new SQLiteConnection(database.ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        string query = @"SELECT * FROM ADMIN_LOGIN WHERE adminname=@adminname AND password=@password";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@adminname", txtAdmin.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);

                        using(SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Monitoring monitoring = new Monitoring();
                                monitoring.Show();
                                Close();
                            }
                            else MessageBox.Show("Wrong Admin Credentials", "Error");
                        }
                    }
                    conn.Close();
                }
            }
            else MessageBox.Show("Please enter Admin Credentials", "Error");
        }

        private void txtField_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSignin_Click(sender, e);
            }
        }
    }
}
