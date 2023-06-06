

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    // calls advanceFrame in animationTime seconds repeatedly every repeatRate
    private void Start()
    {
        InvokeRepeating(nameof(advanceFrame), animationTime, repeatRate);
    }

    private void advanceFrame()
    {
        if (!spriteRenderer.enabled)
        {
            return;
        }
        
        animationFrame++;

        // resets animation frame to 0 if looping and frame reaches end of sprites list 

        if (animationFrame >= sprites.Length && loop) {
            
            animationFrame = 0;
        
        }

        // sets sprite to next sprite in list if looping and not at the end of sprites list 
        if (animationFrame >= 0 && animationFrame < sprites.Length) {

            spriteRenderer.sprite = sprites[animationFrame];
        
        }
    }

    // restarts looping from first sprite in array of sprites 
    public void restart()
    {
        animationFrame = -1;

        advanceFrame();
    }

}
