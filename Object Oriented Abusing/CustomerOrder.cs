using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Abusing
{
    class CustomerOrder
    {
        protected int discount;
        protected List<Product> lstProducts;
        public CustomerOrder(int _discount, List<Product> products)
        {
            this.discount = _discount;
            this.lstProducts = products;
        }
        public virtual decimal calculateTotal()
        {
            decimal total = 0;
            lstProducts.ForEach(p => total += p.Price);
            total -= total * discount / 100;
            return total;
        }
    }
    class StandardCustomerOrder : CustomerOrder
    {
        public StandardCustomerOrder(List<Product> lstProducts) : base(10, lstProducts) { }
        public override decimal calculateTotal()
        {
            //custom logic here
            return base.calculateTotal();
        }
    }
    class SilverCustomerOrder : CustomerOrder
    {
        public SilverCustomerOrder(List<Product> lstProducts) : base(15, lstProducts) { }
        public override decimal calculateTotal()
        {
            //custom logic here too
            return base.calculateTotal();
        }
    }
    class GoldCustomerOrder : CustomerOrder
    {
        public GoldCustomerOrder(List<Product> lstProducts) : base(25, lstProducts) { }
        public override decimal calculateTotal()
        {
            //custom logic here too
            return base.calculateTotal();
        }
    }
}
