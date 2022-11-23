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
        /// This is the method with parameters incompatible with Client.
        /// This method shall be modified to include:
        /// - your parameters
        /// - your return type
        /// - your implementation
        /// </summary>
        /// <param name="adapteeVariable"></param>
        public void adapteeMethod(bool adapteeVariable) { 
            
            Console.WriteLine(adapteeVariable);
        }
        
    }
}
