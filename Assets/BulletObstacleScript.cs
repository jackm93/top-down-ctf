using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObstacleScript : MonoBehaviour {

    public GameObject barrel;

    public GameObject bulletPrefab;

    public Transform bulletSpawn;

    private Vector3 trajectory;

	// Use this for initialization
	void Start () {

        InvokeRepeating("Fire", 2.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Fire() {

        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward;

        Destroy(bullet, 2.0f);
    }
}
