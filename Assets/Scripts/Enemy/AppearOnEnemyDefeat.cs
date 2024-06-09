using UnityEngine;

public class AppearOnEnemyDefeat : MonoBehaviour
{
    public GameObject objectToAppear;

    private void OnEnable()
    {
        EnemyHealthListener.OnEnemyDefeated += ShowObject;
    }

    private void OnDisable()
    {
        EnemyHealthListener.OnEnemyDefeated -= ShowObject;
    }

    private void ShowObject()
    {
        Debug.Log("Enemy defeated, showing object.");
        if (objectToAppear != null)
        {
            objectToAppear.SetActive(true);
        }
        else
        {
            Debug.LogError("objectToAppear is not assigned.");
        }
    }
}
