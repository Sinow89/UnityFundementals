using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class SO_PlayerData : ScriptableObject
{
    [SerializeField] private float playerHealth;
    [SerializeField] private bool playerIsDead;

    public float GetPlayerHealth()
    {
        return playerHealth;
    }

    public void ReduceHealth(float reductionAmount)
    {
        playerHealth -= reductionAmount;
    }

    public void SetPlayerHealth(float newHealth)
    {
        playerHealth = newHealth;
    }
}
