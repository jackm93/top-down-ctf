using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	float speed;
	
    private Rigidbody playerRB;

    void Start() {
        playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
		
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        playerRB.AddForce(movement * speed);
            
    }
}
