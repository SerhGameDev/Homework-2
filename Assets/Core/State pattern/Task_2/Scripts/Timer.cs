using System;

public class Timer
{
    public Timer(float duration, Action onTimerEnd = null)
    {
        this._duration = duration;
        this._elapsedTime = 0f;
        this._isRunning = false;
        this._onTimerEnd = onTimerEnd;
    }

    private float _duration;
    private float _elapsedTime;
    private bool _isRunning;
    private Action _onTimerEnd;

    public void Start()
    {
        _isRunning = true;
    }
    public void Update()
    {
        if (_isRunning)
        {
            _elapsedTime += UnityEngine.Time.deltaTime;
            if (_elapsedTime >= _duration)
            {
                _isRunning = false;
                _elapsedTime = 0f;

                if (_onTimerEnd != null)
                {
                    _onTimerEnd.Invoke();
                }
            }
        }
    }
    public void Reset()
    {
        _isRunning = false;
        _elapsedTime = 0f;
    }
    public bool IsRunning()
    {
        return _isRunning;
    }
}
