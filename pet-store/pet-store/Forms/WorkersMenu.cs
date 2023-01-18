using System;
using System.Windows.Forms;

namespace pet_store
{
    public partial class WorkersMenu : Form
    {
        private readonly User user;
        private readonly Menu menu;

        public WorkersMenu(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            userLabel.Text += user.GetLogin();
            this.menu = menu;
        }

        private void ViewUsersButton_Click(object sender, EventArgs e)
        {
            ViewUserForm viewUserFrom = new();
            viewUserFrom.Show();
        }

        private void WorkersMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new(user);
            addNewUserForm.Show();
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            EditUsersForm editUserForm = new();
            editUserForm.Show();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            DeleteUserForm deleteUserForm = new();
            deleteUserForm.Show();
        }
    }
}
