using UnityEngine;

public class IdleState : StateNpc
{
    public IdleState(IdelStateData idelStateData) => _timer = new Timer(idelStateData.DurationIdel, Exit);
    private Timer _timer;

    public override void Start()
    {
        base.Start();
        _timer.Start();
        Debug.Log($"начал ждать");
    }
    public override void Update()
    {
        _timer.Update();
        Debug.Log($"жду");
    }
}
[System.Serializable]
public class IdelStateData
{
    public float DurationIdel;
}