class PersonOutputHandler
{
    public  void displayInfoConsole(Person p)
    {
        Console.WriteLine("Приятно познакомится!");
        Console.WriteLine($"Имя: {p.getName(true)}");
        Console.WriteLine($"Возраст: {p.Age}");
        Console.WriteLine($"{p.getPrefferedThing()}");
        ChildPerson child = p.getChild();
        if (p.getChild() != null)
        {
            displayInfoConsole(child);
        }
    }
        private  void displayInfoConsole(ChildPerson p)
    {
        Console.WriteLine("данные ребенка");
        Console.WriteLine($"Имя: {p.getName(true)}");
        Console.WriteLine($"Возраст: {p.Age}");
        Console.WriteLine($"{p.getPrefferedThing()}");
    }
    

}