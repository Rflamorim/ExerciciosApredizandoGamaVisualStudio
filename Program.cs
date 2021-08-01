using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int sair = 1;
            while(sair == 1)
            {
                Console.Write("Tabuada por favor digite numero que deseja exibir :\n ");
                Console.Write("Digite o valor numero desejada: \n ");
                int numero = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(numero + " x " + i + " = " + numero * i);
                }

                Console.WriteLine("Digite 1 para continnuar ou 0 para sair");
                sair = Convert.ToInt32(Console.ReadLine());
                if(sair == 2)
                {
                    continue;
                }
                else if (sair == 3)
                {
                    break;
                }

                Console.WriteLine("Finalizando");
            }

            Console.ReadKey();
        }
    }
}
