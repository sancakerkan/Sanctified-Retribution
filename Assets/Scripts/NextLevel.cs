using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Entered by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected. Switching Scene to " + sceneBuildIndex);
            try
            {
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Failed to load scene: " + e.Message);
            }
        }
        else
        {
            Debug.Log("Collider entered but it's not the player. Tag: " + other.tag);
        }
    }
}
