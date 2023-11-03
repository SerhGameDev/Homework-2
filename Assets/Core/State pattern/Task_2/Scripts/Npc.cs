using UnityEngine;

public class Npc : MonoBehaviour
{
    [SerializeField] private FabricaListStateForWorker _listStateForWorker;
    private NpcStateMachine _stateMachine;
    private void Start()
    {
        _stateMachine = new NpcStateMachine(_listStateForWorker.Get());
    }
    private void Update()
    {
        _stateMachine.UpdateState();
    }
}
