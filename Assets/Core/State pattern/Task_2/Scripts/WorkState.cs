using UnityEngine;

public class WorkState : StateNpc
{
    public WorkState(WorkStateData worckStateData) => _timer = new Timer(worckStateData.DurationWorck, Exit);
    private Timer _timer;
    public override void Start()
    {
        base.Start();
        _timer.Start();
    }
    public override void Update()
    {
        _timer.Update();
        Debug.Log("Работаю");
    }
}
[System.Serializable]
public class WorkStateData
{
    public float DurationWorck;
}