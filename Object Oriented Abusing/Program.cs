using System;
using System.Collections.Generic;

namespace Object_Oriented_Abusing
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        // Applying Object oriented programming concept to resolve if-else conditional statements
        static decimal calculateTotal(string customerType,List<Product> lstProducts)
        {
            OrderCalculator orderCalculator = new OrderCalculator(lstProducts);
            return orderCalculator.CalculateOrder(customerType);

        }
        // Before applying OO Polymorphism
        static decimal calculateTotalOld(string customerType, List<Product> lstProducts)
        {
            decimal total = 0;
            int discountRatio = 0;
            lstProducts.ForEach(p => total += p.Price);
            if (customerType == "Standard")
            {

                discountRatio = 10;
                total -= total * discountRatio / 100;
            }
            else if (customerType == "Silver")
            {

                discountRatio = 15;
                total -= total * discountRatio / 100;
            }
            else if (customerType == "Gold")
            {

                discountRatio = 25;
                total -= total * discountRatio / 100;
            }

            return total;

        }
    }

}
