using UnityEngine;

public class EnemyHealthListener : MonoBehaviour
{
    public delegate void EnemyDefeated();
    public static event EnemyDefeated OnEnemyDefeated;

    private CharacterStats characterStats;
    private bool isDead = false;

    private void Start()
    {
        characterStats = GetComponent<CharacterStats>();
        if (characterStats == null)
        {
            Debug.LogError("CharacterStats component not found on " + gameObject.name);
        }
    }

    private void Update()
    {
        if (characterStats != null && characterStats.currentHealth <= 0 && !isDead)
        {
            isDead = true;
            OnEnemyDefeated?.Invoke();
            Destroy(this);
        }
    }
}
