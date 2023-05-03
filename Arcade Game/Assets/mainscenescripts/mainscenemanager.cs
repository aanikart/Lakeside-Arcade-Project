using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainscenemanager : MonoBehaviour

{


    public void shooting()
    {

       SceneManager.LoadScene("alienhome");


    }

    public void fighting()
    {

       

        SceneManager.LoadScene("teiseat-fightinggame");

    }

    public void pacman()
    {
        SceneManager.LoadScene("aanika-pacmangame");


    }

    
}

