using System;

namespace staticc2
{
    static class product
    {
        public static string productnm;
        public static int prod_id ;
        public static int price;
        static product()
        {
             productnm ="table";
             prod_id = 0045;
             price = 2500;
        }
        public static void getDetails()
        {
            Console.WriteLine("name of Product is: " + productnm + "\nproduct Id is: " + prod_id + "\nPrice of Table is: " + price);
        }
        public static void disc()
        {
            int d_price = price / 20;
            Console.WriteLine("After applying 20% of Discount price of Table is: "+(price-d_price));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            product.getDetails();
            product.disc();
        }
    }
}
