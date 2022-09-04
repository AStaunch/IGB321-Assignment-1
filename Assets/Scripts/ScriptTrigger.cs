using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTrigger : MonoBehaviour
{
    public void TriggerObject(int i)
    {
        iTrigger[] scriptedObjects = FindObjectsOfType<ScriptedObject>();
        foreach (iTrigger scriptedObject in scriptedObjects)
        {
            if(scriptedObject.channel == i)
            {
                scriptedObject.Activate();
            }
        }
    }
}
