using SistemaEstacionamento.Db;
using SistemaEstacionamento.Models;
using SistemaEstacionamento.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SistemaEstacionamento.Screens._3
{
    public class AdicionarVaga
    {

        public static void Load()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   Adicionar informações do cliente");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------");
            Client client = new Client();
            Console.WriteLine("");
            Console.Write("  Digite o nome da pessoa: ");
            client.Name = Console.ReadLine() ?? "";
            Console.WriteLine("");
            Console.Write("  Digite o número documento: ");
            client.Document = Console.ReadLine() ?? "";
            Console.WriteLine("");
            Console.Write("  Digite o número telefone: ");
            client.Phone = Console.ReadLine() ?? "";
            Console.WriteLine("");
            Console.Write("  é especial? [S=SIM, N= NÃO]: ");
            client.Special = Console.ReadLine() == "S" ? true : false;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Informações do cliente: ");
            Console.WriteLine($"[{client.Name}]-[{client.Document}]-[{client.Phone}]-[{(client.Special ? "ESPECIAL" : "NORMAL")}]");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Adicionar informações do carro.");
            Console.ForegroundColor = ConsoleColor.White;
            Car car = new Car();
            Console.Write("Digite a placa: ");
            car.LicensePlate = Console.ReadLine() ?? "";
            Console.WriteLine("");

            Console.Write("Digite o modelo: ");
            car.Modelo = Console.ReadLine() ?? "";
            Console.WriteLine("");

            Console.Write("Digite a cor: ");
            car.Color = Console.ReadLine() ?? "";

            Console.WriteLine("");
            //RESUMO
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Informações do Cliente: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{client.Name}]-[{client.Document}]-[{client.Phone}]-[{(client.Special ? "ESPECIAL" : "NORMAL")}]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Informações do Carro: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{car.LicensePlate}]-[{car.Modelo}]-[{car.Color}]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Confirma os dados? [S=SIM, N= NÃO]");
            var resp = Console.ReadLine() ?? "N";
            if (resp.ToUpper() == "S")
            {
                AddClient(client, car);
               
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"Cliente {client.Name} do carro {car.Modelo} adicionado com sucesso!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Digite algo para continuar...");
                Console.ReadLine();
                return;
            }
            else
            {
                return;
            }
        }
        public static void AddClient(Client client, Car car)
        {
   
            var respository = new Repository<Client>(Database.Connection);
            respository.Create(client);
            AddCar(car);
            Scheduling relacao = new Scheduling();
            relacao.IdCar = car.Id;
            relacao.IdClient = car.Id;
            relacao.Special = client.Special;
            AddRelation(relacao);

        }
        public static void AddCar(Car car)
        {
            var respository = new Repository<Car>(Database.Connection);
            respository.Create(car);
        }

        public static void AddRelation(Scheduling relacao)
        {
            var respository = new Repository<Scheduling>(Database.Connection);
            respository.Create(relacao);
        }
    }
}
