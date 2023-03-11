using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class FacadeClass
    {
        ICommonFunctionalities dummyClass;

        public FacadeClass() 
        {
            this.dummyClass = new Class1();
        }

        public FacadeClass(string typeOfClass) 
        {
            switch (typeOfClass) 
            {
                case "Class1":
                    this.dummyClass = new Class1();
                    break;
                case "Class2":
                    this.dummyClass = new Class2();
                    break;
                case "Class3":
                    this.dummyClass = new Class3();
                    break;
                default:
                    this.dummyClass = new Class1();
                    break;
            }
        }

        public void execute1() 
        {
            this.dummyClass.execute1();            
        }

        public void execute2()
        {
            this.dummyClass.execute2();
        }
    }
}
