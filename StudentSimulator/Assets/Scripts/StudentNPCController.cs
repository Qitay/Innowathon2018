using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StudentNPCController : MonoBehaviour
{
    public AudioClip[] onhitAudio;
    public AudioClip[] cursingAudio;
    AudioSource audio;
    public int lives;

    void Start()
    {
        lives = 3;
        audio = GetComponent<AudioSource>();
        audio.volume =3.0f;
    }

    void Update()
    {
        Debug.Log(lives);
    }

    void OnCollisionEnter(Collision collider)
    {
        if(collider.gameObject.name.StartsWith("Crumple_Sphere"))
        {
            --lives;
            if(lives > 0)
            {
                onHitAudioPlaySound();
            }
            else
            {
                cursingPlaySound();
                Destroy(gameObject);
            }
        }
        //Debug.Log(collider.gameObject.name);
        //GameController.Instance.Punish();
        /*if(collision.gameObject.name == "ostry" && przypal) {
            GameController::Instance().Punish();
        }*/
    }

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
}
