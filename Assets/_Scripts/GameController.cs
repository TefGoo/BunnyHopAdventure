using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject bunnyPrefab;
    public Text carrotCountText;
    public Text highScoreText;
    public GameObject gameOverPanel;

    private int carrotCount;
    private int highScore;

    void Start()
    {
        carrotCount = PlayerPrefs.GetInt("CarrotCount", 0);
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateUI();
        gameOverPanel.SetActive(false);
        SpawnBunny();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void SpawnBunny()
    {
        Instantiate(bunnyPrefab, new Vector3(0, -3, 0), Quaternion.identity);
    }

    void Jump()
    {
        // Implement jump logic
    }

    public void CollectCarrot()
    {
        carrotCount++;
        PlayerPrefs.SetInt("CarrotCount", carrotCount);
        UpdateUI();
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        int currentScore = GetCurrentScore();
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        UpdateUI();
    }

    int GetCurrentScore()
    {
        // Implement score calculation logic
        return 0;
    }

    void UpdateUI()
    {
        carrotCountText.text = "Carrots: " + carrotCount;
        highScoreText.text = "High Score: " + highScore;
    }
}
