using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        speed = 40.0f;
        
    }

    // Update is called once per frame

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
