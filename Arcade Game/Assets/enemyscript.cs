using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public GameObject alienprefab;
    public float speed = 3f;
    private Animator anim;
    public bool isdead;
    public float deactivateTimer = 5f;

    [SerializeField]
    private GameObject enemybullet;

    [SerializeField]
    private Transform shootpoint;

    // Start is called before the first frame update
    void Start()
    {
        isdead = false;
        anim = GetComponent<Animator>();
        Invoke("Deactivate", deactivateTimer);
        StartCoroutine(attacktimer());
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
        if (collision.gameObject.name == "playerlaser(Clone)")
        {
            isdead = true;
            anim.Play("destroyedalien", 0, 0f);

            Invoke("Deactivate", 0.8f);

            //add points
        }

        if (collision.gameObject.name == "spaceship")
        {
            //game over

            Deactivate();
        }
    }
    void Deactivate()
    {
        gameObject.SetActive(false);
    }

    void MoveAlien(GameObject alien)
    {
        alien.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }


    IEnumerator attacktimer()
    {
        
        yield return new WaitForSeconds(3);
        Instantiate(enemybullet, shootpoint.position, Quaternion.identity);
        //playsound
        StartCoroutine(attacktimer());
    }


}

