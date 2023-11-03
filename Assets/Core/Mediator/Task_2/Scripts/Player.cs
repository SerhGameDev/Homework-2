using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerUpgrate PlayerUpgrate;
    public PlayerInfo PlayerInfo;
    private void Awake() => PlayerUpgrate = new PlayerUpgrate(PlayerInfo);
}
