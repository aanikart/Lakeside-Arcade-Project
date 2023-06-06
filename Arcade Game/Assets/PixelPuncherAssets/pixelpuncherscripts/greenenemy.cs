using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenenemy : MonoBehaviour
{

    public GameObject enemy;
    public float speed = 2f;

    public int health;

    public Rigidbody2D rigidBody2D;

    private Animator anim;
    //public bool hit;

    public float deactivateTimer = 10f;

    public AudioClip pointup;

    public bool alreadyplayed = false;

    AudioSource audiogreen;
    public GameObject mainplayer;

    public Transform playertransform;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

        //hit = false;
        anim = GetComponent<Animator>();
        Invoke("Deactivate", deactivateTimer);

        audiogreen = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        move(enemy);
        //Debug.Log(health);
        if (health <= 0)
        {
            //hit = true;
            
            /*
            if (!alreadyplayed)
            {
                audiogreen.PlayOneShot(pointup, 1);
                alreadyplayed = true;
            }

            */

            Invoke("Deactivateenemy", 0.2f);

            
            


        }
    }

    void move(GameObject enemy)
    {
        if(transform.position.x > playertransform.position.x)
        {
            enemy.transform.Translate(Vector3.left * speed * Time.deltaTime);
            gameObject.transform.localScale = new Vector3(-6, 6, 1);


        }
        if (transform.position.x < playertransform.position.x)
        {
            enemy.transform.Translate(Vector3.right * speed * Time.deltaTime);
            

        }

    }

    void Deactivate()
    {
        gameObject.SetActive(false);
    }


   
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Damage Taken");
    }

    void Deactivateenemy()
    {
        gameObject.SetActive(false);

    }

}
