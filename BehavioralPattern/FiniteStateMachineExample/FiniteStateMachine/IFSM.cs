namespace FiniteStateMachineExample.FiniteStateMachine
{
    public interface IFSM
    {
        public void FiniteStateMachineProcess();
        public void Initializing();
        public void Processing();
        public void Finishing();
        public FSMState getFSMState();
    }
}
