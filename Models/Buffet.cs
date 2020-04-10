using System;
using System.Collections.Generic;

namespace IronNinja.Models
{
    class Buffet
        {
            public List<Food> Menu;
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Pizza", 1000, false, false),
                    new Food("Steak", 1500, false, false),
                    new Food("Tacos", 800, false, false),
                    new Food("Macaroni", 700, false, false),
                    new Food("Wings", 1200, true, true),
                    new Food("Burgers", 1100, false, false),
                    new Food("Ice Cream", 500, false, true),
                };
            }
            
            public Food Serve()
            {
                Random food = new Random();
                int i = food.Next(6);
                return Menu[i];
            }
        }

}