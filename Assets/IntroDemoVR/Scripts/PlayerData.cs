using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string playerId = "001";

    public void ShowPlayer()
    {
        Debug.Log(playerId);
    }
}