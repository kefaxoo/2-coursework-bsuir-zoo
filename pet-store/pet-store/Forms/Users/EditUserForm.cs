using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pet_store.Forms.Users
{
    public partial class EditUserForm : Form
    {
        private User oldUser;
        private User newUser;
        private EditUsersForm editUsersForm;

        public EditUserForm(User user, EditUsersForm editUsersForm)
        {
            InitializeComponent();
            oldUser = user;
            loginTextBox.Text = oldUser.GetLogin();
            passwordTextBox.Text = oldUser.GetPassword();
            (oldUser.GetRole() == "Директор" ? managerRadioButton : workerRadioButton).Checked = true;
            this.editUsersForm = editUsersForm;
        }

        private void UpdateUser()
        {
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString().ConnectionString))
            {
                connection.Open();
                SQLClass.CheckStateOfConnection(connection);
                var command = new SqlCommand($"UPDATE Items SET Login = '{newUser.GetLogin()}', Password = '{newUser.GetPassword()}', Role = N'{newUser.GetRole()}' WHERE ID = '{newUser.GetID()}'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Пользователь {newUser.GetLogin()} успешно изменён", "Успешная операция", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                editUsersForm.LoadUsers();
                this.Close();
            }
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            var role = managerRadioButton.Checked ? "Директор" : "Продавец";
            newUser = new User(oldUser.GetID(), loginTextBox.Text, passwordTextBox.Text, role);
            if (oldUser != newUser)
            {
                if (MessageBox.Show("Вы точно хотите изменить данные пользователя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    UpdateUser();
                } 
                else
                {
                    this.Close();
                }
            }
        }
    }
}
