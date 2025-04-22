using UnityEngine;
using UnityEngine.UI;

// This script shows how to fully control a button via code.
// Bu script bir butonu kodla tamamen nasıl kontrol edebileceğimizi gösterir.

public class ButtonControl : MonoBehaviour
{
    public Button myButton;

    void Start()
    {
        // 1- Add a listener (AddListener kullanımı)
        // Bir dinleyici ekle
        myButton.onClick.AddListener(OnButtonClicked);

        // 2- Make the button active (interactable = true)
        // Butonu aktif yap
        myButton.interactable = true;
    }

    void OnButtonClicked()
    {
        Debug.Log("Button clicked!");

        // 3- Disable the button after click (interactable = false)
        // Tıklandıktan sonra butonu pasif yap
        myButton.interactable = false;

        // 4- Remove the listener (RemoveListener kullanımı)
        // Dinleyiciyi kaldır
        myButton.onClick.RemoveListener(OnButtonClicked);
    }
}
