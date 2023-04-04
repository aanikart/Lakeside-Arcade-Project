using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
   // private Animator anim;


    private void OnCollisionEnter2D(Collision2D shot)
    {
        //anim.Play("explodealien");
        Destroy(gameObject);
    }
}
