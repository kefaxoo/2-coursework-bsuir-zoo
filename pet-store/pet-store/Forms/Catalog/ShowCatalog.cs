using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pet_store
{
    public partial class ShowCatalog : Form
    {
        private List<Item> items;

        public ShowCatalog()
        {
            InitializeComponent();
            LoadItems();
        }

        public bool IsItemsEmpty()
        {
            return items.Count == 0;
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
                itemsDataGridView.Rows.Add(row);
            }
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

            UpdateDataGridView();
        }
    }
}
