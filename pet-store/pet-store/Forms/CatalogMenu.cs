using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pet_store
{
    public partial class CatalogMenu : Form
    {
        private User user;
        private Menu menu;

        public CatalogMenu(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            userLabel.Text += user.GetRole();
            this.menu = menu;
        }

        private void showCatalogButton_Click(object sender, EventArgs e)
        {
            ShowCatalog showCatalog = new ShowCatalog();
            if (showCatalog.IsItemsEmpty())
            {
                return;
            }

            showCatalog.Show();
        }

        private void CatalogMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.Show();
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            EditItemsForm editItemsForm = new EditItemsForm();
            editItemsForm.Show();
        }
    }
}
