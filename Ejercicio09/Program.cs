using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 3 números diferentes:");
            Console.WriteLine("Ingrese el primer número: ");
            int num1, num2, num3;
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("El número mayor es {0}", num1);
            }
            else if ((num2 > num3) && (num2 > num1))
            {
                Console.WriteLine("El número mayor es {0}", num2);
            }
            else
            {
                Console.WriteLine("El número mayor es {0}", num3);
            }
            Console.ReadKey();
        }
    }
}
