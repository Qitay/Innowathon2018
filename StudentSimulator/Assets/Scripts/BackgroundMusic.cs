using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    public float MUSICVOLUME = 0.1f;

    public AudioClip indangerMusic;
    public AudioClip calmMusic;
    AudioSource music;

    public void playMusic(int number)   // playMusic(0); by wywolac muzyke grozna  
                                        // playMusic(1); by wywolac muzyke spokojna
    {
        if (number == 0)
        {
            music.clip = indangerMusic;
            music.Play();
        }
        if (number == 1)
        {
            music.clip = calmMusic;
            music.Play();
        }

    }

    // Use this for initialization
    void Start()
    { 
        music = GetComponent<AudioSource>();
        music.volume = MUSICVOLUME;
    }
    
	
	// Update is called once per frame
	void Update ()
    {

    }
}
