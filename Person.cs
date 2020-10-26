using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressions_Day14
{
    class Person
    {
        public string name;
        public string city;
        public int age;
        public Person()
        {

        }
        public Person(string name, string city, int age)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }
        public void GettingTopTwo(List<Person> records)
        {
            foreach (Person x in records.FindAll(e => (e.age >= 23)).Take(2))
            {
                Console.WriteLine(x.age + " " + x.name);
            }
        }
    }
}
