using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Models
{
    public class Pitas : BaseClass
    {
        public string picturePath { get; set; }
        public decimal price { get; set; }
        public int count { get; set; }
    }
}
