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
            Console.Write("- Ver Carros");
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
                    BuscarPorPessoa();
                    Load();
                    //MenuTagScreen.Load();
                    break;
                case 3:
                    TodosOsCarros();
                    Load();
                    //MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }

        public static void BucarPorCarro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   Remover carro");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Digite a placa do carro");
            var placa = Console.ReadLine().ToString();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (placa != null)
            {

            }
        }
        public static void BuscarPorPessoa()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   Remover carro ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Digite o nome da pessoa");
            var placa = Console.ReadLine().ToString();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (placa != null)
            {

            }
        }
        public static void TodosOsCarros()
        {

        }

        public void ConfirmaRetiradaDoVeiculo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   Remover carro ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Confirma a retirada do veiculo? (s=SIM, n= não)");
            var resp = Console.ReadLine();

            if (resp.ToUpper() == "S")
            {
                RetirarVeiculo();
            }
            else
            {
                Load();
            }
        }

        public void RetirarVeiculo()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Veiculo retirado1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("...clique para continuar");
            Console.ReadLine();
            Load();
        }


        }
}
