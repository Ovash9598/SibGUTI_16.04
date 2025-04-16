using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите силу: ");
        int strength = int.Parse(Console.ReadLine());

        Console.Write("Введите ловкость: ");
        int lovk = int.Parse(Console.ReadLine());


        Console.Write("Введите интеллект: ");
        int intel = int.Parse(Console.ReadLine());

        int health = strength * 20;
        int mana = intel * 12;
        double attackSpd = lovk * 0.5;


        Console.WriteLine($"Здоровье: {health}");
        Console.WriteLine($"Мана: {mana}");
        Console.WriteLine($"Скорость атаки: {attackSpd}");
    }
}