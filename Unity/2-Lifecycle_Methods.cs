using UnityEngine;

// This script demonstrates the Unity lifecycle methods: Awake, Start, and Update.
// Bu script Unity yaşam döngüsü metodlarını (Awake, Start ve Update) göstermektedir.

public class LifecycleExample : MonoBehaviour
{
    // Awake is called when the script instance is loaded
    // Awake, script sahneye yüklendiği anda çalışır
    void Awake()
    {
        Debug.Log("Awake: Script yüklendi.");
    }

    // Start is called before the first frame update
    // Start, oyun başladıktan sonra nesne aktifse bir kez çalışır
    void Start()
    {
        Debug.Log("Start: Oyun başladı ve obje aktif.");
    }

    // Update is called once per frame
    // Update, oyun süresince her frame başında çalışır
    void Update()
    {
        Debug.Log("Update: Frame başı çalışıyor.");
    }
}
