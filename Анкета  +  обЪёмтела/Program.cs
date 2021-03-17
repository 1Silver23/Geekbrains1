using System;

namespace Привет___рост__вес_и_объёим_тела
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Меня зовут Алекс. Живу в Москве.");
            Console.WriteLine("Мой рост 182см");
            double H = 182;
            Console.WriteLine("Вес 80кг");
            double M = 80;
            double i = M / ((H * H)*1000);
            Console.WriteLine($"Объём моего тела {i}");
            Console.ReadKey();
        }
    }
}
