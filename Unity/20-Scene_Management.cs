using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Bir tuşla farklı sahnelere geçiş yapacağız

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Sahne ismiyle yükleme
            SceneManager.LoadScene("MainMenu");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Sahne indexiyle yükleme
            SceneManager.LoadScene(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Async sahne yükleme
            StartCoroutine(LoadSceneAsyncExample("GameScene"));
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            // Şu anki sahneyi reload
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Async sahne yükleme örneği
    private System.Collections.IEnumerator LoadSceneAsyncExample(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            Debug.Log($"Yükleniyor... {operation.progress * 100}%");
            yield return null;
        }
    }
}
