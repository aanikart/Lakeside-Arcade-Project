using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenfightscript : MonoBehaviour
{
    public Animator animator;
    public float runSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * runSpeed;
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(h * Time.deltaTime, v, 0);

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
