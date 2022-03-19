using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class zad2
    {
        public static void launch(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj dodatnią liczbę: ");
                string input = Console.ReadLine();
                int output = 0;

                foreach(char c in input)
                {
                    output += c - 48;
                }
                
                Console.WriteLine("Suma to " + output);
            }
        }
    }
}
