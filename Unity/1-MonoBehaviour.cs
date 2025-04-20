using UnityEngine;

// This script shows basic MonoBehaviour usage.
// Bu script temel MonoBehaviour kullanımını göstermektedir.

public class MonoBehaviourExample : MonoBehaviour
{
    // Awake is called when the script instance is being loaded
    // Awake sahne yüklenirken çağrılır
    void Awake()
    {
        Debug.Log("Awake çalıştı (Sahne yükleniyor)");
    }

    // Start is called before the first frame update
    // Start ilk frame başlamadan önce bir kez çalışır
    void Start()
    {
        Debug.Log("Start çalıştı (Oyun başladı)");
    }

    // Update is called once per frame
    // Update her frame başına bir kez çalışır
    void Update()
    {
        Debug.Log("Update çalışıyor (Her frame kontrol)");
    }

    // OnDestroy is called when the object is destroyed
    // OnDestroy obje sahneden silindiğinde çalışır
    void OnDestroy()
    {
        Debug.Log("OnDestroy çalıştı (Obje sahneden kaldırıldı)");
    }
}
