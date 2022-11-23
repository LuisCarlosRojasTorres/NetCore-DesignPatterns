using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// Class that needs to use the third-party class ADAPTEE
    /// </summary>
    internal class Client
    {
        TargetInterface adapterInstance;

        public Client(TargetInterface adapterInstance)
        {
            this.adapterInstance = adapterInstance;
        }

        /// <summary>
        /// Functionality that needs to use ADAPTEE methods
        /// For this example its parameter is an int called clientDS,
        /// (which stands for clientDataStructure) however can be anytype or object
        /// </summary>
        /// <param name="clientDS"></param>
        public void ClientFunctionality(int clientDS) 
        {
            adapterInstance.clientMethod(clientDS);
        }
    }
}
