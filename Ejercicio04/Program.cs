using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEj4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num6, i;

            Console.WriteLine("Ingrese el numero: ");
            int.TryParse(Console.ReadLine(), out num);
            int.TryParse(Console.ReadLine(), out num6);

            if (num % 6 == 0 && num <= 6 * 4)
            {
                num6 = num;
                num6++;
            }

            for (i = 0; i <= 6 * 4; i++)
            {
                Console.WriteLine("{0}", num6);
            }

            Console.ReadKey();

        }
    }
}
