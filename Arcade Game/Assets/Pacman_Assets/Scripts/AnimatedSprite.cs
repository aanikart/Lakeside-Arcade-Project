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
    public float repeatRate = 0.15f;
    public int animationFrame { get; private set; }
    public bool loop = true;
    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AdvanceFrame), this.animationTime, this.repeatRate);
    }

    private void AdvanceFrame()
    {
        if (!this.spriteRenderer.enabled)
        {
            return;
        }
        
        this.animationFrame++;

        if (this.animationFrame >= this.sprites.Length && this.loop) {
            
            this.animationFrame = 0;
        
        }

        if (this.animationFrame >= 0 && this.animationFrame < this.sprites.Length) {

            this.spriteRenderer.sprite = this.sprites[this.animationFrame];
        
        }
    }

    public void Restart()
    {
        this.animationFrame = -1;

        AdvanceFrame();
    }

}
