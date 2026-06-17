using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cadastro_de_volei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██╗░░░██╗░█████╗░██╗░░░░░███████╗██╗
██║░░░██║██╔══██╗██║░░░░░██╔════╝██║
╚██╗░██╔╝██║░░██║██║░░░░░█████╗░░██║
░╚████╔╝░██║░░██║██║░░░░░██╔══╝░░██║
░░╚██╔╝░░╚█████╔╝███████╗███████╗██║
░░░╚═╝░░░░╚════╝░╚══════╝╚══════╝╚═╝");
            Console.ResetColor();
            Console.WriteLine("\n quantidade de paises: ");
            string qntpaises = Console.ReadLine();
            Console.WriteLine("\n quantidade de inscritos: ");
            string qntinscritos = Console.ReadLine();
            Console.WriteLine("\n qual o genero: ");
            string genero = Console.ReadLine();
            Console.WriteLine("\n qual a forma de posicionamento: ");
            string posicionamento = Console.ReadLine();



            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
██████╗░███████╗░██████╗░█████╗░██████╗░██╗░█████╗░░█████╗░░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██╔══██╗██║██╔══██╗██╔══██╗██╔══██╗
██║░░██║█████╗░░╚█████╗░██║░░╚═╝██████╔╝██║██║░░╚═╝███████║██║░░██║
██║░░██║██╔══╝░░░╚═══██╗██║░░██╗██╔══██╗██║██║░░██╗██╔══██║██║░░██║
██████╔╝███████╗██████╔╝╚█████╔╝██║░░██║██║╚█████╔╝██║░░██║╚█████╔╝
╚═════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.WriteLine("\n qual o local?: ");
            string  local = Console.ReadLine();
            Console.WriteLine("\n qual o horário?: ");
            string horario = Console.ReadLine();
            Console.WriteLine("\n qual a fase?: ");
            string fase = Console.ReadLine();
            Console.WriteLine("\n qual o confronto: ");
            string confronto = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██║░░██║██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██║░░██║██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██████╔╝╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░░╚════╝░");
            Thread.Sleep(2500); // pausa na programação por 2s
        }
    }
}