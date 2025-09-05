using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI; // Game over canvas
    public TMP_Text finalScoreText; // Score text field
    public ScoreManager scoreManager; // Score Manager gameObject

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGameOver()
    {
        GameOverUI.SetActive(true); // Makes Game Over screen visible

        // Display final score
        int finalScore = scoreManager.GetScore();
        finalScoreText.text = "Score: " + finalScore;

        // Pause game
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        // Unpause game
        Time.timeScale = 1;
        // Gets scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

}
