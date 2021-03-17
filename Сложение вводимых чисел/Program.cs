using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сложение_вводимых_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            Int32 a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            long sum = a + b;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
