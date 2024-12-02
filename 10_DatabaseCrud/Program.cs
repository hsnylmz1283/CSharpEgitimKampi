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
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------\n");
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-11QBVQN6\\MSSQLSMYO; initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün fiyatı: ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source= LAPTOP-11QBVQN6\\MSSQLSMYO; initial catalog = EgitimKampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand command =new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1 ", productName);
            //command.Parameters.AddWithValue("@p2 ", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün başarıyla eklendi.");
            #endregion

            #region Ürün Listeleme İşi

            //SqlConnection connection = new SqlConnection("Data source= LAPTOP-11QBVQN6\\MSSQLSMYO; initial catalog = EgitimKampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //connection.Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün Silme İşi
            //Console.Write("Silinecek ürün id: ");
            //int productId = Convert.ToInt32(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data source= LAPTOP-11QBVQN6\\MSSQLSMYO; initial catalog = EgitimKampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct where productId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Silme işlemi başarılı.");
            #endregion

            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellenecek ürün ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek ürün Fiyatı: ");
            int productPrice = Convert.ToInt32(Console.ReadLine());

            SqlConnection connection = new SqlConnection("data source=LAPTOP-11QBVQN6\\MSSQLSMYO; initial catalog=EgitimKampiDB; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@ProductId", connection);
            command.Parameters.AddWithValue("@ProductName", productName);
            command.Parameters.AddWithValue("@ProductPrice", productPrice);
            command.Parameters.AddWithValue("@ProductId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.Write("Güncelleme Başarılı.");
            #endregion
            Console.ReadKey();
        }
    }
}
