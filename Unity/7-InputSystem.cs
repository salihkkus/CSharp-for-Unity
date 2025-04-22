using UnityEngine;

public class InputSystemExample : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // 1. Space tuşuna basıldığında sadece bir kez çalışır
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space tuşuna basıldı!");
        }

        // 2. W tuşuna basılı tutulduğunda sürekli çalışır
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W tuşuna basılı tutuluyor.");
        }

        // 3. Space tuşu bırakıldığında çalışır
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space tuşu bırakıldı.");
        }

        // 4. Mouse sol tık
        if (Input.GetMouseButtonDown(0))  // 0 = Left Click
        {
            Debug.Log("Mouse sol tıklandı!");
        }

        // 5. Yön tuşları ile karakter hareketi (Horizontal ve Vertical axis)
        float horizontal = Input.GetAxis("Horizontal");  // A-D veya Ok Tuşları
        float vertical = Input.GetAxis("Vertical");      // W-S veya Ok Tuşları

        Vector3 move = new Vector3(horizontal, 0, vertical);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
