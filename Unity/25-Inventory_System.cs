using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public bool isStackable;
}
---------------------------------------------------------------------------
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public List<Item> items = new List<Item>();
    public int space = 10;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public bool Add(Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log("Inventory full!");
            return false;
        }
        items.Add(item);
        Debug.Log(item.itemName + " added to inventory.");
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
    }
}
-----------------------------------------------------------------------
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bool pickedUp = Inventory.instance.Add(item);
            if (pickedUp)
                Destroy(gameObject); // Item sahneden kaybolur
        }
    }
}
