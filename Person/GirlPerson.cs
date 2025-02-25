class GirlPerson : Person
{
    public override string getName(bool isGreating = false)
   
    {
      return isGreating ? $"Г-жа. {Name}": Name;
    }
}