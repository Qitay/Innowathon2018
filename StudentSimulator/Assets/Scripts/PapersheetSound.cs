using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapersheetSound : MonoBehaviour {

    public AudioClip[] writingAudio;
    AudioSource audio;
    Transform transform;

    // Use this for initialization
    void Start () {
        //transform.localScale = new Vector3(0.01379639f, 0.05f, 0.01840163f);
        audio = GetComponent<AudioSource>();
        audio.volume = 1.0f;
    }
	
	// Update is called once per frame
	void Update () {
        //AudioSource.PlayClipAtPoint(writingAudio[0], transform.position, 1.5f);
        if(audio.isPlaying == false)
        {
            audio.clip = writingAudio[Random.Range(0,writingAudio.Length-1)];
            audio.Play();
        }
	}
}
