using System.Collections;
using UnityEngine;

// This script demonstrates how to use Coroutines in Unity.
// Bu script Unity'de Coroutine kullanımını göstermektedir.

public class CoroutineExample : MonoBehaviour
{
    void Start()
    {
        // Start the coroutine when the game begins
        // Oyun başladığında Coroutine başlatılır
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("Coroutine started!"); // Coroutine başladı!
        
        yield return new WaitForSeconds(3f); // 3 seconds wait - 3 saniye bekleme

        Debug.Log("3 seconds passed!"); // 3 saniye geçti!
    }
}
