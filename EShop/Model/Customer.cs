using System.Collections.Generic;

namespace EShop.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public BillingInformation BillingInformation { get; set; }
        public List<Order> Orders { get; } = new List<Order>();
    }

    public class BillingInformation
    {
    }
}