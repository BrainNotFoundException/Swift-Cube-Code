using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    float forwardForce = 4000f;
    float sideForce = 100f;

    /*// Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World");
        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500);
    }*/

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(0, 0, 2000* Time.deltaTime); //TIME.DELTATIME EVENS OUT THE MOVEMENT SPEED FOR FASTER AND SLOWER COMPUTERS!
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        for (int i =0; i<Input.touches.Length; ++i) {
            if (Input.touches[i].position.x > (Camera.main.pixelWidth/2) && Input.touches[i].position.y > 55) {
                //Debug.Log(Input.touches[i].position);
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.touches[i].position.x <(Camera.main.pixelWidth/2) && Input.touches[i].position.y > 55) {
                //Debug.Log(Input.touches[i].position);
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

    }

    //MAKE SURE TO USE FIXEDUPDATE FOR PHYSICS!!
    void FixedUpdate()
    {
        //adding a forward force to the object

        if (rb.position.y < -0.1f && !FindObjectOfType<GameManager>().levelOver)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        else
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

    }

}
