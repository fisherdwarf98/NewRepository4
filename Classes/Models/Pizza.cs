using System;

namespace Classes.Models
{
    public class Pizza
    {

        public Pizza(int toppingSize, string crust, params string[] toppings)
        {
            
            Random rnd = new Random(DateTime.Now.Millisecond);
            PizzaId = rnd.Next(0, int.MaxValue);

            Toppings = new string[toppingSize];

            Crust = crust;
        }

        public Int64 PizzaId;
        
        public string[] Toppings = new string[10];


        public string Crust;

        public string Sauce;

        public int Size;

    }
}
