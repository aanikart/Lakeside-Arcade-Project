
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightscript : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float runSpeed = 40f;
    public float jumpAmount = 70;
    public Collider2D hit;
    public Collider2D hurt;
    public Collider2D push;
    public Collider2D enemyhit;
    public Collider2D enemyhurt;
    public Collider2D enemypush;
    public int health = 10;
    public int maxhealth = 10;
    public int score = 0;

    public gameoverscript isplayerdead;

    public greenfightscript greenfightscript;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        

        if (gameoverscript.isplayerdead == false)
        {
            
            float h = Input.GetAxis("Horizontal") * runSpeed;
            //float v = Input.GetAxis("Vertical") * jumpAmount;
            gameObject.transform.Translate(h * Time.deltaTime, 0, 0);
            if (transform.position.x <= (-9.8))
            {
                gameObject.transform.position = new Vector3((float)-9.79, (float)-1.75, 0);
            }
            if (transform.position.x >= (9.8))
            {
                gameObject.transform.position = new Vector3((float)9.79, (float)-1.75, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                gameObject.transform.localScale = new Vector3(-15, 15, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                gameObject.transform.localScale = new Vector3(15, 15, 0);
            }
            if (transform.position.y <= (-1.75))
            {
                gameObject.transform.position = new Vector3(transform.position.x, (float)-1.75, 0);
            }
            if (transform.position.y >= (2.75))
            {
                gameObject.transform.position = new Vector3(transform.position.x, (float)2.75, 0);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.SetBool("isLPunching", true);
            }
            if (Input.GetKeyUp(KeyCode.E))
            {
                animator.SetBool("isLPunching", false);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                animator.SetBool("isRPunching", true);
            }
            if (Input.GetKeyUp(KeyCode.R))
            {
                animator.SetBool("isRPunching", false);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                animator.SetBool("isLKicking", true);
            }
            if (Input.GetKeyUp(KeyCode.X))
            {
                animator.SetBool("isLKicking", false);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                animator.SetBool("isRKicking", true);
            }
            if (Input.GetKeyUp(KeyCode.C))
            {
                animator.SetBool("isRKicking", false);
            }
        }
        else
        {
            gameObject.transform.position = new Vector3(-3.59f, -1.75f, 0);
            animator.SetBool("isRKicking", false);
            animator.SetBool("isLKicking", false);
            animator.SetBool("isRPunching", false);
            animator.SetBool("isLPunching", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (isplayerdead == false)
        {
            if (collider == enemyhit)
            {
                Debug.Log("hit");
                health--;
                score = score + 100;
                greenfightscript.score = greenfightscript.score - 100;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

            rb.velocity = Vector2.zero;

    }
}

