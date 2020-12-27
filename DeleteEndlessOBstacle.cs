using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEndlessOBstacle : MonoBehaviour
{

    Transform camTransform;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = FindObjectOfType<Camera>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (camTransform.position.z > transform.position.z) {
            Destroy(gameObject);
        }
    }
}
