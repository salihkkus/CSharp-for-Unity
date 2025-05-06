using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    public Text scoreText;
    public Slider healthBar;
    public Button addScoreButton;

    private int score = 0;
    private float health = 1f;

    void Start()
    {
        // Başlangıç değerlerini ayarla
        scoreText.text = "Score: 0";
        healthBar.value = 1f;

        // Butonun onClick eventini bağla
        addScoreButton.onClick.AddListener(AddScore);
    }

    void AddScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;

        // Sağlık barını da azalt (örnek olsun diye)
        health -= 0.1f;
        health = Mathf.Clamp01(health);
        healthBar.value = health;
    }
}
