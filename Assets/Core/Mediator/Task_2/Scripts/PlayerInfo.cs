using System;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    [field: SerializeField] public int Health { get; private set; }
    [field: SerializeField] public int Levl { get; private set; }
    [field: SerializeField] public int LevlPoint { get; private set; }

    public event Action OnSetHealth;
    public event Action OnSetLevl;
    public event Action OnSetLevlPoint;

    public void SetLevl(int setLevl)
    {
        if (setLevl >= 1)
            Levl = setLevl;
        else
            Levl = 1;

        OnSetLevl?.Invoke();
    }
    public void SetLevlPoint(int setPoint)
    {
        if (setPoint >= 0)
            LevlPoint = setPoint;
        else
            LevlPoint = 0;

        OnSetLevlPoint?.Invoke();
    }
    public void SetHealth(int setHealth)
    {
        if (setHealth >= 0)
            Health = setHealth;
        else
            setHealth = 0;

        OnSetHealth?.Invoke();
    }
}
