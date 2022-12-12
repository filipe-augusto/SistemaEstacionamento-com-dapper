using SistemaEstacionamento.Models;
using SistemaEstacionamento.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEstacionamento.Repositories;
using SistemaEstacionamento.Db;

namespace SistemaEstacionamento.Screens
{
    public static class MenuListCar
    {

        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      Carros estacionados no momento");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            var cars = ListaDeCarros();
            if (cars.Count() >= 1)
            {
                foreach (var car in cars)
                {
                 Console.WriteLine($"[{car.Id}].[{car.LicensePlate}].[{car.Color}]" +
                     $".[{car.Modelo}]");
                }
            }
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     1 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Voltar");
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                    case 1:
                    MenuListCar.Load();
                    //Load();
                    //MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
            return;
        }

        public static List<Car> ListaDeCarros()
        {
            var lista = new List<Car>();
            var repository = new Repository<Car>(Database.Connection);
            var cars = repository.Get();
            lista = (List<Car>)cars;
            return lista;
        }



    }
}
