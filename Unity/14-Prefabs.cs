using System.Collections;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab; // Buraya sahneden bir prefab atanacak
    public float spawnInterval = 5f; // Kaç saniyede bir doğacak

    private void Start()
    {
        StartCoroutine(SpawnPrefabRepeatedly());
    }

    IEnumerator SpawnPrefabRepeatedly()
    {
        while (true)
        {
            Instantiate(prefab, new Vector3(Random.Range(-5f, 5f), 1f, Random.Range(-5f, 5f)), Quaternion.identity);
            // Prefabı rastgele bir pozisyonda doğuruyoruz

            yield return new WaitForSeconds(spawnInterval); // 5 saniye bekliyor
        }
    }
}

/*
    Türkçe Açıklama:
    Bu script bir prefabı her 5 saniyede bir sahnede rastgele pozisyonlarda doğurur.
    Start fonksiyonunda Coroutine başlatılıyor ve sonsuz döngü ile çalışıyor.

    English Description:
    This script spawns a prefab every 5 seconds at random positions in the scene.
    The coroutine is started in Start(), and it loops forever.
*/
