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
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * runSpeed;
        //float v = Input.GetAxis("Vertical") * jumpAmount;
        gameObject.transform.Translate(h* Time.deltaTime,0, 0);
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
            //Collider2D[] enemies = Physics2D.OverlapCircleAll(lpointpunch,lpunchrange,ene)
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
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("hit");
        health--;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.zero;
        Debug.Log("stop");
    }
}
