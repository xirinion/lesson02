using System;

class Program
{
    static void Main()
    {
        //создание обьекта -Персона
        Person person;
        bool inCorectGender = true;
        while(inCorectGender)
        {
        Console.Write("Введите ваш пол(м/ж): ");
        string gender = Console.ReadLine().Trim().ToLower();
        switch(gender)
        {
            case "м": 
            person = new MenPerson();
            inCorectGender = false;
            break;
             case "ж": 
            person = new GirlPerson();
             inCorectGender = false;
            break;
            default:
            Console.WriteLine("недопустимое значение- м/ж");
            break;
        }



        Console.WriteLine("Введите ваше имя; ");
        
        //установка имени
        person.setName(Console.ReadLine());
        Console.WriteLine($"ваше имя; {person.getName(false)}");

        //установка возроста
        Console.WriteLine("Введите ваше возраст; ");
        
        while(!int.TryParse( Console.ReadLine(), out person.Age) || person.Age < 0 || person.Age > 200)
        {
            Console.Write("некоректный ввод. Введите число больше либо 0 ");
            Console.Write("Введите ваше возраст; ");
        }
        Console.WriteLine($"ваше возраст; {person.Age}");
        
        //Установка любимой вещи
        person.askPreferense();

        //вывод сводной информации
    
        Console.WriteLine(person.displayInfo());
        Console.WriteLine("Нажмите любую клавишу для выхода");
        Console.ReadKey();
    }
}