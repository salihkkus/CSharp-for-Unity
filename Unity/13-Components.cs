using UnityEngine;

public class ComponentExample : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    private SpriteRenderer mySpriteRenderer;

    void Start()
    {
        // Rigidbody2D componenti ekliyoruz
        myRigidBody = gameObject.AddComponent<Rigidbody2D>();

        // SpriteRenderer componentini çekiyoruz
        mySpriteRenderer = GetComponent<SpriteRenderer>();

        if (mySpriteRenderer != null)
        {
            mySpriteRenderer.color = Color.green; // Nesne rengini değiştir
        }
        else
        {
            Debug.LogWarning("SpriteRenderer bulunamadı!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Boşluk tuşuna basınca Rigidbody2D componentini siliyoruz
            if (myRigidBody != null)
            {
                Destroy(myRigidBody);
            }
        }
    }
}

/*  
--- Açıklamalar ---
Bu script bir GameObject'e Rigidbody2D ekler.
Başlangıçta SpriteRenderer varsa rengini yeşil yapar.
Boşluk (Space) tuşuna basınca Rigidbody2D componentini kaldırır.

--- Türkçe ---
Başlangıçta Rigidbody2D ekleriz.
Eğer SpriteRenderer varsa, rengini yeşil yaparız.
Space tuşuna basılınca Rigidbody2D'yi yok ederiz.
*/
