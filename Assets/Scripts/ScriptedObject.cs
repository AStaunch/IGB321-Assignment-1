using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptedObject : MonoBehaviour, iTrigger
{
    [Range(0, 5)]
    public int Channel = 0;

    public int channel { get => Channel; set => Channel = value; }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Activate();
        }
    }

    public void Trigger()
    {
        Activate();
    }

    public void Activate()
    {
        GetComponent<Animator>().SetTrigger("Activate");
    }
}
