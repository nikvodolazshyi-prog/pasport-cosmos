using System;

class Program
{
    static void Main()
    {
        const string COMPANY = "Космическая служба доставки";

        Console.Write("Введите имя курьера: ");
        string name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введите символ категории допуска: ");
        char category = char.Parse(Console.ReadLine());

        Console.Write("Введите массу посылки (кг): ");
        double mass = double.Parse(Console.ReadLine());

        Console.Write("Есть допуск к опасным грузам (true/false): ");
        bool dangerous = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=== Карточка космического курьера ===");
        Console.WriteLine($"Компания: {COMPANY}");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Категория допуска: {category}");
        Console.WriteLine($"Масса посылки: {mass} кг");
        Console.WriteLine($"Допуск к опасным грузам: {(dangerous ? "да" : "нет")}");
        Console.WriteLine("Маршрут: \"Земля\" -> \"Марс\"");
    }
}