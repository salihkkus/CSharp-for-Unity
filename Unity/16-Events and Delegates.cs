// Events and Delegates Kullanım Örneği

using UnityEngine;

public class Player : MonoBehaviour
{
    // 1. Delegate tanımı
    public delegate void PlayerDamaged();

    // 2. Event tanımı
    public event PlayerDamaged onPlayerDamaged;

    public int health = 100;

    void Update()
    {
        // Sadece test amaçlı: Space tuşuna basınca hasar al
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Player damage aldı: " + damageAmount);

        // Event tetikle
        if (onPlayerDamaged != null)
        {
            onPlayerDamaged();
        }
    }
}

//----------------------------------------

public class UIManager : MonoBehaviour
{
    public Player player;

    void OnEnable()
    {
        // Event'e abone ol
        player.onPlayerDamaged += UpdateHealthUI;
    }

    void OnDisable()
    {
        // Event'ten çık (önemli)
        player.onPlayerDamaged -= UpdateHealthUI;
    }

    void UpdateHealthUI()
    {
        Debug.Log("Can barı güncellendi!");
    }
}
