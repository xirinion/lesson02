class MenPerson : Person
{
    public override string getName(bool isGreating = false)
   
    {
      return isGreating ? $"Гн. {Name}": Name;
    }
}
