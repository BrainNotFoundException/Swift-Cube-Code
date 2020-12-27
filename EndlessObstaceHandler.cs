using UnityEngine;

public class EndlessObstaceHandler : MonoBehaviour
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

    public void Kill()
    {
        Destroy(gameObject);
    }

}
