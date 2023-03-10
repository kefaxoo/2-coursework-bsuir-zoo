using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pet_store
{
    public partial class DeleteItemForm : Form
    {
        private List<Item> items;

        public DeleteItemForm()
        {
            InitializeComponent();
            LoadItems();
        }

        public bool IsItemsNullOrEmpty()
        {
            return items == null || items.Count == 0;
        }

        private void UpdateDataGridView()
        {
            itemsDataGridView.Rows.Clear();
            foreach (var item in items)
            {
                var row = new DataGridViewRow();
                row.CreateCells(itemsDataGridView);
                row.Cells[0].Value = item.GetID();
                row.Cells[1].Value = item.GetName();
                row.Cells[2].Value = item.GetPrice();
                row.Cells[3].Value = item.GetCategory();
                row.Cells[4].Value = item.GetCount();
                row.Cells[5].Value = "Удалить";
                itemsDataGridView.Rows.Add(row);
            }

            itemsDataGridView.CellClick += ItemsDataGridView_CellClick;
        }

        private void ItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == itemsDataGridView.Columns[5].Index && e.RowIndex < items.Count)
            {
                if (MessageBox.Show("Вы точно хотите удалить данный товар", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(SQLClass.BuildConnectionString()))
                    {
                        connection.Open();
                        SQLClass.CheckStateOfConnection(connection);
                        var id = itemsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                        var name = itemsDataGridView.Rows[e.RowIndex].Cells[1].Value;
                        var command = new SqlCommand($"DELETE FROM Items WHERE ID = {id}", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"Товар {name} был успешно удалён", "Успешная операция", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LoadItems();
                    }
                }
            }
        }

        public void LoadItems()
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

            UpdateDataGridView();
        }
    }
}
