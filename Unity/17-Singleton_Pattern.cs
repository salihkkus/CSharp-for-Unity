using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int score = 0; // Örnek bir veri

    private void Awake()
    {
        // Eğer daha önce oluşturulmuş bir instance varsa, bu yeniyi yok et
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // Eğer yoksa kendimizi instance olarak atıyoruz
        Instance = this;

        // Sahne değişiminde kaybolmaması için
        DontDestroyOnLoad(gameObject);
    }

    // Skoru artıran bir örnek fonksiyon
    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Skor: " + score);
    }
}
---------------------------------------------------------------------
//Başka bir scriptten şöyle erişebilirsin
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.AddScore(10); // Space'e basınca 10 puan ekle
        }
    }
}
