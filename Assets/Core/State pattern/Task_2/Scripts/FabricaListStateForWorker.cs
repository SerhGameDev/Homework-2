using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FabricaListStateForWorker : IFabricaListState
{
    [SerializeField] private IdelStateData _idelStateData;
    [SerializeField] private MoveStateData _moveStateDataInWork;
    [SerializeField] private Transform _transformNpc;
    [SerializeField] private WorkStateData _workStateData;
    [SerializeField] private MoveStateData _moveStateDataInHome;
    public List<StateNpc> Get()
    {
        return new List<StateNpc>()
        {
            new IdleState(_idelStateData),
            new MoveStateNpc(_moveStateDataInWork,_transformNpc),
            new WorkState(_workStateData),
            new MoveStateNpc(_moveStateDataInHome,_transformNpc)
        };
    }
}
