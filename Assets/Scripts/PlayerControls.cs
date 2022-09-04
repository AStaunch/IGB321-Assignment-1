using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Player Controls
        if (Input.GetKeyDown("f")) {
            Interact();
        }
		
	}


    void Interact() {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10.0f)){

            Debug.DrawLine(transform.position, hit.point);

            if (hit.transform.gameObject.GetComponent<iTrigger>() != null) {
                hit.transform.gameObject.GetComponent<iTrigger>().Activate();
            }
        }
    }
}
    