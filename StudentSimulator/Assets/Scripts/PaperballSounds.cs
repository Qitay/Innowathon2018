using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperballSounds : MonoBehaviour
{

    public AudioClip[] hitwithPaper;
    public AudioClip[] pickupPaper;
    AudioSource audio;

    public void hitWithPaperPlaySound() //gdy studenta trafi kulka
    {
        audio.clip = hitwithPaper[Random.Range(0, hitwithPaper.Length)];
        audio.Play();
    }

    public void pickUpPaperPlaySound() //gdy podnoszona jest kulka
    {
        audio.clip = pickupPaper[Random.Range(0, pickupPaper.Length)];
        audio.Play();
    }

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.volume = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
