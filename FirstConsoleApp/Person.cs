using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Person : IComparable
    {
        public int age;
        public string firstName;
        public Person() { }
        public Person(int age, string firstName)
        {
            this.age = age;
            this.firstName = firstName;
        }
        protected virtual string GetDetalis()
        {
            return $"Age: {this.age}, Name: {this.firstName}";
        }
        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            if (this.age < p.age) return -1;
            if (this.age > p.age) return 1;
            return 0;
        }
    }

}
