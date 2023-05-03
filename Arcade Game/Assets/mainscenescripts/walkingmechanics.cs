using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingmechanics : MonoBehaviour
{
    public GameObject friend;
    public static bool firstone = false;

    //friendmove.comingfromleft

    // Start is called before the first frame update
    void Start()
    {
        if (firstone == false)
        {
            spawnfriend(friend, 0);
            firstone = true;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(friendmove.comingfromright);

        if (friendmove.comingfromleft == true)
        {
            spawnfriend(friend, 7f);
            Debug.Log("spawned");
            friendmove.comingfromleft = false;
        }

        if (friendmove.comingfromright == true)
        {
            spawnfriend(friend, -7f);
            Debug.Log("spawned");
            friendmove.comingfromright = false;
        }
    }

    void spawnfriend(GameObject f,float xpos)
    {
        Instantiate(f, new Vector3(xpos, -3, 0), Quaternion.identity);
    }
}
