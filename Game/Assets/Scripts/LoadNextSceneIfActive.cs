using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextSceneIfActive : MonoBehaviour
{
    public GameObject dialogue;
    public float delay = 5;
    public string NewLevel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.activeSelf)
        {
            StartCoroutine(LoadLevelAfterDelay(delay));
        }
    }
    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
}

