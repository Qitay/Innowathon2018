using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfessorScript : MonoBehaviour {

    public AudioClip[] marudzenieAudio;
    AudioSource audio;


    public void marudzenieSound() //gdy marudzi/nas przyłapie
    {
        audio.clip = marudzenieAudio[Random.Range(0, marudzenieAudio.Length)];
        audio.Play();
    }

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        
	}
}
