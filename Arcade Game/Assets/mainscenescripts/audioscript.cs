using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioscript : MonoBehaviour
{
    private static audioscript instance;
    public static bool isotherplaying = false;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "alienhome" || sceneName == "pacmangame-home" || sceneName == "teiseat-fightinggame")
        { 
            Destroy(gameObject);
        }
    }
}
