using System;
using System.Data;

class Program {

    static void Main() {

        string again = "a";

        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("***Součet řady čísel****");
            Console.WriteLine("***********************");
            Console.WriteLine("*****Ngo Nam Khánh*****");
            Console.WriteLine("***********************");
            Console.WriteLine();

            Console.Write("Zadejte celé číslo ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu" );
            }
            
            int suma = 0;
            int multi = 1;
            int numberBackup = number;
            int digit;

            while(number >= 10) {
                digit = number % 10;
                number = (number-digit)/10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                multi = multi * digit;
            }
            Console.WriteLine("Digit = {0}", number);

            // musíme přičíst poslední cyklus
            suma = suma + number;

             // musíme přičíst poslední cyklus
            multi = multi * number;

            Console.WriteLine();
            Console.WriteLine("\n\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma );
            Console.WriteLine("\nSoučin cifer čísla {0} je {1}", numberBackup, multi );
           

           

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();

         }
     }
 }




