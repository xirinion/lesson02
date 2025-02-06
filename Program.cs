using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваше имя; ");
        string name = Console.ReadLine();
        Console.WriteLine($"ваше имя; {name}");

        Console.WriteLine("Введите ваше возраст; ");
        int age;
        // bool isAgeInt = (int.TryParse(Console.ReadLine(), out age))
        while(!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.Write("некоректный ввод. Введите число больше либо 0 ");
            Console.Write("Введите ваше возраст; ");
        }
        Console.Write($"ваше возраст; {age}");

        // Console.Write("Введите ваш пол(м/ж): ");
        // string gender = Console.ReadLine().Trim().ToLower();
        // if(gender =="м")
        // {

        // }
        // else
        // {

        }
    }
