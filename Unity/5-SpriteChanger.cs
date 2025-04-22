using UnityEngine;

// This script demonstrates how to change a sprite at runtime.
// Bu script çalışma sırasında bir sprite'ın nasıl değiştirileceğini gösterir.

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // SpriteRenderer component
    public Sprite newSprite; // New sprite to change into

    void Start()
    {
        // Change the sprite when the game starts
        // Oyun başladığında sprite'ı değiştir
        spriteRenderer.sprite = newSprite;
    }
}
