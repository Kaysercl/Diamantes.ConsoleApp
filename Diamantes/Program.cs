using System;

namespace Diamantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Bem vindo ao diamante dinâmico");
                Console.WriteLine("Escreva um número inteiro ímpar");
                int x = int.Parse(Console.ReadLine());
                int meio = x / 2;


                while (x % 2 == 0)
                {
                    Console.WriteLine("Número invalido, por favor digite um número ÍMPAR");                    
                    x = int.Parse(Console.ReadLine());
                    Console.Clear();

                }
                               
                for (int i = 0; i <= meio; i++)
                {
                        for (int j = 0; j <= meio - i; j++)
                        {
                            Console.Write(" ");
                        }
                        int var = (2 * i) + 1;
                        for (int j = 0; j < var; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("X");
                        }
                        Console.WriteLine();
                }

                for (int i = meio - 1; i >= 0; i--)
                {
                        for (int j = 0; j <= meio - i; j++)
                        {
                            Console.Write(" ");
                        }
                        int var = (2 * i) + 1;
                        for (int j = 0; j < var; j++)
                        {
                            Console.Write("X");                            

                        }
                        Console.WriteLine();
                }
                    Console.ReadLine();
                    Console.Clear();
                
                
            }
        }
    }    
}
