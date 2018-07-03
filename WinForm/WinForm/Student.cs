using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    class Student
    {
        public int id { get; set; }
        public String name { get; set; }
        public int age { get; set; }
        public String address { get; set; }
        public double sal { get; set; }
public Student(int id, string name, int age, string address, double sal)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.sal = sal;
        }
    }
}
