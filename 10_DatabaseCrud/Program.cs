using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori Ekleme İşlemi
            //Crud --> Create-Read-Update-Delete

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=YAHYA\\YAHYAMSSQL;Initial Catalog=EgitimKampi;Integrated Security=True;TrustServerCertificate=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Tbl_Category (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi
            ////bool PStatus;
            //Console.Write("Ürün adı: ");
            //string ProductName = Console.ReadLine();

            //Console.Write("Ürün fiyatı: ");
            //if (!decimal.TryParse(Console.ReadLine(), out decimal ProductPrice))
            //{
            //    Console.WriteLine("Geçersiz fiyat girdiniz.");
            //    return;
            //}
            //SqlConnection connection = new SqlConnection("Data Source=YAHYA\\YAHYAMSSQL;Initial Catalog=EgitimKampi;Integrated Security=True;TrustServerCertificate=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO Tbl_Product (ProductName, ProductPrice, ProductStatus) VALUES (@p1, @p2, @p3)", connection);
            //command.Parameters.AddWithValue("@p1", ProductName);
            //command.Parameters.AddWithValue("@p2", ProductPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=YAHYA\\YAHYAMSSQL;Initial Catalog=EgitimKampi;Integrated Security=True;TrustServerCertificate=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * From Tbl_Product", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows) 
            //{ 
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+ " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün İd: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=YAHYA\\YAHYAMSSQL;Initial Catalog=EgitimKampi;Integrated Security=True;TrustServerCertificate=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From Tbl_Product Where ProductID=@productId",connection);
            //command.Parameters.AddWithValue("@productID", productId);
            //command.ExecuteNonQuery();
            //Console.WriteLine("silme işlemi yapıldı.");
            //connection.Close();
            #endregion

            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellenecek ürün Id: ");
            int productId= int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek ürün Adı: ");
            string productName = Console.ReadLine();
            Console.Write("Güncellenecek ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Data Source=YAHYA\\YAHYAMSSQL;Initial Catalog=EgitimKampi;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Update Tbl_Product Set ProductName=@productName, ProductPrice=@productPrice Where ProductID = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme başarılı.");
            #endregion

            //Console.Read();
        }

    }
}
