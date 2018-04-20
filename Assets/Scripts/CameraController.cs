using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //public GameObject player to hold the player Object
    public GameObject player;

    //private Vector3 offset to find initial difference between player Object and camera Object
    private Vector3 offset;

	//used to initialize datamembers
	void Start () {

        //set offset = to camera position - player position
        offset = transform.position - player.transform.position;
	}
	
    //called every frame and guaranteed to run after everything processed in Update
	void LateUpdate () {

        transform.position = player.transform.position + offset;
	}
}
