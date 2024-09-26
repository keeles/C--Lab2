using Microsoft.VisualBasic;

namespace week2
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 1200m,
                    StockQuantity = 10,
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Smartphone",
                    Category = "Electronics",
                    Price = 800m,
                    StockQuantity = 50,
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Washing Machine",
                    Category = "Home Appliances",
                    Price = 500m,
                    StockQuantity = 10,
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Refrigerator",
                    Category = "Home Appliances",
                    Price = 1500m,
                    StockQuantity = 5,
                },
                new Product
                {
                    ProductId = 5,
                    Name = "TV",
                    Category = "Electronics",
                    Price = 600m,
                    StockQuantity = 20,
                },
            };
        }

        public List<Product> FilterProducts()
        {
            List<Product> myProducts = GetSampleProducts();
            var filterQuery =
                from product in myProducts
                where product.Price > 500m
                where product.Category == "Electronics"
                select product;

            return filterQuery.ToList();
        }

        public void GroupAndCalculateTotal()
        {
            List<Product> myProducts = GetSampleProducts();
            var groupAndCalculateQuery =
                from product in myProducts
                group product by product.Category into Category
                select new
                {
                    Category = Category.Key,
                    totalStock = (from product in Category select product.StockQuantity).Sum(),
                };

            foreach (var cat in groupAndCalculateQuery)
            {
                Console.WriteLine($"{cat.Category}: {cat.totalStock} units in stock");
            }
        }

        public void FindProductWithMaxStock()
        {
            List<Product> myProducts = GetSampleProducts();
            var maxStockQuery =
                from product in myProducts
                orderby product.StockQuantity descending
                select product;

            Console.WriteLine(
                $"{maxStockQuery.ToList()[0].Name} - {maxStockQuery.ToList()[0].Price}: {maxStockQuery.ToList()[0].StockQuantity} in stock"
            );
        }

        public void TotalValueInStock()
        {
            List<Product> myProducts = GetSampleProducts();
            var totalValueQuery =
                from product in myProducts
                let TotalValue = product.Price * product.StockQuantity
                orderby TotalValue descending
                select new { Name = product.Name, TotalValue = TotalValue };

            Console.WriteLine(
                $"{totalValueQuery.ToList()[0].Name} ${totalValueQuery.ToList()[0].TotalValue} value in stock"
            );
        }

        public void StockBelowAverage()
        {
            List<Product> myProducts = GetSampleProducts();
            double belowAverageQuery = (
                from product in myProducts
                select product.StockQuantity
            ).Average();

            var productsBelowAverage =
                from product in myProducts
                where product.StockQuantity < belowAverageQuery
                select product;

            Console.WriteLine(
                $"{belowAverageQuery} is the average quantity for all products with stock."
            );
            foreach (Product prod in productsBelowAverage)
            {
                Console.WriteLine($"{prod.Name} - ${prod.Price} has {prod.StockQuantity} in stock");
            }
            ;
        }
    }
}
