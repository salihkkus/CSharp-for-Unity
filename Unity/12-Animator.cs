using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Animator referansı
    public Animator animator;
    
    // Hız ayarı
    public float moveSpeed = 5f;

    private void Update()
    {
        // Yatay eksende hareket girişini al (A/D veya ok tuşları)
        float move = Input.GetAxis("Horizontal");

        // Hareket varsa, yürüyüş animasyonunu başlat
        if (move != 0)
        {
            animator.SetBool("IsWalking", true);  // Yürüme animasyonunu tetikler
            transform.Translate(Vector3.right * move * moveSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("IsWalking", false); // Yürüme animasyonunu durdurur
        }
    }
}

/*
    Türkçe Açıklama:
    - Bu script, karakteri yatay eksende hareket ettirir.
    - "IsWalking" parametresi ile Animator Controller'daki geçişleri kontrol eder.
    - Sağ ve sol tuşlarıyla karakterin hareket etmesi sağlanır.

    English Explanation:
    - This script moves the character on the horizontal axis.
    - It controls the transitions in the Animator Controller with the "IsWalking" parameter.
    - The character moves with the left and right keys.
*/
