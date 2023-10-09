using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachineExample.FiniteStateMachine
{
    public class FSM : IFSM
    {
        FSMState state;

        public FSM() 
        { 
            state = new FSMState();
            this.state = FSMState.Initializing;
        }        

        public void FiniteStateMachineProcess()
        {
            Console.WriteLine(" - Begin FiniteStateMachineProcess()");

            while (
                this.state != FSMState.ErrorAtInitializing &&
                this.state != FSMState.ErrorAtProcessing   &&
                this.state != FSMState.ErrorAtFinishing &&
                this.state != FSMState.Success 
                )
            { 
                switch( this.state ) 
                {
                    case FSMState.Initializing:
                        this.Initializing(); 
                        break;
                    case FSMState.Processing:
                        this.Processing(); 
                        break;
                    case FSMState.Finishing: 
                        this.Finishing(); 
                        break;                      
                }
            }

            Console.WriteLine(" - End FiniteStateMachineProcess()");
        }

        public FSMState getFSMState()
        {
            return this.state;
        }

        public void Initializing()
        {
            Console.WriteLine(" - Start Initializing()");
            Task.Delay(3000).Wait();
            Console.WriteLine(" - End Initializing()");
            this.state = FSMState.Processing;
        }

        public void Processing()
        {
            Console.WriteLine(" - Start Processing()");
            Task.Delay(3000).Wait();
            Console.WriteLine(" - End Processing()");
            this.state = FSMState.Finishing;
        }

        public void Finishing()
        {
            Console.WriteLine(" - Start Finishing()");
            Task.Delay(3000).Wait();
            Console.WriteLine(" - End Finishing()");
            this.state = FSMState.Success;
        }
    }
}
