using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("angelique-alienshootinggame");
       
    }




    public void Mainmenu()
    {
        SceneManager.LoadScene("alienhome");
    }

    public void infoscreen()
    {
        SceneManager.LoadScene("angeliqueinfo");
    }

    public void gamehome()
    {
        SceneManager.LoadScene("Homescene");
    }
}
