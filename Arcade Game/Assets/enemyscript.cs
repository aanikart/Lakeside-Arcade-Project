using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public GameObject alienprefab;
    public float speed = 5f;
    private Animator anim;
    public bool isdead;
    public float deactivateTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        isdead = false;
        anim = GetComponent<Animator>();
        Invoke("Deactivate", deactivateTimer);
    }


    // Update is called once per frame
    void Update()
    {
        if (isdead == false)
        {
            MoveAlien(alienprefab);
            

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isdead = true;
        anim.Play("destroyedalien", 0, 0f);
        
        Invoke("Deactivate", 0.8f);
        
    }
    void Deactivate()
    {
        gameObject.SetActive(false);
    }

    void MoveAlien(GameObject alien)
    {
        alien.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    
}

