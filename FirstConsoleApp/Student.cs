using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Student:Person
    {
        public int grade;
        public Student(int age, string name, int grade) : base(age, name)
        {
            this.grade = grade;
        }
        protected override string GetDetalis()
        {
            return $"{base.GetDetalis()}, grade : {this.grade}";
        }
    }
}
