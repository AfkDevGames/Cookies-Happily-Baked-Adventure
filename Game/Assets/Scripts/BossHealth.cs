using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float hitPoints;
    public float maxHitpoints;
    void Start()
    {
        hitPoints = maxHitpoints;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.D)))
        {
            TakeHit(1);
        }
    }

    // Update is called once per frame
    public void TakeHit(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
