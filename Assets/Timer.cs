using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

    float timer;
    float minutes;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timerCalc();
	}
    
    void timerCalc()
    {
        timer += Time.deltaTime;
        minutes = timer / 60;
       // Debug.Log(minutes);
        if (minutes % 10 == 0)
        {
            Debug.Log(minutes);
        }
    }
}
