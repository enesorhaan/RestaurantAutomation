using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models
{
    public class Menus : BaseClass
    {
        public string contents { get; set; }
        public decimal price { get; set; }
        public decimal anotherPrice { get; set; }
        public int count { get; set; }
        public List<Beverages> beverages { get; set; }
    }
}
