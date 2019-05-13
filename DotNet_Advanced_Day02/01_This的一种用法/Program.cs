using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_This的一种用法
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            //2_1.严重性	说明错误  “Person”不包含采用 0 个参数的构造函数
            //0_1.如果有继承关系了,子类中调用的构造函数,实际上是调用的父类中的无参数的构造函数
        }
    }

    //2.Person父类
    public class Person
    {
        //2_1-1.加入无参的构造函数
        public Person()
        {

        }
        //1_2-1.name自动属性
        public string Name { get; set; }
        //1_2-2.age自动属性
        public int Age { get; set; }
        //1_2.有一个参数的构造函数
        public Person(string name) : this(name, 0)
        {
        }
        //1_3.两个参数的构造函数
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
    public class Student : Person
    {
        //0_1.如果有继承关系了,子类中调用的构造函数,实际上是调用的父类中的无参数的构造函数
    }

}

