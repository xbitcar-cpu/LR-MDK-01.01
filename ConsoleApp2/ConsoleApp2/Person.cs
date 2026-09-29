using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        public struct Person
        {
            public string Name;
            public int Age;
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
            
        }
        public override string ToString()
        {
            return $"Имя {}";
        }
    }
}
