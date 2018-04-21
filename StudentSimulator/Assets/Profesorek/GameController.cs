using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    //public ref StudentController student;
    public bool running;

    public static GameController Instance;

    public StudentController scler;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    void Awake() {
        if(!Instance) {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else {
            Destroy(gameObject);
        }

    }

    public void Punish() {
        Debug.Log("Jeszcze jak!");
    }
}
