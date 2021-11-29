using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{


    public float downTime, upTime, pressTime = 0;
    public float countDown = 2.0f;
    public bool ready = false;
    public GameObject endScreen;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && ready == false)
        {
            downTime = Time.time;
            pressTime = downTime + countDown;
            ready = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            ready = false;
        }
        if (Time.time >= pressTime && ready == true && endScreen.activeSelf)
        {
            ready = false;
            // diomorespeed.Play();
            Application.Quit();
        }


    }
}

