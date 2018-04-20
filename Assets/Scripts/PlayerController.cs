using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //private Rigidbody playerRB to control player movement
    private Rigidbody playerRB;

    //publc float speed to modify the speed of the player
    public float speed;

    void Start() {

        //set the Rigidbody equal to the Rigidbody component attached to the player
        playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {

        //declare two floats horiz, vert and set equal to respective Input axis
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //declare Vector3 movement and instantiate with new Vector 3 x = horiz, y = 0, z = vert
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        //call AddForce for the Rigidbody by passing movement * speed
        playerRB.AddForce(movement * speed);
            
    }
}
