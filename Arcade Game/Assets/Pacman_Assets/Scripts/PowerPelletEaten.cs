using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPelletEaten : PelletEaten
{

    public float duration = 8f;

    protected override void eat()
    {
        FindObjectOfType<GameManagerScript>().powerPelletEaten(this);
    }

}
