using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite downArrowSprite; // Reference to the sprite to be displayed on down arrow press
    private Sprite originalSprite; // Store the original sprite
    private Vector3 originalPosition;

    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>().sprite; // Store the original sprite
        
    }

    // Method to change the sprite to down arrow sprite
    public void ChangeToDownArrowSprite()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null && downArrowSprite != null)
        {
            spriteRenderer.sprite = downArrowSprite;
            originalPosition = transform.position;
            transform.position = originalPosition - new Vector3(0, 1, 0);
            
            

        }
        else
        {
            Debug.LogError("SpriteRenderer or downArrowSprite is not assigned.");
        }
    }

    // Method to change the sprite back to original sprite
    public void ChangeToOriginalSprite()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null && originalSprite != null)
        {
            spriteRenderer.sprite = originalSprite;
            
        }
        else
        {
            Debug.LogError("SpriteRenderer or originalSprite is not assigned.");
        }
    }
}
