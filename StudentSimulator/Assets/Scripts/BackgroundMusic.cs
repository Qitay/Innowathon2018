using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    public float MUSICVOLUME;
    public static BackgroundMusic Instance;
    public AudioClip indangerMusic;
    public AudioClip calmMusic;
    public AudioClip loseMusic;
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
        if(number == 2)
        {
            music.clip = loseMusic;
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
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
