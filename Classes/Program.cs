using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[10];

            //List<int> myNumber = new List<int>();
            //myNumber.Add(6);
            //myNumber.Remove(4);


        }

        private static void DisplayPizza(Pizza pizza)
        {
            Console.WriteLine(pizza.Crust, pizza.Size, pizza.Sauce);
        }

        private static void DisplayPizza(string crust, int size, string sauce)
        {
            Console.WriteLine("Crust: {0} Size: {1} Sauce {2}", crust, size, sauce);
        }

    }
}
