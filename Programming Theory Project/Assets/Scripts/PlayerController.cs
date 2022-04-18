using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float horsePower = 0.0f;
    [SerializeField] private float turnSpeed = 35.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;

    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float rpm;
    [SerializeField] public float zRange=4.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);


        //if (playerRb.transform.position.z < -zRange)

        //    transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        //if (playerRb.transform.position.z > zRange)
        //        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

       
       
            playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
            // Rotates the car based on horizontal input
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
            speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f);
            speedText.SetText("Speed: " + speed + "km/h");
            rpm = Mathf.RoundToInt(speed % 30) * 40;
            rpmText.SetText("RPM: " + rpm);
        
        

        
        
    }
  

}
