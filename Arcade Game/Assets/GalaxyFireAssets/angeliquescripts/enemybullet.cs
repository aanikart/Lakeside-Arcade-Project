using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
    public float speed = 6f;
    public float deactivateTimer = 3f;

    public scorescript script;


    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("Deactivate", deactivateTimer);

        script = FindObjectOfType<scorescript>();
    }

    // Update is called once per frame
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
            Deactivate();
            script.addscore(-50);



        }
    }
   
}
