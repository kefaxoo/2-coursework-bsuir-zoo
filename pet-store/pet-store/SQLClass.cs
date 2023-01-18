using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace pet_store
{
    public class SQLClass
    {
        public static string BuildConnectionString() => "Data Source=PC;Initial Catalog=PetShop;Integrated Security=True";
       
        public static void CheckStateOfConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Ошибка", "Не удалось установить соединение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public static int GetFirstFreeID(string table)
        {
            using (var connection = new SqlConnection(BuildConnectionString()))
            {
                connection.Open();
                CheckStateOfConnection(connection);
                var command = new SqlCommand($"SELECT MIN(ID + 1) FROM {table} WHERE ID + 1 NOT IN (SELECT ID FROM {table})", connection);
                var reader = command.ExecuteReader();
                var id = 1;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            id = Convert.ToInt32(reader.GetValue(0));
                        }
                    }
                }

                reader.Close();
                connection.Close();
                return id;
            }
        }
    }
}
