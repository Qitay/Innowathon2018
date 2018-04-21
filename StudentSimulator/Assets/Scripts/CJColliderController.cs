using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJColliderController : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collided with " + collider.gameObject.name);
        if(collider.gameObject.name == "GRACZ")
        {
            Debug.Log("Looking4przypal");
            GameController.Instance.MaybePunish();
        }
        
    }
    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "GRACZ")
        {
            GameController.Instance.MaybePunish();
        }
    }
}
