using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasermovescript : MonoBehaviour
{
    public float lMoveSpeed = 5;
    public float ldeadZone = 7;
    public GameObject laser;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (laser.transform.position.y > ldeadZone)
        {
            Destroy(gameObject);
        }

        if (animator.GetBool("firelaser"))
        {
            laser.transform.position = laser.transform.position + (Vector3.up * lMoveSpeed) * Time.deltaTime;
        }
    }
}
