using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kollar om det finns 26 rader. Om det är så, gör inget mer!
            for (int j = 1; j < 26; j++)
            {
                // Kollar om varje gång programmet kör igenom en rad om "radnumret" är delbart. Om så är fallet, 
                // sätt in ett mellanrum. Det blir på varannan rad då.
                if (j % 2 == 0)
                {
                    Console.Write(" ");

                }
                // För färgsättningen kollar den om j tillhör var tredje siffra på vägen till 26
                // För gul
               
                if (j == 1 || j == 4 || j == 7 || j == 10 || j == 13 || j == 16 || j == 19 || j == 22 || j == 25)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
                // För rosa

                else if (j == 2 || j == 5 || j == 8 || j == 11 || j == 14 || j == 17 || j == 20 || j == 23)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;

                }
                // Och om inget av dom två, grön.
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                // På varje rad skriver den ut 39 stjärnor. Om i överstiger 40 avslutas raden.   
                 for (int i = 1; i < 40; i++ )
                 {
                     Console.Write("* ");
                   
                 }
                 Console.WriteLine();
             }
             }
     }
}
