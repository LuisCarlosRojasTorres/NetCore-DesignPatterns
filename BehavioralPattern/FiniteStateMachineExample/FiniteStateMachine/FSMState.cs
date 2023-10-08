namespace FiniteStateMachineExample.FiniteStateMachine
{
    public enum FSMState
    {      
        Success = 0,
        Initializing = 1,
        Processing = 2,
        Finishing = 3,
        ErrorAtInitializing = 11,
        ErrorAtProcessing = 12,
        ErrorAtFinishing = 13,
    }    
}
