using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
  
    private void Start()
    {
       
    }
    private void Update()
    {
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);  
    }


}
