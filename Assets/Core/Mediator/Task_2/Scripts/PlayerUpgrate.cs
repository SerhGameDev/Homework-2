using UnityEngine;

public class PlayerUpgrate
{
    public PlayerUpgrate(PlayerInfo playerInfo)
    {
        _playerInfo = playerInfo;
        _playerInfo.OnSetHealth += IsCanReset;
        Reset();
    }

    private PlayerInfo _playerInfo;
    private const int _difficultyUpgrate = 100;

    public void Upgrate()
    {
        if (!IsCanUpgrate())
            return;

        _playerInfo.SetHealth(GetHealthForUpgrate());
        _playerInfo.SetLevl(_playerInfo.Levl + 1);
        _playerInfo.SetLevlPoint(0);
    }
    public void Reset()
    {
        _playerInfo.SetLevl(1);
        _playerInfo.SetLevlPoint(0);
        _playerInfo.SetHealth(GetHealthForUpgrate());
    }
    public void IsCanReset()
    {
        if (_playerInfo.Health == 0)
            Reset();
    }
    public bool IsCanUpgrate() => _playerInfo.Levl * _difficultyUpgrate <= _playerInfo.LevlPoint;
    public int GetHealthForUpgrate() => _playerInfo.Levl * _difficultyUpgrate;
}
