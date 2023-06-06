using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
// pellet sprite from https://github.com/zigurous/unity-pacman-tutorial/tree/main/Assets/Tiles

public class PelletEaten : MonoBehaviour
{
    
    public int points = 10;

    // virtual to override in PowerPelletEaten
    protected virtual void eat()
    {
        FindObjectOfType<GameManagerScript>().pelletEaten(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            eat();
        }
    }
}
