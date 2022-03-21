using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinExacter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter the U.S. cent amount to convert: ");
            string amount = Console.ReadLine();
            double userAmount = Convert.ToDouble(amount);


            int Quarter = 25;
            int Dime = 10;
            int Nickel = 5;

            double quart = Math.Floor(userAmount / Quarter);
            double remainder = userAmount % Quarter;

            double dim = Math.Floor(remainder / Dime);
            double remainder2 = remainder % Dime;

            double nick = Math.Floor(remainder2 / Nickel);
            double remainder3 = remainder2 % Nickel;

            Console.WriteLine($"{userAmount} cents is equal to: \nquarter(s): {quart} \ndime(s): {dim} \nnickel(s):{nick} \nPennies {remainder3}");

        }
    }
}
