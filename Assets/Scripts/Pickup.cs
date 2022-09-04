using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public GameObject thisPickup;

    private float respawnTimer;
    public float respawnTime = 5.0f;

	// Update is called once per frame
	void Update () {

        //Respawn if no object and respawnTimer is over
        if(!thisPickup.activeSelf && Time.time > respawnTimer) {

            thisPickup.SetActive(true);
        }
	}

    //Item-Player Interaction on pickup - Override in child class for item specific behaviour
    public virtual void OnTriggerEnter(Collider other) {
        
        if(other.tag == "Player" && thisPickup.activeSelf) {

            // Adjust player attributes here...
            thisPickup.SetActive(false);
            respawnTimer = Time.time + respawnTime;
        }
    }
}
