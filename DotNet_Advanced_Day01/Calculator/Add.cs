using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Add : JiSuan
    {
        public override int GetResult(int n1, int n2)
        {
            return n1 + n2;
        }
        //public Add(int num1, int num2) : base(num1, num2)
        //{
        //}
    }
}
