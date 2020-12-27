using UnityEngine;

public class AimerFollowPlayer : MonoBehaviour
{

    public Transform playerTransform;
    Vector3 offset = new Vector3(0f, .24f, .281f);

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
