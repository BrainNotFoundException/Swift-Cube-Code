﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }*/

    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z/10).ToString("0");
    }
}
