using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте, эта программа поможет вам выбрать фильм!");
        Console.WriteLine("Как вас зовут?");
        String name = Console.ReadLine();
        Console.WriteLine("Здравствуйте," + name);
        Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: Приключения (П), Триллеры (Т), Фантастика (Ф)?");
        String genre = Console.ReadLine();
        if (genre == "П")
        {
            Console.WriteLine("В таком случае, предлагаю вам посмотреть следующие фильмы:");
            Console.WriteLine("Властелин колец: Братство кольца");
            Console.WriteLine("Джанго освобожденный");
            Console.WriteLine("Хоббит: Нежданное путешествие");
            Console.WriteLine("Апокалипсис");
            Console.WriteLine("Джуманджи");
            Console.WriteLine("Поли");
            Console.WriteLine("Безумный Макс: Дорога ярости");
            Console.WriteLine("Хоббит");
            Console.WriteLine("Стражи Галактики");
            Console.WriteLine("Мумия");
            Console.WriteLine("Путь домой");
        }
        else if (genre == "Т")
        {
            Console.WriteLine("В таком случае, предлагаю вам посмотреть следующие фильмы:");
            Console.WriteLine("Леон");
            Console.WriteLine("Законопослушный гражданин");
            Console.WriteLine("Области тьмы");
            Console.WriteLine("Заложница");
            Console.WriteLine("Гнев");
            Console.WriteLine("Выхода нет");
            Console.WriteLine("Кровавый алмаз");
            Console.WriteLine("Красный дракон");
            Console.WriteLine("Судная ночь");
        }
        else if (genre == "Ф")
        {
            Console.WriteLine("В таком случае, предлагаю вам посмотреть следующие фильмы:");
            Console.WriteLine("Я легенда");
            Console.WriteLine("Веном");
            Console.WriteLine("Первому игроку приготовиться");
            Console.WriteLine("Поезд в Пусан");
            Console.WriteLine("Голодные игры");
            Console.WriteLine("Росомаха");
            Console.WriteLine("Хищник");
            Console.WriteLine("Логан");
        }
        else
        {
            Console.WriteLine("К сожелению этого жанра с списке нет");
            Console.ReadLine();
        }
    }
}