using UnityEngine;

public class ColliderExample : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Çarpışma algılandı: " + collision.gameObject.name);
        // A collision was detected with another object.
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger alanına girildi: " + other.gameObject.name);
        // Entered a trigger zone of another object.
    }
}

// Türkçe Açıklamalar:
// OnCollisionEnter fonksiyonu ile fiziksel çarpışmalar algılanıyor.
// OnTriggerEnter fonksiyonu ile "IsTrigger" seçili collider'lar arasındaki giriş algılanıyor.

// English Comments:
// OnCollisionEnter detects physical collisions between objects.
// OnTriggerEnter detects entering into "IsTrigger" enabled colliders.
