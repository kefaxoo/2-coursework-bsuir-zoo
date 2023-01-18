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
    public partial class AddNewUserForm : Form
    {
        private List<User> users;

        public AddNewUserForm(User user)
        {
            InitializeComponent();
            userLabel.Text += user.GetRole();
            LoadUsers();
        }

        public void LoadUsers()
        {
            users = new List<User>();
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString().ConnectionString))
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

            if (users.Count == 0)
            {
                MessageBox.Show("В базе данных нет пользователей\nПросьба пройти регистрацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowMessageBox(string text) => MessageBox.Show($"Текстовое поле {text} пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private bool AreTextBoxesEmpty()
        {
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                ShowMessageBox("Логин");
                return true;
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                ShowMessageBox("Пароль");
                return true;
            }

            return false;
        }

        private bool IsLoginExist()
        {
            foreach (var user in users)
            {
                if (user.GetLogin() == loginTextBox.Text)
                {
                    return true;
                }
            }

            return false;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (!AreTextBoxesEmpty())
            {
                if (!IsLoginExist())
                {
                    using (var connection = new SqlConnection(SQLClass.BuildConnectionString().ConnectionString))
                    {
                        connection.Open();
                        SQLClass.CheckStateOfConnection(connection);
                        string role = managerRadioButton.Checked ? "Директор" : "Продавец";
                        var command = new SqlCommand($"INSERT INTO Users (ID, Login, Password, Role) VALUES ('{SQLClass.GetFirstFreeID("Users")}', '{loginTextBox.Text}', '{passwordTextBox.Text}', N'{role}')", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"Пользователь {loginTextBox.Text} добавлен в систему", "Операция завершена успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
