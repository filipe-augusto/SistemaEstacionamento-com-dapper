using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Screens._2
{
    public class RemoveCar
    {
        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   Remover carro");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     1 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Buscar por Carro");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Buscar por pessoa");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     3 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Todos os Carros");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Voltar");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    BucarPorCarro();
                    Load();
                    //MenuTagScreen.Load();
                    break;
                case 2:
                    BucarPorCarro();
                    Load();
                    //MenuTagScreen.Load();
                    break;
                case 3:
                    BucarPorCarro();
                    Load();
                    //MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }

        public static void BucarPorCarro()
        {

        }
        public static void BuscarPorPessoa()
        {

        }
        public static void TodosOsCarros()
        {

        }


        }
}
