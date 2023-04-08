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


    // Start is called before the first frame update
    void Start()
    {

        rigidBody2D = GetComponent<Rigidbody2D>();

        hit = false;
        anim = GetComponent<Animator>();
        Invoke("Deactivate", deactivateTimer);
    }


    // Update is called once per frame
    void Update()
    {
        if (hit == false)
        {
            //rigidBody2D.rotation += 0.1f;

            move(asteroid);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "playerlaser(Clone)")
        {
            hit = true;
            anim.Play("asteroiddestory", 0, 0f);
            Debug.Log("animationplayed");

            Invoke("Deactivate", 0.8f);

            //add points
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


