using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScr : MonoBehaviour
{
    public float speed;

    //public Enemy enemyscript;

    public bool GameIsPaused = false;

    public GameObject gameOverMenuUI;

    //public GameObject[] enemies;
    void Start()
    {
        //
        //enemyscript.enabled = true;
        //
        
        gameOverMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

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
    void Restart()
    {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Pause();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (other.tag == gameObject.tag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        else
        {
            Pause();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
