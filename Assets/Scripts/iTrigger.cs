using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iTrigger
{
    public int channel { get; set; }

    public void Activate();

}
