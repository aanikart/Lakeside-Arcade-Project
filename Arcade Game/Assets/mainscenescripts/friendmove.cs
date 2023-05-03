using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class friendmove : MonoBehaviour
{

    public float speed = 2f;
    public float minx, maxx;
    public Animator anim;
    //public GameObject player;
    public string sceneName;


    public static bool comingfromleft = false;
    public static bool comingfromright = false;


    void Start()
    {
        minx = -7.92f;
        maxx = 7.88f;
    }


    void Update()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            Vector3 temp = new Vector3(transform.position.x, -3f, 0);

            temp.x += speed * Time.deltaTime;       

            anim.SetFloat("speed", 2f);

            if (temp.x > maxx)
            {

                Scene currentScene = SceneManager.GetActiveScene();
                string sceneName = currentScene.name;

                if (sceneName == "TitlePage")
                {
                    comingfromright = true;
                    
                    SceneManager.LoadScene("Homescene");
                    
                }

                if (sceneName == "Homescene")
                {
                    temp.x = maxx;
                }
            }

            transform.position = temp;

        }

        else if (Input.GetAxisRaw("Horizontal") == 0f)
        {
            anim.SetFloat("speed", 0f);
            
            transform.position = new Vector3(transform.position.x, -3f, 0);

        }

        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            Vector3 temp = new Vector3(transform.position.x, -3f, 0);

            temp.x -= speed * Time.deltaTime;
            anim.SetFloat("speed", -2f);

            if (temp.x < minx)
            {
                Scene currentScene = SceneManager.GetActiveScene();
                string sceneName = currentScene.name;

                if (sceneName == "Homescene")
                {
                    SceneManager.LoadScene("TitlePage");
                    comingfromleft = true;
                }


                if (sceneName == "TitlePage")
                {
                    temp.x = minx;
                }

            }
            transform.position = temp;

        }
    }
  
}

