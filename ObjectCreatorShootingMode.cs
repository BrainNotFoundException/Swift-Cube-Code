using UnityEngine;

public class ObjectCreatorShootingMode : MonoBehaviour
{

    public Transform playerTransform;
    public GameObject obstacle;
    float nextSpawnTime = 0f;
    float spawnSpace = 45f;

    void FixedUpdate()
    {
        if(!FindObjectOfType<GameManager>().isGameOver && Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + 0.5f;
            float x31 = Random.Range(-6.6f, -3.4f);
            float x32 = Random.Range(-1.6f, 1.6f);
            float x33 = Random.Range(6.6f, 3.4f);
            GameObject newObstacle31 = (GameObject)Instantiate(obstacle, new Vector3(x31, 2f, playerTransform.position.z + spawnSpace), Quaternion.Euler(Vector3.forward));
            GameObject newObstacle32 = (GameObject)Instantiate(obstacle, new Vector3(x32, 2f, playerTransform.position.z + spawnSpace), Quaternion.Euler(Vector3.forward));
            GameObject newObstacle33 = (GameObject)Instantiate(obstacle, new Vector3(x33, 2f, playerTransform.position.z + spawnSpace), Quaternion.Euler(Vector3.forward));
        }
    }

}
