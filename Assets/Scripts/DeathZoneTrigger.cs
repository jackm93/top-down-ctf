using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            playerRespawn(other.gameObject);
        }
    }

    void playerRespawn(GameObject player) {
        PlayerController controller = player.GetComponent("PlayerController") as PlayerController;
        controller.KillPlayer();
    }
}
