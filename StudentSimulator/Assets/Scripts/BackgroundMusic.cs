using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    public AudioClip[] creepyMusic;
    public AudioClip[] royaltyMusic;
    AudioSource audio, music;

    int musicState; // 0 -start, 1- normalny, 2-konczenie -- [ascending, normal, descending] = [0,1,2]

    public void playMusic() //muzyka grozna(done) sielankowa(todo)
    {
        music.volume = 0.05f;
        if (musicState == 0)
        {
            music.clip = creepyMusic[musicState];
            music.Play();
            musicState = 1;
        }
        if (musicState == 1)
        {
            music.clip = creepyMusic[musicState];
            music.Play();
            //musicState = 2; //do tej zmiennej trzeba przypisac te wartosc gdy prowadzacy przestanie sie na nas gapic i bedzie spokojnie
        }
        if (musicState == 2)
        {
            music.clip = creepyMusic[musicState];
            music.Play();
            musicState = 3;
        }

        //sielankowa
        if (musicState == 3)
        {
            //clip na dreamy ascending
            //play
            musicState = 4;
        }
        if (musicState == 4)
        {
            //clip na dreamy normal
            //play
            //musicState = 5; //do tej zmiennej trzeba przypisac te wartosc gdy prowadzacy zaczyna sie na nas gapic
        }
        if (musicState == 5)
        {
            //clip na dreamy descending
            //play
            musicState = 0;
        }
    }

    // Use this for initialization
    void Start()
    {
        music = GetComponent<AudioSource>();
        musicState = 0;
    }
    
	
	// Update is called once per frame
	void Update () {
        if (music.isPlaying == false)
        {
            playMusic();
        }
    }
}
