using pet_store.Forms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pet_store
{
    public partial class DeleteUserForm : Form
    {
        private List<User> users;
        
        public DeleteUserForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void UpdateDataGridView()
        {
            usersDataGridView.Rows.Clear();
            foreach (var user in users)
            {
                var row = new DataGridViewRow();
                row.CreateCells(usersDataGridView);
                row.Cells[0].Value = user.GetID();
                row.Cells[1].Value = user.GetLogin();
                row.Cells[2].Value = user.GetPassword();
                row.Cells[3].Value = user.GetRole();
                row.Cells[4].Value = "Удаление";
                usersDataGridView.Rows.Add(row);
            }
        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == usersDataGridView.Columns[4].Index && e.RowIndex < users.Count)
            {
                if (MessageBox.Show("Вы точно хотите удалить данного пользователя", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(SQLClass.BuildConnectionString()))
                    {
                        connection.Open();
                        SQLClass.CheckStateOfConnection(connection);
                        var id = usersDataGridView.Rows[e.RowIndex].Cells[0].Value;
                        var login = usersDataGridView.Rows[e.RowIndex].Cells[1].Value;
                        var command = new SqlCommand($"DELETE FROM Users WHERE ID = {id}", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"Пользователь {login} был успешно удалён", "Успешная операция", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LoadUsers();
                    }
                }
            }
        }

        public void LoadUsers()
        {
            users = new List<User>();
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
                        users.Add(new User(id, login, password, role));
                    }
                }

                reader.Close();
                connection.Close();
            }

            UpdateDataGridView();
        }
    }
}
