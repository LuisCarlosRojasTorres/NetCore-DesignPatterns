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
        /// <param name="clientVariable"></param>
        public void clientMethod(int clientVariable)
        {
            adapteeInstance.adapteeMethod(ClientToAdapteeVariableConversor(clientVariable));            
        }

        /// <summary>
        /// This CONVERTS the CLIENT interface to something that the ADAPTEE can understand.
        /// </summary>
        /// <param name="clientVariable"></param>
        /// <returns></returns>
        private bool ClientToAdapteeVariableConversor(int clientVariable) 
        {
            if (clientVariable != 0)
            {
                return true;
            }
            else {
                return false;
            }
        
        }
    }
}
