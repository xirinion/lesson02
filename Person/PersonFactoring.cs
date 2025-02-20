static class PersonFactoring
{
    //метод будет возращать людей
    public static Person CreatePerson(string gender)
    {
        Person person = null;
        switch(gender)
            {
                case "м": 
                person = new MenPerson();
                break;
                case "ж": 
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