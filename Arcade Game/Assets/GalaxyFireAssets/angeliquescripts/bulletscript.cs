using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bulletscript : MonoBehaviour
{
    public float speed = 5f;
    public float deactivateTimer = 3f;
    public scorescript script;

    
    void Start()
    {
        //rotate so the bullet is horizontal
        transform.Rotate(0, 0, 270);
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
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }

    void Deactivate()
    {
        gameObject.SetActive(false);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "enemylaser(Clone)")   
        {
            //cancels out if it hits enemylaser
            Deactivate();

        }
        if (collision.gameObject.name == "enemyalien(Clone)")

        {
            //100 points for hitting enemy alien
            script.addscore(100);
            Deactivate();
            

        }

        if (collision.gameObject.name == "asteroid(Clone)")

        {
            //50 points for hitting asteroid
            script.addscore(50);
            Deactivate();
            

        }



    }

    


}
