using UnityEngine;

// [TR] ScriptableObject ile karakter verisi tanımlıyoruz.
// [EN] Defining character data using ScriptableObject.

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Character/Character Data")]
public class CharacterData : ScriptableObject
{
    public string characterName; // [TR] Karakter ismi - [EN] Character name
    public int health; // [TR] Sağlık puanı - [EN] Health points
    public float speed; // [TR] Hız değeri - [EN] Speed value
}

// [TR] Bu ScriptableObject'ten veri okuyacak bir örnek script
// [EN] A sample script that reads data from this ScriptableObject

public class Character : MonoBehaviour
{
    public CharacterData characterData; // [TR] Inspector'dan atayacağımız veri - [EN] Data to assign from Inspector

    private void Start()
    {
        Debug.Log("Character Name: " + characterData.characterName);
        Debug.Log("Health: " + characterData.health);
        Debug.Log("Speed: " + characterData.speed);
    }
}
