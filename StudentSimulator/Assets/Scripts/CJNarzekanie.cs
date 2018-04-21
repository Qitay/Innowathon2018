using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJNarzekanie : MonoBehaviour
{
    public static CJNarzekanie Instance;
    public float MUSICVOLUME;
    public AudioClip[] narzekanie;
    AudioSource audio;

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.volume = MUSICVOLUME;
    }


    // Update is called once per frame
    void Update()
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

    public void Narzekaj()
    {
        audio.clip = narzekanie[Random.Range(0, narzekanie.Length)];
        audio.Play();
    }
}
