using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pet_store
{
    public partial class ViewUserForm : Form
    {
        private List<User> Users;
        
        public ViewUserForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void UpdateDataGridView()
        {
            usersDataGridView.Rows.Clear();
            foreach (var user in Users)
            {
                var row = new DataGridViewRow();
                row.CreateCells(usersDataGridView);
                row.Cells[0].Value = user.GetID();
                row.Cells[1].Value = user.GetLogin();
                row.Cells[2].Value = user.GetPassword();
                row.Cells[3].Value = user.GetRole();
                usersDataGridView.Rows.Add(row);
            }
        }

        private void LoadUsers()
        {
            Users = new List<User>();
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString()))
            {
                connection.Open();
                SQLClass.CheckStateOfConnection(connection);
                var command = new SqlCommand("SELECT * FROM Users", connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var id = Convert.ToInt32(reader.GetValue(0));
                        var login = reader.GetValue(1).ToString();
                        var password = reader.GetValue(2).ToString();
                        var role = reader.GetValue(3).ToString();
                        Users.Add(new User(id, login, password, role));
                    }
                }

                reader.Close();
                connection.Close();
            }

            UpdateDataGridView();
        }
    }
}
