
using System;

class Program
{
     static int Main()
    {


        Console.Write("Введите название заклинания: ");
        string spellName = Console.ReadLine();

        string newSpellName = spellName.ToUpper();
        int l = spellName.Length;

        if (string.IsNullOrWhiteSpace(spellName))
        {

            Console.WriteLine("Ошибка: название заклинания не может быть пустым!");
            return 1;
        }
        Console.WriteLine($"Название заклинания: {newSpellName}");
        Console.WriteLine($"Длина названия: {l}");
        return 0;
    }
}