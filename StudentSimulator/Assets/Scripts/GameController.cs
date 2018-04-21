using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    //public ref StudentController student;
    public bool running;
    public int playerLives;
    public bool przypal;
    public bool zlapany;

    public static GameController Instance;

//    public StudentController ;

    // Use this for initialization
    void Start()
    {

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

    public void Punish()
    {
        playerLives--;
        if(playerLives > 0)
        {
            zlapany = true;
            CJNarzekanie.Instance.Narzekaj();
        }
        else
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("LOSE");
        BackgroundMusic.Instance.playMusic(2);
        Timer.Instance.secondsToEnd = 0f;
    }

    public void MaybePunish()
    {
        if(przypal && !zlapany)
        {
            Punish();
        }
    }

    public void ZrobPrzypal()
    {
        przypal = true;
        zlapany = false;
    }
    public void AnulujPrzypal()
    {
        przypal = false;
        zlapany = false;
    }
}
