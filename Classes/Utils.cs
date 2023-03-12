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
            for (var contador = 0; contador < 5; contador++)
            {
                Console.Write($"*"); 
                Thread.Sleep(500);    
            }
            Console.ResetColor();
        }

        public static void VerificarPastaArquivos(string Caminho){
            string pasta = Caminho.Split("/")[0];
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(Caminho))
            {
                using (File.Create(Caminho)){}
            }
        }
    }
}