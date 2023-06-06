using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainfighterscript : MonoBehaviour
{

    public float speed = 5f;
    public float minX, maxX;

    private Animator anim;

    //public gameover gameover;

    private float currentattacktimer;
    private bool canattack;
    public float attacktimer = 0.35f;

    public static bool isfighterdead;

    public Transform attackpos;
    public float attackrange;
    public LayerMask whatisgreen;

    public int damage;

    public bool goingleft;


    // Start is called before the first frame update
    void Start()
    {
        currentattacktimer = attacktimer;
        isfighterdead = false;

        anim = GetComponent<Animator>();

        goingleft = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isfighterdead == false)
        {
            MoveFighter();
            punch();
        }
    }

    void MoveFighter()
    {
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            goingleft = false;
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            gameObject.transform.localScale = new Vector3( 7, 7, 1);

            anim.Play("runright");

            if (temp.x > maxX)
            {
                temp.x = maxX;
            }

            transform.position = temp;

        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            goingleft = true;
            Vector3 temp = transform.position;
            gameObject.transform.localScale = new Vector3(-7, 7, 1);
            temp.x -= speed * Time.deltaTime;

            anim.Play("runright");
            if (temp.x < minX)
            {
                temp.x = minX;
            }
            transform.position = temp;


        }
    }

    void punch()
    {
        if (goingleft == true)
        {
            gameObject.transform.localScale = new Vector3(-7, 7, 1);
        }
        attacktimer += Time.deltaTime;
        if (attacktimer > currentattacktimer)
        {
            canattack = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Debug.Log("Space");
            if (canattack == true)
            {
                canattack = false;
                attacktimer = 0f;
                anim.Play("mainpunch");

                Collider2D[] enemiestodamage = Physics2D.OverlapCircleAll(attackpos.position,attackrange,whatisgreen);

                for (int i = 0; i < enemiestodamage.Length; i++)
                {
                    enemiestodamage[i].GetComponent<greenenemy>().TakeDamage(damage);
                }

                Debug.Log("Punch");
                
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackpos.position,attackrange);
    }
}
