using System;
using System.Collections.Generic;
using IronNinja.Models;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet dinner = new Buffet();
            SweetTooth dessert = new SweetTooth();
            SpiceHound hotsauce = new SpiceHound();

            while(!dessert.IsFull)
            {
                dessert.Consume(dinner.Serve());
            }
            while(!hotsauce.IsFull)
            {
                hotsauce.Consume(dinner.Serve());
            }
            if(dessert.ConsumptionHistory.Count > hotsauce.ConsumptionHistory.Count)
            {
                Console.WriteLine($"SweetTooth has consumed {dessert.ConsumptionHistory.Count} items!");
            }
            else
            {
                Console.WriteLine($"SpiceHound has consumed {hotsauce.ConsumptionHistory.Count} items!");
            }

        }
    }
}
