using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using Process = System.Diagnostics.Process;
using System.IO;

namespace pet_store
{
    public partial class SalesForm : Form
    {
        private ShowCatalog showCatalog = new();
        private readonly Timer timer = new(1000);
        private List<Item> items;
        private readonly List<Item> billItems;
        private readonly Menu menu;

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
            dateLabel.Text = $"Дата: {DateTime.Now.ToShortDateString()}";
            timeLabel.Text = $"Время: {DateTime.Now.ToShortTimeString()}";
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            timer.Elapsed += UpdateDateAndTime;
            timer.Start();
        }

        private void OpenItemsButton_Click(object sender, EventArgs e)
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
                EditForm editForm = new(billItems[e.RowIndex], items[GetIndex()], this);
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
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (billItems.Count == 0)
            {
                var item = items[GetIndex()];
                billItems.Add(new Item(item, Convert.ToInt32(countNumericUpDown.Value)));
                ReloadDataGridView();
                countNumericUpDown.Value = 1;
                idNumericUpDown.Value = 1;
            } 
            else
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

        private static string DoubleToString(double value) => value.ToString().Replace(',', '.');

        private void UpdateItems(Bill bill)
        {
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString()))
            {
                connection.Open();
                SQLClass.CheckStateOfConnection(connection);
                foreach (var item in items)
                {
                    foreach (var billItem in billItems)
                    {
                        if (billItem.GetID() == item.GetID())
                        {
                            item.SetCount(item.GetCount() - billItem.GetCount());
                        }
                    }

                    var command = new SqlCommand($"UPDATE Items SET Count = '{item.GetCount()}' WHERE ID = {item.GetID()}", connection);
                    command.ExecuteNonQuery();
                }

                connection.Close();
                if (MessageBox.Show("Чек успешно закрыт\nЖелаете открыть его для печати?", "Успешная операция", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string text = $"Чек #{bill.getID()}\n{bill.getDate()} {bill.getTime()}\n\n";
                    foreach (var item in items)
                    {
                        text += $"{item.GetName()} {item.GetPrice()} * {item.GetCount()} = {item.GetCount() * item.GetPrice()}\n";
                    }

                    text += $"\nСумма: {bill.getSum()}\nОплата: {bill.getGivenSum()} {bill.getTypeOfMoney()}\nСдача: {bill.getChange()}\n\nБЛАГОДАРИМ ЗА ПОКУПКУ!";
                    string path = Environment.CurrentDirectory + "\\bills";
                    Directory.CreateDirectory(path);
                    using (var writer = new StreamWriter($"{path}\\{bill.getID()}.txt"))
                    {
                        writer.WriteLine(text);
                    }

                    Process.Start("notepad.exe", $"bills\\{bill.getID()}.txt");
                }

                this.Close();
            }
        }

        private void AddBillToDatabase(Bill bill)
        {
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString()))
            {
                connection.Open();
                SQLClass.CheckStateOfConnection(connection);
                var command = new SqlCommand($"INSERT INTO Bills (ID, Date, Time, Sum, GivenSum, Change, TypeOfMoney) VALUES ('{bill.getID()}', '{bill.getDate()}', '{bill.getTime()}', '{DoubleToString(bill.getSum())}', '{DoubleToString(bill.getGivenSum())}', '{DoubleToString(bill.getChange())}', N'{bill.getTypeOfMoney()}')", connection);
                command.ExecuteNonQuery();
                foreach (var item in billItems)
                {
                    command = new SqlCommand($"INSERT INTO Purchases (ID, BillID, ItemID, Count) VALUES ('{SQLClass.GetFirstFreeID("Purchases")}', '{bill.getID()}', '{item.GetID()}', '{item.GetCount()}')", connection);
                    command.ExecuteNonQuery();
                    UpdateItems(bill);
                }
            }
        }

        public void SetCloseBillData(double change, double givenSum, string typeMoney)
        {
            var now = DateTime.Now;
            var bill = new Bill(SQLClass.GetFirstFreeID("Bills"), now.ToShortDateString(), now.ToShortTimeString(), Convert.ToDouble(sumTextBox.Text), givenSum, change, typeMoney);
            AddBillToDatabase(bill);
        }

        private void CloseBillButton_Click(object sender, EventArgs e)
        {
            CloseBillForm closeBillForm = new(Convert.ToDouble(sumTextBox.Text), this);
            closeBillForm.Show();
        }
    }
}
