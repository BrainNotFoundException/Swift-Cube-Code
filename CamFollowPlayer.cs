using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{

    public Transform playerTransform;
    Vector3 offset = new Vector3(0f, 2f, -7f);

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        //↓THIS WILL LOG IN THE POSITION OF THE PLAYER SINCE THE PLAYER TRANSFORM HAS BEEN ADDED TO THE PUBLIC  VAR ABOVE
        //Debug.Log(playerTransform.position);
        transform.position = playerTransform.position + offset;
        //AN ALTERNATE METHOD TO THIS↑ WOULD BE↓ THAT I CAME UP WITH BUT THE ONE ON TOP IS THE SAME THING IN SHORT LOL
        //transform.position = new Vector3(playerTransform.position.x+offset.x, playerTransform.position.y+offset.y, playerTransform.position.z+offset.z);

    }
}