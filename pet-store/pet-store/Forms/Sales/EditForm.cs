using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_store
{
    public partial class EditForm : Form
    {
        private Item oldItem;
        private Item newItem;
        private Item item;
        private SalesForm salesForm;

        public EditForm(Item itemInBill, Item item, SalesForm salesForm)
        {
            InitializeComponent();
            oldItem = itemInBill;
            nameTextBox.Text = oldItem.GetName();
            priceTextBox.Text = oldItem.GetPrice().ToString();
            countNumericUpDown.Value = oldItem.GetCount();
            sumTextBox.Text = (oldItem.GetPrice() * oldItem.GetCount()).ToString();
            this.item = item;
            newItem = new Item(oldItem, oldItem.GetCount());
            this.salesForm = salesForm;
        }

        private void saveButton_Click(object sender, EventArgs e)
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

        private void countNumericUpDown_ValueChanged(object sender, EventArgs e)
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
    }
}
