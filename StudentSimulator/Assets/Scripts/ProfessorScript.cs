using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ProfessorScript : MonoBehaviour {

    public AudioClip[] marudzenieAudio;
    public Animator anim;
    AudioSource audio;
    float minAnimWait;
    float maxAnimWait;
    float animationLength;
    float animationStart;
    float animationEnd;

    public void marudzenieSound() //gdy marudzi/nas przyłapie
    {
        audio.clip = marudzenieAudio[Random.Range(0, marudzenieAudio.Length)];
        audio.Play();
    }

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        anim.enabled = false;
        animationLength = anim.runtimeAnimatorController.animationClips[0].length;
        Debug.Log(animationLength);
        minAnimWait = animationLength * 1.5f;
        maxAnimWait = animationLength * 3.5f;

        GenAnimTime();

    }

    // Update is called once per frame
    void Update () {


        if(Timer.Instance.secondsToEnd <= animationStart)
        {
            anim.enabled = true;
            animationStart = 0.0f;
        }
        if(Timer.Instance.secondsToEnd <= animationEnd)
        {
            anim.enabled = false;
            GenAnimTime();
        }

    }

    void GenAnimTime()
    {
        if(Timer.Instance.secondsToEnd > 0.0f)
        {
            float animTime = Random.Range(minAnimWait, maxAnimWait);
            if (Timer.Instance.secondsToEnd < animTime)
            {
                animationStart = -1.0f;
                animationEnd = -1.0f;
            }
            else
            {
                animationStart = Timer.Instance.secondsToEnd - animTime;
                animationEnd = animationStart - animationLength;
            }
            
            Debug.Log("Time for next anim: " + animationStart);
        }
        else
        {
            anim.enabled = false;
        }
    }
}


