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
            //rigidBody2D.rotation += 0.1f;

            move(asteroid);
           // transform.Rotate(_rotation * Time.deltaTime);
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
                audioast.PlayOneShot(pointup, 1);
                alreadyplayed = true;
            }



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


        //asteroid.transform.Translate(Vector3.up  * Time.deltaTime);

        //transform.eulerAngles = Vector3.forward * speed * Time.deltaTime;


    }




}


