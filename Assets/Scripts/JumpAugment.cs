using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAugment : MonoBehaviour
{
    public float JumpHeight = 10;
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
        if (other.TryGetComponent(out Rigidbody @object))
        {
            //@object.isKinematic = false;
            //@object.AddForce(new Vector3(0, JumpHeight, 0), ForceMode.VelocityChange);
            ////StoreJump = player.m_JumpSpeed;
            ////player.m_JumpSpeed = PushStrength;s
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Rigidbody player))
        {
            
            //while(player.velocity.y > 0)
            //{
            //    player.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            //}
            //player.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, PushStrength, 0), ForceMode.VelocityChange);
            //player.m_JumpSpeed = StoreJump;
        }
    }
}
