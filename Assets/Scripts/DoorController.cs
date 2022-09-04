using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public void Activate()
    {
        GetComponent<Animator>().SetTrigger("Activate");
    }
}
