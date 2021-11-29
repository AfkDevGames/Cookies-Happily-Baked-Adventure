using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    
     // public static bool GameIsPaused = false;

    //public GameObject gameOverMenuUI;

    

     void Start()
    {
       // gameOverMenuUI.SetActive(false);
    }


    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

       /* if (Input.GetKeyDown(KeyCode.A))
        {
            if (GameIsPaused)
            {
                Restart();
            }
        }*/
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<Manager>().Pause();
            // Pause();
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (other.tag == gameObject.tag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        else
        {
            FindObjectOfType<Manager>().Pause();
            //Pause();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
   /* public void Pause()
    {
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    void Restart()
    {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/

}
