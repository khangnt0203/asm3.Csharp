using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductLibrary
{
    public class ProductDB
    {
        string ConnectionString = "server=localhost,1433;database=SaleDB;uid=sa,pwd=01256230";
        List<Product> list;

        public List<Product> GetList
        {
            get => list;
        }

        public bool AddNewProduct(Product p)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string SQL = "INSERT Product values(@id,@name,@quantity,@price)";
            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("id", p.ProductID);
            command.Parameters.AddWithValue("name", p.ProductName);
            command.Parameters.AddWithValue("quantity", p.ProductQuantity);
            command.Parameters.AddWithValue("price", p.Price);
            connection.Open();
            int row = command.ExecuteNonQuery();
            if (row != 0)
            {
                list.Add(p);
                return true;
            }
            else
            {
                return false;

            }

        }

        public bool RemoveProduct(Product p)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string SQL = "DELETE Product WHERE id = @id";
            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("id", p.ProductID);
            connection.Open();
            int row = command.ExecuteNonQuery();
            if (row != 0)
            {
                list.Remove(p);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UpdateProduct(Product p)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string SQL = "UPDATE Product SET name = @name , quantity = @quantity," +
                "price = @price where id = @id";
            SqlCommand command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("id", p.ProductID);
            command.Parameters.AddWithValue("name", p.ProductName);
            command.Parameters.AddWithValue("quantity", p.ProductQuantity);
            command.Parameters.AddWithValue("price", p.Price);
            connection.Open();
            int row = command.ExecuteNonQuery();
            if (row != 0)
            {
                Product OldProduct = FindProduct(p.ProductID);
                list.Remove(OldProduct);
                list.Add(p);
                return true;
            }
            else
            {
                return false;

            }

        }

        public Product FindProduct(int ID)
        {
            foreach (Product product in list)
            {
                if (product.ProductID == ID)
                {
                    return product;
                }
            }
            return null;
        }


    }
}
