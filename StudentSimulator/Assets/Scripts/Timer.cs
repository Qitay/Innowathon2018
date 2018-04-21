using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Timer : MonoBehaviour {

    public float secondsToEnd;

    public static Timer Instance;
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
		
			GetComponent<TextMeshPro>().text = "Koniec za:\n" + 
                minutesStr + ":" + secondsStr;
		}
        else
        {
            secondsToEnd = 0.0f;
			GetComponent<TextMeshPro>().text = "KONIEC.";
            //GameController.Instance.GameOver();
		}
		
	}
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
