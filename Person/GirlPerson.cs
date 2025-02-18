class GirlPerson : Person
{
  //констаннты класса(то что определяет класс)
    private string PrefferedThingTitle = "ваш любимый цветы: ";//переменная в нутри класса
    public override string getName(bool isGreating = false)
   
    {
      return isGreating ? $"Г-жа. {Name}": Name;
    }

    public override void askPreferense()
    {
        Console.Write(PrefferedThingTitle);
        string PrefferedThingAswer = Console.ReadLine();
        PrefferedThing = $"{PrefferedThingTitle} {PrefferedThingAswer}";
    }


}