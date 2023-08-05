using RestaurantAutomation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models
{
    public class Beverages : BaseClass
    {
        public decimal price { get; set; }
        public int count { get; set; }
        public BeverageType beverageType { get; set; }
    }
}
