using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("");       
            Console.Write("  Digite o nome da pessoa: ");
            var nome = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("  Digite o número documento: ");
            var documento = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("  Digite o número telfone: ");
            var phone = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("  é especial? [S=SIM, N= NÃO]: ");
            var IsSpecial = Console.ReadLine() == "S" ? true:false;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Informações do cliente: ");
            Console.WriteLine($"[{nome}]-[{documento}]-[{phone}]-[{(IsSpecial?"ESPECIAL":"NORMAL")}]");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Adicionar informações do carro.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite a placa: ");
            var placa = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite o modelo: ");
            var modelo = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite a cor: ");
            var cor = Console.ReadLine();
            Console.WriteLine("");
            //RESUMO
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Informações do cliente: ");
            Console.WriteLine($"[{nome}]-[{documento}]-[{phone}]-[{(IsSpecial ? "ESPECIAL" : "NORMAL")}]");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Informações do carro: ");
            Console.WriteLine($"[{placa}]-[{modelo}]-[{cor}]");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Confirma as alterações? [S=SIM, N= NÃO]");
            var resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                AddClient();
            }
            else
            {
                return;
            }
        }
        public static void AddClient()
        {

        }
    }
}
