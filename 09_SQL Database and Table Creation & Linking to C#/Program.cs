using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SQL_Database_and_Table_Creation___Linking_to_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SQL veri tabanı ve tablo bağlama (ders9 başlangıç ve son)
            //ado.net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            string tablenumber = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------");
            SqlConnection connection = new SqlConnection("Data Source=YAHYA\\YAHYAMSSQL;Initial Catalog=EgitimKampi;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Tbl_Category", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            connection.Close();
            #endregion
        }
    }
}
