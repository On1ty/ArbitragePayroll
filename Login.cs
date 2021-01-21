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
using System.Threading;
using ArbitragePayroll;

namespace UI_payroll
{
    public partial class frmLogin : Form
    {
        Database database;
        public frmLogin()
        {
            InitializeComponent();
            database = new Database();
            database.GetConnection();
        }

        private async void btnSignin_Click(object sender, EventArgs e)
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

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                loading.Visible = true;
                                await AsyncLoad();
                                var dashboard = new Dashboard();
                                dashboard.Show();
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

        private static Task<int> AsyncLoad()
        {
            return Task.Run(() => 
            {
                Thread.Sleep(2000);
                return 0;
            });
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
