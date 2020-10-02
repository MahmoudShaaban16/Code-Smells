using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Abusing
{
    class OrderCalculator
    {
        private readonly Dictionary<string, CustomerOrder> customerOrdersDictionary = new Dictionary<string, CustomerOrder>();
        public OrderCalculator(List<Product> products)
        {
            this.customerOrdersDictionary.Add("Standard", new StandardCustomerOrder(products));
            this.customerOrdersDictionary.Add("Silver", new SilverCustomerOrder(products));
            this.customerOrdersDictionary.Add("Gold", new GoldCustomerOrder(products));
        }
        public decimal CalculateOrder(string customerType)
        {
            return customerOrdersDictionary[customerType].calculateTotal();
        }
    }
}
