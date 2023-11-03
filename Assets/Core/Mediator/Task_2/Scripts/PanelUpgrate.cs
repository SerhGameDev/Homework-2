using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelUpgrate : MonoBehaviour
{
    [SerializeField] private Button _buttonAddLevlPoint;
    [SerializeField] private Button _buttonRemoveHealth;
    [SerializeField] private Button _buttonUpgrate;
    [Space]
    [SerializeField] private TextMeshProUGUI _textMeshLevlPoint;
    [SerializeField] private TextMeshProUGUI _textMeshHealth;
    [SerializeField] private TextMeshProUGUI _textMeshLevl;
    [Space]
    [SerializeField] private PanelUpgrateMediator _mediator; 
    [Space]
    [SerializeField] private int _removedHealth = 50;
    [SerializeField] private int _addLevlPoint = 50;

    private void OnEnable()
    {
        _buttonUpgrate.onClick.AddListener(OnClickUpgrate);
        _buttonAddLevlPoint.onClick.AddListener(OnClickAddLevlPoint);
        _buttonRemoveHealth.onClick.AddListener(OnClickRemovedHealth);
    }
    private void OnDisable()
    {
        _buttonUpgrate.onClick.RemoveListener(OnClickUpgrate);
        _buttonAddLevlPoint.onClick.RemoveListener(OnClickAddLevlPoint);
        _buttonRemoveHealth.onClick.RemoveListener(OnClickRemovedHealth);
    }

    public void UpdatePlayerLevelStats(int levlpoint, int levl, int health)
    {
        _textMeshLevlPoint.text = $"Levlpoint: {levlpoint}";
        _textMeshLevl.text = $"Levl: {levl}";
        _textMeshHealth.text = $"Health: {health}";
    }

    public void ShowButtonUpgrate() => _buttonUpgrate.gameObject.SetActive(true);
    public void HideButtonUpgrate() => _buttonUpgrate.gameObject.SetActive(false);

    private void OnClickUpgrate() => _mediator.Upgrate();
    private void OnClickAddLevlPoint() => _mediator.AddLevlPoint(_addLevlPoint);
    private void OnClickRemovedHealth() => _mediator.RemovedHealth(_removedHealth);
}
