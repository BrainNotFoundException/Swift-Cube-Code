using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessObstacle : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {

    }*/

    public Transform playerTransform;
    public GameObject obstacle;
    float nextSpawnTime = 0f;
    float spawnSpace = 45f;
    //bool over = false;
    //float previousPlayerPosition = 0f;

    /*// Update is called once per frame
    void Update()
    {

    }*/

    void FixedUpdate()
    {
        if (!FindObjectOfType<GameManager>().isGameOver) {
            if (Time.time > nextSpawnTime /*&& playerTransform.position.z > (previousPlayerPosition+3f)*/)
            {
                //Debug.Log("first if");
                if (playerTransform.position.z < 3001)
                {
                    nextSpawnTime = Time.time + 0.5f;
                    //Debug.Log("second if");
                    float x21 = Random.Range(-6.6f, -0.9f);
                    float x22 = Random.Range(6.6f, 0.9f);
                    GameObject newObstacle21 = (GameObject)Instantiate(obstacle, new Vector3(x21, 2f, playerTransform.position.z + spawnSpace), Quaternion.Euler(Vector3.forward));
                    GameObject newObstacle22 = (GameObject)Instantiate(obstacle, new Vector3(x22, 2f, playerTransform.position.z + spawnSpace), Quaternion.Euler(Vector3.forward));
                    /*if (!(spawnSpace - 0.1f < 25))
                    {
                        spawnSpace -= 0.1f;
                    }*/
                }
                else if (playerTransform.position.z > 3000)
                {
                    //Debug.Log("Else if");
                    nextSpawnTime = Time.time + 0.6f;
                    //if (!over)
                    //{
                    //    over = true;
                        //spawnSpace = 45f;
                    //}
                    float x31 = Random.Range(-6.6f, -3.4f);
                    float x32 = Random.Range(-1.6f, 1.6f);
                    float x33 = Random.Range(6.6f, 3.4f);
                    GameObject newObstacle31 = (GameObject)Instantiate(obstacle, new Vector3(x31, 2f, playerTransform.position.z + spawnSpace), Quaternion.Euler(Vector3.forward));
                    GameObject newObstacle32 = (GameObject)Instantiate(obstacle, new Vector3(x32, 2f, playerTransform.position.z + spawnSpace), Quaternion.Euler(Vector3.forward));
                    GameObject newObstacle33 = (GameObject)Instantiate(obstacle, new Vector3(x33, 2f, playerTransform.position.z + spawnSpace), Quaternion.Euler(Vector3.forward));
                    /*if (!(spawnSpace - 0.1f < 25))
                    {
                        spawnSpace -= 0.1f;
                    }*/
                }
            }
            //previousPlayerPosition = playerTransform.position.z;
        }
    }

}
