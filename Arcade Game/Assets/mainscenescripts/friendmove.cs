using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendmove : MonoBehaviour
{

    public float speed = 2f;
    public float minx, maxx;
    public Animator anim;
    public GameObject player;



    void Start()
    {
        
    }


    void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            Vector3 temp = new Vector3(transform.position.x, transform.position.y, 0);

            temp.x += speed * Time.deltaTime;

            

            anim.SetFloat("speed", 2f);


            

            if (temp.x > maxx)
            {

                //transition to arcade room
            }

            transform.position = temp;

        }
        else if (Input.GetAxisRaw("Horizontal") == 0f)
        {
            anim.SetFloat("speed", 0f);
            
            transform.position = new Vector3(transform.position.x, -2, 0);

        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            Vector3 temp = new Vector3(transform.position.x, transform.position.y, 0);

            temp.x -= speed * Time.deltaTime;
            anim.SetFloat("speed", -2f);

            

            if (temp.x < minx)
            {
                //transition to title scene
            }
            transform.position = temp;


        }
    }
}
