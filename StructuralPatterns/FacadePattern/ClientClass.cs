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

        public ClientClass(FacadeClass facade)
        {
            this.facade = facade;
        }

        public void execute1()
        { 
            this.facade.execute1();           
        }

        public void execute2()
        {
            this.facade.execute1();
        }
    }
}
