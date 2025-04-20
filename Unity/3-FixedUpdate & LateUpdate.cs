using UnityEngine;

// This script demonstrates the use of FixedUpdate and LateUpdate methods in Unity.
// Bu script Unity'de FixedUpdate ve LateUpdate metodlarının kullanımını göstermektedir.

public class PhysicsAndCameraExample : MonoBehaviour
{
    Rigidbody rb;
    public Transform target; // This will be used for LateUpdate (e.g., camera follow)
    
    void Awake()
    {
        // Getting the Rigidbody component
        // Rigidbody bileşenini alıyoruz
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is used for physics-related operations
    // FixedUpdate fizik tabanlı işlemler için kullanılır
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // Move forward when W is pressed
            // W tuşuna basıldığında ileri hareket eder
            rb.AddForce(Vector3.forward * 10f);
        }
    }

    // LateUpdate is used for actions that must happen after all Updates
    // LateUpdate, tüm Update işlemlerinden sonra gerçekleşmesi gereken işlemler için kullanılır
    void LateUpdate()
    {
        if (target != null)
        {
            // This object follows the target position
            // Bu nesne hedef pozisyonu takip eder
            transform.position = target.position + new Vector3(0, 5, -10);
        }
    }
}
