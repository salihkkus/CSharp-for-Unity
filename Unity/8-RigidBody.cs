using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    public float moveForce = 5f; // AddForce için çarpan
    public float moveSpeed = 5f; // Velocity için sabit hız
    public bool useAddForce = true; // Hangi yöntemi kullanacağımıza karar veren değişken

    private Rigidbody rb;

    void Start()
    {
        // Rigidbody component'ini alıyoruz
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Kullanıcıdan input alıyoruz
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        if (useAddForce)
        {
            // AddForce kullanarak hareket
            rb.AddForce(direction * moveForce);
        }
        else
        {
            // Velocity kullanarak hareket
            rb.velocity = direction * moveSpeed;
        }
    }
}

// Türkçe Açıklamalar:
// Rigidbody component'ini kullanarak iki farklı hareket yöntemi gösteriyoruz.
// useAddForce true ise AddForce ile hareket ediyoruz, false ise direkt velocity veriyoruz.
// AddForce fizik kurallarına uyar, velocity ise anında hız verir.

// English Comments:
// We demonstrate two different movement methods using the Rigidbody component.
// If useAddForce is true, we move the object with AddForce; if false, we set the velocity directly.
// AddForce obeys physics rules, while velocity changes speed instantly.
