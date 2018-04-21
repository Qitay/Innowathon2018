using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StudentController : MonoBehaviour {

    //TODO: Set to true when not holding pen/paper anchor, false otherwise.
    public bool przypal;
    public int lives;

	void Start () {
      przypal = false;
      lives = 3;
	}

	void Update () {
      //Quaternion.Euler();

      //Vector3.Lerp(mojVector, vectorDoKtoregoDazysz, zmiennaDoVectora?? * Time.DeltaTime );
	}

    void OnTriggerEnter(Collider collider) {
        Debug.Log(collider.gameObject.name);
        GameController.Instance.Punish();
        /*if(collision.gameObject.name == "ostry" && przypal) {
            GameController::Instance().Punish();
        }*/
    }
}
