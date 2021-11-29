using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfNotactive : MonoBehaviour
{
    public GameObject menager;

    public GameObject dijalog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!menager.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                dijalog.SetActive(true);
            }
        }
    }
}
