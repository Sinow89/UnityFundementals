using System;
using UnityEngine;

public class PlayerDamagerRecevier : MonoBehaviour
{
    [SerializeField] private SO_PlayerData soPlayerData;
    [SerializeField] private float damageToDeduct;
    private void OnDisable()
    {
        soPlayerData.ReduceHealth(damageToDeduct);
    }
}
