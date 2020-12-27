using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.collider.name);
        if (collision.collider.tag == "obstacle")
        {
            //Debug.Log(collision.collider.name);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
