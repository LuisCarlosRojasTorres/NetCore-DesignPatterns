using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Adapter : TargetInterface
    {
        private Adaptee adapteeInstance;

        public Adapter(Adaptee adapteeInstance)
        {
            this.adapteeInstance = adapteeInstance;
        }

        /// <summary>
        /// Client's method is ADAPTED to use ADAPTEE method
        /// For this example its parameter is an "int" called clientDS,
        /// (which stands for clientDataStructure) however can be anytype or object
        /// It can returns any type.
        /// </summary>
        /// <param name="clientDS"></param>
        public void clientMethod(int clientDS)
        {
            adapteeInstance.adapteeMethod(ClientToAdapteeDSConversor(clientDS));            
        }

        /// <summary>
        /// CONVERTS clientDS to adapteeDS.
        /// So, It shall returns adapteeDS type!!!.
        /// </summary>
        /// <param name="clientVariable"></param>
        /// <returns></returns>
        private bool ClientToAdapteeDSConversor(int clientDS) 
        {
            if (clientDS != 0)
            {
                return true;
            }
            else {
                return false;
            }
        
        }
    }
}
