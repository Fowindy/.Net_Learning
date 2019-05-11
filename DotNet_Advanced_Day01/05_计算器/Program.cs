using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6_1.第一种导入类库命名空间,也等价于6_1-1
//using Calculator;

namespace _05_计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制台形式的计算器
            Console.Write("请输入第一个数:");
            int num1 = Convert.ToInt32(Console.ReadLine());//可能会报异常
            Console.Write("请输入第二个数:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入一个操作符(+,-,*,/):");
            string opt = Console.ReadLine();//符号

            //6_1-1.
            Calculator.Add()

            //类---类库的方式
        }
    }
}
