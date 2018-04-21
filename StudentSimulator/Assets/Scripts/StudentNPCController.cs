using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StudentNPCController : MonoBehaviour
{

    public int lives;

    void Start()
    {
        lives = 3;
    }

    void Update()
    {
        Debug.Log(lives);
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name.StartsWith("Crumple_Sphere"))
        {
            lives--;
        }
        Debug.Log(collider.gameObject.name);
        //GameController.Instance.Punish();
        /*if(collision.gameObject.name == "ostry" && przypal) {
            GameController::Instance().Punish();
        }*/
    }
}
