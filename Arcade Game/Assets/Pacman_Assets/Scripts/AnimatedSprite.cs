using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class AnimatedSprite : MonoBehaviour

{
    public SpriteRenderer spriteRenderer {  get; private set; }
    public Sprite[] sprites;
    public float animationTime = 0.25f;
    private float repeatRate = 0.15f;
    public int animationFrame { get; private set; }
    public bool loop = true;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AdvanceFrame), animationTime, repeatRate);
    }

    private void AdvanceFrame()
    {
        if (!spriteRenderer.enabled)
        {
            return;
        }
        
        animationFrame++;

        /* resets animation frame to 0 if looping and frame reaches end of sprites list */

        if (animationFrame >= sprites.Length && loop) {
            
            animationFrame = 0;
        
        }

        /* sets sprite to next sprite in list if looping and not at the end of sprites list */
        if (animationFrame >= 0 && animationFrame < sprites.Length) {

            spriteRenderer.sprite = sprites[animationFrame];
        
        }
    }

    public void Restart()
    {
        animationFrame = -1;

        AdvanceFrame();
    }

}
