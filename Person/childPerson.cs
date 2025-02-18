using System.Security.Cryptography.X509Certificates;

class ChildPerson : Person
{
    private string PrefferedThingTitle = "Любимая игрушка: ";
    public override string getName(bool isGreating = false)
   
        {
            return Name;
        }
        public override void askPreferense()
    {
        
        Console.Write(PrefferedThingTitle);
        string PrefferedThingAswer = Console.ReadLine();
        PrefferedThing = $"{PrefferedThingTitle} {PrefferedThingAswer}";
    }
    public void askName()
      //установка имени
    {
        Console.WriteLine(" Введите имя ребенка: ");
        setName(Console.ReadLine());
    }

    public void askAge()
    {
        //установка возроста
            Console.WriteLine("Введите возраст ребенка; ");
        
            while(int.TryParse( Console.ReadLine(), out Age) == false || Age < 0)
        {
            Console.Write("некоректный ввод. Введите число больше либо 0 ");
            Console.Write("Введите ваше возраст; ");
        }


    }
    public string displayInfo()
    {

        return $"данные ребенка: имя:{getName(true)}; возраст ребенка :{Age}.  {PrefferedThing} ";
     
    }

}
