using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal interface ICommonFunctionalities
    {
        /// <summary>
        /// Common method used by the facade class.
        /// </summary>
        public void execute1();

        /// <summary>
        /// Another Common method used by the facade class.
        /// </summary>
        public void execute2();
    }
}
