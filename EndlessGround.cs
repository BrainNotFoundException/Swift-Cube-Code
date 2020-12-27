using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessGround : MonoBehaviour
{

    public Transform playerTransform;

    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (0f,1f,(playerTransform.position.z+490f));
    }
}
