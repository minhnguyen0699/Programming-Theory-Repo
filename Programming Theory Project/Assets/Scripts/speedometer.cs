using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class speedometer : MonoBehaviour
{
    private VehicleControl vehicleX;
    private GameObject needleTransform;
    private float updateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        vehicleX = GameObject.Find("RallyCar").GetComponent<VehicleControl>();
        
    }

    // Update is called once per frame
    void Update()
    {
        updateSpeed = vehicleX.speed;
        transform.eulerAngles = new Vector3(0, 0, 180-(updateSpeed * 1.2f));
        
       
    }
}
