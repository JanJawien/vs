using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class zad3
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
                
                bool[] tab = new bool[count];
                for (int i=0; i<count; i++)
                {
                    tab[i] = false;
                }

                foreach(int i in input)
                {
                    if (i > count) break;
                    if (i < 0) break;
                    tab[i - 1] = true;
                }

                bool check = true;
                foreach (bool b in tab)
                {
                    if(!b){
                        check = false;
                        break;
                    }
                }

                Console.WriteLine(check);
            }
        }
    }
}
