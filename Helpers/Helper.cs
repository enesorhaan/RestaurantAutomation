using RestaurantAutomation.Enums;
using RestaurantAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Helpers
{
    public class Helper
    {
        public static List<Pitas> CreatePitas()
        {
            string basePath = "C:\\Users\\Enes Orhan\\Desktop\\Lessons\\RestaurantAutomation\\RestaurantAutomation\\Pictures\\";
            return new List<Pitas>()
            {
                new Pitas()
                {
                    pitaName = "Flaked Cheese",
                    price = 130,
                    picturePath = basePath + "flaked-cheese.jpg",
                },
                new Pitas()
                {
                    pitaName = "Mix",
                    price = 120,
                    picturePath = basePath + "mix.jpg",
                },
                new Pitas()
                {
                    pitaName = "Sausage",
                    price = 105,
                    picturePath = basePath + "sausage.jpg",
                },
                new Pitas()
                {
                    pitaName = "Vegetables",
                    price = 95,
                    picturePath = basePath + "vegetables.jpg",
                },
            };
        }

        public static List<Beverages> CreateBeverages()
        {
            return new List<Beverages>()
            {
                new Beverages()
                {
                    beverageName = "Coke",
                    price = 25,
                    beverageType = BeverageType.carbonatedBeverage,
                },
                new Beverages()
                {
                    beverageName = "Juice",
                    price = 20,
                    beverageType = BeverageType.stillBeverage,
                },
                new Beverages()
                {
                    beverageName = "Ayran",
                    price = 18,
                    beverageType = BeverageType.stillBeverage,
                },
                new Beverages()
                {
                    beverageName = "Mineral Water",
                    price = 14,
                    beverageType = BeverageType.carbonatedBeverage,
                },
                new Beverages()
                {
                    beverageName = "Water",
                    price = 10,
                    beverageType = BeverageType.stillBeverage,
                },
            };
        }

        public static List<Menus> CreateMenus()
        {
            return new List<Menus>()
            {
                new Menus()
                {
                    menuName = "Menu 1",
                    contents = $"Flaked-Cheese Pita + Coke",
                    price = 145,
                    anotherPrice = 155,
                },
                new Menus()
                {
                    menuName = "Menu 2",
                    contents = $"Mix Pita + Juice",
                    price = 135,
                    anotherPrice = 145,
                },
                new Menus()
                {
                    menuName = "Menu 3",
                    contents = $"Sausage Pita + Ayran",
                    price = 118,
                    anotherPrice = 128,
                },
                new Menus()
                {
                    menuName = "Menu 4",
                    contents = $"Vegetable Pita + Mineral Water",
                    price = 100,
                    anotherPrice = 110,
                },
            };
        }
    }
}
