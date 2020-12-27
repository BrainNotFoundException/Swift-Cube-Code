using UnityEngine;

public class Shooter : MonoBehaviour
{

    float nextFireTime = 0f;
    float range = 35f;

    public GameObject aimer;
    public ParticleSystem muzzleFlash;

    
    public void Shoot(){
        RaycastHit hit;

        if(Physics.Raycast(aimer.transform.position, aimer.transform.forward,out hit ,range)
        && Time.time >= nextFireTime && !FindObjectOfType<GameManager>().isGameOver)
        {
            //Debug.Log(hit.transform.name);
            nextFireTime = Time.time + 0.5f;
            EndlessObstaceHandler target = hit.transform.GetComponent<EndlessObstaceHandler>();
            if(target != null){
                muzzleFlash.Play();
                target.Kill();
            }
        }
    }

}
