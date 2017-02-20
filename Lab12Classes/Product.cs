using System;

namespace Lab12Classes
{
    class Product
    {
        int productCode;
        string productName;
        double sellingPrice;
        double costPrice;
        int inStock;
        double totalProfit;
        double profit;
        const double VAT = 1.20;

        //Constructor or initialiser
        public Product(int pCode, string pName, double pSellPrice, double pCostPrice)
        {
            productCode = pCode;
            productName = pName;
            sellingPrice = pSellPrice;
            costPrice = pCostPrice;
        }

        //Method to update stock
        public void RenewStockLevel(int stock)
        {
            inStock = inStock + stock;
        }


        // Method for sale of product
        public bool Sell(int numSold)
        {

            if(numSold > inStock )
            {
                Console.WriteLine("Not enough in stock");
                return false;
            }
            else
            {
                profit =  (sellingPrice - costPrice)* numSold;
                totalProfit = totalProfit + profit;
                profit = 0;
                inStock = inStock - numSold;
                return true;
            }
        }

        //method to display current stock
        public int GetStock()
        {
            Console.WriteLine("Units of product left = " + inStock);
            return inStock;   
        }

        //method to get total profit
        public double GetAccumulatedProfit()
        {
            Console.WriteLine("Total profit is : " + totalProfit);
            return totalProfit;
        }

    }
}
