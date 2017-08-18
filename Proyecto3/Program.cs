using System;
using System.Collections.Generic;
using System.Text;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool estaOK;
            int numero;
            int a = 0;
            int i;
            int j;

            do
            {
                //PIDO EL INGRESO DE UN NÚMERO
                Console.WriteLine("Ingrese un número: ");

                //SI NO COINCIDE EL TIPO EL MÉTODO TRYPARSE
                //RETORNA FALSE, CASO CONTRARIO RETORNA TRUE Y
                //COLOCA EL VALOR INGRESADO EN LA VARIABLE DE SALIDA
                estaOK = int.TryParse(Console.ReadLine(), out numero);

                for (i = 2; i < numero; i++)
                {//por definicion el 1 no es primo, se empieza en 2
                    for (j = 2; j < i - 1; j++)//divide a j entre los números del 1 al 100
                    {
                        if (i % j == 0)// si num1 módulo de i es 0, incrementamos a en 1.
                            a++;


                        if (a == 2)
                        { //si solo tiene dos números divisores entonces es primo y se imprime
                            Console.WriteLine("El número ingresado fue: {0}", i);
                            Console.ReadLine();
                        }
                    }
                }

                if (!estaOK)
                    Console.WriteLine("Error en el tipo de dato.");

            } while (!estaOK);

        }
    }
}