using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject levelSelect;

    // Use this for initialization
    public void Start()
    {
        
    }

    public void Play()
    {
        //Analytics.CustomEvent("playPress", new Dictionary<string, object>
        //{
        //        { "plays = ", 1 },
        //        { "stuff = ", 111 },
        //        { "yeets = ", 69 }

        // });
                        
            
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Levels()
    {
        mainMenu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void level1()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    public void level2()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

    public void level3()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }

    public void tutorial()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Back()
    {
        mainMenu.SetActive(true);
        levelSelect.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        print("So Lonely");
    }
}
