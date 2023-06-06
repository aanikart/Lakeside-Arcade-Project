using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// power pellet sprite from https://github.com/zigurous/unity-pacman-tutorial/tree/main/Assets/Tiles
public class PowerPelletEaten : PelletEaten
{
    // duration that power pellet is active/ghosts are frightened
    public float duration = 8f;

    protected override void eat()
    {
        FindObjectOfType<GameManagerScript>().powerPelletEaten(this);
    }

}
