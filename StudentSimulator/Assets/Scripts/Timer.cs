﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour {
	public float secondsToEnd = 20f;

	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
        if (secondsToEnd > 0)
        {
            secondsToEnd -= Time.deltaTime;
		    int minutes = (int)secondsToEnd / 60;
		    int seconds = (int)secondsToEnd % 60;
		    String minutesStr = minutes.ToString().PadLeft(2, '0');
		    String secondsStr = seconds.ToString().PadLeft(2, '0');
		
			GetComponent<TextMesh>().text = "Czas do końca kolokwium\n" + 
                minutesStr + ":" + secondsStr;
		}
        else
        { 
			GetComponent<TextMesh>().text = "Czas do końca kolokwium\n" +
                "KONIEC.";
		}
		
	}
}
