using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript_DELETE : MonoBehaviour {

    private GameObject Controller;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if(Controller.jestprzycisk)
        {
            ControllerGrabObject();
        }
    }
}
