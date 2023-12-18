using System.Collections.Generic;

namespace Pagination.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
            new Product { ProductId = 1, Price = 2.5m, ProductName = "Mahmoud" },
            new Product { ProductId = 2, Price = 5.0m, ProductName = "John" },
            new Product { ProductId = 3, Price = 7.5m, ProductName = "Alice" },
            new Product { ProductId = 4, Price = 10.0m, ProductName = "Bob" },
            new Product { ProductId = 5, Price = 12.5m, ProductName = "Eva" },
            new Product { ProductId = 6, Price = 15.0m, ProductName = "Michael" },
            new Product { ProductId = 7, Price = 17.5m, ProductName = "Sophia" },
            new Product { ProductId = 8, Price = 20.0m, ProductName = "David" },
            new Product { ProductId = 9, Price = 22.5m, ProductName = "Olivia" },
            new Product { ProductId = 10, Price = 25.0m, ProductName = "Daniel" },
            new Product { ProductId = 11, Price = 25.0m, ProductName = "Daniel554" },
            new Product { ProductId = 12, Price = 27.0m, ProductName = "Daniel565" },
            new Product { ProductId = 13, Price = 28.0m, ProductName = "Daniel565" },
            new Product { ProductId = 14, Price = 29.0m, ProductName = "Daniel565" },
            new Product { ProductId = 15, Price = 233.0m, ProductName = "Daniel565" },
            new Product { ProductId = 16, Price = 25.0m, ProductName = "Daniel565" },
            };
        }
    }
}
