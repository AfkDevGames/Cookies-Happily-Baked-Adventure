using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    #region Public_Variables
    public List<KeyCode> keySequence = new List<KeyCode>();
    #endregion

    #region Private_Variables
    private int _lastCorrectIndex;
    #endregion
    
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //do your stuff
    }
}
#endregion