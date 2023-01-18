using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace pet_store
{
    public partial class SalesForm : Form
    {
        private ShowCatalog showCatalog = new ShowCatalog();
        private readonly Timer timer = new Timer(1000);
        private List<Item> items;
        private List<Item> billItems;
        private Menu menu;

        public SalesForm(Menu menu)
        {
            InitializeComponent();
            showCatalog.Show();
            LoadItems();
            billItems = new List<Item>();
            this.menu = menu;
        }

        public bool IsItemsNullOrEmpty()
        {
            return items == null || items.Count == 0;
        }

        private void LoadItems()
        {
            items = new List<Item>();
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString()))
            {
                connection.Open();
                SQLClass.CheckStateOfConnection(connection);
                var command = new SqlCommand("SELECT * FROM Items", connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var id = Convert.ToInt32(reader.GetValue(0));
                        var name = reader.GetValue(1).ToString();
                        var price = Convert.ToDouble(reader.GetValue(2));
                        var category = reader.GetValue(3).ToString();
                        var count = Convert.ToInt32(reader.GetValue(4));
                        items.Add(new Item(id, name, price, category, count));
                    }
                }

                reader.Close();
                connection.Close();

                if (items.Count == 0)
                {
                    MessageBox.Show("В базе данных нет товаров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
        }

        private void UpdateDateAndTime(object sender, ElapsedEventArgs e)
        {
            //dateLabel.Text = $"Дата: {DateTime.Now.ToShortDateString()}";
            //timeLabel.Text = $"Время: {DateTime.Now.ToShortTimeString()}";
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            timer.Elapsed += UpdateDateAndTime;
            timer.Start();
        }

        private void openItemsButton_Click(object sender, EventArgs e)
        {
            if (!showCatalog.Visible)
            {
                showCatalog = new ShowCatalog();
                showCatalog.Show();
            }
        }

        private bool IsItemInList()
        {
            foreach (var item in items)
            {
                if (item.GetID() == idNumericUpDown.Value)
                {
                    return true;
                }
            }

            return false;
        }

        private int GetIndex()
        {
            var id = Convert.ToInt32(idNumericUpDown.Value);
            return items.FindIndex(item => item.GetID() == id);
        }

        private bool IsAvailable()
        {
            return items[GetIndex()].GetCount() >= Convert.ToInt32(countNumericUpDown.Value);
        }

        private void UpdateSum()
        {
            double sum = 0;
            foreach (var item in billItems)
            {
                sum += item.GetPrice() * item.GetCount();
            }

            sumTextBox.Text = sum.ToString();
        }

        private void ItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == itemsDataGridView.Columns[5].Index && e.RowIndex < billItems.Count)
            {
                EditForm editForm = new EditForm(billItems[e.RowIndex], items[GetIndex()], this);
                editForm.Show();
            }
        }

        private void ReloadDataGridView()
        {
            itemsDataGridView.Rows.Clear();
            foreach (var item in billItems)
            {
                var row = new DataGridViewRow();
                row.CreateCells(itemsDataGridView);
                row.Cells[0].Value = billItems.FindIndex(i => i == item) + 1;
                row.Cells[1].Value = item.GetName();
                row.Cells[2].Value = item.GetPrice();
                row.Cells[3].Value = item.GetCount();
                row.Cells[4].Value = item.GetPrice() * item.GetCount();
                row.Cells[5].Value = "Изменить";
                itemsDataGridView.Rows.Add(row);
            }

            UpdateSum();
        }

        private bool IsItemInBill(Item item)
        {
            foreach (var itemInBill in billItems) {
                if (item.GetID() == itemInBill.GetID())
                {
                    return true;
                }
            }

            return false;
        }
        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (IsItemInList())
            {
                if (IsAvailable())
                {
                    var item = items[GetIndex()];
                    if (!IsItemInBill(item))
                    {
                        billItems.Add(new Item(item, Convert.ToInt32(countNumericUpDown.Value)));
                        ReloadDataGridView();
                    } 
                    else
                    {
                        MessageBox.Show("Данный товар уже в чеке, вы можете его изменить через кнопку \"Изменить\"", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
               
                    countNumericUpDown.Value = 1;
                    idNumericUpDown.Value = 1;
                }
                else
                {
                    MessageBox.Show("Такого количества в наличии нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный номер товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            showCatalog.Close();
            menu.Show();
        }

        public void UpdateBill(Item item)
        {
            var index = billItems.FindIndex(i => i.GetID() == item.GetID());
            billItems[index] = item;
            ReloadDataGridView();
        }

        public void DeleteItemInBill(Item item)
        {
            var index = billItems.FindIndex(i => i.GetID() == item.GetID());
            billItems.RemoveAt(index);
            ReloadDataGridView();
        }
    }
}
