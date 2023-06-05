using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PelletEaten : MonoBehaviour
{
    public int points = 10;

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
