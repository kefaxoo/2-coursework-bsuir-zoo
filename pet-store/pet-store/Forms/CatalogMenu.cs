using System;
using System.Windows.Forms;

namespace pet_store
{
    public partial class CatalogMenu : Form
    {
        private readonly Menu menu;

        public CatalogMenu(User user, Menu menu)
        {
            InitializeComponent();
            userLabel.Text += user.GetRole();
            this.menu = menu;
        }

        private void ShowCatalogButton_Click(object sender, EventArgs e)
        {
            ShowCatalog showCatalog = new();
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

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new();
            addItemForm.Show();
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            EditItemsForm editItemsForm = new();
            if (editItemsForm.IsItemsNullOrEmpty())
            {
                return;
            }

            editItemsForm.Show();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            DeleteItemForm deleteItemForm = new();
            if (deleteItemForm.IsItemsNullOrEmpty())
            {
                return;
            }
            
            deleteItemForm.Show();
        }
    }
}
