using System;
using System.Windows.Forms;

namespace pet_store
{
    public partial class EditForm : Form
    {
        private readonly Item oldItem;
        private readonly Item newItem;
        private readonly Item item;
        private readonly SalesForm salesForm;

        public EditForm(Item itemInBill, Item item, SalesForm salesForm)
        {
            InitializeComponent();
            oldItem = itemInBill;
            this.item = item;
            newItem = new Item(oldItem, oldItem.GetCount());
            this.salesForm = salesForm;
            nameTextBox.Text = oldItem.GetName();
            priceTextBox.Text = oldItem.GetPrice().ToString();
            countNumericUpDown.Value = oldItem.GetCount();
            sumTextBox.Text = (oldItem.GetPrice() * oldItem.GetCount()).ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (oldItem != newItem)
            {
                if (MessageBox.Show("Вы точно хотите изменить данные товара?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    salesForm.UpdateBill(newItem);
                }

                this.Close();
            }
        }

        private void CountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (countNumericUpDown.Value <= item.GetCount())
            {
                newItem.SetCount(Convert.ToInt32(countNumericUpDown.Value));
                sumTextBox.Text = (newItem.GetPrice() * newItem.GetCount()).ToString();
            }
            else
            {
                MessageBox.Show("Такого количества в наличии нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                countNumericUpDown.Value = newItem.GetCount();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить данный товар", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                salesForm.DeleteItemInBill(newItem);
            }

            this.Close();
        }
    }
}
