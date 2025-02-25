using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson02.Person.utils;


abstract class Person
{
    public int Age;
    protected string Name;
    protected GenderType Gender;

    protected string PrefferedThing;
    public string getPrefferedThing()
    {
        return PrefferedThing;
    }

    abstract public string getName(bool isGreating);
    public GenderType getGender() => Gender;

    abstract public void askPreferense();

        
    public void setName(string name)
    {
        Name = name;
    } 
        public void setGender(GenderType g)
    {
        Gender = g;
    }     
    public string displayInfo()

    {

        return $"Приятно познакомится {getName(true)}! Ваш возраст - {Age}. {PrefferedThing} ";
     
    }
}