using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI loseText;  
    private bool isGameOver = false;

    void Start()
    {
        // Hide the lose text at the start
        loseText.gameObject.SetActive(false);
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.L)) // Press L to trigger game over (for testing)
        {
            GameOver();
        }

        // If the game is over, allow player to restart with R
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void GameOver()
    {
        // Pause the game
        Time.timeScale = 0;

        // Show the lose text
        loseText.gameObject.SetActive(true);

        // Set the game over state
        isGameOver = true;
    }

    public void RestartGame()
    {
        // Unpause the game
        Time.timeScale = 1;

        // Restart the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
