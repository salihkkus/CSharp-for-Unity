using UnityEngine;

[System.Serializable]
public class Quest
{
    public string questName;
    public string description;
    public int requiredAmount;
    public int currentAmount;

    public bool IsCompleted => currentAmount >= requiredAmount;

    public void AddProgress(int amount = 1)
    {
        currentAmount += amount;
    }
}
-----------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public Quest currentQuest;
    public Text questText;

    private void Start()
    {
        UpdateUI();
    }

    public void CollectItem()
    {
        if (!currentQuest.IsCompleted)
        {
            currentQuest.AddProgress();
            UpdateUI();

            if (currentQuest.IsCompleted)
            {
                Debug.Log("Görev tamamlandı!");
                questText.text = $"{currentQuest.questName} ✅";
                // ödül verilebilir
            }
        }
    }

    private void UpdateUI()
    {
        questText.text = $"{currentQuest.questName}: {currentQuest.currentAmount}/{currentQuest.requiredAmount}";
    }
}
---------------------------------------------------------------------------------------------------------------------
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<QuestManager>().CollectItem();
            Destroy(gameObject);
        }
    }
}
