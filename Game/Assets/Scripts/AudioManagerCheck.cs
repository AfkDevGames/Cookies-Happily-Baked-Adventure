using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerCheck : MonoBehaviour
{
    public GameObject audioMan;

    // Start is called before the first frame update
    void Start()
    {
        if (FindObjectOfType<AudioManagerScr>())
            return;
        else
            Instantiate(audioMan, transform.position, transform.rotation);

    }

}

