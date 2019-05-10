using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_登记案例
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.DengJi();

            Car car = new Car();
            car.DengJi();

            Student student = new Student();
            student.DengJi();//人可以登记了,只是调用父类Person方法

            Console.ReadKey();
        }
    }
}
