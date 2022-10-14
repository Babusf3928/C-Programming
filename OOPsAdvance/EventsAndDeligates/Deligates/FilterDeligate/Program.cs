using System;
using System.Collections.Generic;
namespace FilterDeligates;
public delegate bool FilterDeligate(Person p);
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person() { Name = "Babu" , Age = 22};
        Person person2 = new Person() { Name = "Bala" , Age = 30};
        Person person3 = new Person() { Name = "Gunal" , Age = 52};
        Person person4 = new Person() { Name = "Jose" , Age = 42};
        Person person5 = new Person() { Name = "Arun" , Age = 10};
        Person person6 = new Person() { Name = "Francis" , Age = 13};


        List<Person> personList = new List<Person>(){person1,person2,person3,person4,person5,person6};

        DisplayPerson("Children",personList,IsChild);
        DisplayPerson("Voter",personList,IsVoter);
        DisplayPerson("Adult",personList,IsAdult);
        DisplayPerson("Senior",personList,IsSenior);
        
    }

    static void DisplayPerson(string title, List<Person> personList,FilterDeligate filter)
    {
        System.Console.WriteLine($"Person in {title} list are : ");

        foreach(Person people in personList)
        {
            if(filter (people))
            {
                System.Console.WriteLine($"{people.Name} is {people.Age} years old");
            }
        }
    }

    static bool IsChild(Person people)
    {
        return people.Age <15;
    }
    static bool IsVoter(Person people)
    {
        return people.Age>=18;
    }

    static bool IsAdult(Person people)
    {
        if(people.Age>=18 && people.Age<50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool IsSenior(Person people)
    {
        return people.Age>=50;
    }
}