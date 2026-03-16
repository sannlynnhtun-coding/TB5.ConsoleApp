using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB5.ConsoleApp.DapperSample.DapperSample
{
    public class ProductCategoryDapperService
    {
        private string connectionString = "Data Source=.;Initial Catalog=Batch5MiniPOS;User ID=sa;Password=sasa@123;Trust Server Certificate=True;";

        public void Create()
        {
            string query = @"INSERT INTO [dbo].[Tbl_ProductCategory]
           ([ProductCategoryName])
     VALUES
           (@ProductCategoryName)";

            using IDbConnection connection = new SqlConnection(connectionString);
            connection.Open();

            int result = connection.Execute(query, new
            {
                ProductCategoryName = "Electronics"
            });

            string message = result > 0 ? "Category created successfully." : "Failed to create category.";
            Console.WriteLine(message);
        }

        public void Read()
        {
            string query = "SELECT * FROM Tbl_ProductCategory";

            using IDbConnection connection = new SqlConnection(connectionString);
            connection.Open();

            List<TblProductCategory> lst = connection.Query<TblProductCategory>(query).ToList();

            foreach (var item in lst)
            {
                Console.WriteLine($"Id: {item.ProductCategoryId}, Name: {item.ProductCategoryName}");
            }
        }

        public void Edit()
        {
            string query = "SELECT * FROM Tbl_ProductCategory Where ProductCategoryId=@Id;";

            using IDbConnection connection = new SqlConnection(connectionString);
            connection.Open();

            var item = connection.Query<TblProductCategory>(query, new
            {
                Id = 1
            }).FirstOrDefault();

            if (item is null)
            {
                Console.WriteLine("Category not found.");
                return;
            }

            Console.WriteLine($"Id: {item.ProductCategoryId}, Name: {item.ProductCategoryName}");
        }

        public void Update()
        {
            string query = @"UPDATE [dbo].[Tbl_ProductCategory]
SET [ProductCategoryName] = @Name
WHERE ProductCategoryId = @Id";

            using IDbConnection connection = new SqlConnection(connectionString);
            connection.Open();

            int result = connection.Execute(query, new
            {
                Id = 1,
                Name = "Updated Electronics"
            });

            string message = result > 0 ? "Category updated successfully." : "Failed to update category.";
            Console.WriteLine(message);
        }

        public void Delete()
        {
            string query = @"DELETE FROM [dbo].[Tbl_ProductCategory]
WHERE ProductCategoryId = @Id";

            using IDbConnection connection = new SqlConnection(connectionString);
            connection.Open();

            int result = connection.Execute(query, new { Id = 1 });

            string message = result > 0 ? "Category deleted successfully." : "Failed to delete category.";
            Console.WriteLine(message);
        }
    }

    public class TblProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; } = null!;
    }
}
