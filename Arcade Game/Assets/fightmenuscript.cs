using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class fightmenuscript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("teiseat-fightinggame");

    }


    public void gamehome()
    {
        SceneManager.LoadScene("Homescene");
    }
}
