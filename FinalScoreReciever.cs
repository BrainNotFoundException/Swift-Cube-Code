using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreReciever : MonoBehaviour
{

    public Transform playerTransform;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = (playerTransform.position.z / 10).ToString("0");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
}
