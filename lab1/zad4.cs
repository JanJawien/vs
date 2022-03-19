using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class zad4
    {
        public static void launch(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj ilość liczb: ");
                int count = Convert.ToInt32(Console.ReadLine()); // handle

                Console.Write("Podaj liczby: ");
                string raw = Console.ReadLine();
                string[] rawtab = raw.Split(' ');
                int[] input = Array.ConvertAll(rawtab, int.Parse);

                int sum = 0;
                int best = 0;
                for(int i=1; i<input.Length; i++)
                {
                    if (input[i] < input[i-1])
                    {
                        sum += input[i-1] - input[i];
                    } else if(input[i] > input[i-1])
                    {
                        best = (best < sum ? sum : best);
                        sum = 0;
                    }
                }

                best = (best < sum ? sum : best);
                Console.WriteLine(best);
            }
        }
    }
}