using Microsoft.Data.SqlClient;
using System;
using SistemaEstacionamento.Db;

namespace SistemaEstacionamento
{

    public class Program
    {
        private const string connectionString = @"Server=192.168.99.100\sqlserver,1433;Database=Parking;User ID=sa; Password=1q2w3e4r@#$; TrustServerCertificate=True";
        const string conectStringJob = @"Server=IM-BRS-NT1071\MSSQLSERVER01; Integrated Security=SSPI; Database=Parking;";

        public static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(connectionString);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }
        private static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      Sistema Estacionamento");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     1 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Carros estacionados");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     2 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Retirada de carro");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     3 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Adicionar carro");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     4 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Relatórios");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     5 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Vincular Carro/Cliente");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 4:
                    //MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }

    }
}