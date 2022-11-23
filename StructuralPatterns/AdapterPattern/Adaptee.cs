using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdapterPattern
{
    /// <summary>
    /// This is the class that will be adapted. 
    /// </summary>
    internal class Adaptee
    {
        /// <summary>
        /// This is the method that Client needs to use HOWEVER
        /// its parameters are incompatible with ClientFunctionlity method i.e. clientDS != adapteeDS.
        /// For this example its parameter is an bool called adapteeDS,
        /// (which stands for adapteeDataStructure) however can be anytype
        /// </summary>
        /// <param name="adapteeDS"></param>
        public void adapteeMethod(bool adapteeDS) { 
            
            Console.WriteLine(adapteeDS);
        }
        
    }
}
