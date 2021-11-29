using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public float speed;

    //public Enemy enemyscript;

    public bool GameIsPaused = false;

    public GameObject gameOverMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        gameOverMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (GameIsPaused)
            {
                Restart();
            }
        }
    }
    public void Pause()
    {
        //enemyscript.enabled = false;

        Time.timeScale = 0f;
        GameIsPaused = true;
        gameOverMenuUI.SetActive(true);
        //proba
        //source.PlayOneShot(clip);
        //proba

    }
    public void Restart()
    {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
