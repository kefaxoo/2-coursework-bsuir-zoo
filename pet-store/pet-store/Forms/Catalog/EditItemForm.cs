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
    public partial class EditItemForm : Form
    {
        private Item oldItem;
        private Item newItem;
        private EditItemsForm editItemsForm;

        public EditItemForm(Item oldItem, EditItemsForm editItemsForm)
        {
            InitializeComponent();
            this.oldItem = oldItem;
            nameTextBox.Text = oldItem.GetName();
            priceNumericUpDown.Value = Convert.ToDecimal(oldItem.GetPrice());
            categoryTextBox.Text = oldItem.GetCategory();
            countNumericUpDown.Value = oldItem.GetCount();
            this.editItemsForm = editItemsForm;
        }

        private void UpdateItem()
        {
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString().ConnectionString))
            {
                connection.Open();
                SQLClass.CheckStateOfConnection(connection);
                var command = new SqlCommand($"UPDATE Items SET Name = N'{newItem.GetName()}', Price = '{newItem.GetPrice().ToString().Replace(',', '.')}', Category = N'{newItem.GetCategory()}', Count = '{newItem.GetCount()}' WHERE ID = '{newItem.GetID()}'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Товар {newItem.GetName()} успешно изменён", "Успешная операция", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                editItemsForm.LoadItems();
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newItem = new Item(oldItem.GetID(), nameTextBox.Text, Convert.ToDouble(priceNumericUpDown.Value), categoryTextBox.Text, Convert.ToInt32(countNumericUpDown.Text));
            if (oldItem != newItem)
            {
                if (MessageBox.Show("Вы точно хотите изменить данные товара?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    UpdateItem();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
