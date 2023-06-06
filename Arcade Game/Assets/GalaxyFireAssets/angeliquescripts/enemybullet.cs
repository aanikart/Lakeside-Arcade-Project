using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
    public float speed = 6f;
    public float deactivateTimer = 3f;

    public scorescript script;


   
    void Start()
    {
        
        Invoke("Deactivate", deactivateTimer);


        script = FindObjectOfType<scorescript>();
    }

    
    void Update()
    {
        Move();
        
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
        
    }

    void Deactivate()
    {
        gameObject.SetActive(false);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name == "playerlaser(Clone)")
        {
            Deactivate();
           
        }
        if (collision.gameObject.name == "spaceship")
        {
            //if enemy bullet hits player, -50 points
            Deactivate();
            script.addscore(-50);



        }
    }
   
}
