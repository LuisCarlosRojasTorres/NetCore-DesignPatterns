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
        /// </summary>
        /// <param name="clientDS"></param>
        public void clientMethod(int clientDS)
        {
            adapteeInstance.adapteeMethod(ClientToAdapteeDSConversor(clientDS));            
        }

        /// <summary>
        /// This CONVERTS the CLIENT interface to something that the ADAPTEE can understand.
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
