using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemFollowPlayer : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    public Transform playerTransform;
    Vector3 offset = new Vector3(0.5f, -0.5f, 0f);
    //Vector3 offset = new Vector3(0f, -1.0f, 0f);

    // Update is called once per frame
    void Update()
    {

        transform.position = playerTransform.position + offset;
        if(FindObjectOfType<GameManager>().isGameOver){
	Destroy(gameObject);
        }
    }
}
