using System.Collections;
using System.Collections.Generic;
using UnityEngine.Analytics;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Vector3 playerStart;
    public Transform playerCurrent;
    public PlayerController player;
    public float dist;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        playerStart = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        

    }
	
	// Update is called once per frame
	void Update () {
        playerCurrent = player.transform;
        //Debug.Log(playerStart + " " + player.transform.position);
        
        dist = Vector3.Distance(playerStart, player.transform.position);
        //print("you have traveled " + Mathf.Round(dist) + " metres");
        //print("yeet" + player.transform.position);
    }
}
