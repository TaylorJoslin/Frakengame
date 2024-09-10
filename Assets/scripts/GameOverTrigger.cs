using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public GameOverManager gameOverManager;  // Reference to the GameOverManager script

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has entered the trigger
        if (other.CompareTag("Player"))
        {
            // Call the GameOver function from GameOverManager
            gameOverManager.GameOver();
        }
    }
}
