using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightscript : MonoBehaviour
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
        gameObject.transform.Translate(h* Time.deltaTime, v, 0);

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
}
