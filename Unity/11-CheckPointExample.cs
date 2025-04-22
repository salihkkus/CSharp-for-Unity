using System.Collections;
using UnityEngine;
using UnityEngine.UI; // UI elemanları için

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private int score = 0;
    public int totalCoins = 5; // toplam toplanacak coin
    public Text scoreText;
    public GameObject door; // açılacak kapı

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        UpdateScoreText(); // sahne başlarken skoru güncelle
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Basit W, A, S, D hareketi
        float moveX = 0;
        float moveZ = 0;

        if (Input.GetKey(KeyCode.W))
            moveZ = 1;
        if (Input.GetKey(KeyCode.S))
            moveZ = -1;
        if (Input.GetKey(KeyCode.A))
            moveX = -1;
        if (Input.GetKey(KeyCode.D))
            moveX = 1;

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized;
        rb.velocity = move * 5f; // Hız 5f
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject); // Coin yok et
            score++; // Skoru artır
            UpdateScoreText();

            if (score >= totalCoins)
            {
                StartCoroutine(OpenDoor()); // Coroutine ile kapıyı aç
            }
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    IEnumerator OpenDoor()
    {
        yield return new WaitForSeconds(1f); // 1 saniye bekle
        door.transform.localScale = new Vector3(1, 0, 1); // Kapının yüksekliğini 0 yap (açılmış gibi)
    }
}
