using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace ArbitragePayroll
{
    class Database
    {
        public string ConnectionString { get; set; }


        string connection;
        private readonly string dbName = "Payroll.db";

        //Access Database

        public void GetConnection()
        {
            connection = @"Data Source=" + dbName + "; Version=3";
            ConnectionString = connection; 
        }

        //Creating a new Database
        public Database()
        {
            //Check if Database exist and if not, create a new one
            if (!File.Exists("./" + dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                GetConnection();

                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    using(SQLiteCommand command = new SQLiteCommand())
                    {
                        /**
                         *CREATE ADMIN_TABLE
                         */
                        string query = @"CREATE TABLE ADMIN_LOGIN (" +
                                    "id INTEGER NOT NULL UNIQUE," +
                                    "adminname Text(50) NOT NULL UNIQUE," +
                                    "password Text(50) NOT NULL," +
                                    "PRIMARY KEY(id AUTOINCREMENT))";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.ExecuteNonQuery();

                        query = @"INSERT INTO ADMIN_LOGIN (adminname, password) VALUES ('admin', 'admin')";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.ExecuteNonQuery();

                        /**
                         *CREATE EMPLOYEE TABLE
                         */
                        query = @"CREATE TABLE EMP_TBL (" +
                                "id_emp_tbl INTEGER NOT NULL," +
                                "emp_id   TEXT(60) NOT NULL," +
                                "last  TEXT(60) NOT NULL," +
                                "first TEXT(60) NOT NULL," +
                                "middle    TEXT(60) NOT NULL," +
                                "address   TEXT(100) NOT NULL," +
                                "dob   TEXT(60) NOT NULL," +
                                "civil TEXT(60) NOT NULL," +
                                "nationality   TEXT(60) NOT NULL," +
                                "sss  TEXT(60) NOT NULL," +
                                "philhealth    TEXT(60) NOT NULL," +
                                "pagibig  TEXT(60) NOT NULL," +
                                "tin   TEXT(60) NOT NULL," +
                                "email TEXT(60) NOT NULL," +
                                "mobile    TEXT(60) NOT NULL," +
                                "position TEXT(60) NOT NULL," +
                                "class TEXT(60) NOT NULL," +
                                "basic TEXT(60) NOT NULL," +
                                "allowance TEXT(60) NOT NULL," +
                                "PRIMARY KEY(id_emp_tbl AUTOINCREMENT))";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.ExecuteNonQuery();

                        query = @"INSERT INTO EMP_TBL
                                (emp_id,last,first,middle,address,dob,civil,nationality,sss,philhealth,pagibig,tin,email,mobile,position,class,basic,allowance)
                                VALUES
                                ('20-0102-003', 'Pallo', 'Juan Miguel', '', '571 D. Ignacio Compound, Caloocan City', '01-03-1999', 'Single', 'Filipino', '', '', '', '', 'juanity.andoy@gmail.com', '09165569164', 'Programmer', 'Regular', '500', '1500'),
                                ('20-0102-004', 'Sarthou', 'Carl Joseph', '', '571 D. Ignacio Compound, Caloocan City', '01-03-1999', 'Single', 'Filipino', '', '', '', '', 'juanity.andoy@gmail.com', '09165569164', 'Programmer', 'Regular', '500', '1500'),
                                ('20-0102-005', 'Cayon', 'Sixmar Simon', '', '571 D. Ignacio Compound, Caloocan City', '01-03-1999', 'Single', 'Filipino', '', '', '', '', 'juanity.andoy@gmail.com', '09165569164', 'Programmer', 'Regular', '500', '1500'),
                                ('20-0102-006', 'Bondoc III', 'Leonardo', '', '571 D. Ignacio Compound, Caloocan City', '01-03-1999', 'Single', 'Filipino', '', '', '', '', 'juanity.andoy@gmail.com', '09165569164', 'Programmer', 'Regular', '500', '1500')";

                        command.CommandText = query;
                        command.Connection = conn;
                        command.ExecuteNonQuery();

                        /**
                         *CREATE ATTENDANCE TABLE
                         */
                        query = @"CREATE TABLE ATTENDANCE (" +
                                "id_attend_tbl INTEGER NOT NULL UNIQUE," +
                                "emp_id TEXT(60) NOT NULL," +
                                "date_in TEXT(60) NOT NULL," +
                                "time_in TEXT(60) NOT NULL," +
                                "date_out TEXT(60)," +
                                "time_out TEXT(60)," +
                                "status TEXT(60) NOT NULL," +
                                "PRIMARY KEY(id_attend_tbl AUTOINCREMENT))";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.ExecuteNonQuery();

                        /**
                         *CREATE LEAVE TABLE
                         */
                        query = @"CREATE TABLE LEAVE (" +
                                "id_leave_tbl    INTEGER NOT NULL," +
	                            "emp_id    TEXT(60) NOT NULL," +
                                "vacation  INTEGER NOT NULL," +
	                            "sick INTEGER NOT NULL," +
                                "emergency INTEGER NOT NULL," +
                                "birthday  INTEGER NOT NULL," +
                                "PRIMARY KEY(id_leave_tbl AUTOINCREMENT))";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            else return;
        }
    }
}
