using UnityEngine;
public class MoveStateNpc : StateNpc
{
    public MoveStateNpc(MoveStateData stateData, Transform transformNpc)
    {
        _stateData = stateData;
        _transformNpc = transformNpc;
        _target = _stateData.Target;
    }
    private MoveStateData _stateData;
    private Transform _target;
    private Transform _transformNpc;

    public override void Update()
    {
        _transformNpc.position = Vector3.MoveTowards(_transformNpc.position, _target.position, _stateData.Speed * Time.deltaTime);

        if (Vector3.Distance(_target.position, _transformNpc.position) <= 0)
            Exit();
    }
}
[System.Serializable]
public class MoveStateData
{
    public float Speed;
    public Transform Target;
}