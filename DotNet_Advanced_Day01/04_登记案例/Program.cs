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
            #region 第一种登记方式,不推荐
            //Person person = new Person();
            //person.DengJi();
            //person.SayHello();

            //Car car = new Car();
            //car.DengJi();

            //Student student = new Student();
            //student.SayHello();
            //student.DengJi();

            //House house = new House();
            //house.DengJi(); 
            #endregion

            #region 第二种方式,推荐
            IDengJi dj = new Car()/*new Student()*//*new House()*/;
            dj.DengJi(); 
            #endregion

            Console.ReadKey();
        }
    }
}
