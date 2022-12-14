using SistemaEstacionamento.Db;
using SistemaEstacionamento.Models;
using SistemaEstacionamento.Repositories;
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

            Console.WriteLine("--------------------------------------------------");
            var agentoEscolhido = TodosOsCarros();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Carro escolhido");
            Console.WriteLine("--------------------------------------------------");
            var retirou = ConfirmaRetiradaVeiculo(agentoEscolhido);
      
            if (retirou)
            {
                Console.Clear();
                Console.Write($"Registrado a retirada do Carro");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($" {agentoEscolhido.Car.Modelo}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" do dono(a)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{agentoEscolhido.Client.Name}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" com sucesso!");

            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nenhum carro encontrado com esse id.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Caso deseje sair digite 0");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);
            if (option == 0)
            {
                return;
            }
            Load();
            //switch (option)
            //{
            //    case 1:
            //        BucarPorCarro();
            //        Load();
            //        //MenuTagScreen.Load();
            //        break;
            //    case 2:
            //        BuscarPorPessoa();
            //        Load();
            //        //MenuTagScreen.Load();
            //        break;
            //    case 3:
            //        TodosOsCarros();
            //        Load();
            //        //MenuTagScreen.Load();
            //        break;
            //    default: Load(); break;
            //}
        }


        public static SchedulingModelView TodosOsCarros()
        {
            Scheduling agendamentoEscolhido = new Scheduling();
            var repository = new SchedulingRepository(Database.Connection);
            var lista = repository.CarrosEstacionados(Database.Connection);

            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item.Id);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" - [DATA:{item.StartDate}]-[NOME:{item.Client.Name}]-[MODELO:{item.Car.Modelo}]-[PLACA:{item.Car.LicensePlate}]");
            }
            Console.WriteLine();
            Console.WriteLine("Digite o id do carro que deseja retirar ou digite 0 para sair");
            int escolhido = Convert.ToInt32(Console.ReadLine());
            if (escolhido == 0)
            {
                return null;
            }
            return lista.FirstOrDefault(x => x.Id == escolhido);

        }

        public static bool ConfirmaRetiradaVeiculo(SchedulingModelView dadosRetirada)
        {
            try
            {


            Console.WriteLine($"Cliente: {dadosRetirada.Client.Name}");
            Console.WriteLine($"Documento: {dadosRetirada.Client.Document}");
            Console.WriteLine($"Carro: {dadosRetirada.Car.Modelo}-{dadosRetirada.Car.Color}");
            Console.WriteLine($"Placa: {dadosRetirada.Car.LicensePlate}");
            Console.WriteLine($"Entrada: {dadosRetirada.StartDate}");
            var quantidadeMinutos = (int)DateTime.Now.Subtract(dadosRetirada.StartDate).TotalMinutes; // dadosRetirada.StartDate.Subtract().TotalMinutes;
            Console.WriteLine($"Total minutos: {quantidadeMinutos}");
            var total = quantidadeMinutos * 0.2;
            Console.WriteLine($"Valor a pagar: R$ {Math.Round(total, 2)}");

            Console.WriteLine($"Saida: {DateTime.Now}");
            dadosRetirada.Value = (decimal)Math.Round(total, 2);
            dadosRetirada.AmountMinutes = quantidadeMinutos;
            dadosRetirada.EndDate = DateTime.Now;
            dadosRetirada.Finished = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Confirma a retirada do veículo? [S = Sim], [N = Não]");
            Console.ForegroundColor = ConsoleColor.White;
            var resp = Console.ReadLine() ?? "N";

            if (resp.ToUpper() == "S")
            {
                try
                {
                    Scheduling agendamento = new Scheduling();
                    agendamento.StartDate = dadosRetirada.StartDate;
                    agendamento.Id = dadosRetirada.Id;
                    agendamento.IdCar = dadosRetirada.IdCar;
                    agendamento.IdClient = dadosRetirada.IdClient;
                    agendamento.Value = dadosRetirada.Value;
                    agendamento.AmountMinutes = dadosRetirada.AmountMinutes;
                    agendamento.Finished = true;
                    agendamento.EndDate = dadosRetirada.EndDate;
                    agendamento.Special = dadosRetirada.Special;
                    //agendamento.id
                    var retirouVeiculo = RetirarVeiculo(agendamento);

                    if (retirouVeiculo)
                    {
                        Console.WriteLine();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch
                {
                }
                return false;
            }
            else
            {
                return false;
            }
            }
            catch 
            {
                return false;
            }
        }


        public static bool RetirarVeiculo(Scheduling scheduling)
        {
            try
            {
                var repository = new Repository<Scheduling>(Database.Connection);
                repository.Update(scheduling);

                return true;
            }
            catch
            {
                return false;
            }

            // Load();
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


    }
}
