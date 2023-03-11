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

        /// <summary>
        /// Most common way to construct a Facade class (using aggregation).
        /// </summary>
        /// <param name="dummy"></param>
        public FacadeClass(ICommonFunctionalities dummy) 
        {
            this.dummyClass = dummy;
        }

        /// <summary>
        /// Another form to add construct a facade is with a type flag (using composition).
        /// </summary>
        /// <param name="typeOfClass"></param>
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

        /// <summary>
        /// This calls the execute1 method of its class
        /// </summary>
        public void execute1() 
        {
            this.dummyClass.execute1();            
        }

        /// <summary>
        /// This calls the execute2 method of its class
        /// </summary>
        public void execute2()
        {
            this.dummyClass.execute2();
        }
    }
}
