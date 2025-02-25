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

        //вывод сводной информации

        outputHandler.displayInfoConsole(p);
        
        Console.WriteLine("Нажмите любую клавишу для выхода");
        Console.ReadKey();
    }
}