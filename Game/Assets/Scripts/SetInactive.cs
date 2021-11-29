using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInactive : MonoBehaviour
{
    public GameObject Uibox;
    #region Public_Variables
    public List<KeyCode> keySequence = new List<KeyCode>();
    #endregion

    #region Private_Variables
    private int _lastCorrectIndex;
    #endregion
    /*public void Start()
    {
        if (Uibox.activeSelf)
        {
            Uibox.SetActive(false);
        }

    }*/

    #region Unity_CallBacks
    // Update is called once per frame
    void Update()
    {
        if (keySequence.Count > 0)
        {
            foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(vKey))
                {
                    if (vKey == (keySequence[_lastCorrectIndex]))
                    {
                        _lastCorrectIndex++;
                        if (_lastCorrectIndex == keySequence.Count)
                        {
                            KeySequenceMatched();
                        }
                    }
                    else
                    {
                        _lastCorrectIndex = 0;
                    }
                }
            }
        }
    }

    #endregion

    #region Private_Methods

    void KeySequenceMatched()
    {
        _lastCorrectIndex = 0;
        Debug.Log("Key Sequence Matched");
        Uibox.SetActive(false);

        //do your stuff
    }
}
    #endregion


