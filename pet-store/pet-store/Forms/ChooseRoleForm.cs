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
    public partial class ChooseRoleForm : Form
    {
        private string login;
        private string password;
        private LoginForm loginForm;
        
        public ChooseRoleForm()
        {
            InitializeComponent();
            adminRadioButton.Left = (this.ClientSize.Width - adminRadioButton.Width) / 2;
            workerRadioButton.Left = (this.ClientSize.Width - workerRadioButton.Width) / 2;
        }

        public void Set(string login, string password, LoginForm loginForm)
        {
            this.login = login;
            this.password = password;
            this.loginForm = loginForm;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString()))
            {
                connection.Open();
                SQLClass.CheckStateOfConnection(connection);
                string role = adminRadioButton.Checked ? "Директор" : "Продавец";
                var command = new SqlCommand($"INSERT INTO Users (ID, Login, Password, Role) VALUES ('{SQLClass.GetFirstFreeID("Users")}', '{login}', '{password}', N'{role}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Пользователь {login} добавлен в систему", "Операция завершена успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginForm.LoadUsers();
                this.Close();
            }
        }
    }
}
