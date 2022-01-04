using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenAufgabe4Person
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("Peter", "Meier", 20);
            //Teacher teacher1 = new Teacher("Klaus", "Peter", 30);
            //Student student1 = new Student("Michi", "Mädchen", 23);
            //person1.PrintInformation();
            //teacher1.PrintInformation();
            //student1.PrintInformation();

            Person[] peopleInClassroom =
            {
                new Teacher("John", "Smith", 32),
                new Student("Sabrina", "Müller", 18),
                new Student("Anna", "Matt", 17),
                new Student("Peter", "Fredl", 18),
                new Student("Matthias", "Maier", 19)
            };

            foreach (Person p in peopleInClassroom)
            {
                p.PrintInformation();

                if (p is Teacher)
                {
                    (p as Teacher).Teach();
                }
                else if (p is Student)
                {
                    (p as Student).ListenToTeacher();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.WriteLine("Alter: {0}", Age);
        }
    }

    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void Teach()
        {
            Console.WriteLine("Herr/Frau {0} unterrichtet die Klasse!", LastName);
        }
    }

    public class Student : Person
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void ListenToTeacher()
        {
            Console.WriteLine("Der/Die Schüler/in {0} {1} hört dem Lehrer zu!", FirstName, LastName);
        }
    }
}
