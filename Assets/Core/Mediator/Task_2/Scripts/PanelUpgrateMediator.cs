using UnityEngine;

public class PanelUpgrateMediator : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PanelUpgrate _panelUpgrate;

    private PlayerInfo _playerInfo;
    private PlayerUpgrate _playerUpgrate;

    private void Start() => Initialization();

    public void Initialization()
    {
        _playerInfo = _player.PlayerInfo;
        _playerUpgrate = _player.PlayerUpgrate;

        _playerInfo.OnSetLevlPoint += UpdatePlayerLevelStats;
        _playerInfo.OnSetHealth += UpdatePlayerLevelStats;
        _playerInfo.OnSetLevl += UpdatePlayerLevelStats;

        UpdatePlayerLevelStats();
    }
    public void UpdatePlayerLevelStats()
    {
        if (_playerUpgrate.IsCanUpgrate())
            _panelUpgrate.ShowButtonUpgrate();
        else
            _panelUpgrate.HideButtonUpgrate();

        _panelUpgrate.UpdatePlayerLevelStats(_playerInfo.LevlPoint, _playerInfo.Levl, _playerInfo.Health);
    }
    public void Upgrate() => _playerUpgrate.Upgrate();
    public void RemovedHealth(int removedHealth) => _playerInfo.SetHealth(_playerInfo.Health - removedHealth);
    public void AddLevlPoint(int addlevlPoint) => _playerInfo.SetLevlPoint(_playerInfo.LevlPoint + addlevlPoint);

}

