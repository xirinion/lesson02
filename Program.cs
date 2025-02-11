using System;

class Program
{
    static void Main()
    {
        //создание обьекта -Персона
        Person person = new Person();
        Console.WriteLine("Введите ваше имя; ");
        string name = Console.ReadLine();
        //установка имени
        person.setName(name);
        Console.WriteLine($"ваше имя; {person.getName()}");

//установка возроста
        Console.WriteLine("Введите ваше возраст; ");
        
        while(!int.TryParse( Console.ReadLine(), out person.Age) || person.Age < 0 || person.Age > 200)
        {
            Console.Write("некоректный ввод. Введите число больше либо 0 ");
            Console.Write("Введите ваше возраст; ");
        }
        Console.Write($"ваше возраст; {person.Age}");

        Console.Write("Введите ваш пол(м/ж): ");
        string gender = Console.ReadLine();
        string Gender = Console.ReadLine().Trim().ToLower();
        //установка пола
        person.setGender(gender);
 //вывод сводной информации
        person.displayInfo();
        Console.WriteLine("Нажмите любую клавишу для выхода");
        Console.ReadKey();
    }
}