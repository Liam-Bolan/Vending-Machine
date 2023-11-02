using _18._10._23_vending_machine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _18._10._23_vending_machine
{
    internal class Program
    {
        public struct products
        {
            public string prodname;
            public double prodprice;
            public double prodstock;
            public int prodnum;

        }

        static void Main(string[] args)
        {
            int itemnumber;
            double insertcoins;
            products[] machine = new products[10];
            LoadItems(machine);
            displayItems(machine);
            Console.WriteLine("\nPlease enter item number:");
            itemnumber = int.Parse(Console.ReadLine());

            if (itemnumber == 0)
            {
                Console.WriteLine($"Please insert £{machine[0].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[0].prodprice)
                {
                    Console.WriteLine("1x M&MS dispensing");
                    Console.ReadLine();
                }
            }
            else if (itemnumber == 1)
            {
                Console.WriteLine($"Please insert £{machine[1].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[1].prodprice)
                {
                    Console.WriteLine("1x Kinder Bueno Dispensing");
                    Console.ReadLine();
                }
            }
            else if (itemnumber == 2)
            {
                Console.WriteLine($"Please insert £{machine[2].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[2].prodprice)
                {
                    Console.WriteLine("1x Skittles Dispensing");
                    Console.ReadLine();
                }
            }
            else if (itemnumber == 3)
            {
                Console.WriteLine($"Please insert £{machine[3].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[3].prodprice)
                {
                    Console.WriteLine("1x Walkers Salt and Vinegar Dispensing");
                    Console.ReadLine();
                }
            }
            else if (itemnumber == 4)
            {
                Console.WriteLine($"Please insert £{machine[4].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[4].prodprice)
                {
                    Console.WriteLine("1x Starbursts Dispensing");
                    Console.ReadLine();
                }
            }
            else if (itemnumber == 5)
            {
                Console.WriteLine($"Please insert £{machine[5].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[5].prodprice)
                {
                    Console.WriteLine("1x Milkyway Dispensing");
                    Console.ReadLine();
                }
            }
            else if (itemnumber == 6)
            {
                Console.WriteLine("Out of stock!");
            }
            else if (itemnumber == 7)
            {
                Console.WriteLine($"Please insert £{machine[7].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[7].prodprice)
                {
                    Console.WriteLine("1x Skittles Dispensing");
                    Console.ReadLine();
                }
            }
            else if (itemnumber == 8)
            {
                Console.WriteLine($"Please insert £{machine[8].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[8].prodprice)
                {
                    Console.WriteLine("1x Skittles Dispensing");
                    Console.ReadLine();
                }
            }
            else if (itemnumber == 9)
            {
                Console.WriteLine($"Please insert £{machine[9].prodprice}");
                insertcoins = double.Parse(Console.ReadLine());
                if (insertcoins == machine[9].prodprice)
                {
                    Console.WriteLine("1x Skittles Dispensing");
                    Console.ReadLine();
                }
            }
        }
        public static void LoadItems(products[] machine)
        {
            machine[0].prodname = "M&Ms";
            machine[0].prodprice = 0.80;
            machine[0].prodstock = 10;
            machine[0].prodnum = 0;

            machine[1].prodname = "Kinder Bueno";
            machine[1].prodprice = 1.30;
            machine[1].prodstock = 4;
            machine[1].prodnum = 1;

            machine[2].prodname = "Skittles";
            machine[2].prodprice = 1.00;
            machine[2].prodstock = 2;
            machine[2].prodnum = 2;

            machine[3].prodname = "Walkers Salt and Vinegar";
            machine[3].prodprice = 1.50;
            machine[3].prodstock = 8;
            machine[3].prodnum = 3;

            machine[4].prodname = "Starbursts";
            machine[4].prodprice = 0.75;
            machine[4].prodstock = 9;
            machine[4].prodnum = 4;

            machine[5].prodname = "Milkyway";
            machine[5].prodprice = 0.60;
            machine[5].prodstock = 10;
            machine[5].prodnum = 5;

            machine[6].prodname = "Smart Water";
            machine[6].prodprice = 1.30;
            machine[6].prodstock = 0;
            machine[6].prodnum = 6;
            machine[6].prodnum = 6;

            machine[7].prodname = "Lucozade Sport Orange";
            machine[7].prodprice = 1.50;
            machine[7].prodstock = 6;
            machine[7].prodnum = 7;

            machine[8].prodname = "Wotsits";
            machine[8].prodprice = 1.25;
            machine[8].prodstock = 3;
            machine[8].prodnum = 8;

            machine[9].prodname = "Monster Energy";
            machine[9].prodprice = 1.60;
            machine[9].prodstock = 6;
            machine[9].prodnum = 9;

        }

        static void displayItems(products[] machine)
        {
            foreach (products item in machine)
            {
                Console.WriteLine($" {item.prodnum,-3} {item.prodname,-40}£{item.prodprice,-10}{item.prodstock}");

            }
        }
    }
}









