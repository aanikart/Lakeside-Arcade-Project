using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 5f;
    public float minY, maxY;

    [SerializeField]
    private GameObject playerbullet;

    [SerializeField]
    private Transform attackpoint;

    public GameObject spaceship;

    public float attacktimer = 0.35f;
    private float currentattacktimer;
    private bool canattack;

    private Animator anim;

    public gameover gameover;

    public static bool isdead;

    // Start is called before the first frame update
    void Start()
    {
        currentattacktimer = attacktimer;
        isdead = false;

        anim = GetComponent<Animator>();

        anim.Play("idlespaceship", 0, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (isdead == false)
        {
            MovePlayer();
            attack();
        }
    }

    void MovePlayer()
    {
        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;

            if (temp.y > maxY)
            {
                temp.y = maxY;
            }

            transform.position = temp;

        }
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;

            if (temp.y < minY)
            {
                temp.y = minY;
            }
            transform.position = temp;


        }
    }

    void attack()
    {
        attacktimer += Time.deltaTime;
        if (attacktimer > currentattacktimer)
        {
            canattack = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canattack == true)
            {
                canattack = false;
                attacktimer = 0f;
                Instantiate(playerbullet, attackpoint.position, Quaternion.identity);

                //playsound

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isdead == false)
        {
            if (collision.gameObject.name == "enemylaser(Clone)")
            {
                anim.Play("hurtspaceship", 0, 0f);

            }
        }
        

        if (collision.gameObject.name == "asteroid(Clone)"|| collision.gameObject.name == "enemyalien(Clone)")
        {
            isdead = true;
            GameOver();


        }

    }

    public void GameOver()
    {
        gameover.Setup(scorescript.scoreValue, scorescript.ticketnumber);
    }

}