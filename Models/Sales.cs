using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models
{
    public class Sales : BaseClass
    {
        public Sales()
        {
            creationDate = DateTime.Now.ToString();
        }

        public string creationDate { get; set; }
        public decimal totalPrice { get; set; }
        public string paymentMethod { get; set; }
        public List<string> orderList { get; set; }

        public override string ToString()
        {
            return $"Order List on {creationDate}:\nTotal Price: {totalPrice}\nPayment Method: {paymentMethod}";
        }
    }
}
