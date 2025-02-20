using System.Runtime.CompilerServices;

class PersonInputHandler
//собирает всю информацию про пользователя
{
    private Person person;
    public Person GetPersonDetails()
    {
        string gender = askGenderConsole();
        person  = PersonFactoring.CreatePerson(gender);

        string personName = askName();
        person.setName(personName);
        person.Age = askAge;

        return person;
        
    }
    private string askGenderConsole()
    {
        while(true)
        {
            Console.Write("Введите ваш пол(м/ж): ");
            //поймать ошибку
            try 
            {
                string gender = Console.ReadLine().Trim().ToLower();
                genderValidator(gender);
                return gender;
            }catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
    private void genderValidator(string g)
    {
        if(!(g == "m" || g == "f"))
        {
            //выбрасывание исключения
            throw new ArgumentException("некорректный ввод. Введите m либо f.");
        }
    }
    private string askName()
    {
        while(true)
        {
            Console.WriteLine("Введите ваше имя; ");
            //поймать ошибку
            try 
            {
                string name = Console.ReadLine();
                emptyStringValidator(name);
                return name;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
          

    }
    private int askAge()
    {
        Console.WriteLine("Введите ваше возраст; ");

         while(true)
         {
            // //установка возроста
             try
            {
             string stAge = Console.ReadLine();
             emptyStringValidator(stAge);
             int Age = int.Parse(stAge);
             positivIntValidator(Age);
             return Age;

            }
             catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
         }
    }
        private void emptyStringValidator(string s)
    {
        if(s.Length==0)
        {
            //выбрасывание исключения
            throw new ArgumentException("некорректный ввод. Поле не может быть пустым");
        }
    }
        private void positivIntValidator(int i)
    {
        if(i < 0)
        {
            //выбрасывание исключения
            throw new ArgumentException("некорректный ввод. Поле не может быть пустым");
        }
    }

}