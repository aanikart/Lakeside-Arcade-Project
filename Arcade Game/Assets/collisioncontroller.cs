using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioncontroller : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GameOver")
        {
            Debug.Log("GamOver");
        }

        if (collision.gameObject.name == "laserbeam")
        {
            Debug.Log("laserhit");
        }
        Destroy(gameObject);
    }
}
