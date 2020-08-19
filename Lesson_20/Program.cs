using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    class Program
    {
        static void PrintPersonArray(Person[] persons)
        {
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }
        }
        static void Main(string[] args)
        {
            Person israel = new Person(80948, 25, 1.83f, "Israel");
            Person lior = new Person(30875928, 23, 1.60f, "Lior");
            Person adir = new Person(6457, 24, 1.70f, "Adir");
            Person naor = new Person(24635756, 25, 1.80f, "Naor");
            Person mor = new Person(436768976, 25, 1.85f, "Mor");

            Person[] persons = { israel, lior, adir, naor, mor };

            PrintPersonArray(persons);

            Console.WriteLine("+++++++++++After sort+++++++++++");
            Array.Sort(persons);
            PrintPersonArray(persons);

            Console.WriteLine("+++++++++++By Name++++++++++");
            Array.Sort(persons,new PersonCompareByName());
            PrintPersonArray(persons);
        }
    }
}
