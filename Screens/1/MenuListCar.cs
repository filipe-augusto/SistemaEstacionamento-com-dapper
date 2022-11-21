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
            Console.ForegroundColor = ConsoleColor.White;
            var cars = ListaDeCarros();
            if (cars.Count() >= 1)
            {
                foreach (var car in cars)
                {
             Console.WriteLine($"[{car.Id}].[{car.LicensePlate}].[{car.Color}].[{car.Modelo}]");
                }
            }
        
           
            var option = short.Parse(Console.ReadLine()!);
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
