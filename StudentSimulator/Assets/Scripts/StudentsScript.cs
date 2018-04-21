using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentsScript : MonoBehaviour {

    public AudioClip[] onhitAudio;
    public AudioClip[] cursingAudio;
    AudioSource audio;

    public void onHitAudioPlaySound() //gdy studenta trafi kulka i go boli :3
    {
        audio.clip = onhitAudio[Random.Range(0, onhitAudio.Length)];
        audio.Play();
    }

    public void cursingPlaySound() //gdy student traci zycie i zostanie usuniety
    {
        audio.clip = cursingAudio[Random.Range(0, cursingAudio.Length)];
        audio.Play();
    }

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        audio.volume = 1.0f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
