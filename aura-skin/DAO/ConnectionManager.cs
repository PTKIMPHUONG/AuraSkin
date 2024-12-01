using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace aura_skin
{
    internal class ConnectionManager
    {
        public static string GetConnectionString()
        {
            string filePath = "ConnectFile.txt"; // Đường dẫn đến file .txt
            return File.ReadAllText(filePath).Trim();
        }
        public static void GetTableList(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();  // Mở kết nối

                    // Truy vấn để lấy danh sách các bảng
                    string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tableName = reader["TABLE_NAME"].ToString();
                                MessageBox.Show($"Bảng: {tableName}");  // Hiển thị tên bảng
                                                                        // Bạn có thể sử dụng các tên bảng này để thêm vào file .dbml hoặc thực hiện các thao tác khác
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
