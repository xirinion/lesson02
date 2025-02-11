using System;

class Person
{
    public string Name;
    public string Age;
    public string Gender;
    public string PrefferedThing;
}
class Program
{
    static void Main()
    {
        Person person = new Person();
        Console.WriteLine("Введите ваше имя; ");
        person.Name = Console.ReadLine();
        Console.WriteLine($"ваше имя; {person.Name}");

        Console.WriteLine("Введите ваше возраст; ");
        
        while(!int.TryParse(Console.ReadLine(), person.Age) || person.Age < 0)
        {
            Console.Write("некоректный ввод. Введите число больше либо 0 ");
            Console.Write("Введите ваше возраст; ");
        }
        Console.Write($"ваше возраст; {person.Age}");

        Console.Write("Введите ваш пол(м/ж): ");
        person.Gender = Console.ReadLine().Trim().ToLower();
        if(person.Gender =="м")
        {
            Console.Write("Введите вашу любимую марку авто; ");
            person.PrefferedThing = Console.ReadLine();
            Console.WriteLine($"Приятно познакомится, {person.Name}. Ваш возраст {person.Age}, ваш любимый авто{person.PrefferedThing}");
        }
        else
        {
             Console.WriteLine("Введите ваши любимые цветы; ");
            person.PrefferedThing = Console.ReadLine();
            Console.WriteLine($"Приятно познакомится, {person.Name}. Ваш возраст {person.Age}, любимые цветы {person.PrefferedThing}");
        }
        Console.WriteLine("Нажмите любую клавишу для выхода");
        Console.ReadKey();
    }
}