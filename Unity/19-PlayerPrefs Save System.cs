using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreText;
    public Text highScoreText;

    private int currentScore = 0;

    private void Start()
    {
        // Oyuna girince eski kaydedilen yüksek skoru al
        int savedHighScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + savedHighScore;

        currentScoreText.text = "Score: 0";
    }

    private void Update()
    {
        // Sadece test için: Boşluk tuşuna basınca puanı artır
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddScore(10);
        }
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        currentScoreText.text = "Score: " + currentScore;

        int savedHighScore = PlayerPrefs.GetInt("HighScore", 0);

        if (currentScore > savedHighScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            PlayerPrefs.Save(); // Bunu eklemek iyi pratik, veriyi hemen diske yazar

            highScoreText.text = "High Score: " + currentScore;
        }
    }
}
