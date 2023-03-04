using UnityEngine;
using System.Collections;

public class lasertrigger : MonoBehaviour
{
    private Animator animator;


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("firelaser",true);
        }

    }
}
