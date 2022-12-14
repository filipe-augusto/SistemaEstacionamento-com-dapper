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
            var repository = new SchedulingRepository(Database.Connection);
            var lista = repository.CarrosEstacionados(Database.Connection);

            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" - [DATA:{item.StartDate}]-[NOME:{item.Client.Name}]-[MODELO:{item.Car.Modelo}]-[PLACA:{item.Car.LicensePlate}]");
            }
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("     0 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Voltar");
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                    case 0:

                    return;
                  
                default: Load();
                    break;
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
