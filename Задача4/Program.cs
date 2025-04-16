using System;

class Program
{
    static void Main()
    {

        string[] heroes = { "Invoker (керри)", "Juggernaut (двойка)", "Lina (тройка)", "Shadow Fiend (четверка)", "Pudge (пятерка)" };


        Console.WriteLine("Список героев:");
        for (int i = 0; i < heroes.Length; i++)
        {
            Console.WriteLine($"{i}. {heroes[i]}");
        }


        Console.Write(" Введите имя героя: ");
        string heroName = Console.ReadLine();


        static int FindHero(string[] heroes, string heroName)
        {
            for (int i = 0; i < heroes.Length; i++)
            {
                if (heroes[i].Contains(heroName, StringComparison.OrdinalIgnoreCase)){
                    return i;
                }
            }
            return -1;
        }


        int pos = FindHero(heroes, heroName);
        if (pos != -1)
        {
            Console.WriteLine($"Герой найден на позиции {pos}");
        }
        else
        {
            Console.WriteLine("Герой не найден");
        }
    }

}