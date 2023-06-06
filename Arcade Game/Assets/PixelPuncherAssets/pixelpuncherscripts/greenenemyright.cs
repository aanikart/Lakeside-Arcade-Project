using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenenemyright : MonoBehaviour
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

    public Transform mainPlayer;


    public float fightdistance;
    private float distance;
    public bool isattacking;

    

    // Start is called before the first frame update

    void Start()
    {
        isattacking = false;
        rigidBody2D = GetComponent<Rigidbody2D>();


        //hit = false;
        anim = GetComponent<Animator>();
        //Invoke("Deactivate", deactivateTimer);

        audiogreen = GetComponent<AudioSource>();

        fightdistance = 1f;
    }


    // Update is called once per frame
    void Update()
    {


        move(enemy);


        attackplayer();

        if (health <= 0)
        {

            Invoke("Deactivateenemy", 0.2f);

        }
    }

    void move(GameObject enemy)
    {


        if (isattacking == false)
        {

            enemy.transform.Translate(Vector3.left * speed * Time.deltaTime);
            gameObject.transform.localScale = new Vector3(-6, 6, 1);

        }
    }

    void Deactivateenemy()
    {
        gameObject.SetActive(false);
    }



    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Damage Taken");
    }



    void attackplayer()
    {

        if (Vector2.Distance(transform.position, mainPlayer.transform.position) < fightdistance)
        {
            isattacking = true;
            
             
             anim.SetTrigger("righttrigger");

            Debug.Log("attacking player");

        }
        isattacking = false;
    }

}
