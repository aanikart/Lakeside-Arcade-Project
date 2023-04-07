using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenfightscript : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float runSpeed = 40f;
    public float jumpAmount = 70;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal2") * runSpeed;
        //float v = Input.GetAxis("Vertical2") * jumpAmount;
        gameObject.transform.Translate(h * Time.deltaTime, 0, 0);
        if (transform.position.x <= (-9.8))
        {
            gameObject.transform.position = new Vector3((float)-9.79, (float)-1.75, 0);
        }
        if (transform.position.x >= (9.8))
        {
            gameObject.transform.position = new Vector3((float)9.79, (float)-1.75, 0);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            gameObject.transform.localScale = new Vector3(-15, 15, 0);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            gameObject.transform.localScale = new Vector3(15, 15, 0);
        }
        if (transform.position.y <= (-1.75))
        {
            gameObject.transform.position = new Vector3(transform.position.x, (float)-1.75, 0);
        }
        if (transform.position.y >= (2.75))
        {
            gameObject.transform.position = new Vector3(transform.position.x, (float)2.7, 0);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            animator.SetBool("isLPunchingG", true);
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            animator.SetBool("isLPunchingG", false);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            animator.SetBool("isRPunchingG", true);
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            animator.SetBool("isRPunchingG", false);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetBool("isLKickingG", true);
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            animator.SetBool("isLKickingG", false);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            animator.SetBool("isRKickingG", true);
        }
        if (Input.GetKeyUp(KeyCode.N))
        {
            animator.SetBool("isRKickingG", false);
        }
    }
}
