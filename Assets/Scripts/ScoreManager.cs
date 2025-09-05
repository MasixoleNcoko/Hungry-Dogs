using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score = 0;
    public TextMeshProUGUI scoreNumber;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreNumber.text = "Score: " + score.ToString();
    }

    private void UpdateScoreUI()
    {
        if (scoreNumber != null)
        {
            scoreNumber.text = score.ToString();
        }
    }

    public int GetScore()
    {
        return score;
    }
}
