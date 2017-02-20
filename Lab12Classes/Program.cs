using System;


namespace Lab12Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int purchaced;

            Product newProduct = new Product(1234, "toy", 10, 7);
            newProduct.RenewStockLevel(100);
            newProduct.GetStock();
            Console.WriteLine("How many would you like to buy: ");
            purchaced = Int32.Parse(Console.ReadLine());
            newProduct.Sell(purchaced);
            newProduct.GetAccumulatedProfit();


            do
            {
                Console.WriteLine("");
                Console.WriteLine("Would you like to buy more?");
                newProduct.GetStock();
                Console.WriteLine("Enter ammount to purchace or Input 0 to EXIT : ");
                purchaced = Int32.Parse(Console.ReadLine());
                newProduct.Sell(purchaced);
                newProduct.GetAccumulatedProfit();

            } while (purchaced != 0);



        }
    }
}
