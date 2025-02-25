using lesson02.Person.utils;
using System.Reflection;
using System.Runtime.CompilerServices;

class PersonInputHandler
//собирает всю информацию про пользователя
{
    private Person person;
    public Person GetPersonDetails()
    {
        GenderType gender = askGenderConsole();
        person = PersonFactoring.CreatePerson(gender);

        string personName = askName();
        person.setName(personName);
        person.Age = askAge();
        ChildPerson child = askAboutChild();
        person.setChild(child);
        return person;

        return person;
        
    }
    private ChildPerson askAboutChild()
    {
        // наличие детей

        string hasChildren;
        do
        {
            Console.Write("есть ли у вас ребенок (да/нет)?");
            hasChildren = Console.ReadLine().Trim().ToLower();
            switch (hasChildren)
            {
                case "да":
                    GenderType gender = askGenderConsole();
                    string name = askName();
                    int age = askAge();
                    ChildPerson child = PersonFactoring.CreateChildPerson(gender, name, age);
                    return child;
                case "нет":
                    break;
                default:
                    Console.WriteLine("недопустимое значение - да/нет");
                    break;
            }
        } while (!(hasChildren == "да" || hasChildren == "нет"));
        return null;
    }
    private GenderType askGenderConsole()
    {
        while(true)
        {
            Console.Write("Введите пол(м/ж): ");
            //поймать ошибку
            try 
            {
                string gender = Console.ReadLine().Trim().ToLower();
                genderValidator(gender);
                switch(gender)
                {
                    case "m":
                        return GenderType.Male;
                    case "f":
                        return GenderType.Female;
                    default:
                        throw new ArgumentException("не удалось распознать пол");
                }
                
            }
            catch(ArgumentException e)
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
            Console.WriteLine("Введите имя; ");
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
        Console.WriteLine("Введите возраст; ");

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