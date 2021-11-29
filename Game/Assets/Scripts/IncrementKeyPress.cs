using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementKeyPress : MonoBehaviour
{
    public int mynumber = 0;
    public int turnmusicoff;
    public int turnmusicon;
    public int nesto1; 
    public int nesto2;
    public int end;
   
    public GameObject turnmusicoff1;
    public GameObject turnmusicon1;
    public GameObject nestoa1;
    public GameObject nestob2;
    public GameObject end1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            mynumber += 1;
        }
        if (mynumber == turnmusicoff)
        {
            turnmusicoff1.SetActive(false);
        }
        if (mynumber == turnmusicon)
        {
            turnmusicon1.SetActive(true);
        }
        if (mynumber == nesto1)
        {
            nestoa1.SetActive(true);
        }
        if (mynumber == nesto2)
        {
            nestob2.SetActive(false);
        }
        if (mynumber ==end)
        {
            end1.SetActive(true);
        }
    }
}
