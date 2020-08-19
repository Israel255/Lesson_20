using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }

        public int CompareTo(Person other)
        {
            return this.Id - other.Id;
        }

        public override string ToString()
        {
            return "Person Name: " + Name + " Person Age: " + Age + " Person Height: " + Height + " Person Id: " + Id;
        }
    }
    class PersonCompareById : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Id - y.Id;
        }
    }
    class PersonCompareByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
    class PersonCompareByHeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return Convert.ToInt32(x.Height - y.Height);
        }
    }
    class PersonCompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int g = x.Name.CompareTo(y.Name);
            return g;
        }
    }
}
