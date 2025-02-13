class MenPerson : Person
{
    public override string getName(bool isGreating = false)
   
    {
      return isGreating ? $"Гн. {Name}": Name;
    }
        public override void askPreferense()
    {
        string PrefferedThingTitle = "Ваша любимая машина: ";
        Console.Write(PrefferedThingTitle);
        string PrefferedThingAswer = Console.ReadLine();
        PrefferedThing = $"{PrefferedThingTitle} {PrefferedThingAswer}";
    }

}
