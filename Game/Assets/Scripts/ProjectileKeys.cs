using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileKeys : MonoBehaviour
{
    public GameObject[] projectiles;


    private Vector2 targetPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(projectiles[0], transform.position, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(projectiles[1], transform.position, Quaternion.identity);
        }

    }
}
