using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_2.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto){
            
            Console.Write($"{texto}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write($"*"); 
                Thread.Sleep(1000);    
            }
            Console.ResetColor();
        }
    }
}