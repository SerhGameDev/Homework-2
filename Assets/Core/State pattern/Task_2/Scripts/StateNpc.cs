public abstract class StateNpc
{
    protected NpcStateMachine NpcStateMachine;
    public virtual void Initializ(NpcStateMachine npcStateMachine) => NpcStateMachine = npcStateMachine;
    public virtual void Start() { }
    public abstract void Update();
    public virtual void Exit()
    {
        NpcStateMachine.SwitchToNextState();
    }
}
