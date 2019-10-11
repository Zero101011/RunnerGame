using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTime : MonoBehaviour {

    public bool ended;
    public int level;

	// Use this for initialization
	void Start ()
    {
        ended = false;
        level = SceneManager.GetActiveScene().buildIndex;
        LevelStart();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        ended = true;

        if(ended == true)
        {
            //print("you took" + Time.timeSinceLevelLoad);
        }
        
        if(other.gameObject.tag == "blue" || other.gameObject.tag == "green")
        {
            if (level <= 2)
            {
                LevelComplete();
                SceneManager.LoadScene(level + 1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    private void LevelStart()
    {
        AnalyticsEvent.LevelStart("level ", SceneManager.GetActiveScene().buildIndex);
    }
    private void LevelComplete()
    {
        AnalyticsEvent.LevelComplete("level ", SceneManager.GetActiveScene().buildIndex);
    }
}
