using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusControll : Vehicle
{
    public override void MoveForward() {
        transform.Translate(Vector3.forward * Time.deltaTime * 30 * MainManager.Instance.difficulty);
    }

    protected override void ControlPlayer() { 
    
    }
}
