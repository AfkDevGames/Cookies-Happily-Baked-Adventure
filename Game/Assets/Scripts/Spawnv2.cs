using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spawnv2 : MonoBehaviour
{
    

    public float downTime, upTime, pressTime = 0;
    public float countDown = 2.0f;
    public bool ready = false;
   

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && ready == false)
        {
            downTime = Time.time;
            pressTime = downTime + countDown;
            ready = true;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            ready = false;
        }
        if (Time.time >= pressTime && ready == true )
        {
            ready = false;
            // diomorespeed.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        

    }

}