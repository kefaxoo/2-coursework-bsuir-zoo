using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pet_store
{
    public partial class WorkersMenu : Form
    {
        private User user;
        private Menu menu;

        public WorkersMenu(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            userLabel.Text += user.GetLogin();
            this.menu = menu;
        }

        private void viewUsersButton_Click(object sender, EventArgs e)
        {
            ViewUserForm viewUserFrom = new ViewUserForm();
            viewUserFrom.Show();
        }

        private void WorkersMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm(user);
            addNewUserForm.Show();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            EditUsersForm editUserForm = new EditUsersForm();
            editUserForm.Show();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.Show();
        }
    }
}
