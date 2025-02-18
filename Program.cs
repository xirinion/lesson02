using System;

class Program
{
    static void Main()
    {
        //Инициализация
        PersonOutputHandler outputHandler = new PersonOutputHandler();

        //создание обьекта -Персона
        Person person = null; //говорит выделить место под персону(null - ни что)
        do
        {
        
            Console.Write("Введите ваш пол(м/ж): ");
            string gender = Console.ReadLine().Trim().ToLower();
            switch(gender)
            {
                case "м": 
                person = new MenPerson();
                break;
                case "ж": 
                person = new GirlPerson();
                break;
                default:
                Console.WriteLine("недопустимое значение- м/ж");
                break;
            }
        }        while(person == null);



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

        // наличие детей

        string hasChildren;
        ChildPerson Child = null;
        do
        {
        
            Console.Write( "есть ли у вас ребенок (да/нет)?");
            hasChildren = Console.ReadLine().Trim().ToLower();
            switch(hasChildren)
            {
                case "да": 
                    Child = new ChildPerson();
                    Child.askName();
                    Child.askAge();
                    Child.askPreferense();
                    break;
                case "нет": 
                    break;
                default:
                    Console.WriteLine("недопустимое значение - да/нет");
                    break;
            }
        }        while(!(hasChildren == "да" || hasChildren == "нет"));


        //вывод сводной информации
    
        //Console.WriteLine(person.displayInfo());
        outputHandler.displayInfoConsole(person);
        if(Child != null)
        {
            outputHandler.displayInfoConsole(Child);
        }
        Console.WriteLine("Нажмите любую клавишу для выхода");
        Console.ReadKey();
    }
}