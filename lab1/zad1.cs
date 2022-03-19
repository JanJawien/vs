using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1 {

    class zad1 {

        public static void launch(string[] args){
            while(true){
                Console.Write("Podaj rok: ");
                string input = Console.ReadLine();
                int inputint = Convert.ToInt32(input); // todo handle

                if (inputint % 4 != 0){
                    Console.WriteLine("Zwykły");
                } else if (inputint % 100 != 0){
                    Console.WriteLine("Przestępny");
                } else if (inputint % 400 != 0){
                    Console.WriteLine("Zwykły");
                } else {
                    Console.WriteLine("Przestępny");
                }

                if(1<2){

                }
            }
        }
    }
}
