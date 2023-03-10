using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pet_store
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private static void ShowMessageBox(string text) => MessageBox.Show($"Текстовое поле {text} пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private bool AreTextBoxEmpty()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                ShowMessageBox("Название");
                return true;
            }

            if (string.IsNullOrEmpty(categoryTextBox.Text))
            {
                ShowMessageBox("Категория");
                return true;
            }

            return false;
        }

        private void AddItem(Item item)
        {
            using (var connection = new SqlConnection(SQLClass.BuildConnectionString()))
            {
                connection.Open();
                SQLClass.CheckStateOfConnection(connection);
                var command = new SqlCommand($"INSERT INTO Items (ID, Name, Price, Category, Count) VALUES ('{item.GetID()}', N'{item.GetName()}', '{item.GetPrice().ToString().Replace(',', '.')}', N'{item.GetCategory()}', '{item.GetCount()}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Товар {item.GetName()} был добавлен в систему", "Успешная операция", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!AreTextBoxEmpty())
            {
                var price = Convert.ToDouble(priceNumericUpDown.Value);
                var count = Convert.ToInt32(countNumericUpDown.Text);
                var item = new Item(SQLClass.GetFirstFreeID("Items"), nameTextBox.Text, price, categoryTextBox.Text, count);
                AddItem(item);
            }
        }
    }
}
