using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceControl : Vehicle
{
    public override void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 60 * MainManager.Instance.difficulty);
    }

    protected override void ControlPlayer()
    {

    }

}
