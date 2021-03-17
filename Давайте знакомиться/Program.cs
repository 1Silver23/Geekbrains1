using System;

namespace Привет___рост__вес_и_объёим_тела
{
    class inputConsoleDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте познакомимся");
            Console.Write("Как вас зомут?");
            String v = Console.ReadLine();
            Console.WriteLine("рад знакомству,  " + v + "!");
            Console.ReadKey();
            Console.WriteLine("Знакомство состоялось");
            Console.ReadKey();
        }
    }
}