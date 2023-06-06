using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidscript : MonoBehaviour
{
    public GameObject asteroid;
    public float speed = 2f;

    public Rigidbody2D rigidBody2D;

    private Animator anim;
    public bool hit;
    public float deactivateTimer = 5f;

    public AudioClip pointup;
    AudioSource audioast;
    public bool alreadyplayed = false;

    void Start()
    {

        rigidBody2D = GetComponent<Rigidbody2D>();

        hit = false;
        anim = GetComponent<Animator>();
        Invoke("Deactivate", deactivateTimer);

        audioast = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (hit == false)
        {

            move(asteroid);
           
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "playerlaser(Clone)")
        {
            hit = true;
            anim.Play("asteroiddestory", 0, 0f);
            if (!alreadyplayed)
            {
                //point sound played
                audioast.PlayOneShot(pointup, 1);
                alreadyplayed = true;
            }

            //destroy after animation plays 
            Invoke("Deactivate", 0.6f);

        }

        if (collision.gameObject.name == "spaceship")
        {
            //game over

            Deactivate();
        }
    }
    void Deactivate()
    {
        gameObject.SetActive(false);
    }

    void move(GameObject asteroid)
    {
        asteroid.transform.Translate(Vector3.left * speed * Time.deltaTime);


        
    }




}


