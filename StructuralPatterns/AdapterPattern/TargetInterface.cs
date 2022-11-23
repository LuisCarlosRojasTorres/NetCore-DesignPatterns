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
        /// For this example its parameter is an int called clientDS,
        /// (which stands for clientDataStructure) however can be anytype or object
        /// It can returns any type.
        /// </summary>
        /// <returns></returns>
        public void clientMethod(int clientDS);

    }
}
