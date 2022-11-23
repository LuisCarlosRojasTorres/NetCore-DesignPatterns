using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal interface TargetInterface
    {
        /// <summary>
        /// Client's method that need to be ADAPTED
        /// </summary>
        /// <returns></returns>
        public void clientMethod(int clientVariable);

    }
}
