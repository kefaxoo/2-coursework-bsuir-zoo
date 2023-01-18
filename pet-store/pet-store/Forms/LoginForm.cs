using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_store
{
    public partial class LoginForm : Form
    {
        private List<User> Users;
        
        public LoginForm()
        {
            InitializeComponent();
            nameLabel.Left = (this.ClientSize.Width - nameLabel.Width) / 2;
            signLabel.Left = (this.ClientSize.Width - signLabel.Width) / 2;
            loginLabel.Left = (this.ClientSize.Width - loginLabel.Width) / 2;
            passwordLabel.Left = (this.ClientSize.Width - passwordLabel.Width) / 2;
            LoadUsers();
        }

        public void LoadUsers()
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

            if (Users.Count == 0)
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
            foreach (var user in Users)
            {
                if (user.GetLogin() == loginTextBox.Text)
                {
                    return true;
                }
            }

            return false;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (!AreTextBoxesEmpty())
            {
                var findLogin = false;
                foreach (var user in Users)
                {
                    if (user.GetLogin() == loginTextBox.Text)
                    {
                        findLogin = true;
                        if (user.GetPassword() == passwordTextBox.Text)
                        {
                            Menu form = new Menu(user);
                            form.Show();
                            this.Hide();
                            return;
                        }
                    }
                }

                if (findLogin)
                {
                    MessageBox.Show("Вы ввели неправильный логин или пароль, попробуйте ещё раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else
                {
                    MessageBox.Show("Данного пользователя не существует, пройдите регистрацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (!AreTextBoxesEmpty()) 
            {
                if (!IsLoginExist())
                {
                    var form = new ChooseRoleForm();
                    form.Set(loginTextBox.Text, passwordTextBox.Text, this);
                    form.Show();
                } 
                else
                {
                    MessageBox.Show("Невозможно зарегестрировать пользователя с таким логином", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
