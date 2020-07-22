﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{

    Image timer;
    public float maxTime = 5f;
    float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Image> ();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timer.fillAmount = timeLeft / maxTime;
        } else {
            Time.timeScale = 0;
        }
    }
}
