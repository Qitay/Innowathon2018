﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StudentController : MonoBehaviour {

    public int lives;

	void Start () {
        lives = 3;
	}

	void Update () {
     
	}

    void OnTriggerEnter(Collider collider) {
        Debug.Log(collider.gameObject.name);
        //GameController.Instance.Punish();
        /*if(collision.gameObject.name == "ostry" && przypal) {
            GameController::Instance().Punish();
        }*/
    }
}
