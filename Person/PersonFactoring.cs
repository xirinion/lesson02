using lesson02.Person.utils;

static class PersonFactoring
{
    //метод будет возращать людей
    public static Person CreatePerson(GenderType gender)
    {
        Person person = null;
        switch(gender)
            {
                case GenderType.Male: 
                person = new MenPerson();
                break;
                case GenderType.Female: 
                person = new GirlPerson();
                break;
                default:
                Console.WriteLine("недопустимое значение- м/ж");
                break;
            }
            return person;
    }
    //     public static ChildPerson CreateChildPerson()
    // {

    // }
}