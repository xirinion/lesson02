class PersonOutputHandler
{
    public  void displayInfoConsole(Person p)
    {
        Console.WriteLine("Приятно познакомится!");
        Console.WriteLine($"Имя: {p.getName(true)}");
        Console.WriteLine($"Возраст: {p.Age}");
        Console.WriteLine($"{p.getPrefferedThing()}");
    }
        public  void displayInfoConsole(ChildPerson p)
    {
        Console.WriteLine("данные ребенка");
        Console.WriteLine($"Имя: {p.getName(true)}");
        Console.WriteLine($"Возраст: {p.Age}");
        Console.WriteLine($"{p.getPrefferedThing()}");
    }
    

}