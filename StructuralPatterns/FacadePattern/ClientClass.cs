using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class ClientClass
    {
        FacadeClass facade;

        /// <summary>
        /// Client class does not need to kno how to create the many classes
        /// that implemments ICommonFunctionalities.
        /// It only needs to have a facade.
        /// </summary>
        /// <param name="facade"></param>
        public ClientClass(FacadeClass facade)
        {
            this.facade = facade;
        }

        /// <summary>
        /// It calls the execute1 method of ICommonFunctionalities through its Facade.
        /// </summary>
        public void execute1()
        { 
            this.facade.execute1();           
        }

        /// <summary>
        /// It calls the execute2 method of ICommonFunctionalities through its Facade.
        /// </summary>
        public void execute2()
        {
            this.facade.execute2();
        }
    }
}
