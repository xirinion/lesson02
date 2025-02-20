using System;

class Program
{
    static void Main()
    {
        //Инициализация
        PersonInputHandler inputHandler = new PersonInputHandler();
        PersonOutputHandler outputHandler = new PersonOutputHandler();

        //Запрос данных о персоне
        Person p = inputHandler.GetPersonDetails();


        
        //Установка любимой вещи
        // person.askPreferense();

        // наличие детей

        // string hasChildren;
        // ChildPerson Child = null;
        // do
        // {
        
        //     Console.Write( "есть ли у вас ребенок (да/нет)?");
        //     hasChildren = Console.ReadLine().Trim().ToLower();
        //     switch(hasChildren)
        //     {
        //         case "да": 
        //             Child = new ChildPerson();
        //             Child.askName();
        //             Child.askAge();
        //             Child.askPreferense();
        //             break;
        //         case "нет": 
        //             break;
        //         default:
        //             Console.WriteLine("недопустимое значение - да/нет");
        //             break;
        //     }
        // }        while(!(hasChildren == "да" || hasChildren == "нет"));


        //вывод сводной информации
    
        Console.WriteLine(person.displayInfo());
        outputHandler.displayInfoConsole(p);
        
        if(Child != null)
        {
            outputHandler.displayInfoConsole(Child);
        }
        Console.WriteLine("Нажмите любую клавишу для выхода");
        Console.ReadKey();
    }
}