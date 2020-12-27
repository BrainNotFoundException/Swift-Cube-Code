using UnityEngine;

public class HeadGunFollowPlayer : MonoBehaviour
{

    public Transform playerTransform;
    Vector3 offset = new Vector3(0,0.47f,0.079f);

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
