class Person
{
    private string Name;
    public int Age;
    private string Gender;
    private string PrefferedThing;

    public string getName(bool isGreating = false)
    {
        if (!isGreating)
        {
           return Name;
        }
        else
        {
            string name;
            if(Gender =="м")
            {
                name = $"Гн.{Name}";
            }
            else
            {
                name = $"Г-жа.{Name}";
            }
            return name;
        }
        
    }
    public string displayInfo()
    {
        string info;
        string preferedThingTitle;
        if(Gender =="м")
            {
                preferedThingTitle = " ваш любимый авто";
              
            }
            else
            {
                preferedThingTitle = (" ваш любимый цвет");
            }
        Console.Write($"{preferedThingTitle}: ");

        PrefferedThing = Console.ReadLine();

        info = $"Приятно познакомится {getName(true)}! Ваш возраст {Age}. {preferedThingTitle} - {PrefferedThing} ";
            
        return info;
    }
    public void setName(string name)
    {
        Name = name;
    }
    
    public string getGender()
    {
        return Gender;
    }
    public void setGender(string gender)
    {
        Gender = gender;
    }
    
}