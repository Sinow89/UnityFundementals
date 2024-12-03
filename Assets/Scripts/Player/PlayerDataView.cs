using System;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerDataView : MonoBehaviour
{
    [FormerlySerializedAs("playerData")] [SerializeField] private SO_PlayerData soPlayerData;

    private void OnEnable()
    {
        var playerHealth = soPlayerData.GetPlayerHealth();
        Debug.Log(playerHealth);
    }
}
