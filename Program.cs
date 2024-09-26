using System.Linq.Expressions;
using Lab2;
using week2;

public class Program
{
    static void Main(string[] args)
    {
        // MathOperations mOp = new MathOperations(1200000000, 1200000000);
        // mOp.CalculateProductWithOverflow();
        // TypeConversion tCon = new TypeConversion(345.55);
        // tCon.DemoTypeConversion();
        // StringManipulation strManip = new StringManipulation();
        // strManip.DemoStringOperations();
        // strManip.ReverseWordsInString();
        // ListOperations mathOp = new ListOperations(new List<int> { 1, 4, 67, 8, 9, 10, 34 });
        // mathOp.SearchItem();
        List<Product> originalProductList = Product.GetSampleProducts();
        Product myProd = new Product();
        List<Product> myProducts = myProd.FilterProducts();
        Console.WriteLine("ALL PRODUCTS");
        foreach (Product product in originalProductList)
        {
            Console.WriteLine(product.Name);
        }
        Console.WriteLine("-------------------");
        Console.WriteLine("FILTERED PRODUCTS");
        foreach (Product product in myProducts)
        {
            Console.WriteLine(product.Name);
        }
        Console.WriteLine("-------------------");
        myProd.StockBelowAverage();
    }
}
