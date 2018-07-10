using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("meu pai não existe");


            Console.WriteLine("deseja cadastrar quantos carros;");
            int carro = Convert.ToInt32(Console.ReadLine());
            string tabom = Console.ReadLine();
            Console.WriteLine("concerteza você não vai conseguir cadastrar esse carro");
            while (tabom != "tabom")
            {



                Console.WriteLine("deseja cadastrar quantos carros;");
                carro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("concerteza você não vai conseguir cadastrar esse carro");
            }
        }
    }
}
