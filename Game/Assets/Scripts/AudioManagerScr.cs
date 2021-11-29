using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManagerScr : MonoBehaviour
{

    public AudioSource BGM;
    public static AudioManagerScr instance;
  
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (FindObjectsOfType<AudioManagerScr>().Length > 1)
        {
            Destroy(gameObject);
        }

    }

    public void ChangeBGM(AudioClip music)
    {
        if (BGM.clip.name == music.name)
            return;

        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
        //try
        if (SceneManager.GetActiveScene().name != ("PreMenu"))
            BGM.loop = true;


    }

}
