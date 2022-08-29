using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAugment : MonoBehaviour
{
    public float PushStrength = 10;
    private float StoreJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out UnityStandardAssets.Characters.FirstPerson.FPController player))
        {
            player.m_JumpSpeed = PushStrength;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out UnityStandardAssets.Characters.FirstPerson.FPController player))
        {
            player.m_JumpSpeed = PushStrength;
        }
    }
}
