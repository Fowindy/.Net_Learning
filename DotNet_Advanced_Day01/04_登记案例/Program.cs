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
            //person.DengJi();
            person.SayHello();

            Car car = new Car();
            car.DengJi();

            Student student = new Student();
            student.SayHello();
            student.DengJi();

            Console.ReadKey();
        }
    }
}
