using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnContact : MonoBehaviour
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
            ScoreManager.instance.AddPoint();
            Destroy(gameObject);
        }

    }
}
