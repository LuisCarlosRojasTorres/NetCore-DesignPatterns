using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Client
    {
        TargetInterface adapterInstance;

        public Client(TargetInterface adapterInstance)
        {
            this.adapterInstance = adapterInstance;
        }

        public void ClientFunctionality(int clientVariable) 
        {
            adapterInstance.clientMethod(clientVariable);
        }
    }
}
