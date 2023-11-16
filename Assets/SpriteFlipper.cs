using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isFlipped = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Check if the "A" key is being held down
        if (Input.GetKey(KeyCode.A))
        {
            // If not already flipped, flip the sprite
            if (!isFlipped)
            {
                FlipSpriteHorizontally();
            }
        }
        else
        {
            // If the "A" key is not held down, unflip the sprite
            if (isFlipped)
            {
                UnflipSpriteHorizontally();
            }
        }
    }

    private void FlipSpriteHorizontally()
    {
        if (spriteRenderer != null)
        {
            // Flip the sprite by negating its current scale on the X axis
            Vector3 currentScale = transform.localScale;
            currentScale.x *= -1;
            transform.localScale = currentScale;
            isFlipped = true;
        }
    }

    private void UnflipSpriteHorizontally()
    {
        if (spriteRenderer != null)
        {
            // Unflip the sprite by negating its current scale on the X axis
            Vector3 currentScale = transform.localScale;
            currentScale.x *= -1;
            transform.localScale = currentScale;
            isFlipped = false;
        }
    }
}
