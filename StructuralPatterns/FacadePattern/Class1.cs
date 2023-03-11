using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Class1 : ICommonFunctionalities
    {
        public Class1() { }

        public void execute1()
        {
            Console.WriteLine("Hi i am Class1 type - This is my execute1()");
        }

        public void execute2()
        {
            Console.WriteLine("Hi i am Class1 type - This is my execute2()");
        }
    }
}
