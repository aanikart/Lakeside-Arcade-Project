using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public float speed = 5f;
    public float deactivateTimer = 3f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 270);
        Invoke("Deactivate", deactivateTimer);
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
        if (collision.gameObject.name == "enemylaser(Clone)"|| collision.gameObject.name == "enemyalien(Clone)")
            
        {
            Deactivate();
        }
    }
    
}
