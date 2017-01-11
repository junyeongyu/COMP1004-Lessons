using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP1004_W2017_Lesson1_Part2
{
    static class Program
    {
        class Person
        {
            // public properties
            public string name { get; set; }
            public int age { get; set; }

            // Constructor
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void saysHello()
            {
                Console.WriteLine("hello world in saysHello()");
            }
        }

        static void Main()
        {
            Person tom = new Person("Tom", 30);
            tom.saysHello();
            Console.WriteLine("Hello World");
        }
    }
}
