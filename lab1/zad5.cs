using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class zad5
    {
        public static void launch(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj tekst: ");
                string input = Console.ReadLine();
                int[] count = new int['z'-'a']; // initialized to 0

                foreach(char c in input){
                    if (!Char.IsLetter(c)) continue;
                    count[Char.ToLower(c) - 'a']++;
                }

                for(int i=0; i<'z'-'a'; i++) {
                    if(count[i] == 0) continue;
                    Console.WriteLine((char)('a'+i) + " - " + count[i]);
                }
            }
        }
    }
}