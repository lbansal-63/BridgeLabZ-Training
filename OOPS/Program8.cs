using System; 
public class Program
{
    static class Product
    {
        public static int prodId;
        public static string prodName;
        public static int prodPrice; 

        static Product()
        {
            prodId = 111;
            prodName = "Guitar";
            prodPrice = 5000; 
        }
        public static void getProdDetail()
        {
            Console.WriteLine("Product Id: {0}", prodId);
            Console.WriteLine("Product Name: {0}", prodName);
            Console.WriteLine("Product Price: {0}", prodPrice);
        }

        public static void getDiscount()
        {
            int disAmt = prodPrice / 10;
            Console.WriteLine("Your discount amount is: {0}", disAmt);
            Console.WriteLine("Total cost of product is: {0}", (prodPrice - disAmt));
        }
    }

    public static void Main()
    {
        Product.getProdDetail();
        Product.getDiscount();
    }
}