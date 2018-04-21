using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    // Use this for initialization
    private Vector3 startpos;
    private Quaternion startrot;
    public GameObject ball;
    public GameObject spawningPoint;

    void Start()
    {
        SpawnCrumple();
        //Debug.Log(GetComponent<Rigidbody>().name);
    }

   

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log(collider);
        if (collider.CompareTag("Crumple"))
        {
            //Debug.Log(GetComponent<Rigidbody>().name);
            SpawnCrumple();
        }
        //GameController.Instance.Punish();
        /*if(collision.gameObject.name == "ostry" && przypal) {
            GameController::Instance().Punish();
        }*/
    }

    private void SpawnCrumple()
    {
        Instantiate(ball, spawningPoint.transform.position, spawningPoint.transform.rotation);

    }


    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
