using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSmasher : MonoBehaviour {

    private bool isIncreasing = true;

    [SerializeField]
    float maxSize = 5.0f;

    [SerializeField]
    float minSize = 0.5f;

    [SerializeField]
    Vector3 smasherSpeedOut;

    [SerializeField]
    Vector3 smasherSpeedIn;

    private Vector3 scale;
    private Vector3 position;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isIncreasing) {
            scale = transform.localScale;
            position = transform.position;

            scale += smasherSpeedOut;
            position -= smasherSpeedOut;

            transform.position = position;
            transform.localScale = scale;
            
            if (scale.y >= maxSize) {
                isIncreasing = false;
            }
        } else {
            scale = transform.localScale;
            position = transform.position;

            scale -= smasherSpeedIn;
            position += smasherSpeedIn;

            transform.localScale = scale;
            transform.position = position;

            if (scale.y <= minSize) {
                isIncreasing = true;
            }
        }
        

	}

}
