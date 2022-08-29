using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, iTrigger
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Activate();
        }
    }
    public void Activate()
    {
        GetComponent<Animator>().SetTrigger("Activate");
    }
}
